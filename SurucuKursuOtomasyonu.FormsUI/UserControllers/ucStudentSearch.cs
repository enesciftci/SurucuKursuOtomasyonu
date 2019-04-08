using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SurucuKursuOtomasyonu.Business.Abstract;
using SurucuKursuOtomasyonu.Business.DependencyResolvers;
using SurucuKursuOtomasyonu.Entities.Concrete;
using SurucuKursuOtomasyonu.Information.Abstract;

namespace SurucuKursuOtomasyonu.FormsUI.UserControllers
{
    public partial class UcStudentSearch : UserControl
    {
        private static UcStudentSearch _instanceStudentSearch;

        private readonly IRegistrationSeasonService _registrationSeasonService =
            InstanceFactory.GetInstance<IRegistrationSeasonService>();

        private IExportByPdfService _exportByPdfService = InstanceFactory.GetInstance<IExportByPdfService>();
        private readonly IStudentService _studentService = InstanceFactory.GetInstance<IStudentService>();

        public UcStudentSearch()
        {
            InitializeComponent();
        }

        public static UcStudentSearch InstanceStudentSearch
        {
            get
            {
                if (_instanceStudentSearch == null) _instanceStudentSearch = new UcStudentSearch();
                return _instanceStudentSearch;
            }
        }

        private void DgwRefresh()
        {
            dgwStudentSearch.DataSource = _studentService.GetAll();
        }


        private void ucStudentSearch_Load(object sender, EventArgs e)
        {
            cmbRegistrationSeason.DataSource = _registrationSeasonService.GetSeasons();
            cmbRegistrationSeason.ValueMember = "RegistrationSeasonID";
            cmbRegistrationSeason.DisplayMember = "Season";
            cmbRegistrationSeason.SelectedIndex = -1;
            dgwStudentSearch.DataSource = _studentService.GetAll();
        }

        private void cmbRegistrationSeason_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwStudentSearch.DataSource =
                    _studentService.GetBySeason(Convert.ToInt32(cmbRegistrationSeason.SelectedValue));
            }
            catch (Exception)
            {
            }
        }


        private void txtNationalNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmbRegistrationSeason.SelectedIndex = -1;
            if (!string.IsNullOrEmpty(txtNationalNumber.Text))
                dgwStudentSearch.DataSource =
                    _studentService.GetByNationalNumber(txtNationalNumber.Text);
            else
                DgwRefresh();
        }

        private void txtStudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmbRegistrationSeason.SelectedIndex = -1;
            if (!string.IsNullOrEmpty(txtStudentName.Text))
                dgwStudentSearch.DataSource = _studentService.GetByName(txtStudentName.Text);
            else
                DgwRefresh();
        }


        private void cmbRegistrationSeason_Enter(object sender, EventArgs e)
        {
            txtNationalNumber.Text = "";
            txtStudentName.Text = "";
            DgwRefresh();
        }

        private void gbpStudentSearch_Enter(object sender, EventArgs e)
        {

        }

        private void btnPluralPdf_Click(object sender, EventArgs e)
        {

            List<Student> students = new List<Student>();

            DataGridViewRow row(int i)
            {
                var data = dgwStudentSearch.Rows[i];
                return data;
            }

            /* MessageBox.Show(dgwStudentSearch.Rows[0].Cells[0].Value.ToString());
             MessageBox.Show(dgwStudentSearch.Rows[0].Cells[1].Value.ToString());
             */
          
                for (int i = 0; i < dgwStudentSearch.RowCount; i++)
            {

                students.Add(new Student
                {
                  StudentId = Convert.ToInt32(row(i).Cells[0].Value),
                    StudentName = row(i).Cells[1].Value.ToString(),
                    StudentSurname = row(i).Cells[2].Value.ToString(),
                    StudentNationalNumber = row(i).Cells[3].Value.ToString(),
                    StudentGender = row(i).Cells[4].Value.ToString(),
                    StudentEmail = row(i).Cells[5].Value.ToString(),
                    StudentBirthdate = Convert.ToDateTime(row(i).Cells[6].Value),
                    StudentPlaceofBirth = Convert.ToInt32(row(i).Cells[7].Value),
                    StudentPhoneNumber = row(i).Cells[8].Value.ToString(),
                    StudentAdress = row(i).Cells[9].Value.ToString(),
                    RegistrationDate = DateTime.Today,
                    RegistrationSeason = Convert.ToInt32(row(i).Cells[11].Value),
                   StudentDebt = Convert.ToDecimal(row(i).Cells[12].Value),
                    StudentTotalDebt = Convert.ToDecimal(row(i).Cells[13].Value),
                    QuantityInstallment = Convert.ToInt32(row(i).Cells[14].Value),
                    StudentIbanNumber = row(i).Cells[15].Value.ToString(),
                    StudentHaveLicenceType = row(i).Cells[16].Value.ToString(),
                    StudentWantLicenceType = row(i).Cells[17].Value.ToString()
                });


                _exportByPdfService.CreateForAllStudent(students);
            }
           

        }

        /* for (int i = 0; i < dgwStudentSearch.RowCount; i++)
            {
                for (int j = 0; j < dgwStudentSearch.ColumnCount; j++)
                {
                    var data = dgwStudentSearch.Rows[i].Cells[j].Value.ToString();

                    students.Add(new Student
                     {
                       //  StudentId = Convert.ToInt32(data),
                         StudentName = dgwStudentSearch.Rows[i].Cells[j].Value.ToString(),
                         StudentSurname = data.ToString(),
                         StudentNationalNumber = data.ToString(),
                         StudentGender = data.ToString(),
                         StudentEmail = data.ToString(),
                        StudentBirthdate =DateTime.Today.AddYears(-20),
                         RegistrationDate =DateTime.Today,
                         RegistrationSeason = Convert.ToInt32(data),
                         StudentDebt = Convert.ToDecimal(data),
                         StudentTotalDebt = Convert.ToDecimal(data),
                         QuantityInstallment = Convert.ToInt32(data),
                         StudentPlaceofBirth = Convert.ToInt32(data),
                         StudentPhoneNumber = data.ToString(),
                         StudentAdress = data.ToString(),
                         StudentIbanNumber = data.ToString(),
                         StudentHaveLicenceType = data.ToString(),
                         StudentWantLicenceType = data.ToString()
                     });
                    foreach (var student in students)
                    {
                        MessageBox.Show(student.StudentName);
                    }
                     _exportByPdfService.CreateForAllStudent(students);

                }
            }*/
    


private void dgwStudentSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnSingularPdf_Click(object sender, EventArgs e)
        {

        }
    }
}