using SurucuKursuOtomasyonu.Business.Abstract;
using SurucuKursuOtomasyonu.Business.Concrete;
using SurucuKursuOtomasyonu.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;

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

        void DgwRefresh()
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
            if (!String.IsNullOrEmpty(txtNationalNumber.Text))
            {
                dgwStudentSearch.DataSource =
                    _studentService.GetByNationalNumber(txtNationalNumber.Text);
            }
            else
            {
                DgwRefresh();
            }
        }

        private void txtStudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmbRegistrationSeason.SelectedIndex = -1;
            if (!String.IsNullOrEmpty(txtStudentName.Text))
            {
                dgwStudentSearch.DataSource = _studentService.GetByName(txtStudentName.Text);
            }
            else
            {
                DgwRefresh();
            }
           
        }


        private void cmbRegistrationSeason_Enter(object sender, EventArgs e)
        {
            txtNationalNumber.Text = "";
            txtStudentName.Text = "";
            DgwRefresh();
            
        }
    }
}
