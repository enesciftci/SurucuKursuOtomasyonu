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
            dgwStudents.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;
            dgwStudents.DataSource = _studentService.GetBySeason();
            
            cmbRegistrationSeason.DataSource = _registrationSeasonService.GetSeasons();
            cmbRegistrationSeason.ValueMember = "RegistrationSeasonID";
            cmbRegistrationSeason.DisplayMember = "Season";



        }

        private void toolstripStudentRecord_Click(object sender, EventArgs e)
        {
            gpbStudentSearch.Visible = false;
        }
    }
}
