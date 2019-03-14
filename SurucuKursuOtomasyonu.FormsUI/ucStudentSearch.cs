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



       

        private void ucStudentSearch_Load(object sender, EventArgs e)
        {
            dgwStudentSearch.DataSource = _studentService.GetAll();
           cmbRegistrationSeason.DataSource = _registrationSeasonService.GetSeasons();
            cmbRegistrationSeason.ValueMember = "RegistrationSeasonID";
            cmbRegistrationSeason.DisplayMember = "Season";
           
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

     


        private void txtStudentNationalNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgwStudentSearch.DataSource =
                _studentService.GetByNationalNumber(txtStudentNationalNumber.Text);
        }

        private void txtStudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgwStudentSearch.DataSource = _studentService.GetByName(txtStudentName.Text);
        }
    }
}
