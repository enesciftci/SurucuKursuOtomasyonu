namespace SurucuKursuOtomasyonu.FormsUI
{
    partial class UcStudentRegulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcStudentRegulation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbStudentRegulation = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbLicenceType = new System.Windows.Forms.ComboBox();
            this.lblLicenceType = new System.Windows.Forms.Label();
            this.lblRegistrationDebt = new System.Windows.Forms.Label();
            this.txtRegistrationDebt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblQuantityInstallment = new System.Windows.Forms.Label();
            this.cmbQuantityInstallment = new System.Windows.Forms.ComboBox();
            this.btnDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.checkHaveLicence = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblIbanNumber = new System.Windows.Forms.Label();
            this.lblHaveLicenceType = new System.Windows.Forms.Label();
            this.txtIbanNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cmbHaveLicenceType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.cmbRegistrationSeason = new System.Windows.Forms.ComboBox();
            this.txtPhoneNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRegistrationSeason = new System.Windows.Forms.Label();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.dpcRegistrationDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtAdress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStudentName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNationalNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.cmbPlaceofBirth = new System.Windows.Forms.ComboBox();
            this.txtStudentSurname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.lblNationalNumber = new System.Windows.Forms.Label();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblPlaceofBirth = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.dpcBirthdate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwStudentRegulation = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtSearchByNationalNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
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
            this.gpbStudentRegulation.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentRegulation)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbStudentRegulation
            // 
            this.gpbStudentRegulation.BackColor = System.Drawing.Color.White;
            this.gpbStudentRegulation.Controls.Add(this.groupBox3);
            this.gpbStudentRegulation.Controls.Add(this.groupBox2);
            this.gpbStudentRegulation.Controls.Add(this.groupBox1);
            this.gpbStudentRegulation.Controls.Add(this.label1);
            this.gpbStudentRegulation.Controls.Add(this.dgwStudentRegulation);
            this.gpbStudentRegulation.Controls.Add(this.txtSearchByNationalNumber);
            this.gpbStudentRegulation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbStudentRegulation.Location = new System.Drawing.Point(0, 0);
            this.gpbStudentRegulation.Name = "gpbStudentRegulation";
            this.gpbStudentRegulation.Size = new System.Drawing.Size(2035, 955);
            this.gpbStudentRegulation.TabIndex = 0;
            this.gpbStudentRegulation.TabStop = false;
            this.gpbStudentRegulation.Text = "Öğrenci Düzenle";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbLicenceType);
            this.groupBox3.Controls.Add(this.lblLicenceType);
            this.groupBox3.Controls.Add(this.lblRegistrationDebt);
            this.groupBox3.Controls.Add(this.txtRegistrationDebt);
            this.groupBox3.Controls.Add(this.lblQuantityInstallment);
            this.groupBox3.Controls.Add(this.cmbQuantityInstallment);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.checkHaveLicence);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.lblIbanNumber);
            this.groupBox3.Controls.Add(this.lblHaveLicenceType);
            this.groupBox3.Controls.Add(this.txtIbanNumber);
            this.groupBox3.Controls.Add(this.cmbHaveLicenceType);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(2029, 115);
            this.groupBox3.TabIndex = 168;
            this.groupBox3.TabStop = false;
            // 
            // cmbLicenceType
            // 
            this.cmbLicenceType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLicenceType.FormattingEnabled = true;
            this.cmbLicenceType.ItemHeight = 20;
            this.cmbLicenceType.Location = new System.Drawing.Point(838, 65);
            this.cmbLicenceType.Name = "cmbLicenceType";
            this.cmbLicenceType.Size = new System.Drawing.Size(216, 28);
            this.cmbLicenceType.TabIndex = 156;
            this.cmbLicenceType.Text = "Ehliyet Tipini Seçiniz";
            // 
            // lblLicenceType
            // 
            this.lblLicenceType.AutoSize = true;
            this.lblLicenceType.BackColor = System.Drawing.Color.White;
            this.lblLicenceType.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLicenceType.ForeColor = System.Drawing.Color.Gray;
            this.lblLicenceType.Location = new System.Drawing.Point(834, 30);
            this.lblLicenceType.Name = "lblLicenceType";
            this.lblLicenceType.Size = new System.Drawing.Size(93, 23);
            this.lblLicenceType.TabIndex = 158;
            this.lblLicenceType.Text = "Ehliyet Tipi";
            // 
            // lblRegistrationDebt
            // 
            this.lblRegistrationDebt.AutoSize = true;
            this.lblRegistrationDebt.BackColor = System.Drawing.Color.White;
            this.lblRegistrationDebt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegistrationDebt.ForeColor = System.Drawing.Color.Gray;
            this.lblRegistrationDebt.Location = new System.Drawing.Point(274, 30);
            this.lblRegistrationDebt.Name = "lblRegistrationDebt";
            this.lblRegistrationDebt.Size = new System.Drawing.Size(98, 23);
            this.lblRegistrationDebt.TabIndex = 152;
            this.lblRegistrationDebt.Text = "Kayıt Ücreti";
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
            this.txtRegistrationDebt.Location = new System.Drawing.Point(278, 65);
            this.txtRegistrationDebt.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegistrationDebt.Name = "txtRegistrationDebt";
            this.txtRegistrationDebt.Size = new System.Drawing.Size(248, 43);
            this.txtRegistrationDebt.TabIndex = 139;
            this.txtRegistrationDebt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblQuantityInstallment
            // 
            this.lblQuantityInstallment.AutoSize = true;
            this.lblQuantityInstallment.BackColor = System.Drawing.Color.White;
            this.lblQuantityInstallment.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantityInstallment.ForeColor = System.Drawing.Color.Gray;
            this.lblQuantityInstallment.Location = new System.Drawing.Point(558, 30);
            this.lblQuantityInstallment.Name = "lblQuantityInstallment";
            this.lblQuantityInstallment.Size = new System.Drawing.Size(99, 23);
            this.lblQuantityInstallment.TabIndex = 153;
            this.lblQuantityInstallment.Text = "Taksit Sayısı";
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
            this.cmbQuantityInstallment.Location = new System.Drawing.Point(562, 63);
            this.cmbQuantityInstallment.Name = "cmbQuantityInstallment";
            this.cmbQuantityInstallment.Size = new System.Drawing.Size(216, 28);
            this.cmbQuantityInstallment.TabIndex = 140;
            this.cmbQuantityInstallment.Text = "Taksit Sayısı Seçiniz";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageActive = null;
            this.btnDelete.Location = new System.Drawing.Point(1691, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 85);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 162;
            this.btnDelete.TabStop = false;
            this.btnDelete.Zoom = 10;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // checkHaveLicence
            // 
            this.checkHaveLicence.AutoSize = true;
            this.checkHaveLicence.BackColor = System.Drawing.Color.White;
            this.checkHaveLicence.ForeColor = System.Drawing.Color.Black;
            this.checkHaveLicence.Location = new System.Drawing.Point(1090, 63);
            this.checkHaveLicence.Name = "checkHaveLicence";
            this.checkHaveLicence.Size = new System.Drawing.Size(141, 21);
            this.checkHaveLicence.TabIndex = 142;
            this.checkHaveLicence.Text = "Ehliyet Sahibi Mi?";
            this.checkHaveLicence.UseVisualStyleBackColor = false;
            this.checkHaveLicence.CheckedChanged += new System.EventHandler(this.checkHaveLicence_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.ErrorImage = null;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageActive = null;
            this.btnUpdate.InitialImage = null;
            this.btnUpdate.Location = new System.Drawing.Point(1530, 21);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 85);
            this.btnUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUpdate.TabIndex = 161;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Zoom = 10;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblIbanNumber
            // 
            this.lblIbanNumber.AutoSize = true;
            this.lblIbanNumber.BackColor = System.Drawing.Color.White;
            this.lblIbanNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIbanNumber.ForeColor = System.Drawing.Color.Gray;
            this.lblIbanNumber.Location = new System.Drawing.Point(6, 30);
            this.lblIbanNumber.Name = "lblIbanNumber";
            this.lblIbanNumber.Size = new System.Drawing.Size(127, 23);
            this.lblIbanNumber.TabIndex = 157;
            this.lblIbanNumber.Text = "IBAN Numarası";
            // 
            // lblHaveLicenceType
            // 
            this.lblHaveLicenceType.AutoSize = true;
            this.lblHaveLicenceType.BackColor = System.Drawing.Color.White;
            this.lblHaveLicenceType.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHaveLicenceType.ForeColor = System.Drawing.Color.Gray;
            this.lblHaveLicenceType.Location = new System.Drawing.Point(1254, 30);
            this.lblHaveLicenceType.Name = "lblHaveLicenceType";
            this.lblHaveLicenceType.Size = new System.Drawing.Size(156, 23);
            this.lblHaveLicenceType.TabIndex = 160;
            this.lblHaveLicenceType.Text = "Mevcut Ehliyet Tipi";
            this.lblHaveLicenceType.Visible = false;
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
            this.txtIbanNumber.Location = new System.Drawing.Point(10, 65);
            this.txtIbanNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtIbanNumber.Name = "txtIbanNumber";
            this.txtIbanNumber.Size = new System.Drawing.Size(248, 43);
            this.txtIbanNumber.TabIndex = 141;
            this.txtIbanNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmbHaveLicenceType
            // 
            this.cmbHaveLicenceType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHaveLicenceType.FormattingEnabled = true;
            this.cmbHaveLicenceType.ItemHeight = 20;
            this.cmbHaveLicenceType.Location = new System.Drawing.Point(1258, 65);
            this.cmbHaveLicenceType.Name = "cmbHaveLicenceType";
            this.cmbHaveLicenceType.Size = new System.Drawing.Size(170, 28);
            this.cmbHaveLicenceType.TabIndex = 143;
            this.cmbHaveLicenceType.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPhoneNumber);
            this.groupBox2.Controls.Add(this.cmbRegistrationSeason);
            this.groupBox2.Controls.Add(this.txtPhoneNumber);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.lblRegistrationSeason);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.lblRegistrationDate);
            this.groupBox2.Controls.Add(this.lblAdress);
            this.groupBox2.Controls.Add(this.dpcRegistrationDate);
            this.groupBox2.Controls.Add(this.txtAdress);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(2029, 121);
            this.groupBox2.TabIndex = 167;
            this.groupBox2.TabStop = false;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Gray;
            this.lblPhoneNumber.Location = new System.Drawing.Point(6, 28);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(143, 23);
            this.lblPhoneNumber.TabIndex = 155;
            this.lblPhoneNumber.Text = "Telefon Numarası";
            // 
            // cmbRegistrationSeason
            // 
            this.cmbRegistrationSeason.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRegistrationSeason.FormattingEnabled = true;
            this.cmbRegistrationSeason.ItemHeight = 20;
            this.cmbRegistrationSeason.Location = new System.Drawing.Point(838, 69);
            this.cmbRegistrationSeason.Name = "cmbRegistrationSeason";
            this.cmbRegistrationSeason.Size = new System.Drawing.Size(216, 28);
            this.cmbRegistrationSeason.TabIndex = 155;
            this.cmbRegistrationSeason.Text = "Eğitim Sezonunu Seçiniz";
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
            this.txtPhoneNumber.Location = new System.Drawing.Point(10, 69);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(248, 43);
            this.txtPhoneNumber.TabIndex = 136;
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblEmail.Location = new System.Drawing.Point(274, 28);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 23);
            this.lblEmail.TabIndex = 149;
            this.lblEmail.Text = "E-Mail";
            // 
            // lblRegistrationSeason
            // 
            this.lblRegistrationSeason.AutoSize = true;
            this.lblRegistrationSeason.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegistrationSeason.ForeColor = System.Drawing.Color.Gray;
            this.lblRegistrationSeason.Location = new System.Drawing.Point(834, 28);
            this.lblRegistrationSeason.Name = "lblRegistrationSeason";
            this.lblRegistrationSeason.Size = new System.Drawing.Size(119, 23);
            this.lblRegistrationSeason.TabIndex = 157;
            this.lblRegistrationSeason.Text = "Eğitim Sezonu";
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
            this.txtEmail.Location = new System.Drawing.Point(278, 69);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(248, 43);
            this.txtEmail.TabIndex = 132;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.lblRegistrationDate.BackColor = System.Drawing.Color.White;
            this.lblRegistrationDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegistrationDate.ForeColor = System.Drawing.Color.Gray;
            this.lblRegistrationDate.Location = new System.Drawing.Point(1086, 28);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(93, 23);
            this.lblRegistrationDate.TabIndex = 151;
            this.lblRegistrationDate.Text = "Kayıt Tarihi";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.BackColor = System.Drawing.Color.White;
            this.lblAdress.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdress.ForeColor = System.Drawing.Color.Gray;
            this.lblAdress.Location = new System.Drawing.Point(558, 28);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(53, 23);
            this.lblAdress.TabIndex = 156;
            this.lblAdress.Text = "Adres";
            // 
            // dpcRegistrationDate
            // 
            this.dpcRegistrationDate.BackColor = System.Drawing.Color.SeaGreen;
            this.dpcRegistrationDate.BorderRadius = 0;
            this.dpcRegistrationDate.ForeColor = System.Drawing.Color.White;
            this.dpcRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpcRegistrationDate.FormatCustom = null;
            this.dpcRegistrationDate.Location = new System.Drawing.Point(1090, 63);
            this.dpcRegistrationDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpcRegistrationDate.Name = "dpcRegistrationDate";
            this.dpcRegistrationDate.Size = new System.Drawing.Size(248, 33);
            this.dpcRegistrationDate.TabIndex = 135;
            this.dpcRegistrationDate.Value = new System.DateTime(2019, 3, 13, 22, 54, 58, 99);
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
            this.txtAdress.Location = new System.Drawing.Point(562, 69);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(248, 43);
            this.txtAdress.TabIndex = 131;
            this.txtAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Controls.Add(this.txtNationalNumber);
            this.groupBox1.Controls.Add(this.lblStudentName);
            this.groupBox1.Controls.Add(this.cmbPlaceofBirth);
            this.groupBox1.Controls.Add(this.txtStudentSurname);
            this.groupBox1.Controls.Add(this.radioFemale);
            this.groupBox1.Controls.Add(this.lblStudentSurname);
            this.groupBox1.Controls.Add(this.lblNationalNumber);
            this.groupBox1.Controls.Add(this.radioMale);
            this.groupBox1.Controls.Add(this.lblBirthdate);
            this.groupBox1.Controls.Add(this.lblPlaceofBirth);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.dpcBirthdate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2029, 146);
            this.groupBox1.TabIndex = 166;
            this.groupBox1.TabStop = false;
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
            this.txtStudentName.Location = new System.Drawing.Point(10, 75);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(248, 43);
            this.txtStudentName.TabIndex = 168;
            this.txtStudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtNationalNumber.Location = new System.Drawing.Point(562, 75);
            this.txtNationalNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtNationalNumber.Name = "txtNationalNumber";
            this.txtNationalNumber.Size = new System.Drawing.Size(248, 43);
            this.txtNationalNumber.TabIndex = 162;
            this.txtNationalNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.White;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentName.ForeColor = System.Drawing.Color.Gray;
            this.lblStudentName.Location = new System.Drawing.Point(6, 30);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(41, 23);
            this.lblStudentName.TabIndex = 169;
            this.lblStudentName.Text = "İsim";
            // 
            // cmbPlaceofBirth
            // 
            this.cmbPlaceofBirth.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlaceofBirth.FormattingEnabled = true;
            this.cmbPlaceofBirth.ItemHeight = 20;
            this.cmbPlaceofBirth.Location = new System.Drawing.Point(838, 74);
            this.cmbPlaceofBirth.Name = "cmbPlaceofBirth";
            this.cmbPlaceofBirth.Size = new System.Drawing.Size(216, 28);
            this.cmbPlaceofBirth.TabIndex = 165;
            this.cmbPlaceofBirth.Text = "Doğum Yeriniz Seçiniz";
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
            this.txtStudentSurname.Location = new System.Drawing.Point(278, 75);
            this.txtStudentSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(248, 43);
            this.txtStudentSurname.TabIndex = 161;
            this.txtStudentSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.BackColor = System.Drawing.Color.White;
            this.radioFemale.ForeColor = System.Drawing.Color.Black;
            this.radioFemale.Location = new System.Drawing.Point(1455, 74);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(65, 21);
            this.radioFemale.TabIndex = 164;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Kadın";
            this.radioFemale.UseVisualStyleBackColor = false;
            // 
            // lblStudentSurname
            // 
            this.lblStudentSurname.AutoSize = true;
            this.lblStudentSurname.BackColor = System.Drawing.Color.White;
            this.lblStudentSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentSurname.ForeColor = System.Drawing.Color.Gray;
            this.lblStudentSurname.Location = new System.Drawing.Point(274, 30);
            this.lblStudentSurname.Name = "lblStudentSurname";
            this.lblStudentSurname.Size = new System.Drawing.Size(68, 23);
            this.lblStudentSurname.TabIndex = 166;
            this.lblStudentSurname.Text = "Soyisim";
            // 
            // lblNationalNumber
            // 
            this.lblNationalNumber.AutoSize = true;
            this.lblNationalNumber.BackColor = System.Drawing.Color.White;
            this.lblNationalNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNationalNumber.ForeColor = System.Drawing.Color.Gray;
            this.lblNationalNumber.Location = new System.Drawing.Point(558, 30);
            this.lblNationalNumber.Name = "lblNationalNumber";
            this.lblNationalNumber.Size = new System.Drawing.Size(161, 23);
            this.lblNationalNumber.TabIndex = 168;
            this.lblNationalNumber.Text = "T.C Kimlik Numarası";
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.BackColor = System.Drawing.Color.White;
            this.radioMale.ForeColor = System.Drawing.Color.Black;
            this.radioMale.Location = new System.Drawing.Point(1370, 74);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(65, 21);
            this.radioMale.TabIndex = 163;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Erkek";
            this.radioMale.UseVisualStyleBackColor = false;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.BackColor = System.Drawing.Color.White;
            this.lblBirthdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirthdate.ForeColor = System.Drawing.Color.Gray;
            this.lblBirthdate.Location = new System.Drawing.Point(1086, 30);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(112, 23);
            this.lblBirthdate.TabIndex = 150;
            this.lblBirthdate.Text = "Doğum Tarihi";
            // 
            // lblPlaceofBirth
            // 
            this.lblPlaceofBirth.AutoSize = true;
            this.lblPlaceofBirth.BackColor = System.Drawing.Color.White;
            this.lblPlaceofBirth.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlaceofBirth.ForeColor = System.Drawing.Color.Gray;
            this.lblPlaceofBirth.Location = new System.Drawing.Point(834, 30);
            this.lblPlaceofBirth.Name = "lblPlaceofBirth";
            this.lblPlaceofBirth.Size = new System.Drawing.Size(99, 23);
            this.lblPlaceofBirth.TabIndex = 170;
            this.lblPlaceofBirth.Text = "Doğum Yeri";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.White;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGender.ForeColor = System.Drawing.Color.Gray;
            this.lblGender.Location = new System.Drawing.Point(1366, 30);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(70, 23);
            this.lblGender.TabIndex = 169;
            this.lblGender.Text = "Cinsiyet";
            // 
            // dpcBirthdate
            // 
            this.dpcBirthdate.BackColor = System.Drawing.Color.SeaGreen;
            this.dpcBirthdate.BorderRadius = 0;
            this.dpcBirthdate.ForeColor = System.Drawing.Color.White;
            this.dpcBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpcBirthdate.FormatCustom = null;
            this.dpcBirthdate.Location = new System.Drawing.Point(1090, 74);
            this.dpcBirthdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpcBirthdate.Name = "dpcBirthdate";
            this.dpcBirthdate.Size = new System.Drawing.Size(240, 33);
            this.dpcBirthdate.TabIndex = 133;
            this.dpcBirthdate.Value = new System.DateTime(2019, 3, 13, 22, 54, 58, 99);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(9, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 165;
            this.label1.Text = "Aranacak T.C";
            // 
            // dgwStudentRegulation
            // 
            this.dgwStudentRegulation.AllowUserToAddRows = false;
            this.dgwStudentRegulation.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgwStudentRegulation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwStudentRegulation.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgwStudentRegulation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwStudentRegulation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwStudentRegulation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwStudentRegulation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudentRegulation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgwStudentRegulation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwStudentRegulation.DoubleBuffered = true;
            this.dgwStudentRegulation.EnableHeadersVisualStyles = false;
            this.dgwStudentRegulation.HeaderBgColor = System.Drawing.Color.SeaShell;
            this.dgwStudentRegulation.HeaderForeColor = System.Drawing.Color.SlateBlue;
            this.dgwStudentRegulation.Location = new System.Drawing.Point(3, 458);
            this.dgwStudentRegulation.Name = "dgwStudentRegulation";
            this.dgwStudentRegulation.ReadOnly = true;
            this.dgwStudentRegulation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwStudentRegulation.RowHeadersVisible = false;
            this.dgwStudentRegulation.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dgwStudentRegulation.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
            this.dgwStudentRegulation.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgwStudentRegulation.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgwStudentRegulation.RowTemplate.Height = 24;
            this.dgwStudentRegulation.Size = new System.Drawing.Size(2029, 494);
            this.dgwStudentRegulation.TabIndex = 164;
            this.dgwStudentRegulation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStudentRegulation_CellClick);
            // 
            // txtSearchByNationalNumber
            // 
            this.txtSearchByNationalNumber.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSearchByNationalNumber.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchByNationalNumber.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtSearchByNationalNumber.BorderThickness = 2;
            this.txtSearchByNationalNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchByNationalNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearchByNationalNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchByNationalNumber.isPassword = false;
            this.txtSearchByNationalNumber.Location = new System.Drawing.Point(146, 423);
            this.txtSearchByNationalNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchByNationalNumber.Name = "txtSearchByNationalNumber";
            this.txtSearchByNationalNumber.Size = new System.Drawing.Size(248, 44);
            this.txtSearchByNationalNumber.TabIndex = 163;
            this.txtSearchByNationalNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchByNationalNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchByNationalNumber_KeyPress);
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
            this.StudentDebt.HeaderText = "Kayıt Ücreti";
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
            // ucStudentRegulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gpbStudentRegulation);
            this.Name = "UcStudentRegulation";
            this.Size = new System.Drawing.Size(2035, 955);
            this.Load += new System.EventHandler(this.ucStudentRegulation_Load);
            this.gpbStudentRegulation.ResumeLayout(false);
            this.gpbStudentRegulation.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentRegulation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbStudentRegulation;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSearchByNationalNumber;
        private Bunifu.Framework.UI.BunifuImageButton btnDelete;
        private Bunifu.Framework.UI.BunifuImageButton btnUpdate;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtIbanNumber;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtRegistrationDebt;
        private Bunifu.Framework.UI.BunifuDatepicker dpcRegistrationDate;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPhoneNumber;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuDatepicker dpcBirthdate;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAdress;
        private System.Windows.Forms.Label lblHaveLicenceType;
        private System.Windows.Forms.ComboBox cmbHaveLicenceType;
        private System.Windows.Forms.CheckBox checkHaveLicence;
        private System.Windows.Forms.ComboBox cmbQuantityInstallment;
        private System.Windows.Forms.Label lblIbanNumber;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblQuantityInstallment;
        private System.Windows.Forms.Label lblRegistrationDebt;
        private System.Windows.Forms.Label lblRegistrationDate;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblEmail;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgwStudentRegulation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbLicenceType;
        private System.Windows.Forms.Label lblLicenceType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbRegistrationSeason;
        private System.Windows.Forms.Label lblRegistrationSeason;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStudentName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNationalNumber;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.ComboBox cmbPlaceofBirth;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStudentSurname;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.Label lblStudentSurname;
        private System.Windows.Forms.Label lblNationalNumber;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.Label lblPlaceofBirth;
        private System.Windows.Forms.Label lblGender;
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
    }
}
