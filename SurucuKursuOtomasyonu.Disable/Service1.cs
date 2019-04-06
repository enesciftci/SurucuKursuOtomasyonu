using System.ServiceProcess;

namespace SurucuKursuOtomasyonu.Information
{
    public partial class Service1 : ServiceBase
    {
        //  private IStudentService _studentService = InstanceFactory.GetInstance<IStudentService>();

        public Service1()
        {
            InitializeComponent();
        }


        //  Timer tmr=new Timer();

        protected override void OnStart(string[] args)
        {
        }

        /*   tmr.Interval = 120000;
           tmr.Enabled = true;
           tmr.Start();
           tmr.Elapsed+=new ElapsedEventHandler(tmr_Elapsed);
        
       

       private void tmr_Elapsed(object sender, ElapsedEventArgs e)
       {
        
       }

 */
        protected override void OnStop()
        {
        }
    }
}