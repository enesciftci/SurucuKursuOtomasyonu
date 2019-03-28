using SurucuKursuOtomasyonu.Business.Abstract;
using SurucuKursuOtomasyonu.Business.DependencyResolvers;
using SurucuKursuOtomasyonu.Entities.Concrete;
using System;
using System.Windows.Forms;

namespace SurucuKursuOtomasyonu.FormsUI.UserControllers
{
    public partial class UcStudentRecord : UserControl
    {
   
        private string _gender,_haveLicenceType;

        private readonly IRegistrationSeasonService _registrationSeasonService =
            InstanceFactory.GetInstance<IRegistrationSeasonService>();

        private readonly IStudentService _studentService = InstanceFactory.GetInstance<IStudentService>();
        private readonly ILicenceTypeService _licenceTypeService = InstanceFactory.GetInstance<ILicenceTypeService>();
        private readonly ICityService _cityService = InstanceFactory.GetInstance<ICityService>();
        private static UcStudentRecord _instanceStudentRecord;
        public UcStudentRecord()
        {
            InitializeComponent();
        }
        public static UcStudentRecord InstanceStudentRecord
        {
            get
            {
                if (_instanceStudentRecord == null)
                {
                    _instanceStudentRecord = new UcStudentRecord();
                    
                }
               
                return _instanceStudentRecord;
            }
        }

        void cmbLoader(ComboBox combo,ComboBox combo2,ComboBox combo3)
        {
            combo.DataSource = _licenceTypeService.GetLicenceTypes();
            combo.ValueMember = "LicenceTypeId";
            combo.DisplayMember = "LicenceName";
            combo2.DataSource = _cityService.GetCities();
            combo2.DisplayMember = "CityName";
            combo2.ValueMember = "CityId";
            combo3.DataSource = _licenceTypeService.GetLicenceTypes();
            combo3.ValueMember = "LicenceTypeId";
            combo3.DisplayMember = "LicenceName";
         
        }

        private void ucStudentRecord_Load(object sender, EventArgs e)
        {
            cmbLoader(cmbLicenceType, cmbPlaceofBirth, cmbHaveLicenceType);
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
          
            try
            {
                if (radioFemale.Checked)
            {
                _gender = "Kadın";
            }

            if (radioMale.Checked)
            {
                _gender = "Erkek";
            }

            if (cmbHaveLicenceType.Visible == false)
            {
                _haveLicenceType = "Null";
            }
            else
            {
                _haveLicenceType = cmbHaveLicenceType.Text;
            }

            _studentService.Add(new Student
            {
                StudentName = txtStudentName.Text,
                StudentSurname = txtStudentSurname.Text,
                StudentNationalNumber = txtNationalNumber.Text,
                StudentGender = _gender,
                StudentEmail = txtEmail.Text.Trim().ToLower(),
                StudentBirthdate = Convert.ToDateTime(dpcBirthdate.Value),
                RegistrationDate = Convert.ToDateTime(DateTime.Today.ToShortDateString()),
                RegistrationSeason =_registrationSeasonService.GetSeasons().Count,
                StudentDebt = Convert.ToDecimal(txtRegistrationDebt.Text),
                StudentTotalDebt = Convert.ToDecimal(txtRegistrationDebt.Text),
                QuantityInstallment = Convert.ToInt32(cmbQuantityInstallment.Text),
                StudentPlaceofBirth =Convert.ToInt32(cmbPlaceofBirth.SelectedValue),
                StudentPhoneNumber = txtPhoneNumber.Text,
                StudentAdress = txtAdress.Text,
                StudentIbanNumber = txtIbanNumber.Text.ToUpper().Trim(),
                StudentWantLicenceType = cmbLicenceType.Text,
                StudentHaveLicenceType =_haveLicenceType
            });
                MessageBox.Show(@"Üye Kaydı Tamamlandı");
              
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
   
            }
           
           
        }

       

        private void checkHaveLicence_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHaveLicence.Checked)
            {
                cmbHaveLicenceType.Visible = true;
                lblHaveLicenceType.Visible = true;

            }
            else
            {
                cmbHaveLicenceType.Visible = false;
                lblHaveLicenceType.Visible = false;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox || control is MaskedTextBox || control is RichTextBox)
                    {
                        (control as TextBox)?.Clear();
                        (control as MaskedTextBox)?.Clear();
                        (control as RichTextBox)?.Clear();
                    }
                    else
                        func(control.Controls);
            };

            func(Controls);
            cmbLoader(cmbLicenceType, cmbPlaceofBirth, cmbHaveLicenceType);
            cmbQuantityInstallment.SelectedIndex = 0;
            radioFemale.Checked = false;
                radioMale.Checked = false;
            }
      

    }
}
