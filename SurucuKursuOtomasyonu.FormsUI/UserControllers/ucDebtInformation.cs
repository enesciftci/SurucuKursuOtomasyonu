using System;
using System.Threading;
using System.Windows.Forms;
using SurucuKursu.InformationService.Senders.MailSender;
using SurucuKursuOtomasyonu.Business.Abstract;
using SurucuKursuOtomasyonu.Business.DependencyResolvers;

namespace SurucuKursuOtomasyonu.FormsUI.UserControllers
{
    public partial class UcDebtInformation : UserControl
    {
        private IStudentService _studentService = InstanceFactory.GetInstance<IStudentService>();
        private static UcDebtInformation _instanceDebtInformation;
        private string _email,_name,_surname,_debt,_message;
        private int i;
        public UcDebtInformation()
        {
            InitializeComponent();
        }
        public static UcDebtInformation InstanceDebtInformation
        {
            get
            {
                if (_instanceDebtInformation == null)
                {
                    _instanceDebtInformation = new UcDebtInformation();
                }

                return _instanceDebtInformation;
            }
            
        }

      
        void HideColumns(int column)
        {
            dgwDebtInformation.Columns[column].Visible = false;
        }
        private void UcDebtInformation_Load(object sender, System.EventArgs e)
        {
            dgwDebtInformation.DataSource = _studentService.GetDebtor();
          
            for (int i = 6; i <= 9; i++)
            {
               HideColumns(i);
            }
            HideColumns(4);
            HideColumns(16);
            HideColumns(11);
            HideColumns(17);
       

        }

        private void dgwDebtInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnSendInformation_Click(object sender, EventArgs e)
        {
            prgDebtInformation.Value = 0;
            prgDebtInformation.Maximum = 100;
            prgDebtInformation.Step = Convert.ToInt32(dgwDebtInformation.RowCount*0.6);
            btnSendInformation.Enabled = false;
          
            
            if (cbxInfoWithEmail.Checked)
            {
                try
                {

                
                for ( i = 0; i < dgwDebtInformation.RowCount; i++)
                {
                    prgDebtInformation.PerformStep();
              
                    foreach (var email in dgwDebtInformation.Rows[i].Cells[5].Value.ToString())
                    {
                        _email += email.ToString();

                    }

                    foreach (var name in dgwDebtInformation.Rows[i].Cells[1].Value.ToString())
                    {
                        _name += name.ToString();
                    }
                   
                    foreach (var surname in dgwDebtInformation.Rows[i].Cells[2].Value.ToString())
                    {
                        _surname += surname;
                    }

                    foreach (var debt in dgwDebtInformation.Rows[i].Cells[13].Value.ToString())
                    {
                        _debt += debt.ToString();
                    }

                  
                    string nameSurname = string.Concat($"{_name} {_surname}");
                    lblStudentState.Text = nameSurname;
                    Application.DoEvents();
                    _message =
                        $"Sayın {nameSurname} sürücü kursumuza {_debt} ödemeniz bulunmaktadır. En kısa sürede ödemenizi yapmanızı rica eder iyi günler dileriz.";
                 
             MailSender.SendMail(_email, _message);
                   
                    _surname = "";
                    _debt = "";
                    _name = "";
                    _email = "";
                }
               
            btnSendInformation.Enabled = true;
                }
            catch (Exception)
            {
               MessageBox.Show($@"{_name},{_surname} isimli öğrenciye mail gönderilemedi");
            }

        }
           

        }
    }
}
