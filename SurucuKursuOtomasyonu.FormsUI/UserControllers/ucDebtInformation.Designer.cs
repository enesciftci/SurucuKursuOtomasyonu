namespace SurucuKursuOtomasyonu.FormsUI.UserControllers
{
    partial class ucDebtInformation
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDebtInformation));
            this.dgwStudentSearch = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentTotalDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInstallment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentIbanNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxAuto = new System.Windows.Forms.CheckBox();
            this.btnSendInformation = new Bunifu.Framework.UI.BunifuImageButton();
            this.cmbInfoWithEmail = new System.Windows.Forms.CheckBox();
            this.cmbInfoWithSMS = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSendInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwStudentSearch
            // 
            this.dgwStudentSearch.AllowUserToAddRows = false;
            this.dgwStudentSearch.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaShell;
            this.dgwStudentSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwStudentSearch.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgwStudentSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwStudentSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwStudentSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwStudentSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudentSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.StudentSurname,
            this.StudentEmail,
            this.StudentPhoneNumber,
            this.RegistrationDate,
            this.StudentDebt,
            this.StudentTotalDebt,
            this.QuantityInstallment,
            this.StudentIbanNumber});
            this.dgwStudentSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwStudentSearch.DoubleBuffered = true;
            this.dgwStudentSearch.EnableHeadersVisualStyles = false;
            this.dgwStudentSearch.HeaderBgColor = System.Drawing.Color.SeaShell;
            this.dgwStudentSearch.HeaderForeColor = System.Drawing.Color.SlateBlue;
            this.dgwStudentSearch.Location = new System.Drawing.Point(0, 0);
            this.dgwStudentSearch.Name = "dgwStudentSearch";
            this.dgwStudentSearch.ReadOnly = true;
            this.dgwStudentSearch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwStudentSearch.RowHeadersVisible = false;
            this.dgwStudentSearch.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dgwStudentSearch.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
            this.dgwStudentSearch.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgwStudentSearch.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgwStudentSearch.RowTemplate.Height = 24;
            this.dgwStudentSearch.Size = new System.Drawing.Size(879, 332);
            this.dgwStudentSearch.TabIndex = 166;
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.FillWeight = 93.67348F;
            this.StudentID.HeaderText = "Numara";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.FillWeight = 94.72271F;
            this.StudentName.HeaderText = "Ad";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // StudentSurname
            // 
            this.StudentSurname.DataPropertyName = "StudentSurname";
            this.StudentSurname.FillWeight = 95.71414F;
            this.StudentSurname.HeaderText = "Soyad";
            this.StudentSurname.Name = "StudentSurname";
            this.StudentSurname.ReadOnly = true;
            // 
            // StudentEmail
            // 
            this.StudentEmail.DataPropertyName = "StudentEmail";
            this.StudentEmail.FillWeight = 98.47205F;
            this.StudentEmail.HeaderText = "Email";
            this.StudentEmail.Name = "StudentEmail";
            this.StudentEmail.ReadOnly = true;
            // 
            // StudentPhoneNumber
            // 
            this.StudentPhoneNumber.DataPropertyName = "StudentPhoneNumber";
            this.StudentPhoneNumber.FillWeight = 100.6992F;
            this.StudentPhoneNumber.HeaderText = "Telefon Numarası";
            this.StudentPhoneNumber.Name = "StudentPhoneNumber";
            this.StudentPhoneNumber.ReadOnly = true;
            // 
            // RegistrationDate
            // 
            this.RegistrationDate.DataPropertyName = "RegistrationDate";
            this.RegistrationDate.FillWeight = 101.9869F;
            this.RegistrationDate.HeaderText = "Kayıt Tarihi";
            this.RegistrationDate.Name = "RegistrationDate";
            this.RegistrationDate.ReadOnly = true;
            // 
            // StudentDebt
            // 
            this.StudentDebt.DataPropertyName = "StudentDebt";
            this.StudentDebt.FillWeight = 101.2267F;
            this.StudentDebt.HeaderText = "Borç Tutarı";
            this.StudentDebt.Name = "StudentDebt";
            this.StudentDebt.ReadOnly = true;
            // 
            // StudentTotalDebt
            // 
            this.StudentTotalDebt.DataPropertyName = "StudentTotalDebt";
            this.StudentTotalDebt.HeaderText = "Kalan Borç";
            this.StudentTotalDebt.Name = "StudentTotalDebt";
            this.StudentTotalDebt.ReadOnly = true;
            // 
            // QuantityInstallment
            // 
            this.QuantityInstallment.DataPropertyName = "QuantityInstallment";
            this.QuantityInstallment.FillWeight = 103.7697F;
            this.QuantityInstallment.HeaderText = "Taksit Sayısı";
            this.QuantityInstallment.Name = "QuantityInstallment";
            this.QuantityInstallment.ReadOnly = true;
            // 
            // StudentIbanNumber
            // 
            this.StudentIbanNumber.DataPropertyName = "StudentIbanNumber";
            this.StudentIbanNumber.FillWeight = 104.2626F;
            this.StudentIbanNumber.HeaderText = "Iban Numarası";
            this.StudentIbanNumber.Name = "StudentIbanNumber";
            this.StudentIbanNumber.ReadOnly = true;
            // 
            // cbxAuto
            // 
            this.cbxAuto.AutoSize = true;
            this.cbxAuto.Location = new System.Drawing.Point(23, 347);
            this.cbxAuto.Name = "cbxAuto";
            this.cbxAuto.Size = new System.Drawing.Size(170, 21);
            this.cbxAuto.TabIndex = 167;
            this.cbxAuto.Text = "Otomatik Bilgilendirme";
            this.cbxAuto.UseVisualStyleBackColor = true;
            // 
            // btnSendInformation
            // 
            this.btnSendInformation.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSendInformation.Image = ((System.Drawing.Image)(resources.GetObject("btnSendInformation.Image")));
            this.btnSendInformation.ImageActive = null;
            this.btnSendInformation.Location = new System.Drawing.Point(187, 403);
            this.btnSendInformation.Name = "btnSendInformation";
            this.btnSendInformation.Size = new System.Drawing.Size(71, 71);
            this.btnSendInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSendInformation.TabIndex = 168;
            this.btnSendInformation.TabStop = false;
            this.btnSendInformation.Zoom = 10;
            // 
            // cmbInfoWithEmail
            // 
            this.cmbInfoWithEmail.AutoSize = true;
            this.cmbInfoWithEmail.Location = new System.Drawing.Point(23, 374);
            this.cmbInfoWithEmail.Name = "cmbInfoWithEmail";
            this.cmbInfoWithEmail.Size = new System.Drawing.Size(152, 21);
            this.cmbInfoWithEmail.TabIndex = 169;
            this.cmbInfoWithEmail.Text = "E-Mail ile Bilgilendir";
            this.cmbInfoWithEmail.UseVisualStyleBackColor = true;
            // 
            // cmbInfoWithSMS
            // 
            this.cmbInfoWithSMS.AutoSize = true;
            this.cmbInfoWithSMS.Location = new System.Drawing.Point(195, 374);
            this.cmbInfoWithSMS.Name = "cmbInfoWithSMS";
            this.cmbInfoWithSMS.Size = new System.Drawing.Size(142, 21);
            this.cmbInfoWithSMS.TabIndex = 170;
            this.cmbInfoWithSMS.Text = "SMS ile Bilgilendir";
            this.cmbInfoWithSMS.UseVisualStyleBackColor = true;
            // 
            // ucDebtInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbInfoWithSMS);
            this.Controls.Add(this.cmbInfoWithEmail);
            this.Controls.Add(this.btnSendInformation);
            this.Controls.Add(this.cbxAuto);
            this.Controls.Add(this.dgwStudentSearch);
            this.Name = "ucDebtInformation";
            this.Size = new System.Drawing.Size(879, 576);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSendInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgwStudentSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentTotalDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInstallment;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIbanNumber;
        private System.Windows.Forms.CheckBox cbxAuto;
        private Bunifu.Framework.UI.BunifuImageButton btnSendInformation;
        private System.Windows.Forms.CheckBox cmbInfoWithEmail;
        private System.Windows.Forms.CheckBox cmbInfoWithSMS;
    }
}
