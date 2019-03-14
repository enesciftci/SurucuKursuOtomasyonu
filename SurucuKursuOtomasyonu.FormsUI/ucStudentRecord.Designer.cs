namespace SurucuKursuOtomasyonu.FormsUI
{
    partial class ucStudentRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucStudentRecord));
            this.gbpStudentRecord = new System.Windows.Forms.GroupBox();
            this.btnClear = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRegister = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtIbanNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtRegistrationDebt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dpcRegistrationDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtPhoneNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNationalNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtStudentSurname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtStudentName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dpcBirthdate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtAdress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblHaveLicenceType = new System.Windows.Forms.Label();
            this.cmbHaveLicenceType = new System.Windows.Forms.ComboBox();
            this.checkHaveLicence = new System.Windows.Forms.CheckBox();
            this.cmbPlaceofBirth = new System.Windows.Forms.ComboBox();
            this.lblPlaceofBirth = new System.Windows.Forms.Label();
            this.cmbQuantityInstallment = new System.Windows.Forms.ComboBox();
            this.cmbLicenceType = new System.Windows.Forms.ComboBox();
            this.cmbRegistrationSeason = new System.Windows.Forms.ComboBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.richTxtAdress = new System.Windows.Forms.RichTextBox();
            this.lblIbanNumber = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblLicenceType = new System.Windows.Forms.Label();
            this.lblQuantityInstallment = new System.Windows.Forms.Label();
            this.lblRegistrationDebt = new System.Windows.Forms.Label();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNationalNumber = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.lblRegistrationSeason = new System.Windows.Forms.Label();
            this.gbpStudentRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // gbpStudentRecord
            // 
            this.gbpStudentRecord.Controls.Add(this.btnClear);
            this.gbpStudentRecord.Controls.Add(this.btnRegister);
            this.gbpStudentRecord.Controls.Add(this.txtIbanNumber);
            this.gbpStudentRecord.Controls.Add(this.txtRegistrationDebt);
            this.gbpStudentRecord.Controls.Add(this.dpcRegistrationDate);
            this.gbpStudentRecord.Controls.Add(this.txtPhoneNumber);
            this.gbpStudentRecord.Controls.Add(this.txtEmail);
            this.gbpStudentRecord.Controls.Add(this.txtNationalNumber);
            this.gbpStudentRecord.Controls.Add(this.txtStudentSurname);
            this.gbpStudentRecord.Controls.Add(this.txtStudentName);
            this.gbpStudentRecord.Controls.Add(this.dpcBirthdate);
            this.gbpStudentRecord.Controls.Add(this.txtAdress);
            this.gbpStudentRecord.Controls.Add(this.lblHaveLicenceType);
            this.gbpStudentRecord.Controls.Add(this.cmbHaveLicenceType);
            this.gbpStudentRecord.Controls.Add(this.checkHaveLicence);
            this.gbpStudentRecord.Controls.Add(this.cmbPlaceofBirth);
            this.gbpStudentRecord.Controls.Add(this.lblPlaceofBirth);
            this.gbpStudentRecord.Controls.Add(this.cmbQuantityInstallment);
            this.gbpStudentRecord.Controls.Add(this.cmbLicenceType);
            this.gbpStudentRecord.Controls.Add(this.cmbRegistrationSeason);
            this.gbpStudentRecord.Controls.Add(this.radioFemale);
            this.gbpStudentRecord.Controls.Add(this.radioMale);
            this.gbpStudentRecord.Controls.Add(this.lblGender);
            this.gbpStudentRecord.Controls.Add(this.richTxtAdress);
            this.gbpStudentRecord.Controls.Add(this.lblIbanNumber);
            this.gbpStudentRecord.Controls.Add(this.lblAdress);
            this.gbpStudentRecord.Controls.Add(this.lblPhoneNumber);
            this.gbpStudentRecord.Controls.Add(this.lblLicenceType);
            this.gbpStudentRecord.Controls.Add(this.lblQuantityInstallment);
            this.gbpStudentRecord.Controls.Add(this.lblRegistrationDebt);
            this.gbpStudentRecord.Controls.Add(this.lblRegistrationDate);
            this.gbpStudentRecord.Controls.Add(this.lblBirthdate);
            this.gbpStudentRecord.Controls.Add(this.lblEmail);
            this.gbpStudentRecord.Controls.Add(this.lblNationalNumber);
            this.gbpStudentRecord.Controls.Add(this.lblStudentName);
            this.gbpStudentRecord.Controls.Add(this.lblStudentSurname);
            this.gbpStudentRecord.Controls.Add(this.lblRegistrationSeason);
            this.gbpStudentRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbpStudentRecord.Location = new System.Drawing.Point(0, 0);
            this.gbpStudentRecord.Name = "gbpStudentRecord";
            this.gbpStudentRecord.Size = new System.Drawing.Size(1470, 940);
            this.gbpStudentRecord.TabIndex = 0;
            this.gbpStudentRecord.TabStop = false;
            this.gbpStudentRecord.Text = "Öğrenci Kayıt";
            this.gbpStudentRecord.Enter += new System.EventHandler(this.gbpStudentRecord_Enter);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageActive = null;
            this.btnClear.Location = new System.Drawing.Point(1034, 831);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 85);
            this.btnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClear.TabIndex = 125;
            this.btnClear.TabStop = false;
            this.btnClear.Zoom = 10;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.ErrorImage = null;
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.ImageActive = null;
            this.btnRegister.InitialImage = null;
            this.btnRegister.Location = new System.Drawing.Point(891, 831);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(87, 85);
            this.btnRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRegister.TabIndex = 124;
            this.btnRegister.TabStop = false;
            this.btnRegister.Zoom = 10;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtIbanNumber
            // 
            this.txtIbanNumber.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.txtIbanNumber.BorderColorIdle = System.Drawing.Color.Black;
            this.txtIbanNumber.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.txtIbanNumber.BorderThickness = 2;
            this.txtIbanNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIbanNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIbanNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIbanNumber.isPassword = false;
            this.txtIbanNumber.Location = new System.Drawing.Point(889, 703);
            this.txtIbanNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtIbanNumber.Name = "txtIbanNumber";
            this.txtIbanNumber.Size = new System.Drawing.Size(309, 43);
            this.txtIbanNumber.TabIndex = 15;
            this.txtIbanNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtRegistrationDebt
            // 
            this.txtRegistrationDebt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.txtRegistrationDebt.BorderColorIdle = System.Drawing.Color.Black;
            this.txtRegistrationDebt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.txtRegistrationDebt.BorderThickness = 2;
            this.txtRegistrationDebt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegistrationDebt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRegistrationDebt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRegistrationDebt.isPassword = false;
            this.txtRegistrationDebt.Location = new System.Drawing.Point(889, 491);
            this.txtRegistrationDebt.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegistrationDebt.Name = "txtRegistrationDebt";
            this.txtRegistrationDebt.Size = new System.Drawing.Size(309, 43);
            this.txtRegistrationDebt.TabIndex = 13;
            this.txtRegistrationDebt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dpcRegistrationDate
            // 
            this.dpcRegistrationDate.BackColor = System.Drawing.Color.SeaGreen;
            this.dpcRegistrationDate.BorderRadius = 0;
            this.dpcRegistrationDate.ForeColor = System.Drawing.Color.White;
            this.dpcRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpcRegistrationDate.FormatCustom = null;
            this.dpcRegistrationDate.Location = new System.Drawing.Point(889, 74);
            this.dpcRegistrationDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpcRegistrationDate.Name = "dpcRegistrationDate";
            this.dpcRegistrationDate.Size = new System.Drawing.Size(301, 33);
            this.dpcRegistrationDate.TabIndex = 9;
            this.dpcRegistrationDate.Value = new System.DateTime(2019, 3, 13, 22, 54, 58, 99);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.txtPhoneNumber.BorderColorIdle = System.Drawing.Color.Black;
            this.txtPhoneNumber.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.txtPhoneNumber.BorderThickness = 2;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhoneNumber.isPassword = false;
            this.txtPhoneNumber.Location = new System.Drawing.Point(889, 178);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(309, 43);
            this.txtPhoneNumber.TabIndex = 10;
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.txtEmail.BorderColorIdle = System.Drawing.Color.Black;
            this.txtEmail.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.txtEmail.BorderThickness = 2;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.isPassword = false;
            this.txtEmail.Location = new System.Drawing.Point(72, 604);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(309, 43);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNationalNumber
            // 
            this.txtNationalNumber.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.txtNationalNumber.BorderColorIdle = System.Drawing.Color.Black;
            this.txtNationalNumber.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.txtNationalNumber.BorderThickness = 2;
            this.txtNationalNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNationalNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNationalNumber.isPassword = false;
            this.txtNationalNumber.Location = new System.Drawing.Point(72, 283);
            this.txtNationalNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtNationalNumber.Name = "txtNationalNumber";
            this.txtNationalNumber.Size = new System.Drawing.Size(309, 43);
            this.txtNationalNumber.TabIndex = 2;
            this.txtNationalNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.txtStudentSurname.BorderColorIdle = System.Drawing.Color.Black;
            this.txtStudentSurname.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.txtStudentSurname.BorderThickness = 2;
            this.txtStudentSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentSurname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStudentSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStudentSurname.isPassword = false;
            this.txtStudentSurname.Location = new System.Drawing.Point(72, 182);
            this.txtStudentSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(309, 43);
            this.txtStudentSurname.TabIndex = 1;
            this.txtStudentSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtStudentName
            // 
            this.txtStudentName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.txtStudentName.BorderColorIdle = System.Drawing.Color.Black;
            this.txtStudentName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.txtStudentName.BorderThickness = 2;
            this.txtStudentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStudentName.isPassword = false;
            this.txtStudentName.Location = new System.Drawing.Point(72, 74);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(309, 43);
            this.txtStudentName.TabIndex = 0;
            this.txtStudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dpcBirthdate
            // 
            this.dpcBirthdate.BackColor = System.Drawing.Color.SeaGreen;
            this.dpcBirthdate.BorderRadius = 0;
            this.dpcBirthdate.ForeColor = System.Drawing.Color.White;
            this.dpcBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpcBirthdate.FormatCustom = null;
            this.dpcBirthdate.Location = new System.Drawing.Point(80, 703);
            this.dpcBirthdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpcBirthdate.Name = "dpcBirthdate";
            this.dpcBirthdate.Size = new System.Drawing.Size(301, 33);
            this.dpcBirthdate.TabIndex = 7;
            this.dpcBirthdate.Value = new System.DateTime(2019, 3, 13, 22, 54, 58, 99);
            // 
            // txtAdress
            // 
            this.txtAdress.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.txtAdress.BorderColorIdle = System.Drawing.Color.Black;
            this.txtAdress.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.txtAdress.BorderThickness = 2;
            this.txtAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdress.isPassword = false;
            this.txtAdress.Location = new System.Drawing.Point(72, 491);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(309, 43);
            this.txtAdress.TabIndex = 5;
            this.txtAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblHaveLicenceType
            // 
            this.lblHaveLicenceType.AutoSize = true;
            this.lblHaveLicenceType.BackColor = System.Drawing.Color.White;
            this.lblHaveLicenceType.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHaveLicenceType.ForeColor = System.Drawing.Color.Gray;
            this.lblHaveLicenceType.Location = new System.Drawing.Point(885, 805);
            this.lblHaveLicenceType.Name = "lblHaveLicenceType";
            this.lblHaveLicenceType.Size = new System.Drawing.Size(156, 23);
            this.lblHaveLicenceType.TabIndex = 123;
            this.lblHaveLicenceType.Text = "Mevcut Ehliyet Tipi";
            this.lblHaveLicenceType.Visible = false;
            // 
            // cmbHaveLicenceType
            // 
            this.cmbHaveLicenceType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHaveLicenceType.FormattingEnabled = true;
            this.cmbHaveLicenceType.ItemHeight = 20;
            this.cmbHaveLicenceType.Location = new System.Drawing.Point(889, 849);
            this.cmbHaveLicenceType.Name = "cmbHaveLicenceType";
            this.cmbHaveLicenceType.Size = new System.Drawing.Size(170, 28);
            this.cmbHaveLicenceType.TabIndex = 17;
            this.cmbHaveLicenceType.Visible = false;
            // 
            // checkHaveLicence
            // 
            this.checkHaveLicence.AutoSize = true;
            this.checkHaveLicence.BackColor = System.Drawing.Color.White;
            this.checkHaveLicence.ForeColor = System.Drawing.Color.Black;
            this.checkHaveLicence.Location = new System.Drawing.Point(889, 765);
            this.checkHaveLicence.Name = "checkHaveLicence";
            this.checkHaveLicence.Size = new System.Drawing.Size(141, 21);
            this.checkHaveLicence.TabIndex = 16;
            this.checkHaveLicence.Text = "Ehliyet Sahibi Mi?";
            this.checkHaveLicence.UseVisualStyleBackColor = false;
            this.checkHaveLicence.CheckedChanged += new System.EventHandler(this.checkHaveLicence_CheckedChanged);
            // 
            // cmbPlaceofBirth
            // 
            this.cmbPlaceofBirth.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlaceofBirth.FormattingEnabled = true;
            this.cmbPlaceofBirth.ItemHeight = 20;
            this.cmbPlaceofBirth.Location = new System.Drawing.Point(80, 805);
            this.cmbPlaceofBirth.Name = "cmbPlaceofBirth";
            this.cmbPlaceofBirth.Size = new System.Drawing.Size(216, 28);
            this.cmbPlaceofBirth.TabIndex = 8;
            this.cmbPlaceofBirth.Text = "Doğum Yeriniz Seçiniz";
            // 
            // lblPlaceofBirth
            // 
            this.lblPlaceofBirth.AutoSize = true;
            this.lblPlaceofBirth.BackColor = System.Drawing.Color.White;
            this.lblPlaceofBirth.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlaceofBirth.ForeColor = System.Drawing.Color.Gray;
            this.lblPlaceofBirth.Location = new System.Drawing.Point(76, 761);
            this.lblPlaceofBirth.Name = "lblPlaceofBirth";
            this.lblPlaceofBirth.Size = new System.Drawing.Size(99, 23);
            this.lblPlaceofBirth.TabIndex = 122;
            this.lblPlaceofBirth.Text = "Doğum Yeri";
            // 
            // cmbQuantityInstallment
            // 
            this.cmbQuantityInstallment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuantityInstallment.FormattingEnabled = true;
            this.cmbQuantityInstallment.ItemHeight = 20;
            this.cmbQuantityInstallment.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbQuantityInstallment.Location = new System.Drawing.Point(889, 604);
            this.cmbQuantityInstallment.Name = "cmbQuantityInstallment";
            this.cmbQuantityInstallment.Size = new System.Drawing.Size(216, 28);
            this.cmbQuantityInstallment.TabIndex = 14;
            this.cmbQuantityInstallment.Text = "Taksit Sayısı Seçiniz";
            // 
            // cmbLicenceType
            // 
            this.cmbLicenceType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLicenceType.FormattingEnabled = true;
            this.cmbLicenceType.ItemHeight = 20;
            this.cmbLicenceType.Location = new System.Drawing.Point(889, 392);
            this.cmbLicenceType.Name = "cmbLicenceType";
            this.cmbLicenceType.Size = new System.Drawing.Size(216, 28);
            this.cmbLicenceType.TabIndex = 12;
            this.cmbLicenceType.Text = "Ehliyet Tipini Seçiniz";
            // 
            // cmbRegistrationSeason
            // 
            this.cmbRegistrationSeason.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRegistrationSeason.FormattingEnabled = true;
            this.cmbRegistrationSeason.ItemHeight = 20;
            this.cmbRegistrationSeason.Location = new System.Drawing.Point(889, 283);
            this.cmbRegistrationSeason.Name = "cmbRegistrationSeason";
            this.cmbRegistrationSeason.Size = new System.Drawing.Size(216, 28);
            this.cmbRegistrationSeason.TabIndex = 11;
            this.cmbRegistrationSeason.Text = "Eğitim Sezonunu Seçiniz";
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.BackColor = System.Drawing.Color.White;
            this.radioFemale.ForeColor = System.Drawing.Color.Black;
            this.radioFemale.Location = new System.Drawing.Point(170, 399);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(65, 21);
            this.radioFemale.TabIndex = 4;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Kadın";
            this.radioFemale.UseVisualStyleBackColor = false;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.BackColor = System.Drawing.Color.White;
            this.radioMale.ForeColor = System.Drawing.Color.Black;
            this.radioMale.Location = new System.Drawing.Point(80, 399);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(65, 21);
            this.radioMale.TabIndex = 3;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Erkek";
            this.radioMale.UseVisualStyleBackColor = false;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.White;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGender.ForeColor = System.Drawing.Color.Gray;
            this.lblGender.Location = new System.Drawing.Point(78, 346);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(70, 23);
            this.lblGender.TabIndex = 121;
            this.lblGender.Text = "Cinsiyet";
            // 
            // richTxtAdress
            // 
            this.richTxtAdress.Location = new System.Drawing.Point(430, 11);
            this.richTxtAdress.Name = "richTxtAdress";
            this.richTxtAdress.Size = new System.Drawing.Size(349, 55);
            this.richTxtAdress.TabIndex = 92;
            this.richTxtAdress.Text = "";
            // 
            // lblIbanNumber
            // 
            this.lblIbanNumber.AutoSize = true;
            this.lblIbanNumber.BackColor = System.Drawing.Color.White;
            this.lblIbanNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIbanNumber.ForeColor = System.Drawing.Color.Gray;
            this.lblIbanNumber.Location = new System.Drawing.Point(885, 660);
            this.lblIbanNumber.Name = "lblIbanNumber";
            this.lblIbanNumber.Size = new System.Drawing.Size(127, 23);
            this.lblIbanNumber.TabIndex = 120;
            this.lblIbanNumber.Text = "IBAN Numarası";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.BackColor = System.Drawing.Color.White;
            this.lblAdress.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdress.ForeColor = System.Drawing.Color.Gray;
            this.lblAdress.Location = new System.Drawing.Point(76, 446);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(53, 23);
            this.lblAdress.TabIndex = 119;
            this.lblAdress.Text = "Adres";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Gray;
            this.lblPhoneNumber.Location = new System.Drawing.Point(885, 137);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(143, 23);
            this.lblPhoneNumber.TabIndex = 118;
            this.lblPhoneNumber.Text = "Telefon Numarası";
            // 
            // lblLicenceType
            // 
            this.lblLicenceType.AutoSize = true;
            this.lblLicenceType.BackColor = System.Drawing.Color.White;
            this.lblLicenceType.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLicenceType.ForeColor = System.Drawing.Color.Gray;
            this.lblLicenceType.Location = new System.Drawing.Point(885, 346);
            this.lblLicenceType.Name = "lblLicenceType";
            this.lblLicenceType.Size = new System.Drawing.Size(93, 23);
            this.lblLicenceType.TabIndex = 117;
            this.lblLicenceType.Text = "Ehliyet Tipi";
            // 
            // lblQuantityInstallment
            // 
            this.lblQuantityInstallment.AutoSize = true;
            this.lblQuantityInstallment.BackColor = System.Drawing.Color.White;
            this.lblQuantityInstallment.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantityInstallment.ForeColor = System.Drawing.Color.Gray;
            this.lblQuantityInstallment.Location = new System.Drawing.Point(885, 559);
            this.lblQuantityInstallment.Name = "lblQuantityInstallment";
            this.lblQuantityInstallment.Size = new System.Drawing.Size(99, 23);
            this.lblQuantityInstallment.TabIndex = 116;
            this.lblQuantityInstallment.Text = "Taksit Sayısı";
            // 
            // lblRegistrationDebt
            // 
            this.lblRegistrationDebt.AutoSize = true;
            this.lblRegistrationDebt.BackColor = System.Drawing.Color.White;
            this.lblRegistrationDebt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegistrationDebt.ForeColor = System.Drawing.Color.Gray;
            this.lblRegistrationDebt.Location = new System.Drawing.Point(885, 446);
            this.lblRegistrationDebt.Name = "lblRegistrationDebt";
            this.lblRegistrationDebt.Size = new System.Drawing.Size(98, 23);
            this.lblRegistrationDebt.TabIndex = 115;
            this.lblRegistrationDebt.Text = "Kayıt Ücreti";
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.lblRegistrationDate.BackColor = System.Drawing.Color.White;
            this.lblRegistrationDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegistrationDate.ForeColor = System.Drawing.Color.Gray;
            this.lblRegistrationDate.Location = new System.Drawing.Point(885, 31);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(93, 23);
            this.lblRegistrationDate.TabIndex = 114;
            this.lblRegistrationDate.Text = "Kayıt Tarihi";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.BackColor = System.Drawing.Color.White;
            this.lblBirthdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirthdate.ForeColor = System.Drawing.Color.Gray;
            this.lblBirthdate.Location = new System.Drawing.Point(76, 660);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(112, 23);
            this.lblBirthdate.TabIndex = 113;
            this.lblBirthdate.Text = "Doğum Tarihi";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblEmail.Location = new System.Drawing.Point(76, 559);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 23);
            this.lblEmail.TabIndex = 112;
            this.lblEmail.Text = "E-Mail";
            // 
            // lblNationalNumber
            // 
            this.lblNationalNumber.AutoSize = true;
            this.lblNationalNumber.BackColor = System.Drawing.Color.White;
            this.lblNationalNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNationalNumber.ForeColor = System.Drawing.Color.Gray;
            this.lblNationalNumber.Location = new System.Drawing.Point(76, 246);
            this.lblNationalNumber.Name = "lblNationalNumber";
            this.lblNationalNumber.Size = new System.Drawing.Size(161, 23);
            this.lblNationalNumber.TabIndex = 111;
            this.lblNationalNumber.Text = "T.C Kimlik Numarası";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.White;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentName.ForeColor = System.Drawing.Color.Gray;
            this.lblStudentName.Location = new System.Drawing.Point(76, 31);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(41, 23);
            this.lblStudentName.TabIndex = 110;
            this.lblStudentName.Text = "İsim";
            // 
            // lblStudentSurname
            // 
            this.lblStudentSurname.AutoSize = true;
            this.lblStudentSurname.BackColor = System.Drawing.Color.White;
            this.lblStudentSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentSurname.ForeColor = System.Drawing.Color.Gray;
            this.lblStudentSurname.Location = new System.Drawing.Point(76, 137);
            this.lblStudentSurname.Name = "lblStudentSurname";
            this.lblStudentSurname.Size = new System.Drawing.Size(68, 23);
            this.lblStudentSurname.TabIndex = 109;
            this.lblStudentSurname.Text = "Soyisim";
            // 
            // lblRegistrationSeason
            // 
            this.lblRegistrationSeason.AutoSize = true;
            this.lblRegistrationSeason.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegistrationSeason.ForeColor = System.Drawing.Color.Gray;
            this.lblRegistrationSeason.Location = new System.Drawing.Point(885, 246);
            this.lblRegistrationSeason.Name = "lblRegistrationSeason";
            this.lblRegistrationSeason.Size = new System.Drawing.Size(119, 23);
            this.lblRegistrationSeason.TabIndex = 108;
            this.lblRegistrationSeason.Text = "Eğitim Sezonu";
            // 
            // ucStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbpStudentRecord);
            this.Name = "ucStudentRecord";
            this.Size = new System.Drawing.Size(1470, 940);
            this.Load += new System.EventHandler(this.ucStudentRecord_Load);
            this.gbpStudentRecord.ResumeLayout(false);
            this.gbpStudentRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbpStudentRecord;
        private System.Windows.Forms.Label lblHaveLicenceType;
        private System.Windows.Forms.ComboBox cmbHaveLicenceType;
        private System.Windows.Forms.CheckBox checkHaveLicence;
        private System.Windows.Forms.ComboBox cmbPlaceofBirth;
        private System.Windows.Forms.Label lblPlaceofBirth;
        private System.Windows.Forms.ComboBox cmbQuantityInstallment;
        private System.Windows.Forms.ComboBox cmbLicenceType;
        private System.Windows.Forms.ComboBox cmbRegistrationSeason;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RichTextBox richTxtAdress;
        private System.Windows.Forms.Label lblIbanNumber;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblLicenceType;
        private System.Windows.Forms.Label lblQuantityInstallment;
        private System.Windows.Forms.Label lblRegistrationDebt;
        private System.Windows.Forms.Label lblRegistrationDate;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNationalNumber;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentSurname;
        private System.Windows.Forms.Label lblRegistrationSeason;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAdress;
        private Bunifu.Framework.UI.BunifuDatepicker dpcBirthdate;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNationalNumber;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStudentSurname;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStudentName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuDatepicker dpcRegistrationDate;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPhoneNumber;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtIbanNumber;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtRegistrationDebt;
        private Bunifu.Framework.UI.BunifuImageButton btnClear;
        private Bunifu.Framework.UI.BunifuImageButton btnRegister;
    }
}
