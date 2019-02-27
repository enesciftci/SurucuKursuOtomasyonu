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
    public partial class ucStudentRegulation : UserControl
    {
        private readonly IStudentService _studentService = new StudentManager(new EfStudentDal());
        private static ucStudentRegulation _instanceStudentRegulation;

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

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucStudentRegulation_Load(object sender, EventArgs e)
        {
            dgwStudentSearch.DataSource = _studentService.GetAll();
        }

        private void dgwStudentSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
