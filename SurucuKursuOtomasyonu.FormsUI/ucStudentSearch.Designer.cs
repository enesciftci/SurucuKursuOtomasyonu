namespace SurucuKursuOtomasyonu.FormsUI
{
    partial class ucStudentSearch
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
            this.gbpStudentSearch = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbRegistrationSeason = new System.Windows.Forms.ComboBox();
            this.maskedtxtStudentNationalNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistrationSeason = new System.Windows.Forms.Label();
            this.dgwStudentSearch = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNationalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentBirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationSeason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInstallment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentPlaceofBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentIbanNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentHaveLicence = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.StudentHaveLicenceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentWantLicenceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gbpStudentSearch)).BeginInit();
            this.gbpStudentSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // gbpStudentSearch
            // 
            this.gbpStudentSearch.Controls.Add(this.dgwStudentSearch);
            this.gbpStudentSearch.Controls.Add(this.panel1);
            this.gbpStudentSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbpStudentSearch.Location = new System.Drawing.Point(0, 0);
            this.gbpStudentSearch.Name = "gbpStudentSearch";
            this.gbpStudentSearch.Size = new System.Drawing.Size(1532, 538);
            this.gbpStudentSearch.TabIndex = 11;
            this.gbpStudentSearch.Text = "Öğrenci Sorgulama";
            this.gbpStudentSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.gbpStudentSearch_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbRegistrationSeason);
            this.panel1.Controls.Add(this.maskedtxtStudentNationalNumber);
            this.panel1.Controls.Add(this.txtStudentName);
            this.panel1.Controls.Add(this.lblStudentName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblRegistrationSeason);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1528, 47);
            this.panel1.TabIndex = 18;
            // 
            // cmbRegistrationSeason
            // 
            this.cmbRegistrationSeason.FormattingEnabled = true;
            this.cmbRegistrationSeason.ItemHeight = 16;
            this.cmbRegistrationSeason.Location = new System.Drawing.Point(132, 10);
            this.cmbRegistrationSeason.Name = "cmbRegistrationSeason";
            this.cmbRegistrationSeason.Size = new System.Drawing.Size(121, 24);
            this.cmbRegistrationSeason.TabIndex = 23;
            // 
            // maskedtxtStudentNationalNumber
            // 
            this.maskedtxtStudentNationalNumber.Location = new System.Drawing.Point(456, 10);
            this.maskedtxtStudentNationalNumber.Mask = "00000000000";
            this.maskedtxtStudentNationalNumber.Name = "maskedtxtStudentNationalNumber";
            this.maskedtxtStudentNationalNumber.Size = new System.Drawing.Size(156, 23);
            this.maskedtxtStudentNationalNumber.TabIndex = 22;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(782, 10);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(156, 23);
            this.txtStudentName.TabIndex = 21;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(679, 13);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(77, 17);
            this.lblStudentName.TabIndex = 20;
            this.lblStudentName.Text = "Öğrenci Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "T.C Kimlik Numarası";
            // 
            // lblRegistrationSeason
            // 
            this.lblRegistrationSeason.AutoSize = true;
            this.lblRegistrationSeason.Location = new System.Drawing.Point(3, 17);
            this.lblRegistrationSeason.Name = "lblRegistrationSeason";
            this.lblRegistrationSeason.Size = new System.Drawing.Size(94, 17);
            this.lblRegistrationSeason.TabIndex = 18;
            this.lblRegistrationSeason.Text = "Eğitim Sezonu";
            // 
            // dgwStudentSearch
            // 
            this.dgwStudentSearch.AllowUserToAddRows = false;
            this.dgwStudentSearch.AllowUserToDeleteRows = false;
            this.dgwStudentSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgwStudentSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudentSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.StudentSurname,
            this.StudentNationalNumber,
            this.StudentEmail,
            this.StudentBirthdate,
            this.RegistrationTime,
            this.RegistrationSeason,
            this.StudentDebt,
            this.QuantityInstallment,
            this.StudentPlaceofBirth,
            this.StudentPhoneNumber,
            this.StudentAdress,
            this.StudentIbanNumber,
            this.StudentHaveLicence,
            this.StudentHaveLicenceType,
            this.StudentWantLicenceType});
            this.dgwStudentSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwStudentSearch.Location = new System.Drawing.Point(2, 78);
            this.dgwStudentSearch.Name = "dgwStudentSearch";
            this.dgwStudentSearch.RowTemplate.Height = 24;
            this.dgwStudentSearch.Size = new System.Drawing.Size(1528, 458);
            this.dgwStudentSearch.TabIndex = 44;
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "Öğrenci Numarası";
            this.StudentID.Name = "StudentID";
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "Öğrenci Adı";
            this.StudentName.Name = "StudentName";
            // 
            // StudentSurname
            // 
            this.StudentSurname.DataPropertyName = "StudentSurname";
            this.StudentSurname.HeaderText = "Öğrenci Soyadı";
            this.StudentSurname.Name = "StudentSurname";
            // 
            // StudentNationalNumber
            // 
            this.StudentNationalNumber.DataPropertyName = "StudentNationalNumber";
            this.StudentNationalNumber.HeaderText = "Öğrenci Kimlik Numarası";
            this.StudentNationalNumber.Name = "StudentNationalNumber";
            // 
            // StudentEmail
            // 
            this.StudentEmail.DataPropertyName = "StudentEmail";
            this.StudentEmail.HeaderText = "Öğrenci Email";
            this.StudentEmail.Name = "StudentEmail";
            // 
            // StudentBirthdate
            // 
            this.StudentBirthdate.DataPropertyName = "StudentBirthdate";
            this.StudentBirthdate.HeaderText = "Öğrenci Doğum Tarihi";
            this.StudentBirthdate.Name = "StudentBirthdate";
            // 
            // RegistrationTime
            // 
            this.RegistrationTime.DataPropertyName = "RegistrationTime";
            this.RegistrationTime.HeaderText = "Öğrenci Kayıt Tarihi";
            this.RegistrationTime.Name = "RegistrationTime";
            // 
            // RegistrationSeason
            // 
            this.RegistrationSeason.DataPropertyName = "RegistrationSeason";
            this.RegistrationSeason.HeaderText = "Eğitim Sezonu";
            this.RegistrationSeason.Name = "RegistrationSeason";
            // 
            // StudentDebt
            // 
            this.StudentDebt.DataPropertyName = "StudentDebt";
            this.StudentDebt.HeaderText = "Borç Tutarı";
            this.StudentDebt.Name = "StudentDebt";
            // 
            // QuantityInstallment
            // 
            this.QuantityInstallment.DataPropertyName = "QuantityInstallment";
            this.QuantityInstallment.HeaderText = "Taksit Sayısı";
            this.QuantityInstallment.Name = "QuantityInstallment";
            // 
            // StudentPlaceofBirth
            // 
            this.StudentPlaceofBirth.DataPropertyName = "StudentPlaceofBirth";
            this.StudentPlaceofBirth.HeaderText = "Doğum Yeri";
            this.StudentPlaceofBirth.Name = "StudentPlaceofBirth";
            // 
            // StudentPhoneNumber
            // 
            this.StudentPhoneNumber.DataPropertyName = "StudentPhoneNumber";
            this.StudentPhoneNumber.HeaderText = "Telefon Numarası";
            this.StudentPhoneNumber.Name = "StudentPhoneNumber";
            // 
            // StudentAdress
            // 
            this.StudentAdress.DataPropertyName = "StudentAdress";
            this.StudentAdress.HeaderText = "Öğrenci Adresi";
            this.StudentAdress.Name = "StudentAdress";
            // 
            // StudentIbanNumber
            // 
            this.StudentIbanNumber.DataPropertyName = "StudentIbanNumber";
            this.StudentIbanNumber.HeaderText = "IBAN Numarası";
            this.StudentIbanNumber.Name = "StudentIbanNumber";
            // 
            // StudentHaveLicence
            // 
            this.StudentHaveLicence.DataPropertyName = "StudentHaveLicence";
            this.StudentHaveLicence.HeaderText = "Ehliyeti Var Mı";
            this.StudentHaveLicence.Name = "StudentHaveLicence";
            // 
            // StudentHaveLicenceType
            // 
            this.StudentHaveLicenceType.DataPropertyName = "StudentHaveLicenceType";
            this.StudentHaveLicenceType.HeaderText = "Sahip Olunan Ehliyet Tipi";
            this.StudentHaveLicenceType.Name = "StudentHaveLicenceType";
            // 
            // StudentWantLicenceType
            // 
            this.StudentWantLicenceType.DataPropertyName = "StudentWantLicenceType";
            this.StudentWantLicenceType.HeaderText = "İstenen Ehliyet Tipi";
            this.StudentWantLicenceType.Name = "StudentWantLicenceType";
            // 
            // ucStudentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbpStudentSearch);
            this.Name = "ucStudentSearch";
            this.Size = new System.Drawing.Size(1532, 538);
            this.Load += new System.EventHandler(this.ucStudentSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbpStudentSearch)).EndInit();
            this.gbpStudentSearch.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gbpStudentSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbRegistrationSeason;
        private System.Windows.Forms.MaskedTextBox maskedtxtStudentNationalNumber;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegistrationSeason;
        private System.Windows.Forms.DataGridView dgwStudentSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNationalNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentBirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationSeason;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInstallment;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentPlaceofBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIbanNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn StudentHaveLicence;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentHaveLicenceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentWantLicenceType;
    }
}
