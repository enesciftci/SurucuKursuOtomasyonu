using SurucuKursuOtomasyonu.Business.Abstract;
using SurucuKursuOtomasyonu.Business.Concrete;
using SurucuKursuOtomasyonu.DataAccess.Concrete.EntityFramework;
using SurucuKursuOtomasyonu.Entities.Concrete;
using System;
using System.Windows.Forms;

namespace SurucuKursuOtomasyonu.FormsUI
{
    public partial class ucStudentRegulation : UserControl
    {
        private readonly IStudentService _studentService = new StudentManager(new EfStudentDal());
       private readonly IRegistrationSeasonService _registrationSeasonService=new RegistrationSeasonManager(new EfRegistrationSeasonDal());
        private  readonly ILicenceTypeService _licenceTypeService=new LicenceTypeManager(new EfLicenceTypeDal());
        private readonly ICityService _cityService=new CityManager(new EfCityDal());
        private static ucStudentRegulation _instanceStudentRegulation;
        private string _gender, _haveLicenceType;
        private string _haveLicence;

        public void DgwLoad()
        {
            dgwStudentRegulation.DataSource = _studentService.GetAll();
        }
        public static ucStudentRegulation InstanceStudentRegulation
        {
            get
            {
                if (_instanceStudentRegulation == null)
                {
                  
                    _instanceStudentRegulation = new ucStudentRegulation();
                   
                }
              
                return _instanceStudentRegulation;
            }
             
              
            
        }
        public ucStudentRegulation()
        {
            InitializeComponent();
              
        }
        
        string FillTextBox(int i)
        {
           return dgwStudentRegulation.CurrentRow.Cells[i].Value.ToString();
        }
       

        private void ucStudentRegulation_Load(object sender, EventArgs e)
        {
         
            dgwStudentRegulation.DataSource = _studentService.GetAll();
            cmbRegistrationSeason.DataSource = _registrationSeasonService.GetSeasons();
            cmbRegistrationSeason.ValueMember = "RegistrationSeasonID";
            cmbRegistrationSeason.DisplayMember = "Season";

            cmbLicenceType.DataSource = _licenceTypeService.GetLicenceTypes();
            cmbLicenceType.ValueMember = "LicenceTypeId";
            cmbLicenceType.DisplayMember = "LicenceName";

            cmbPlaceofBirth.DataSource = _cityService.GetCities();
            cmbPlaceofBirth.DisplayMember = "CityName";
            cmbPlaceofBirth.ValueMember = "CityId";
           
        }

    

        private void dgwStudentRegulation_CellClick(object sender, DataGridViewCellEventArgs e)
        {/* 
            Name=1                    RegistrationSeason=11
            Surname=2                  RegistrationDebt=12
            nationalNumber=3            Quantityİnstallment=13
            Gender=4                    Iban=14
            Email=5                   LicenceType=15
            Birthdate=6                  HaveLicence=16
            PlaceofBirth=7            
             PhoneNumber=8 
             Adress=9          
            RegistrationDate=10       */


              txtStudentName.Text = FillTextBox(1);
               txtStudentSurname.Text = FillTextBox(2);
               txtNationalNumber.Text = FillTextBox(3);
               _gender = FillTextBox(4);
               if (_gender.Contains("Erkek"))
               {
                   radioMale.Checked = true;
               }

               if (_gender.Contains("Kadın"))
               {
                   radioFemale.Checked = true;
               }
            txtEmail.Text = FillTextBox(5);
            dpcBirthdate.Value= Convert.ToDateTime(FillTextBox(6));
            //   MessageBox.Show(Convert.ToInt16(FillTextBox(12)).ToString());
               cmbPlaceofBirth.SelectedIndex = Convert.ToInt32(FillTextBox(7));
            txtPhoneNumber.Text = FillTextBox(8);
            txtAdress.Text = FillTextBox(9);
            dpcRegistrationDate.Value = Convert.ToDateTime(FillTextBox(10));
            cmbRegistrationSeason.SelectedIndex = Convert.ToInt16(FillTextBox(11));
            txtRegistrationDebt.Text = FillTextBox(12);
            cmbQuantityInstallment.Text = FillTextBox(13);
            txtIbanNumber.Text = FillTextBox(14);
            cmbLicenceType.Text = FillTextBox(16);
            _haveLicence = FillTextBox(15);
                   if (_haveLicence.Contains("Null"))
               {
                   checkHaveLicence.Checked = false;
                   lblHaveLicenceType.Visible = false;
                   cmbHaveLicenceType.Visible = false;
               }
               else
               {           
                   checkHaveLicence.Checked = true;
                   cmbHaveLicenceType.Text = FillTextBox(16);
                   lblHaveLicenceType.Visible = true;
                   cmbHaveLicenceType.Visible = true;
               }
              
              
            txtSearchByNationalNumber.ResetText();
          //  MessageBox.Show(dgwStudentRegulation.CurrentCell.ColumnIndex.ToString());

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
            DialogResult dialogResult =
                MessageBox.Show(txtStudentName.Text + @" " + txtStudentSurname.Text + @" Silinecek Emin Misiniz?",
                    @"Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

                   try
                   {
                       if (dgwStudentRegulation.CurrentRow != null)
                           _studentService.Delete(new Student
                           {
                               StudentID = Convert.ToInt32(dgwStudentRegulation.CurrentRow.Cells[1].Value)
                           });

                       DgwLoad();
                   }
                   catch (Exception)
                   {

                   }
            }
        }

       

            private void txtSearchByNationalNumber_KeyPress(object sender, KeyPressEventArgs e)
            {

                if (txtSearchByNationalNumber.Text == String.Empty)
                {

                    DgwLoad();
                }

                else
                {
                    dgwStudentRegulation.DataSource =
                        _studentService.GetByNationalNumber(txtSearchByNationalNumber.Text);
                }
            }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show(txtStudentName.Text + @" " + txtStudentSurname.Text + @" Güncellenecek Emin Misiniz ?", @"Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
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

                    _studentService.Update(new Student
                    {
                        StudentID = Convert.ToInt32(dgwStudentRegulation.CurrentRow.Cells[1].Value),
                        StudentName = txtStudentName.Text,
                        StudentSurname = txtStudentSurname.Text,
                        StudentNationalNumber = txtNationalNumber.Text,
                        StudentGender = _gender,
                        StudentEmail = txtEmail.Text,
                        StudentBirthdate = Convert.ToDateTime(dpcBirthdate.Value),
                        RegistrationDate = Convert.ToDateTime(dpcRegistrationDate.Value),
                        RegistrationSeason = Convert.ToInt32(cmbRegistrationSeason.SelectedValue),
                        StudentDebt = Convert.ToDouble(txtRegistrationDebt.Text),
                        QuantityInstallment = Convert.ToInt32(cmbQuantityInstallment.Text),
                        StudentPlaceofBirth = Convert.ToInt32(cmbPlaceofBirth.SelectedValue),
                        StudentPhoneNumber = txtPhoneNumber.Text,
                        StudentAdress = txtAdress.Text,
                        StudentIbanNumber = txtIbanNumber.Text,
                        StudentWantLicenceType = cmbLicenceType.Text,
                        StudentHaveLicenceType = _haveLicenceType
                    });
                    MessageBox.Show(@"Öğrenci Güncellendi");

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);

                }

                DgwLoad();
            }
            else
            {
                MessageBox.Show(@"Değişiklik Uygulanmadı");
            }
        }

      
    }
}
