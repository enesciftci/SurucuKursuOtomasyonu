using System;
using System.Windows.Forms;
using SurucuKursuOtomasyonu.Business.Abstract;
using SurucuKursuOtomasyonu.Business.DependencyResolvers;

namespace SurucuKursuOtomasyonu.FormsUI.UserControllers
{
    public partial class UcStudentSearch : UserControl
    {
        private static UcStudentSearch _instanceStudentSearch;

        private readonly IRegistrationSeasonService _registrationSeasonService =
            InstanceFactory.GetInstance<IRegistrationSeasonService>();

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
    }
}