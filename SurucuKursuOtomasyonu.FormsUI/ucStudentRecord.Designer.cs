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
            this.gpbStudentRecord = new DevExpress.XtraEditors.GroupControl();
            this.panelStudentRegister = new System.Windows.Forms.Panel();
            this.btnRegisterToday = new DevExpress.XtraEditors.SimpleButton();
            this.cmbPlaceofBirth = new System.Windows.Forms.ComboBox();
            this.lblPlaceofBirth = new System.Windows.Forms.Label();
            this.cmbQuantityInstallment = new System.Windows.Forms.ComboBox();
            this.cmbLicenceType = new System.Windows.Forms.ComboBox();
            this.cmbRegistrationSeason = new System.Windows.Forms.ComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.maskedTxtIbanNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtRegistrationDebt = new DevExpress.XtraEditors.TextEdit();
            this.maskedTxtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.maskedtxtRegistrationDate = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtBirthdate = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
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
            this.txtStudentSurname = new DevExpress.XtraEditors.TextEdit();
            this.txtStudentName = new DevExpress.XtraEditors.TextEdit();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.maskedTxtNationalNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.lblRegistrationSeason = new System.Windows.Forms.Label();
            this.checkHaveLicence = new System.Windows.Forms.CheckBox();
            this.cmbHaveLicenceType = new System.Windows.Forms.ComboBox();
            this.lblHaveLicenceType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gpbStudentRecord)).BeginInit();
            this.gpbStudentRecord.SuspendLayout();
            this.panelStudentRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistrationDebt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbStudentRecord
            // 
            this.gpbStudentRecord.Controls.Add(this.panelStudentRegister);
            this.gpbStudentRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbStudentRecord.Location = new System.Drawing.Point(0, 0);
            this.gpbStudentRecord.Name = "gpbStudentRecord";
            this.gpbStudentRecord.Size = new System.Drawing.Size(1153, 606);
            this.gpbStudentRecord.TabIndex = 0;
            this.gpbStudentRecord.Text = "Öğrenci Kayıt";
            // 
            // panelStudentRegister
            // 
            this.panelStudentRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panelStudentRegister.Controls.Add(this.lblHaveLicenceType);
            this.panelStudentRegister.Controls.Add(this.cmbHaveLicenceType);
            this.panelStudentRegister.Controls.Add(this.checkHaveLicence);
            this.panelStudentRegister.Controls.Add(this.btnRegisterToday);
            this.panelStudentRegister.Controls.Add(this.cmbPlaceofBirth);
            this.panelStudentRegister.Controls.Add(this.lblPlaceofBirth);
            this.panelStudentRegister.Controls.Add(this.cmbQuantityInstallment);
            this.panelStudentRegister.Controls.Add(this.cmbLicenceType);
            this.panelStudentRegister.Controls.Add(this.cmbRegistrationSeason);
            this.panelStudentRegister.Controls.Add(this.simpleButton1);
            this.panelStudentRegister.Controls.Add(this.radioFemale);
            this.panelStudentRegister.Controls.Add(this.radioMale);
            this.panelStudentRegister.Controls.Add(this.lblGender);
            this.panelStudentRegister.Controls.Add(this.maskedTxtIbanNumber);
            this.panelStudentRegister.Controls.Add(this.txtRegistrationDebt);
            this.panelStudentRegister.Controls.Add(this.maskedTxtPhoneNumber);
            this.panelStudentRegister.Controls.Add(this.maskedtxtRegistrationDate);
            this.panelStudentRegister.Controls.Add(this.maskedTxtBirthdate);
            this.panelStudentRegister.Controls.Add(this.txtEmail);
            this.panelStudentRegister.Controls.Add(this.richTxtAdress);
            this.panelStudentRegister.Controls.Add(this.lblIbanNumber);
            this.panelStudentRegister.Controls.Add(this.lblAdress);
            this.panelStudentRegister.Controls.Add(this.lblPhoneNumber);
            this.panelStudentRegister.Controls.Add(this.lblLicenceType);
            this.panelStudentRegister.Controls.Add(this.lblQuantityInstallment);
            this.panelStudentRegister.Controls.Add(this.lblRegistrationDebt);
            this.panelStudentRegister.Controls.Add(this.lblRegistrationDate);
            this.panelStudentRegister.Controls.Add(this.lblBirthdate);
            this.panelStudentRegister.Controls.Add(this.lblEmail);
            this.panelStudentRegister.Controls.Add(this.lblNationalNumber);
            this.panelStudentRegister.Controls.Add(this.lblStudentName);
            this.panelStudentRegister.Controls.Add(this.txtStudentSurname);
            this.panelStudentRegister.Controls.Add(this.txtStudentName);
            this.panelStudentRegister.Controls.Add(this.btnRegister);
            this.panelStudentRegister.Controls.Add(this.maskedTxtNationalNumber);
            this.panelStudentRegister.Controls.Add(this.lblStudentSurname);
            this.panelStudentRegister.Controls.Add(this.lblRegistrationSeason);
            this.panelStudentRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStudentRegister.Location = new System.Drawing.Point(2, 25);
            this.panelStudentRegister.Name = "panelStudentRegister";
            this.panelStudentRegister.Size = new System.Drawing.Size(1149, 579);
            this.panelStudentRegister.TabIndex = 45;
            // 
            // btnRegisterToday
            // 
            this.btnRegisterToday.Location = new System.Drawing.Point(918, 13);
            this.btnRegisterToday.Name = "btnRegisterToday";
            this.btnRegisterToday.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterToday.TabIndex = 10;
            this.btnRegisterToday.Text = "Bugün";
            this.btnRegisterToday.Click += new System.EventHandler(this.btnRegisterToday_Click);
            // 
            // cmbPlaceofBirth
            // 
            this.cmbPlaceofBirth.FormattingEnabled = true;
            this.cmbPlaceofBirth.ItemHeight = 16;
            this.cmbPlaceofBirth.Location = new System.Drawing.Point(165, 333);
            this.cmbPlaceofBirth.Name = "cmbPlaceofBirth";
            this.cmbPlaceofBirth.Size = new System.Drawing.Size(170, 24);
            this.cmbPlaceofBirth.TabIndex = 8;
            // 
            // lblPlaceofBirth
            // 
            this.lblPlaceofBirth.AutoSize = true;
            this.lblPlaceofBirth.ForeColor = System.Drawing.Color.White;
            this.lblPlaceofBirth.Location = new System.Drawing.Point(3, 332);
            this.lblPlaceofBirth.Name = "lblPlaceofBirth";
            this.lblPlaceofBirth.Size = new System.Drawing.Size(80, 17);
            this.lblPlaceofBirth.TabIndex = 83;
            this.lblPlaceofBirth.Text = "Doğum Yeri";
            // 
            // cmbQuantityInstallment
            // 
            this.cmbQuantityInstallment.FormattingEnabled = true;
            this.cmbQuantityInstallment.ItemHeight = 16;
            this.cmbQuantityInstallment.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbQuantityInstallment.Location = new System.Drawing.Point(741, 213);
            this.cmbQuantityInstallment.Name = "cmbQuantityInstallment";
            this.cmbQuantityInstallment.Size = new System.Drawing.Size(170, 24);
            this.cmbQuantityInstallment.TabIndex = 15;
            // 
            // cmbLicenceType
            // 
            this.cmbLicenceType.FormattingEnabled = true;
            this.cmbLicenceType.ItemHeight = 16;
            this.cmbLicenceType.Location = new System.Drawing.Point(741, 134);
            this.cmbLicenceType.Name = "cmbLicenceType";
            this.cmbLicenceType.Size = new System.Drawing.Size(170, 24);
            this.cmbLicenceType.TabIndex = 13;
            // 
            // cmbRegistrationSeason
            // 
            this.cmbRegistrationSeason.FormattingEnabled = true;
            this.cmbRegistrationSeason.ItemHeight = 16;
            this.cmbRegistrationSeason.Location = new System.Drawing.Point(741, 94);
            this.cmbRegistrationSeason.Name = "cmbRegistrationSeason";
            this.cmbRegistrationSeason.Size = new System.Drawing.Size(170, 24);
            this.cmbRegistrationSeason.TabIndex = 12;
            this.cmbRegistrationSeason.SelectedIndexChanged += new System.EventHandler(this.cmbRegistrationSeason_SelectedIndexChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.Location = new System.Drawing.Point(519, 436);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(176, 68);
            this.simpleButton1.TabIndex = 18;
            this.simpleButton1.Text = "Temizle";
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.ForeColor = System.Drawing.Color.White;
            this.radioFemale.Location = new System.Drawing.Point(255, 129);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(62, 21);
            this.radioFemale.TabIndex = 4;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Kadın";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.ForeColor = System.Drawing.Color.White;
            this.radioMale.Location = new System.Drawing.Point(165, 129);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(63, 21);
            this.radioMale.TabIndex = 3;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Erkek";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(3, 134);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(55, 17);
            this.lblGender.TabIndex = 75;
            this.lblGender.Text = "Cinsiyet";
            // 
            // maskedTxtIbanNumber
            // 
            this.maskedTxtIbanNumber.Location = new System.Drawing.Point(741, 249);
            this.maskedTxtIbanNumber.Mask = "TR 0000-0000-0000-0000";
            this.maskedTxtIbanNumber.Name = "maskedTxtIbanNumber";
            this.maskedTxtIbanNumber.Size = new System.Drawing.Size(170, 23);
            this.maskedTxtIbanNumber.TabIndex = 16;
            // 
            // txtRegistrationDebt
            // 
            this.txtRegistrationDebt.Location = new System.Drawing.Point(741, 175);
            this.txtRegistrationDebt.Name = "txtRegistrationDebt";
            this.txtRegistrationDebt.Size = new System.Drawing.Size(170, 22);
            this.txtRegistrationDebt.TabIndex = 14;
            // 
            // maskedTxtPhoneNumber
            // 
            this.maskedTxtPhoneNumber.Location = new System.Drawing.Point(741, 53);
            this.maskedTxtPhoneNumber.Mask = "(999) 000-0000";
            this.maskedTxtPhoneNumber.Name = "maskedTxtPhoneNumber";
            this.maskedTxtPhoneNumber.Size = new System.Drawing.Size(170, 23);
            this.maskedTxtPhoneNumber.TabIndex = 11;
            // 
            // maskedtxtRegistrationDate
            // 
            this.maskedtxtRegistrationDate.Location = new System.Drawing.Point(741, 13);
            this.maskedtxtRegistrationDate.Mask = "00/00/0000";
            this.maskedtxtRegistrationDate.Name = "maskedtxtRegistrationDate";
            this.maskedtxtRegistrationDate.Size = new System.Drawing.Size(170, 23);
            this.maskedtxtRegistrationDate.TabIndex = 9;
            this.maskedtxtRegistrationDate.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTxtBirthdate
            // 
            this.maskedTxtBirthdate.Location = new System.Drawing.Point(167, 287);
            this.maskedTxtBirthdate.Mask = "00/00/0000";
            this.maskedTxtBirthdate.Name = "maskedTxtBirthdate";
            this.maskedTxtBirthdate.Size = new System.Drawing.Size(170, 23);
            this.maskedTxtBirthdate.TabIndex = 7;
            this.maskedTxtBirthdate.ValidatingType = typeof(System.DateTime);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(167, 248);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(170, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // richTxtAdress
            // 
            this.richTxtAdress.Location = new System.Drawing.Point(167, 169);
            this.richTxtAdress.Name = "richTxtAdress";
            this.richTxtAdress.Size = new System.Drawing.Size(349, 55);
            this.richTxtAdress.TabIndex = 5;
            this.richTxtAdress.Text = "";
            // 
            // lblIbanNumber
            // 
            this.lblIbanNumber.AutoSize = true;
            this.lblIbanNumber.ForeColor = System.Drawing.Color.White;
            this.lblIbanNumber.Location = new System.Drawing.Point(563, 255);
            this.lblIbanNumber.Name = "lblIbanNumber";
            this.lblIbanNumber.Size = new System.Drawing.Size(97, 17);
            this.lblIbanNumber.TabIndex = 60;
            this.lblIbanNumber.Text = "IBAN Numarası";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.lblAdress.ForeColor = System.Drawing.Color.White;
            this.lblAdress.Location = new System.Drawing.Point(3, 172);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(42, 17);
            this.lblAdress.TabIndex = 59;
            this.lblAdress.Text = "Adres";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Location = new System.Drawing.Point(563, 58);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(112, 17);
            this.lblPhoneNumber.TabIndex = 58;
            this.lblPhoneNumber.Text = "Telefon Numarası";
            // 
            // lblLicenceType
            // 
            this.lblLicenceType.AutoSize = true;
            this.lblLicenceType.ForeColor = System.Drawing.Color.White;
            this.lblLicenceType.Location = new System.Drawing.Point(563, 140);
            this.lblLicenceType.Name = "lblLicenceType";
            this.lblLicenceType.Size = new System.Drawing.Size(72, 17);
            this.lblLicenceType.TabIndex = 57;
            this.lblLicenceType.Text = "Ehliyet Tipi";
            // 
            // lblQuantityInstallment
            // 
            this.lblQuantityInstallment.AutoSize = true;
            this.lblQuantityInstallment.ForeColor = System.Drawing.Color.White;
            this.lblQuantityInstallment.Location = new System.Drawing.Point(563, 220);
            this.lblQuantityInstallment.Name = "lblQuantityInstallment";
            this.lblQuantityInstallment.Size = new System.Drawing.Size(80, 17);
            this.lblQuantityInstallment.TabIndex = 56;
            this.lblQuantityInstallment.Text = "Taksit Sayısı";
            // 
            // lblRegistrationDebt
            // 
            this.lblRegistrationDebt.AutoSize = true;
            this.lblRegistrationDebt.ForeColor = System.Drawing.Color.White;
            this.lblRegistrationDebt.Location = new System.Drawing.Point(563, 178);
            this.lblRegistrationDebt.Name = "lblRegistrationDebt";
            this.lblRegistrationDebt.Size = new System.Drawing.Size(77, 17);
            this.lblRegistrationDebt.TabIndex = 55;
            this.lblRegistrationDebt.Text = "Kayıt Ücreti";
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.lblRegistrationDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.lblRegistrationDate.ForeColor = System.Drawing.Color.White;
            this.lblRegistrationDate.Location = new System.Drawing.Point(563, 19);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(74, 17);
            this.lblRegistrationDate.TabIndex = 54;
            this.lblRegistrationDate.Text = "Kayıt Tarihi";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.lblBirthdate.ForeColor = System.Drawing.Color.White;
            this.lblBirthdate.Location = new System.Drawing.Point(3, 290);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(90, 17);
            this.lblBirthdate.TabIndex = 53;
            this.lblBirthdate.Text = "Doğum Tarihi";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(3, 253);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 52;
            this.lblEmail.Text = "E-Mail";
            // 
            // lblNationalNumber
            // 
            this.lblNationalNumber.AutoSize = true;
            this.lblNationalNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.lblNationalNumber.ForeColor = System.Drawing.Color.White;
            this.lblNationalNumber.Location = new System.Drawing.Point(3, 91);
            this.lblNationalNumber.Name = "lblNationalNumber";
            this.lblNationalNumber.Size = new System.Drawing.Size(126, 17);
            this.lblNationalNumber.TabIndex = 51;
            this.lblNationalNumber.Text = "T.C Kimlik Numarası";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.lblStudentName.ForeColor = System.Drawing.Color.White;
            this.lblStudentName.Location = new System.Drawing.Point(3, 13);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(32, 17);
            this.lblStudentName.TabIndex = 50;
            this.lblStudentName.Text = "İsim";
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.Location = new System.Drawing.Point(165, 50);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(170, 22);
            this.txtStudentSurname.TabIndex = 1;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(165, 10);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(170, 22);
            this.txtStudentName.TabIndex = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btnRegister.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Appearance.Options.UseBackColor = true;
            this.btnRegister.Appearance.Options.UseFont = true;
            this.btnRegister.Appearance.Options.UseForeColor = true;
            this.btnRegister.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnRegister.Location = new System.Drawing.Point(212, 436);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(176, 68);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "Kayıt";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // maskedTxtNationalNumber
            // 
            this.maskedTxtNationalNumber.Location = new System.Drawing.Point(165, 88);
            this.maskedTxtNationalNumber.Mask = "00000000000";
            this.maskedTxtNationalNumber.Name = "maskedTxtNationalNumber";
            this.maskedTxtNationalNumber.Size = new System.Drawing.Size(170, 23);
            this.maskedTxtNationalNumber.TabIndex = 2;
            // 
            // lblStudentSurname
            // 
            this.lblStudentSurname.AutoSize = true;
            this.lblStudentSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.lblStudentSurname.ForeColor = System.Drawing.Color.White;
            this.lblStudentSurname.Location = new System.Drawing.Point(1, 53);
            this.lblStudentSurname.Name = "lblStudentSurname";
            this.lblStudentSurname.Size = new System.Drawing.Size(54, 17);
            this.lblStudentSurname.TabIndex = 48;
            this.lblStudentSurname.Text = "Soyisim";
            // 
            // lblRegistrationSeason
            // 
            this.lblRegistrationSeason.AutoSize = true;
            this.lblRegistrationSeason.ForeColor = System.Drawing.Color.White;
            this.lblRegistrationSeason.Location = new System.Drawing.Point(563, 100);
            this.lblRegistrationSeason.Name = "lblRegistrationSeason";
            this.lblRegistrationSeason.Size = new System.Drawing.Size(94, 17);
            this.lblRegistrationSeason.TabIndex = 46;
            this.lblRegistrationSeason.Text = "Eğitim Sezonu";
            // 
            // checkHaveLicence
            // 
            this.checkHaveLicence.AutoSize = true;
            this.checkHaveLicence.ForeColor = System.Drawing.Color.White;
            this.checkHaveLicence.Location = new System.Drawing.Point(741, 289);
            this.checkHaveLicence.Name = "checkHaveLicence";
            this.checkHaveLicence.Size = new System.Drawing.Size(132, 21);
            this.checkHaveLicence.TabIndex = 17;
            this.checkHaveLicence.Text = "Ehliyet Sahibi Mi?";
            this.checkHaveLicence.UseVisualStyleBackColor = true;
            this.checkHaveLicence.CheckedChanged += new System.EventHandler(this.checkHaveLicence_CheckedChanged);
            // 
            // cmbHaveLicenceType
            // 
            this.cmbHaveLicenceType.FormattingEnabled = true;
            this.cmbHaveLicenceType.ItemHeight = 16;
            this.cmbHaveLicenceType.Location = new System.Drawing.Point(741, 325);
            this.cmbHaveLicenceType.Name = "cmbHaveLicenceType";
            this.cmbHaveLicenceType.Size = new System.Drawing.Size(170, 24);
            this.cmbHaveLicenceType.TabIndex = 18;
            this.cmbHaveLicenceType.Visible = false;
            // 
            // lblHaveLicenceType
            // 
            this.lblHaveLicenceType.AutoSize = true;
            this.lblHaveLicenceType.ForeColor = System.Drawing.Color.White;
            this.lblHaveLicenceType.Location = new System.Drawing.Point(563, 328);
            this.lblHaveLicenceType.Name = "lblHaveLicenceType";
            this.lblHaveLicenceType.Size = new System.Drawing.Size(121, 17);
            this.lblHaveLicenceType.TabIndex = 86;
            this.lblHaveLicenceType.Text = "Mevcut Ehliyet Tipi";
            this.lblHaveLicenceType.Visible = false;
            // 
            // ucStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbStudentRecord);
            this.Name = "ucStudentRecord";
            this.Size = new System.Drawing.Size(1153, 606);
            this.Load += new System.EventHandler(this.ucStudentRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpbStudentRecord)).EndInit();
            this.gpbStudentRecord.ResumeLayout(false);
            this.panelStudentRegister.ResumeLayout(false);
            this.panelStudentRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistrationDebt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gpbStudentRecord;
        private System.Windows.Forms.Panel panelStudentRegister;
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
        private DevExpress.XtraEditors.TextEdit txtStudentSurname;
        private DevExpress.XtraEditors.TextEdit txtStudentName;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private System.Windows.Forms.MaskedTextBox maskedTxtNationalNumber;
        private System.Windows.Forms.Label lblStudentSurname;
        private System.Windows.Forms.Label lblRegistrationSeason;
        private System.Windows.Forms.RichTextBox richTxtAdress;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private System.Windows.Forms.MaskedTextBox maskedTxtIbanNumber;
        private DevExpress.XtraEditors.TextEdit txtRegistrationDebt;
        private System.Windows.Forms.MaskedTextBox maskedTxtPhoneNumber;
        private System.Windows.Forms.MaskedTextBox maskedtxtRegistrationDate;
        private System.Windows.Forms.MaskedTextBox maskedTxtBirthdate;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.Label lblGender;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ComboBox cmbRegistrationSeason;
        private System.Windows.Forms.ComboBox cmbQuantityInstallment;
        private System.Windows.Forms.ComboBox cmbLicenceType;
        private System.Windows.Forms.ComboBox cmbPlaceofBirth;
        private System.Windows.Forms.Label lblPlaceofBirth;
        private DevExpress.XtraEditors.SimpleButton btnRegisterToday;
        private System.Windows.Forms.Label lblHaveLicenceType;
        private System.Windows.Forms.ComboBox cmbHaveLicenceType;
        private System.Windows.Forms.CheckBox checkHaveLicence;
    }
}
