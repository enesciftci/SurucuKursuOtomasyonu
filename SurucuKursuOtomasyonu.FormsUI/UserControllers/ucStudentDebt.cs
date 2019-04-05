using SurucuKursuOtomasyonu.Business.Abstract;
using SurucuKursuOtomasyonu.Business.DependencyResolvers;
using SurucuKursuOtomasyonu.Entities.Concrete;
using System;
using System.Windows.Forms;
using SurucuKursu.InformationService.DocumentExporter;

namespace SurucuKursuOtomasyonu.FormsUI.UserControllers
{
    public partial class UcStudentDebt : UserControl
    {
        private static UcStudentDebt _instanceStudentDebt;
        private static readonly IStudentService StudentService = InstanceFactory.GetInstance<IStudentService>();
        private decimal _pay = 0, _remainingDebt;
        private decimal _mustPaid = 0;
        private int _remainingInstallment;

        public static UcStudentDebt InstanceStudentDebt
        {

            get
            {
                if (_instanceStudentDebt == null)
                {

                    _instanceStudentDebt = new UcStudentDebt();

                }


                return _instanceStudentDebt;
            }
        }

        public UcStudentDebt()
        {
            InitializeComponent();
        }

        private void fillTxt()
        {
            if (dgwStudentDebt.CurrentRow != null)
            {
                txtRemainingDebt.Text = dgwStudentDebt.CurrentRow.Cells[13].Value.ToString();
                txtRemainingInstallment.Text = dgwStudentDebt.CurrentRow.Cells[14].Value.ToString();
                txtStudentId.Text = dgwStudentDebt.CurrentRow.Cells[0].Value.ToString();
                txtStudentNameSurname.Text = string.Concat(dgwStudentDebt.CurrentRow.Cells[1].Value + " ",
                    dgwStudentDebt.CurrentRow.Cells[2].Value.ToString());
                _remainingInstallment = Convert.ToInt32(txtRemainingInstallment.Text);
                _remainingDebt = Convert.ToDecimal(txtRemainingDebt.Text);
            }

           
            if (_remainingInstallment <= 0)
            {
               
                _mustPaid = 0;
            }
            else
            {
                _mustPaid = _remainingDebt / _remainingInstallment;
            }

            txtMustPaidAmount.Text = Math.Round(_mustPaid,2).ToString();
        }

        string FillTextBox(int i)
        {
            var fill = "";
            if (dgwStudentDebt.CurrentRow == null)
            {
                MessageBox.Show(@"Kayıt Seçimi Yapınız.", @"Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                fill = dgwStudentDebt.CurrentRow.Cells[i].Value.ToString();
            }

            return fill;
        }

        private void txtPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgwStudentDebt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            fillTxt();
        }

        private void UcStudentDebt_Load(object sender, EventArgs e)
        {


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNationalNumber.Text))
            {
                dgwStudentDebt.DataSource = StudentService.GetByNationalNumber(txtNationalNumber.Text);
                for (int i = 4; i <= 9; i++)
                {
                    dgwStudentDebt.Columns[i].Visible = false;
                }

                dgwStudentDebt.Columns[16].Visible = false;
                dgwStudentDebt.Columns[11].Visible = false;
                if (dgwStudentDebt.RowCount <= 0)
                {
                    MessageBox.Show(@"Kayıt Bulunamadı", @"Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show(@"Lütfen T.C Alanını Doldurun", @"Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtNationalNumber.Text = "";
        }

        private void UcStudentDebt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            if (dgwStudentDebt.CurrentRow != null && !String.IsNullOrEmpty(txtStudentId.Text))
            {
                string studentNationalNumber = dgwStudentDebt.CurrentRow.Cells[3].Value.ToString();
                string registrationDate = dgwStudentDebt.CurrentRow.Cells[10].Value.ToString();
                string studentDebt = dgwStudentDebt.CurrentRow.Cells[12].Value.ToString();
                string ibanNumber = dgwStudentDebt.CurrentRow.Cells[15].Value.ToString();
                string studentWantLicenceType = dgwStudentDebt.CurrentRow.Cells[17].Value.ToString();
                ExportByPdf.CreatDebtPdf(txtStudentId.Text, txtStudentNameSurname.Text, studentNationalNumber,
                    registrationDate, studentDebt, txtRemainingDebt.Text, txtRemainingInstallment.Text, ibanNumber,
                    studentWantLicenceType);

            }
            else
            {
                MessageBox.Show(@"Öğrenci Seçimi Yapınız.", @"Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ExportWithPrinter.PrintPdf();
        }

        private void txtNationalNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dgwStudentDebt.Rows.Count>0)
            {
                if (!String.IsNullOrWhiteSpace(txtPaidAmount.Text) && Convert.ToDecimal(txtPaidAmount.Text) > 0)
                {
                    _pay = Convert.ToDecimal(txtPaidAmount.Text);


                    if (_remainingDebt <= 0)
                    {
                        MessageBox.Show(@"Öğrencinin Borcu Bulunmamaktadır.", @"Uyarı", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                       
                        _mustPaid = 0;

                    }

                    if (_mustPaid == _pay)
                    {
                        _remainingDebt = _remainingDebt - _pay;
                        _remainingInstallment--;

                    }
                    else if (_mustPaid < _pay)
                    {
                        _remainingDebt = _remainingDebt - _pay;
                        _remainingInstallment -= 2;
                    }
                    else if (_mustPaid * 2 <= _pay)
                    {
                        _remainingDebt = _remainingDebt - _pay;
                        _remainingInstallment -= 3;
                    }

                    StudentService.Update(new Student
                    {
                        StudentId = Convert.ToInt32(txtStudentId.Text),
                        StudentName = FillTextBox(1),
                        StudentSurname = FillTextBox(2),
                        StudentNationalNumber = FillTextBox(3),
                        StudentGender = FillTextBox(4),
                        StudentEmail = FillTextBox(5),
                        StudentBirthdate = Convert.ToDateTime(FillTextBox(6)),
                        StudentPlaceofBirth = Convert.ToInt32(FillTextBox(7)),
                        StudentPhoneNumber = FillTextBox(8),
                        StudentAdress = FillTextBox(9),
                        RegistrationDate = Convert.ToDateTime(FillTextBox(10)),
                        RegistrationSeason = Convert.ToInt32(FillTextBox(11)),
                        StudentTotalDebt = _remainingDebt,
                        QuantityInstallment = _remainingInstallment,
                        StudentIbanNumber = FillTextBox(15),
                        StudentWantLicenceType = FillTextBox(17),
                        StudentHaveLicenceType = FillTextBox(16),
                        StudentDebt = Convert.ToDecimal(FillTextBox(13))

                    });

                }
                else
                {
                    MessageBox.Show(@"Tutar Boş veya 0 dan Küçük Olamaz", @"Uyarı", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtPaidAmount.Text = "";
                }
            }
        }
    }
}
