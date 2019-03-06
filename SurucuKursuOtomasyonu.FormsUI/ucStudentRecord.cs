using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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

        private IRegistrationSeasonService _registrationSeasonService =
            new RegistrationSeasonManager(new EfRegistrationSeasonDal());

        private IStudentService _studentService = new StudentManager(new EfStudentDal());
        private ILicenceTypeService _licenceTypeService = new LicenceTypeManager(new EfLicenceTypeDal());
        private ICityService _cityService = new CityManager(new EfCityDal());
        private static ucStudentRecord _instanceStudentRecord;

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

        public ucStudentRecord()
        {
            InitializeComponent();
        }

        private void ucStudentRecord_Load(object sender, EventArgs e)
        {
            cmbRegistrationSeason.DataSource = _registrationSeasonService.GetSeasons();
            cmbRegistrationSeason.ValueMember = "RegistrationSeasonID";
            cmbRegistrationSeason.DisplayMember = "Season";

            cmbLicenceType.DataSource = _licenceTypeService.GetLicenceTypes();
            cmbLicenceType.ValueMember = "LicenceTypeId";
            cmbLicenceType.DisplayMember = "LicenceName";

            cmbHaveLicenceType.DataSource = _licenceTypeService.GetLicenceTypes();
            cmbHaveLicenceType.ValueMember = "LicenceTypeId";
            cmbHaveLicenceType.DisplayMember = "LicenceName";

            cmbPlaceofBirth.DataSource = _cityService.GetCities();
            cmbPlaceofBirth.DisplayMember = "CityName";
            cmbPlaceofBirth.ValueMember = "CityId";
            

        }

        private void btnRegisterToday_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;
            maskedtxtRegistrationDate.Text = date.ToString("ddMMyyyy");

        }

        private void btnRegister_Click(object sender, EventArgs e)
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
                StudentNationalNumber = maskedTxtNationalNumber.Text,
                StudentGender = _gender,
                StudentEmail = txtEmail.Text,
                StudentBirthdate = Convert.ToDateTime(maskedTxtBirthdate.Text),
                RegistrationDate = Convert.ToDateTime(maskedtxtRegistrationDate.Text),
                RegistrationSeason =Convert.ToInt32(cmbRegistrationSeason.SelectedValue),
                StudentDebt = Convert.ToDouble(txtRegistrationDebt.Text),
                QuantityInstallment = Convert.ToInt32(cmbQuantityInstallment.Text),
                StudentPlaceofBirth =Convert.ToInt32(cmbPlaceofBirth.SelectedValue),
                StudentPhoneNumber = maskedTxtPhoneNumber.Text,
                StudentAdress = richTxtAdress.Text,
                StudentIbanNumber = maskedTxtIbanNumber.Text,
                StudentWantLicenceType = cmbLicenceType.Text,
                StudentHaveLicenceType =_haveLicenceType
            });

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

        private void cmbRegistrationSeason_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  MessageBox.Show("index", cmbRegistrationSeason.SelectedValue.ToString());
        }
    }
}
