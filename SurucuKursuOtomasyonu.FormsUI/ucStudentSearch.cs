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

namespace SurucuKursuOtomasyonu.FormsUI
{
    public partial class ucStudentSearch : UserControl
    {
         private readonly IStudentService _studentService = new StudentManager(new EfStudentDal());
        private IRegistrationSeasonService _registrationSeasonService = new RegistrationSeasonManager(new EfRegistrationSeasonDal());
       
        private static ucStudentSearch _instanceStudentSearch;

        public static ucStudentSearch InstanceStudentSearch
        {
            get
            {
                if (_instanceStudentSearch == null)
                {
                    _instanceStudentSearch = new ucStudentSearch();
                }
                return _instanceStudentSearch;
            }
        }
        public ucStudentSearch()
        {
            InitializeComponent();
        }



        private void gbpStudentSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucStudentSearch_Load(object sender, EventArgs e)
        {
            dgwStudentSearch.DataSource = _studentService.GetAll();
           cmbRegistrationSeason.DataSource = _registrationSeasonService.GetSeasons();
            cmbRegistrationSeason.ValueMember = "RegistrationSeasonID";
            cmbRegistrationSeason.DisplayMember = "Season";
           
        }
    }
}
