using System;
using System.Windows.Forms;
using SurucuKursuOtomasyonu.Business.Abstract;
using SurucuKursuOtomasyonu.Business.DependencyResolvers;
using SurucuKursuOtomasyonu.Entities.Concrete;

namespace SurucuKursuOtomasyonu.FormsUI.UserControllers
{
    public partial class UcStudentRegulation : UserControl
    {
        private static UcStudentRegulation _instanceStudentRegulation;
        private readonly ICityService _cityService = InstanceFactory.GetInstance<ICityService>();

        /*  private readonly IRegistrationSeasonService _registrationSeasonService =
            InstanceFactory.GetInstance<IRegistrationSeasonService>();*/

        private readonly ILicenceTypeService _licenceTypeService = InstanceFactory.GetInstance<ILicenceTypeService>();

        private readonly IStudentService _studentService = InstanceFactory.GetInstance<IStudentService>();
        private string _gender, _haveLicenceType;
        private string _haveLicence;

        public UcStudentRegulation()
        {
            InitializeComponent();
        }

        public static UcStudentRegulation InstanceStudentRegulation
        {
            get
            {
                if (_instanceStudentRegulation == null) _instanceStudentRegulation = new UcStudentRegulation();


                return _instanceStudentRegulation;
            }
        }

        private void ClearAll()
        {
            Action<ControlCollection> func = null;

            func = controls =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox)?.Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
            radioFemale.Checked = false;
            radioMale.Checked = false;
        }

        private void comboClear(ComboBox combo)
        {
            combo.SelectedIndex = -1;
        }

        private void DgwLoad()
        {
            dgwStudentRegulation.DataSource = _studentService.GetAll();
        }

        private void LicenceLoader(ComboBox combo)
        {
            combo.DataSource = _licenceTypeService.GetLicenceTypes();
            combo.ValueMember = "LicenceTypeId";
            combo.DisplayMember = "LicenceName";
        }

        private string FillTextBox(int i)
        {
            var fill = "";
            if (dgwStudentRegulation.CurrentRow == null)
                MessageBox.Show(@"Kayıt Seçimi Yapınız.", @"Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                fill = dgwStudentRegulation.CurrentRow.Cells[i].Value.ToString();

            return fill;
        }


        private void ucStudentRegulation_Load(object sender, EventArgs e)
        {
            dgwStudentRegulation.BorderStyle = BorderStyle.Fixed3D;
            dgwStudentRegulation.DataSource = _studentService.GetAll();

            LicenceLoader(cmbLicenceType);
            LicenceLoader(cmbHaveLicenceType);


            cmbPlaceofBirth.DataSource = _cityService.GetCities();
            cmbPlaceofBirth.DisplayMember = "CityName";
            cmbPlaceofBirth.ValueMember = "CityId";
        }


        private void dgwStudentRegulation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtStudentName.Text = FillTextBox(1);
                txtStudentSurname.Text = FillTextBox(2);
                txtNationalNumber.Text = FillTextBox(3);
                _gender = FillTextBox(4);
                if (_gender.Contains("Erkek")) radioMale.Checked = true;

                if (_gender.Contains("Kadın")) radioFemale.Checked = true;

                txtEmail.Text = FillTextBox(5);
                dpcBirthdate.Value = Convert.ToDateTime(FillTextBox(6));
                cmbPlaceofBirth.SelectedValue = Convert.ToInt32(FillTextBox(7));
                txtPhoneNumber.Text = FillTextBox(8);
                txtAdress.Text = FillTextBox(9);

                txtRegistrationDebt.Text = FillTextBox(12);
                cmbQuantityInstallment.Text = FillTextBox(14);
                txtIbanNumber.Text = FillTextBox(15);
                cmbLicenceType.Text = FillTextBox(17);
                _haveLicence = FillTextBox(16);
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
            }
            catch (Exception)
            {
                MessageBox.Show(@"Bir Hatayla Karşılaşıldı");
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


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dialogResult =
                MessageBox.Show(txtStudentName.Text + @" " + txtStudentSurname.Text + @" Silinecek Emin Misiniz?",
                    @"Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
                try
                {
                    if (dgwStudentRegulation.CurrentRow != null)
                        _studentService.Delete(new Student
                        {
                            StudentId = Convert.ToInt32(dgwStudentRegulation.CurrentRow.Cells[0].Value)
                        });

                    DgwLoad();
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Bir hatayla karşılaşıldı");
                }
        }


        private void txtSearchByNationalNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearchByNationalNumber.Text == string.Empty)
                DgwLoad();

            else
                dgwStudentRegulation.DataSource =
                    _studentService.GetByNationalNumber(txtSearchByNationalNumber.Text);
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var dialogResult =
                MessageBox.Show(txtStudentName.Text + @" " + txtStudentSurname.Text + @" Güncellenecek Emin Misiniz ?",
                    @"Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (radioFemale.Checked) _gender = "Kadın";

                    if (radioMale.Checked) _gender = "Erkek";

                    if (cmbHaveLicenceType.Visible == false)
                        _haveLicenceType = "Null";
                    else
                        _haveLicenceType = cmbHaveLicenceType.Text;

                    _studentService.Update(new Student
                    {
                        StudentId = Convert.ToInt32(dgwStudentRegulation.CurrentRow.Cells[0].Value),
                        StudentName = txtStudentName.Text,
                        StudentSurname = txtStudentSurname.Text,
                        StudentNationalNumber = txtNationalNumber.Text,
                        StudentGender = _gender,
                        StudentEmail = txtEmail.Text,
                        StudentBirthdate = Convert.ToDateTime(dpcBirthdate.Value),
                        RegistrationDate = Convert.ToDateTime(FillTextBox(10)),
                        RegistrationSeason = Convert.ToInt32(FillTextBox(11)),
                        StudentDebt = Convert.ToDecimal(txtRegistrationDebt.Text),
                        StudentTotalDebt = Convert.ToDecimal(dgwStudentRegulation.CurrentRow.Cells[13].Value),
                        QuantityInstallment = Convert.ToInt32(cmbQuantityInstallment.Text),
                        StudentPlaceofBirth = Convert.ToInt32(cmbPlaceofBirth.SelectedValue),
                        StudentPhoneNumber = txtPhoneNumber.Text,
                        StudentAdress = txtAdress.Text,
                        StudentIbanNumber = txtIbanNumber.Text,
                        StudentWantLicenceType = cmbLicenceType.Text,
                        StudentHaveLicenceType = _haveLicenceType
                    });
                    MessageBox.Show(@"Öğrenci Güncellendi");
                    ClearAll();

                    comboClear(cmbHaveLicenceType);
                    comboClear(cmbLicenceType);
                    comboClear(cmbPlaceofBirth);
                    comboClear(cmbQuantityInstallment);
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