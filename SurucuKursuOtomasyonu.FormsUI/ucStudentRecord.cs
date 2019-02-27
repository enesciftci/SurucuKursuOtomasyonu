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
    public partial class ucStudentRecord : UserControl
    {

        private IRegistrationSeasonService _registrationSeasonService = new RegistrationSeasonManager(new EfRegistrationSeasonDal());
        private ILicenceTypeService _licenceTypeService = new LicenceTypeManager(new EfLicenceTypeDal());
        private ICityService _cityService=new CityManager(new EfCityDal());
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

            comboBox1.DataSource = _licenceTypeService.GetLicenceTypes();
            comboBox1.ValueMember = "LicenceTypeId";
            comboBox1.DisplayMember = "LicenceName";
            comboBox3.DataSource = _cityService.GetCities();
            comboBox3.DisplayMember = "CityName";
            comboBox3.ValueMember = "CityId";
        }

        private void btnRegisterToday_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;
            maskedtxtRegisterDate.Text=date.ToString("ddMMyyyy");

        }
    }
}
