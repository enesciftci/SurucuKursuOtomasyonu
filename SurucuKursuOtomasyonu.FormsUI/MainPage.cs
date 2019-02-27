using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SurucuKursuOtomasyonu.Business.Abstract;
using SurucuKursuOtomasyonu.Business.Concrete;
using SurucuKursuOtomasyonu.DataAccess.Concrete.EntityFramework;

namespace SurucuKursuOtomasyonu.FormsUI
{
    public partial class MainPage :Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
      private readonly IStudentService _studentService = new StudentManager(new EfStudentDal());
      private  IRegistrationSeasonService _registrationSeasonService=new RegistrationSeasonManager(new EfRegistrationSeasonDal());
       
        private void MainPage_Load(object sender, EventArgs e)
        {
           /* dgwStudents.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;
          dgwStudents.DataSource = _studentService.GetAll();
            dgwStudents.DataSource = _studentService.Get(1);
            cmbRegistrationSeason.DataSource = _registrationSeasonService.GetSeasons();
            cmbRegistrationSeason.ValueMember = "RegistrationSeasonID";
            cmbRegistrationSeason.DisplayMember = "Season";
            comboBox1.DataSource = _registrationSeasonService.GetSeasons();
            comboBox1.ValueMember = "RegistrationSeasonID";
            comboBox1.DisplayMember = "Season";
            */
           
        }

     
        private void btnStudentRecord_Click(object sender, EventArgs e)
        {
            if (!panelMainPage.Controls.Contains(ucStudentRecord.InstanceStudentRecord))
            {
                panelMainPage.Controls.Add(ucStudentRecord.InstanceStudentRecord);
                ucStudentRecord.InstanceStudentRecord.Dock = DockStyle.Top;
                ucStudentRecord.InstanceStudentRecord.BringToFront();
            }
            else
            {
                ucStudentRecord.InstanceStudentRecord.BringToFront();

            }
           
        }

        private void btnStudentSearch_Click(object sender, EventArgs e)
        {
            if (!panelMainPage.Controls.Contains(ucStudentSearch.InstanceStudentSearch))
            {
                panelMainPage.Controls.Add(ucStudentSearch.InstanceStudentSearch);
                ucStudentSearch.InstanceStudentSearch.Dock = DockStyle.Fill;
                ucStudentSearch.InstanceStudentSearch.BringToFront();
            }
            else
            {
                ucStudentSearch.InstanceStudentSearch.BringToFront();
            }
        }

        private void btnStudentRegulation_Click(object sender, EventArgs e)
        {
            if (!panelMainPage.Controls.Contains(ucStudentRegulation.InstanceStudentRegulation))
            {
                panelMainPage.Controls.Add(ucStudentRegulation.InstanceStudentRegulation);
                ucStudentRegulation.InstanceStudentRegulation.Dock = DockStyle.Fill;
                ucStudentRegulation.InstanceStudentRegulation.BringToFront();
            }
            else
            {
                ucStudentRegulation.InstanceStudentRegulation.BringToFront();
            }
        }

        private void MainPage_SizeChanged(object sender, EventArgs e)
        {
            
        }
    }
}
