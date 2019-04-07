using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using SurucuKursuOtomasyonu.Business.Abstract;
using SurucuKursuOtomasyonu.Business.DependencyResolvers;
using SurucuKursuOtomasyonu.Entities.Concrete;
using SurucuKursuOtomasyonu.Information.Abstract;

namespace SurucuKursuOtomasyonu.FormsUI.UserControllers
{
    public partial class UcStudentRecord : UserControl
    {
        private static UcStudentRecord _instanceStudentRecord;
        private readonly ICityService _cityService = InstanceFactory.GetInstance<ICityService>();
        private readonly ILicenceTypeService _licenceTypeService = InstanceFactory.GetInstance<ILicenceTypeService>();

        private readonly IRegistrationSeasonService _registrationSeasonService =
            InstanceFactory.GetInstance<IRegistrationSeasonService>();

        private readonly IStudentService _studentService = InstanceFactory.GetInstance<IStudentService>();

        private IExportWithPrinterService _exportWithPrinterService =
            InstanceFactory.GetInstance<IExportWithPrinterService>();

        private IExportByPdfService _exportByPdfService = InstanceFactory.GetInstance<IExportByPdfService>();
        private string _gender, _haveLicenceType;

        public UcStudentRecord()
        {
            InitializeComponent();
        }

        public static UcStudentRecord InstanceStudentRecord
        {
            get
            {
                if (_instanceStudentRecord == null) _instanceStudentRecord = new UcStudentRecord();

                return _instanceStudentRecord;
            }
        }

        private void CmbLoader(ComboBox combo, ComboBox combo2, ComboBox combo3)
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
            CmbLoader(cmbLicenceType, cmbPlaceofBirth, cmbHaveLicenceType);
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioFemale.Checked) _gender = "Kadın";

                if (radioMale.Checked) _gender = "Erkek";

                if (cmbHaveLicenceType.Visible == false)
                    _haveLicenceType = "Null";
                else
                    _haveLicenceType = cmbHaveLicenceType.Text;
              var student=new Student
              {
                  StudentName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtStudentName.Text),
                  StudentSurname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtStudentSurname.Text),
                  StudentNationalNumber = txtNationalNumber.Text,
                  StudentGender = _gender,
                  StudentEmail = txtEmail.Text.Trim().ToLower(),
                  StudentBirthdate = Convert.ToDateTime(dpcBirthdate.Value),
                  RegistrationDate = Convert.ToDateTime(DateTime.Today.ToShortDateString()),
                  RegistrationSeason = _registrationSeasonService.GetSeasons().Count,
                  StudentDebt = Convert.ToDecimal(txtRegistrationDebt.Text),
                  StudentTotalDebt = Convert.ToDecimal(txtRegistrationDebt.Text),
                  QuantityInstallment = Convert.ToInt32(cmbQuantityInstallment.Text),
                  StudentPlaceofBirth = Convert.ToInt32(cmbPlaceofBirth.SelectedValue),
                  StudentPhoneNumber = txtPhoneNumber.Text,
                  StudentAdress = txtAdress.Text,
                  StudentIbanNumber = txtIbanNumber.Text.ToUpper().Trim(),
                  StudentWantLicenceType = cmbLicenceType.Text,
                  StudentHaveLicenceType = _haveLicenceType
              };
                _studentService.Add(student);
               
                MessageBox.Show(@"Üye Kaydı Tamamlandı");
                var dialog = MessageBox.Show(@"Öğrenci Bilgilerini Yazdırmak İster Misiniz ?", @"Uyarı",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    _exportByPdfService.CreateRecordPdf(student);
                   _exportWithPrinterService.PrintPdf();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                /* MessageBox.Show(@"Lütfen Alanları Kontrol Ediniz.", @"Uyarı", MessageBoxButtons.OK,
                     MessageBoxIcon.Information);*/
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
            Action<ControlCollection> func = null;

            func = controls =>
            {
                foreach (Control control in controls)
                    if (control is TextBox || control is MaskedTextBox || control is RichTextBox)
                    {
                        (control as TextBox)?.Clear();
                        (control as MaskedTextBox)?.Clear();
                        (control as RichTextBox)?.Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    }
            };

            func(Controls);
            CmbLoader(cmbLicenceType, cmbPlaceofBirth, cmbHaveLicenceType);
            cmbQuantityInstallment.SelectedIndex = 0;
            radioFemale.Checked = false;
            radioMale.Checked = false;
        }
    }
}