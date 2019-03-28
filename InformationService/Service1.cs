using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Timers;
using System.Windows.Forms;
using SurucuKursuOtomasyonu.Business.Abstract;
using SurucuKursuOtomasyonu.Business.Concrete;
using SurucuKursuOtomasyonu.Business.DependencyResolvers;
using SurucuKursuOtomasyonu.Entities.Concrete;
using Timer = System.Timers.Timer;

namespace InformationService
{
  
    public partial class Service1 : ServiceBase
    {
        private IStudentService _studentService = InstanceFactory.GetInstance<IStudentService>();
        
        public Service1()
        {
            InitializeComponent();
        }
        

        Timer tmr=new Timer();
        DataGridView dgw=new DataGridView();
        protected override void OnStart(string[] args)
        {
          
            tmr.Interval = 120000;
            tmr.Enabled = true;
            tmr.Start();
            tmr.Elapsed+=new ElapsedEventHandler(tmr_Elapsed);
            CalculateDebtor();
        }

        private void tmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            MessageBox.Show(dgw.CurrentRow.Cells[0].Value.ToString());
        }

        void CalculateDebtor()
        {
            dgw.DataSource = _studentService.GetDebtor();

        }

        protected override void OnStop()
        {
        }
    }
}
