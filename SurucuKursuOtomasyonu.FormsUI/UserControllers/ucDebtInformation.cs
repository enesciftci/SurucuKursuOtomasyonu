using System;
using System.Windows.Forms;
using SurucuKursuOtomasyonu.Business.Abstract;
using SurucuKursuOtomasyonu.Business.DependencyResolvers;
using SurucuKursuOtomasyonu.Information.Abstract;

namespace SurucuKursuOtomasyonu.FormsUI.UserControllers
{
    public partial class UcDebtInformation : UserControl
    {
        private static UcDebtInformation _instanceDebtInformation;
        private string _email, _name, _surname, _debt, _message;
        private readonly IMailService _mailService = InstanceFactory.GetInstance<IMailService>();
        private readonly IStudentService _studentService = InstanceFactory.GetInstance<IStudentService>();
        private int i;

        public UcDebtInformation()
        {
            InitializeComponent();
        }

        public static UcDebtInformation InstanceDebtInformation
        {
            get
            {
                if (_instanceDebtInformation == null) _instanceDebtInformation = new UcDebtInformation();

                return _instanceDebtInformation;
            }
        }


        private void HideColumns(int column)
        {
            dgwDebtInformation.Columns[column].Visible = false;
        }

        private void UcDebtInformation_Load(object sender, EventArgs e)
        {
            dgwDebtInformation.DataSource = _studentService.GetDebtor();

            for (var i = 6; i <= 9; i++) HideColumns(i);
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
            prgDebtInformation.Maximum = dgwDebtInformation.RowCount;
            prgDebtInformation.Step = 1;
            btnSendInformation.Enabled = false;


            if (cbxInfoWithEmail.Checked)
            {
                try
                {
                    for (i = 0; i < dgwDebtInformation.RowCount; i++)
                    {
                        prgDebtInformation.PerformStep();

                        foreach (var email in dgwDebtInformation.Rows[i].Cells[5].Value.ToString())
                            _email += email.ToString();

                        foreach (var name in dgwDebtInformation.Rows[i].Cells[1].Value.ToString())
                            _name += name.ToString();

                        foreach (var surname in dgwDebtInformation.Rows[i].Cells[2].Value.ToString())
                            _surname += surname;

                        foreach (var debt in dgwDebtInformation.Rows[i].Cells[13].Value.ToString())
                            _debt += debt.ToString();


                        var nameSurname = string.Concat($"{_name} {_surname}");

                        lbxDebtorStudents.Items.Add(nameSurname);

                        Application.DoEvents();
                        _message =
                            $"Sayın {nameSurname} sürücü kursumuza {_debt} ödemeniz bulunmaktadır. En kısa sürede ödemenizi yapmanızı rica eder iyi günler dileriz.";


                        _mailService.SendMail(_email, _message);

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

                lblSuccessfulRecord.Text = @"İletilen Borçlu Sayısı: " + lbxDebtorStudents.Items.Count;
                lbxDebtorStudents.Text = @"Borçlu Sayısı: " + dgwDebtInformation.RowCount;
                MessageBox.Show(dgwDebtInformation.RowCount.ToString());
            }
        }
    }
}