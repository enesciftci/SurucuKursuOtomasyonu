namespace SurucuKursuOtomasyonu.FormsUI.UserControllers
{
    partial class UcStudentSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcStudentSearch));
            this.gbpStudentSearch = new System.Windows.Forms.GroupBox();
            this.dgwStudentSearch = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNationalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentBirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentPlaceofBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationSeason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentTotalDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInstallment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentIbanNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentHaveLicenceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentWantLicenceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExportPdf = new System.Windows.Forms.Label();
            this.btnSingularPdf = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPluralPdf = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtNationalNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtStudentName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblRegistrationSeason = new System.Windows.Forms.Label();
            this.lblNationalNumber = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.cmbRegistrationSeason = new System.Windows.Forms.ComboBox();
            this.gbpStudentSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentSearch)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSingularPdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPluralPdf)).BeginInit();
            this.SuspendLayout();
            // 
            // gbpStudentSearch
            // 
            this.gbpStudentSearch.Controls.Add(this.dgwStudentSearch);
            this.gbpStudentSearch.Controls.Add(this.panel1);
            this.gbpStudentSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbpStudentSearch.Location = new System.Drawing.Point(0, 0);
            this.gbpStudentSearch.Name = "gbpStudentSearch";
            this.gbpStudentSearch.Size = new System.Drawing.Size(1746, 955);
            this.gbpStudentSearch.TabIndex = 0;
            this.gbpStudentSearch.TabStop = false;
            this.gbpStudentSearch.Text = "Öğrenci Arama";
            this.gbpStudentSearch.Enter += new System.EventHandler(this.gbpStudentSearch_Enter);
            // 
            // dgwStudentSearch
            // 
            this.dgwStudentSearch.AllowUserToAddRows = false;
            this.dgwStudentSearch.AllowUserToDeleteRows = false;
            this.dgwStudentSearch.AllowUserToResizeColumns = false;
            this.dgwStudentSearch.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaShell;
            this.dgwStudentSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwStudentSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwStudentSearch.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwStudentSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwStudentSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
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
            this.StudentNationalNumber,
            this.StudentGender,
            this.StudentEmail,
            this.StudentBirthdate,
            this.StudentPlaceofBirth,
            this.StudentPhoneNumber,
            this.StudentAdress,
            this.RegistrationDate,
            this.RegistrationSeason,
            this.StudentDebt,
            this.StudentTotalDebt,
            this.QuantityInstallment,
            this.StudentIbanNumber,
            this.StudentHaveLicenceType,
            this.StudentWantLicenceType});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwStudentSearch.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgwStudentSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwStudentSearch.DoubleBuffered = true;
            this.dgwStudentSearch.EnableHeadersVisualStyles = false;
            this.dgwStudentSearch.GridColor = System.Drawing.Color.Gray;
            this.dgwStudentSearch.HeaderBgColor = System.Drawing.Color.SeaShell;
            this.dgwStudentSearch.HeaderForeColor = System.Drawing.Color.SlateBlue;
            this.dgwStudentSearch.Location = new System.Drawing.Point(3, 182);
            this.dgwStudentSearch.Name = "dgwStudentSearch";
            this.dgwStudentSearch.ReadOnly = true;
            this.dgwStudentSearch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwStudentSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwStudentSearch.RowHeadersVisible = false;
            this.dgwStudentSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwStudentSearch.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dgwStudentSearch.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
            this.dgwStudentSearch.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgwStudentSearch.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgwStudentSearch.RowTemplate.Height = 24;
            this.dgwStudentSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwStudentSearch.Size = new System.Drawing.Size(1740, 770);
            this.dgwStudentSearch.TabIndex = 165;
            this.dgwStudentSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStudentSearch_CellClick);
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
            // StudentGender
            // 
            this.StudentGender.DataPropertyName = "StudentGender";
            this.StudentGender.FillWeight = 95.7299F;
            this.StudentGender.HeaderText = "Cinsiyet";
            this.StudentGender.Name = "StudentGender";
            this.StudentGender.ReadOnly = true;
            // 
            // StudentEmail
            // 
            this.StudentEmail.DataPropertyName = "StudentEmail";
            this.StudentEmail.FillWeight = 98.47205F;
            this.StudentEmail.HeaderText = "Email";
            this.StudentEmail.Name = "StudentEmail";
            this.StudentEmail.ReadOnly = true;
            // 
            // StudentBirthdate
            // 
            this.StudentBirthdate.DataPropertyName = "StudentBirthdate";
            this.StudentBirthdate.FillWeight = 99.2569F;
            this.StudentBirthdate.HeaderText = "Doğum Günü";
            this.StudentBirthdate.Name = "StudentBirthdate";
            this.StudentBirthdate.ReadOnly = true;
            // 
            // StudentPlaceofBirth
            // 
            this.StudentPlaceofBirth.DataPropertyName = "StudentPlaceofBirth";
            this.StudentPlaceofBirth.FillWeight = 99.99845F;
            this.StudentPlaceofBirth.HeaderText = "Doğum Yeri";
            this.StudentPlaceofBirth.Name = "StudentPlaceofBirth";
            this.StudentPlaceofBirth.ReadOnly = true;
            // 
            // StudentPhoneNumber
            // 
            this.StudentPhoneNumber.DataPropertyName = "StudentPhoneNumber";
            this.StudentPhoneNumber.FillWeight = 100.6992F;
            this.StudentPhoneNumber.HeaderText = "Telefon Numarası";
            this.StudentPhoneNumber.Name = "StudentPhoneNumber";
            this.StudentPhoneNumber.ReadOnly = true;
            // 
            // StudentAdress
            // 
            this.StudentAdress.DataPropertyName = "StudentAdress";
            this.StudentAdress.FillWeight = 101.3613F;
            this.StudentAdress.HeaderText = "Adres";
            this.StudentAdress.Name = "StudentAdress";
            this.StudentAdress.ReadOnly = true;
            // 
            // RegistrationDate
            // 
            this.RegistrationDate.DataPropertyName = "RegistrationDate";
            this.RegistrationDate.FillWeight = 101.9869F;
            this.RegistrationDate.HeaderText = "Kayıt Tarihi";
            this.RegistrationDate.Name = "RegistrationDate";
            this.RegistrationDate.ReadOnly = true;
            // 
            // RegistrationSeason
            // 
            this.RegistrationSeason.DataPropertyName = "RegistrationSeason";
            this.RegistrationSeason.FillWeight = 102.5781F;
            this.RegistrationSeason.HeaderText = "Kayıt Sezonu";
            this.RegistrationSeason.Name = "RegistrationSeason";
            this.RegistrationSeason.ReadOnly = true;
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
            // StudentHaveLicenceType
            // 
            this.StudentHaveLicenceType.DataPropertyName = "StudentHaveLicenceType";
            this.StudentHaveLicenceType.FillWeight = 104.7284F;
            this.StudentHaveLicenceType.HeaderText = "Sahip Olunan Ehliyet Tipi";
            this.StudentHaveLicenceType.Name = "StudentHaveLicenceType";
            this.StudentHaveLicenceType.ReadOnly = true;
            // 
            // StudentWantLicenceType
            // 
            this.StudentWantLicenceType.DataPropertyName = "StudentWantLicenceType";
            this.StudentWantLicenceType.FillWeight = 105.1685F;
            this.StudentWantLicenceType.HeaderText = "İstenen Belge";
            this.StudentWantLicenceType.Name = "StudentWantLicenceType";
            this.StudentWantLicenceType.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblExportPdf);
            this.panel1.Controls.Add(this.btnSingularPdf);
            this.panel1.Controls.Add(this.btnPluralPdf);
            this.panel1.Controls.Add(this.txtNationalNumber);
            this.panel1.Controls.Add(this.txtStudentName);
            this.panel1.Controls.Add(this.lblRegistrationSeason);
            this.panel1.Controls.Add(this.lblNationalNumber);
            this.panel1.Controls.Add(this.lblStudentName);
            this.panel1.Controls.Add(this.cmbRegistrationSeason);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1740, 148);
            this.panel1.TabIndex = 0;
            // 
            // lblExportPdf
            // 
            this.lblExportPdf.AutoSize = true;
            this.lblExportPdf.BackColor = System.Drawing.SystemColors.Control;
            this.lblExportPdf.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExportPdf.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblExportPdf.Location = new System.Drawing.Point(1235, 11);
            this.lblExportPdf.Name = "lblExportPdf";
            this.lblExportPdf.Size = new System.Drawing.Size(154, 23);
            this.lblExportPdf.TabIndex = 171;
            this.lblExportPdf.Text = "Kayıtları Dışa Aktar";
            // 
            // btnSingularPdf
            // 
            this.btnSingularPdf.BackColor = System.Drawing.Color.Transparent;
            this.btnSingularPdf.ErrorImage = null;
            this.btnSingularPdf.Image = ((System.Drawing.Image)(resources.GetObject("btnSingularPdf.Image")));
            this.btnSingularPdf.ImageActive = null;
            this.btnSingularPdf.InitialImage = null;
            this.btnSingularPdf.Location = new System.Drawing.Point(1359, 50);
            this.btnSingularPdf.Name = "btnSingularPdf";
            this.btnSingularPdf.Size = new System.Drawing.Size(87, 78);
            this.btnSingularPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSingularPdf.TabIndex = 170;
            this.btnSingularPdf.TabStop = false;
            this.btnSingularPdf.Zoom = 10;
            this.btnSingularPdf.Click += new System.EventHandler(this.btnSingularPdf_Click);
            // 
            // btnPluralPdf
            // 
            this.btnPluralPdf.BackColor = System.Drawing.Color.Transparent;
            this.btnPluralPdf.ErrorImage = null;
            this.btnPluralPdf.Image = ((System.Drawing.Image)(resources.GetObject("btnPluralPdf.Image")));
            this.btnPluralPdf.ImageActive = null;
            this.btnPluralPdf.InitialImage = null;
            this.btnPluralPdf.Location = new System.Drawing.Point(1239, 50);
            this.btnPluralPdf.Name = "btnPluralPdf";
            this.btnPluralPdf.Size = new System.Drawing.Size(87, 78);
            this.btnPluralPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPluralPdf.TabIndex = 169;
            this.btnPluralPdf.TabStop = false;
            this.btnPluralPdf.Zoom = 10;
            this.btnPluralPdf.Click += new System.EventHandler(this.btnPluralPdf_Click);
            // 
            // txtNationalNumber
            // 
            this.txtNationalNumber.BorderColorFocused = System.Drawing.Color.MediumSlateBlue;
            this.txtNationalNumber.BorderColorIdle = System.Drawing.Color.Black;
            this.txtNationalNumber.BorderColorMouseHover = System.Drawing.Color.MediumSlateBlue;
            this.txtNationalNumber.BorderThickness = 2;
            this.txtNationalNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNationalNumber.ForeColor = System.Drawing.Color.Black;
            this.txtNationalNumber.isPassword = false;
            this.txtNationalNumber.Location = new System.Drawing.Point(872, 86);
            this.txtNationalNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtNationalNumber.Name = "txtNationalNumber";
            this.txtNationalNumber.Size = new System.Drawing.Size(248, 43);
            this.txtNationalNumber.TabIndex = 152;
            this.txtNationalNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNationalNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationalNumber_KeyPress);
            // 
            // txtStudentName
            // 
            this.txtStudentName.BorderColorFocused = System.Drawing.Color.MediumSlateBlue;
            this.txtStudentName.BorderColorIdle = System.Drawing.Color.Black;
            this.txtStudentName.BorderColorMouseHover = System.Drawing.Color.MediumSlateBlue;
            this.txtStudentName.BorderThickness = 2;
            this.txtStudentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStudentName.ForeColor = System.Drawing.Color.Black;
            this.txtStudentName.isPassword = false;
            this.txtStudentName.Location = new System.Drawing.Point(347, 86);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(248, 43);
            this.txtStudentName.TabIndex = 151;
            this.txtStudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStudentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentName_KeyPress);
            // 
            // lblRegistrationSeason
            // 
            this.lblRegistrationSeason.AutoSize = true;
            this.lblRegistrationSeason.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegistrationSeason.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblRegistrationSeason.Location = new System.Drawing.Point(21, 50);
            this.lblRegistrationSeason.Name = "lblRegistrationSeason";
            this.lblRegistrationSeason.Size = new System.Drawing.Size(119, 23);
            this.lblRegistrationSeason.TabIndex = 150;
            this.lblRegistrationSeason.Text = "Eğitim Sezonu";
            // 
            // lblNationalNumber
            // 
            this.lblNationalNumber.AutoSize = true;
            this.lblNationalNumber.BackColor = System.Drawing.SystemColors.Control;
            this.lblNationalNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNationalNumber.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblNationalNumber.Location = new System.Drawing.Point(868, 50);
            this.lblNationalNumber.Name = "lblNationalNumber";
            this.lblNationalNumber.Size = new System.Drawing.Size(161, 23);
            this.lblNationalNumber.TabIndex = 149;
            this.lblNationalNumber.Text = "T.C Kimlik Numarası";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.SystemColors.Control;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentName.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblStudentName.Location = new System.Drawing.Point(343, 50);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(41, 23);
            this.lblStudentName.TabIndex = 148;
            this.lblStudentName.Text = "İsim";
            // 
            // cmbRegistrationSeason
            // 
            this.cmbRegistrationSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegistrationSeason.ForeColor = System.Drawing.Color.Black;
            this.cmbRegistrationSeason.FormattingEnabled = true;
            this.cmbRegistrationSeason.Location = new System.Drawing.Point(25, 104);
            this.cmbRegistrationSeason.Name = "cmbRegistrationSeason";
            this.cmbRegistrationSeason.Size = new System.Drawing.Size(151, 24);
            this.cmbRegistrationSeason.TabIndex = 2;
            this.cmbRegistrationSeason.SelectedIndexChanged += new System.EventHandler(this.cmbRegistrationSeason_SelectedIndexChanged);
            this.cmbRegistrationSeason.Enter += new System.EventHandler(this.cmbRegistrationSeason_Enter);
            // 
            // UcStudentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbpStudentSearch);
            this.Name = "UcStudentSearch";
            this.Size = new System.Drawing.Size(1746, 955);
            this.Load += new System.EventHandler(this.ucStudentSearch_Load);
            this.gbpStudentSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSingularPdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPluralPdf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbpStudentSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbRegistrationSeason;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgwStudentSearch;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblNationalNumber;
        private System.Windows.Forms.Label lblRegistrationSeason;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStudentName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNationalNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNationalNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentBirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentPlaceofBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationSeason;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentTotalDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInstallment;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIbanNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentHaveLicenceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentWantLicenceType;
        private Bunifu.Framework.UI.BunifuImageButton btnPluralPdf;
        private Bunifu.Framework.UI.BunifuImageButton btnSingularPdf;
        private System.Windows.Forms.Label lblExportPdf;
    }
}
