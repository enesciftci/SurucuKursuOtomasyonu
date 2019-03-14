using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SurucuKursuOtomasyonu.Business.Abstract;
using SurucuKursuOtomasyonu.Business.Concrete;

using SurucuKursuOtomasyonu.DataAccess.Concrete.EntityFramework;
using SurucuKursuOtomasyonu.Entities.Concrete;


namespace SurucuKursuOtomasyonu.FormsUI
{
    public partial class ucStudentRecord : UserControl
    {
   
        private string _gender,_haveLicenceType;
        
        private IRegistrationSeasonService _registrationSeasonService =new RegistrationSeasonManager(new EfRegistrationSeasonDal());
        ucStudentRegulation ucStudentRegulation=new ucStudentRegulation();
        private IStudentService _studentService = new StudentManager(new EfStudentDal());
        private ILicenceTypeService _licenceTypeService = new LicenceTypeManager(new EfLicenceTypeDal());
        private ICityService _cityService = new CityManager(new EfCityDal());
        private static ucStudentRecord _instanceStudentRecord;
        public ucStudentRecord()
        {
            InitializeComponent();
        }
        public static ucStudentRecord InstanceStudentRecord
        {
            get
            {
                if (_instanceStudentRecord == null)
                {
                    _instanceStudentRecord = new ucStudentRecord();
                    
                }
               
                return _instanceStudentRecord;
            }
        }

        void LicenceLoader(ComboBox combo)
        {
            combo.DataSource = _licenceTypeService.GetLicenceTypes();
            combo.ValueMember = "LicenceTypeId";
            combo.DisplayMember = "LicenceName";
        }

     

        private void ucStudentRecord_Load(object sender, EventArgs e)
        {
            
            //  cmbRegistrationSeason.SelectedIndex = 0;
            
            cmbRegistrationSeason.ValueMember = "RegistrationSeasonID";
            cmbRegistrationSeason.DisplayMember = "Season";
            cmbRegistrationSeason.DataSource = _registrationSeasonService.GetSeasons();
            LicenceLoader(cmbLicenceType);
            LicenceLoader(cmbHaveLicenceType);
           /* cmbLicenceType.DataSource = _licenceTypeService.GetLicenceTypes();
            cmbLicenceType.ValueMember = "LicenceTypeId";
            cmbLicenceType.DisplayMember = "LicenceName";

            cmbHaveLicenceType.DataSource = _licenceTypeService.GetLicenceTypes();
            cmbHaveLicenceType.ValueMember = "LicenceTypeId";
            cmbHaveLicenceType.DisplayMember = "LicenceName";*/

            cmbPlaceofBirth.DataSource = _cityService.GetCities();
            cmbPlaceofBirth.DisplayMember = "CityName";
            cmbPlaceofBirth.ValueMember = "CityId";
          

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
                StudentEmail = txtEmail.Text,
                StudentBirthdate = Convert.ToDateTime(dpcBirthdate.Value),
                RegistrationDate = Convert.ToDateTime(dpcRegistrationDate.Value),
                RegistrationSeason =Convert.ToInt32(cmbRegistrationSeason.SelectedValue),
                StudentDebt = Convert.ToDouble(txtRegistrationDebt.Text),
                QuantityInstallment = Convert.ToInt32(cmbQuantityInstallment.Text),
                StudentPlaceofBirth =Convert.ToInt32(cmbPlaceofBirth.SelectedValue),
                StudentPhoneNumber = txtPhoneNumber.Text,
                StudentAdress = richTxtAdress.Text,
                StudentIbanNumber = txtIbanNumber.Text,
                StudentWantLicenceType = cmbLicenceType.Text,
                StudentHaveLicenceType =_haveLicenceType
            });
                MessageBox.Show("Üye Kaydı Tamamlandı");
              
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
            foreach (Control c in gbpStudentRecord.Controls)
            {
                if (c is ComboBox)
                {
                    c.ResetText();
                }

                radioFemale.Checked = false;
                radioMale.Checked = false;
            }
        }

        private void gbpStudentRecord_Enter(object sender, EventArgs e)
        {

        }

     
    }
}
