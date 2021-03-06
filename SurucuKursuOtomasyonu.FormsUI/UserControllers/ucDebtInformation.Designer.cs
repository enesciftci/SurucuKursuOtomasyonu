﻿namespace SurucuKursuOtomasyonu.FormsUI.UserControllers
{
    partial class UcDebtInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcDebtInformation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSendInformation = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgwDebtInformation = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNationalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentTotalDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInstallment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentIbanNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentWantLicenceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prgDebtInformation = new System.Windows.Forms.ProgressBar();
            this.cbxAuto = new System.Windows.Forms.CheckBox();
            this.cbxInfoWithEmail = new System.Windows.Forms.CheckBox();
            this.cmbInfoWithSMS = new System.Windows.Forms.CheckBox();
            this.lblStudentState = new System.Windows.Forms.Label();
            this.lbxDebtorStudents = new System.Windows.Forms.ListBox();
            this.gbpInformationSettings = new System.Windows.Forms.GroupBox();
            this.lblSuccessfulRecord = new System.Windows.Forms.Label();
            this.lblTotalDebt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSendInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDebtInformation)).BeginInit();
            this.gbpInformationSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendInformation
            // 
            this.btnSendInformation.BackColor = System.Drawing.Color.Transparent;
            this.btnSendInformation.ErrorImage = null;
            this.btnSendInformation.Image = ((System.Drawing.Image)(resources.GetObject("btnSendInformation.Image")));
            this.btnSendInformation.ImageActive = null;
            this.btnSendInformation.InitialImage = null;
            this.btnSendInformation.Location = new System.Drawing.Point(462, 9);
            this.btnSendInformation.Name = "btnSendInformation";
            this.btnSendInformation.Size = new System.Drawing.Size(123, 114);
            this.btnSendInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSendInformation.TabIndex = 171;
            this.btnSendInformation.TabStop = false;
            this.btnSendInformation.Zoom = 10;
            this.btnSendInformation.Click += new System.EventHandler(this.btnSendInformation_Click);
            // 
            // dgwDebtInformation
            // 
            this.dgwDebtInformation.AllowUserToAddRows = false;
            this.dgwDebtInformation.AllowUserToDeleteRows = false;
            this.dgwDebtInformation.AllowUserToResizeColumns = false;
            this.dgwDebtInformation.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgwDebtInformation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgwDebtInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDebtInformation.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwDebtInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwDebtInformation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgwDebtInformation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwDebtInformation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgwDebtInformation.ColumnHeadersHeight = 55;
            this.dgwDebtInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwDebtInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.StudentSurname,
            this.StudentNationalNumber,
            this.RegistrationDate,
            this.StudentDebt,
            this.StudentTotalDebt,
            this.QuantityInstallment,
            this.StudentIbanNumber,
            this.StudentWantLicenceType,
            this.StudentEmail});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwDebtInformation.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgwDebtInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwDebtInformation.DoubleBuffered = true;
            this.dgwDebtInformation.EnableHeadersVisualStyles = false;
            this.dgwDebtInformation.GridColor = System.Drawing.Color.Gray;
            this.dgwDebtInformation.HeaderBgColor = System.Drawing.Color.SeaShell;
            this.dgwDebtInformation.HeaderForeColor = System.Drawing.Color.SlateBlue;
            this.dgwDebtInformation.Location = new System.Drawing.Point(0, 0);
            this.dgwDebtInformation.MultiSelect = false;
            this.dgwDebtInformation.Name = "dgwDebtInformation";
            this.dgwDebtInformation.ReadOnly = true;
            this.dgwDebtInformation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwDebtInformation.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgwDebtInformation.RowHeadersVisible = false;
            this.dgwDebtInformation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwDebtInformation.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgwDebtInformation.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.dgwDebtInformation.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgwDebtInformation.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgwDebtInformation.RowTemplate.Height = 24;
            this.dgwDebtInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDebtInformation.Size = new System.Drawing.Size(1521, 606);
            this.dgwDebtInformation.TabIndex = 172;
            this.dgwDebtInformation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDebtInformation_CellClick);
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
            // StudentNationalNumber
            // 
            this.StudentNationalNumber.DataPropertyName = "StudentNationalNumber";
            this.StudentNationalNumber.FillWeight = 96.65094F;
            this.StudentNationalNumber.HeaderText = "Kimlik Numarası";
            this.StudentNationalNumber.Name = "StudentNationalNumber";
            this.StudentNationalNumber.ReadOnly = true;
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
            // StudentWantLicenceType
            // 
            this.StudentWantLicenceType.DataPropertyName = "StudentWantLicenceType";
            this.StudentWantLicenceType.FillWeight = 105.1685F;
            this.StudentWantLicenceType.HeaderText = "İstenen Belge";
            this.StudentWantLicenceType.Name = "StudentWantLicenceType";
            this.StudentWantLicenceType.ReadOnly = true;
            // 
            // StudentEmail
            // 
            this.StudentEmail.DataPropertyName = "StudentEmail";
            this.StudentEmail.HeaderText = "Öğrenci Email";
            this.StudentEmail.Name = "StudentEmail";
            this.StudentEmail.ReadOnly = true;
            // 
            // prgDebtInformation
            // 
            this.prgDebtInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prgDebtInformation.Location = new System.Drawing.Point(0, 1031);
            this.prgDebtInformation.Name = "prgDebtInformation";
            this.prgDebtInformation.Size = new System.Drawing.Size(1521, 32);
            this.prgDebtInformation.TabIndex = 173;
            // 
            // cbxAuto
            // 
            this.cbxAuto.AutoSize = true;
            this.cbxAuto.Location = new System.Drawing.Point(207, 26);
            this.cbxAuto.Name = "cbxAuto";
            this.cbxAuto.Size = new System.Drawing.Size(151, 21);
            this.cbxAuto.TabIndex = 175;
            this.cbxAuto.Text = "Otomatik Bilgilendir";
            this.cbxAuto.UseVisualStyleBackColor = true;
            // 
            // cbxInfoWithEmail
            // 
            this.cbxInfoWithEmail.AutoSize = true;
            this.cbxInfoWithEmail.Location = new System.Drawing.Point(20, 26);
            this.cbxInfoWithEmail.Name = "cbxInfoWithEmail";
            this.cbxInfoWithEmail.Size = new System.Drawing.Size(152, 21);
            this.cbxInfoWithEmail.TabIndex = 176;
            this.cbxInfoWithEmail.Text = "E-Mail ile Bilgilendir";
            this.cbxInfoWithEmail.UseVisualStyleBackColor = true;
            // 
            // cmbInfoWithSMS
            // 
            this.cmbInfoWithSMS.AutoSize = true;
            this.cmbInfoWithSMS.Location = new System.Drawing.Point(20, 73);
            this.cmbInfoWithSMS.Name = "cmbInfoWithSMS";
            this.cmbInfoWithSMS.Size = new System.Drawing.Size(140, 21);
            this.cmbInfoWithSMS.TabIndex = 177;
            this.cmbInfoWithSMS.Text = "Sms ile Bilgilendir";
            this.cmbInfoWithSMS.UseVisualStyleBackColor = true;
            // 
            // lblStudentState
            // 
            this.lblStudentState.AutoSize = true;
            this.lblStudentState.Location = new System.Drawing.Point(9, 643);
            this.lblStudentState.Name = "lblStudentState";
            this.lblStudentState.Size = new System.Drawing.Size(0, 17);
            this.lblStudentState.TabIndex = 178;
            // 
            // lbxDebtorStudents
            // 
            this.lbxDebtorStudents.FormattingEnabled = true;
            this.lbxDebtorStudents.ItemHeight = 16;
            this.lbxDebtorStudents.Location = new System.Drawing.Point(12, 841);
            this.lbxDebtorStudents.Name = "lbxDebtorStudents";
            this.lbxDebtorStudents.Size = new System.Drawing.Size(451, 84);
            this.lbxDebtorStudents.TabIndex = 179;
            // 
            // gbpInformationSettings
            // 
            this.gbpInformationSettings.Controls.Add(this.cmbInfoWithSMS);
            this.gbpInformationSettings.Controls.Add(this.cbxInfoWithEmail);
            this.gbpInformationSettings.Controls.Add(this.cbxAuto);
            this.gbpInformationSettings.Controls.Add(this.btnSendInformation);
            this.gbpInformationSettings.Location = new System.Drawing.Point(12, 643);
            this.gbpInformationSettings.Name = "gbpInformationSettings";
            this.gbpInformationSettings.Size = new System.Drawing.Size(591, 152);
            this.gbpInformationSettings.TabIndex = 180;
            this.gbpInformationSettings.TabStop = false;
            this.gbpInformationSettings.Text = "Bilgilendirme Ayarları";
            // 
            // lblSuccessfulRecord
            // 
            this.lblSuccessfulRecord.AutoSize = true;
            this.lblSuccessfulRecord.Location = new System.Drawing.Point(548, 863);
            this.lblSuccessfulRecord.Name = "lblSuccessfulRecord";
            this.lblSuccessfulRecord.Size = new System.Drawing.Size(0, 17);
            this.lblSuccessfulRecord.TabIndex = 181;
            // 
            // lblTotalDebt
            // 
            this.lblTotalDebt.AutoSize = true;
            this.lblTotalDebt.Location = new System.Drawing.Point(548, 908);
            this.lblTotalDebt.Name = "lblTotalDebt";
            this.lblTotalDebt.Size = new System.Drawing.Size(0, 17);
            this.lblTotalDebt.TabIndex = 182;
            // 
            // UcDebtInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTotalDebt);
            this.Controls.Add(this.lblSuccessfulRecord);
            this.Controls.Add(this.gbpInformationSettings);
            this.Controls.Add(this.lbxDebtorStudents);
            this.Controls.Add(this.lblStudentState);
            this.Controls.Add(this.prgDebtInformation);
            this.Controls.Add(this.dgwDebtInformation);
            this.Name = "UcDebtInformation";
            this.Size = new System.Drawing.Size(1521, 1063);
            this.Load += new System.EventHandler(this.UcDebtInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSendInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDebtInformation)).EndInit();
            this.gbpInformationSettings.ResumeLayout(false);
            this.gbpInformationSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton btnSendInformation;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgwDebtInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNationalNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentTotalDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInstallment;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIbanNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentWantLicenceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentEmail;
        private System.Windows.Forms.ProgressBar prgDebtInformation;
        private System.Windows.Forms.CheckBox cbxAuto;
        private System.Windows.Forms.CheckBox cbxInfoWithEmail;
        private System.Windows.Forms.CheckBox cmbInfoWithSMS;
        private System.Windows.Forms.Label lblStudentState;
        private System.Windows.Forms.ListBox lbxDebtorStudents;
        private System.Windows.Forms.GroupBox gbpInformationSettings;
        private System.Windows.Forms.Label lblSuccessfulRecord;
        private System.Windows.Forms.Label lblTotalDebt;
    }
}
