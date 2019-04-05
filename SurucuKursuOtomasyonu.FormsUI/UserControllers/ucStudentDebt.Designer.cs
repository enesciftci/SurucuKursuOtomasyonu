namespace SurucuKursuOtomasyonu.FormsUI.UserControllers
{
    partial class UcStudentDebt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcStudentDebt));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelDgw = new System.Windows.Forms.Panel();
            this.dgwStudentDebt = new Bunifu.Framework.UI.BunifuCustomDataGrid();
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
            this.panelTxts = new System.Windows.Forms.Panel();
            this.btnPrint = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtMustPaidAmount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExportPdf = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentId = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtStudentNameSurname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemainingInstallment = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtRemainingDebt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txtPaidAmount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtNationalNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblNationalNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPay = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1.SuspendLayout();
            this.panelDgw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentDebt)).BeginInit();
            this.panelTxts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportPdf)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.panelDgw);
            this.groupBox1.Controls.Add(this.panelTxts);
            this.groupBox1.Controls.Add(this.panelSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1400, 900);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Borç Ödeme";
            // 
            // panelDgw
            // 
            this.panelDgw.Controls.Add(this.dgwStudentDebt);
            this.panelDgw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDgw.Location = new System.Drawing.Point(3, 331);
            this.panelDgw.Name = "panelDgw";
            this.panelDgw.Size = new System.Drawing.Size(1394, 566);
            this.panelDgw.TabIndex = 179;
            // 
            // dgwStudentDebt
            // 
            this.dgwStudentDebt.AllowUserToAddRows = false;
            this.dgwStudentDebt.AllowUserToDeleteRows = false;
            this.dgwStudentDebt.AllowUserToResizeColumns = false;
            this.dgwStudentDebt.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgwStudentDebt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwStudentDebt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwStudentDebt.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgwStudentDebt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwStudentDebt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwStudentDebt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwStudentDebt.ColumnHeadersHeight = 55;
            this.dgwStudentDebt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwStudentDebt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.StudentSurname,
            this.StudentNationalNumber,
            this.RegistrationDate,
            this.StudentDebt,
            this.StudentTotalDebt,
            this.QuantityInstallment,
            this.StudentIbanNumber,
            this.StudentWantLicenceType});
            this.dgwStudentDebt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwStudentDebt.DoubleBuffered = true;
            this.dgwStudentDebt.EnableHeadersVisualStyles = false;
            this.dgwStudentDebt.GridColor = System.Drawing.Color.SeaShell;
            this.dgwStudentDebt.HeaderBgColor = System.Drawing.Color.SeaShell;
            this.dgwStudentDebt.HeaderForeColor = System.Drawing.Color.SlateBlue;
            this.dgwStudentDebt.Location = new System.Drawing.Point(0, 0);
            this.dgwStudentDebt.MultiSelect = false;
            this.dgwStudentDebt.Name = "dgwStudentDebt";
            this.dgwStudentDebt.ReadOnly = true;
            this.dgwStudentDebt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwStudentDebt.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwStudentDebt.RowHeadersVisible = false;
            this.dgwStudentDebt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwStudentDebt.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dgwStudentDebt.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
            this.dgwStudentDebt.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgwStudentDebt.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgwStudentDebt.RowTemplate.Height = 24;
            this.dgwStudentDebt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgwStudentDebt.Size = new System.Drawing.Size(1394, 566);
            this.dgwStudentDebt.TabIndex = 167;
            this.dgwStudentDebt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStudentDebt_CellClick);
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
            // panelTxts
            // 
            this.panelTxts.Controls.Add(this.btnPrint);
            this.panelTxts.Controls.Add(this.txtMustPaidAmount);
            this.panelTxts.Controls.Add(this.label4);
            this.panelTxts.Controls.Add(this.btnExportPdf);
            this.panelTxts.Controls.Add(this.label2);
            this.panelTxts.Controls.Add(this.txtStudentId);
            this.panelTxts.Controls.Add(this.txtStudentNameSurname);
            this.panelTxts.Controls.Add(this.label6);
            this.panelTxts.Controls.Add(this.label3);
            this.panelTxts.Controls.Add(this.txtRemainingInstallment);
            this.panelTxts.Controls.Add(this.txtRemainingDebt);
            this.panelTxts.Controls.Add(this.label5);
            this.panelTxts.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTxts.Location = new System.Drawing.Point(3, 118);
            this.panelTxts.Name = "panelTxts";
            this.panelTxts.Size = new System.Drawing.Size(1394, 213);
            this.panelTxts.TabIndex = 178;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.ErrorImage = null;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageActive = null;
            this.btnPrint.InitialImage = null;
            this.btnPrint.Location = new System.Drawing.Point(1295, 105);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(87, 78);
            this.btnPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrint.TabIndex = 169;
            this.btnPrint.TabStop = false;
            this.btnPrint.Zoom = 10;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtMustPaidAmount
            // 
            this.txtMustPaidAmount.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtMustPaidAmount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMustPaidAmount.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtMustPaidAmount.BorderThickness = 1;
            this.txtMustPaidAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMustPaidAmount.Enabled = false;
            this.txtMustPaidAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMustPaidAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMustPaidAmount.isPassword = false;
            this.txtMustPaidAmount.Location = new System.Drawing.Point(582, 45);
            this.txtMustPaidAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtMustPaidAmount.Name = "txtMustPaidAmount";
            this.txtMustPaidAmount.Size = new System.Drawing.Size(248, 43);
            this.txtMustPaidAmount.TabIndex = 157;
            this.txtMustPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 23);
            this.label4.TabIndex = 177;
            this.label4.Text = "Öğrenci Numarası";
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.BackColor = System.Drawing.Color.Transparent;
            this.btnExportPdf.ErrorImage = null;
            this.btnExportPdf.Image = ((System.Drawing.Image)(resources.GetObject("btnExportPdf.Image")));
            this.btnExportPdf.ImageActive = null;
            this.btnExportPdf.InitialImage = null;
            this.btnExportPdf.Location = new System.Drawing.Point(1149, 105);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(87, 78);
            this.btnExportPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExportPdf.TabIndex = 168;
            this.btnExportPdf.TabStop = false;
            this.btnExportPdf.Zoom = 10;
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(578, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 23);
            this.label2.TabIndex = 158;
            this.label2.Text = "Ödenmesi Gereken Miktar";
            // 
            // txtStudentId
            // 
            this.txtStudentId.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtStudentId.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStudentId.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtStudentId.BorderThickness = 1;
            this.txtStudentId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentId.Enabled = false;
            this.txtStudentId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStudentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStudentId.isPassword = false;
            this.txtStudentId.Location = new System.Drawing.Point(10, 45);
            this.txtStudentId.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(248, 43);
            this.txtStudentId.TabIndex = 176;
            this.txtStudentId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtStudentNameSurname
            // 
            this.txtStudentNameSurname.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtStudentNameSurname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStudentNameSurname.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtStudentNameSurname.BorderThickness = 1;
            this.txtStudentNameSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentNameSurname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStudentNameSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStudentNameSurname.isPassword = false;
            this.txtStudentNameSurname.Location = new System.Drawing.Point(297, 45);
            this.txtStudentNameSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentNameSurname.Name = "txtStudentNameSurname";
            this.txtStudentNameSurname.Size = new System.Drawing.Size(248, 43);
            this.txtStudentNameSurname.TabIndex = 168;
            this.txtStudentNameSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(869, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 23);
            this.label6.TabIndex = 175;
            this.label6.Text = "Kalan Borç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(293, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 169;
            this.label3.Text = "Öğrenci Ad Soyad";
            // 
            // txtRemainingInstallment
            // 
            this.txtRemainingInstallment.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtRemainingInstallment.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRemainingInstallment.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtRemainingInstallment.BorderThickness = 1;
            this.txtRemainingInstallment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemainingInstallment.Enabled = false;
            this.txtRemainingInstallment.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRemainingInstallment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRemainingInstallment.isPassword = false;
            this.txtRemainingInstallment.Location = new System.Drawing.Point(1149, 45);
            this.txtRemainingInstallment.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemainingInstallment.Name = "txtRemainingInstallment";
            this.txtRemainingInstallment.Size = new System.Drawing.Size(248, 43);
            this.txtRemainingInstallment.TabIndex = 172;
            this.txtRemainingInstallment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtRemainingDebt
            // 
            this.txtRemainingDebt.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtRemainingDebt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRemainingDebt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtRemainingDebt.BorderThickness = 1;
            this.txtRemainingDebt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemainingDebt.Enabled = false;
            this.txtRemainingDebt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRemainingDebt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRemainingDebt.isPassword = false;
            this.txtRemainingDebt.Location = new System.Drawing.Point(873, 45);
            this.txtRemainingDebt.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemainingDebt.Name = "txtRemainingDebt";
            this.txtRemainingDebt.Size = new System.Drawing.Size(248, 43);
            this.txtRemainingDebt.TabIndex = 174;
            this.txtRemainingDebt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(1145, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 173;
            this.label5.Text = "Kalan Taksit";
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.txtPaidAmount);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.txtNationalNumber);
            this.panelSearch.Controls.Add(this.lblNationalNumber);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Controls.Add(this.btnPay);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(3, 18);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1394, 100);
            this.panelSearch.TabIndex = 167;
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPaidAmount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPaidAmount.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPaidAmount.BorderThickness = 2;
            this.txtPaidAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaidAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPaidAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPaidAmount.isPassword = false;
            this.txtPaidAmount.Location = new System.Drawing.Point(575, 51);
            this.txtPaidAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(248, 43);
            this.txtPaidAmount.TabIndex = 155;
            this.txtPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaidAmount_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.ErrorImage = null;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageActive = null;
            this.btnSearch.InitialImage = null;
            this.btnSearch.Location = new System.Drawing.Point(297, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 78);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 160;
            this.btnSearch.TabStop = false;
            this.btnSearch.Zoom = 10;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.txtNationalNumber.Location = new System.Drawing.Point(13, 51);
            this.txtNationalNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtNationalNumber.Name = "txtNationalNumber";
            this.txtNationalNumber.Size = new System.Drawing.Size(248, 43);
            this.txtNationalNumber.TabIndex = 154;
            this.txtNationalNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNationalNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationalNumber_KeyPress);
            // 
            // lblNationalNumber
            // 
            this.lblNationalNumber.AutoSize = true;
            this.lblNationalNumber.BackColor = System.Drawing.SystemColors.Control;
            this.lblNationalNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNationalNumber.ForeColor = System.Drawing.Color.Gray;
            this.lblNationalNumber.Location = new System.Drawing.Point(9, 16);
            this.lblNationalNumber.Name = "lblNationalNumber";
            this.lblNationalNumber.Size = new System.Drawing.Size(161, 23);
            this.lblNationalNumber.TabIndex = 153;
            this.lblNationalNumber.Text = "T.C Kimlik Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(571, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 156;
            this.label1.Text = "Ödenen Miktar";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.ErrorImage = null;
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageActive = null;
            this.btnPay.InitialImage = null;
            this.btnPay.Location = new System.Drawing.Point(873, 22);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(87, 78);
            this.btnPay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPay.TabIndex = 159;
            this.btnPay.TabStop = false;
            this.btnPay.Zoom = 10;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // UcStudentDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UcStudentDebt";
            this.Size = new System.Drawing.Size(1400, 900);
            this.Load += new System.EventHandler(this.UcStudentDebt_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UcStudentDebt_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.panelDgw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentDebt)).EndInit();
            this.panelTxts.ResumeLayout(false);
            this.panelTxts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportPdf)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelSearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPaidAmount;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNationalNumber;
        private System.Windows.Forms.Label lblNationalNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMustPaidAmount;
        private Bunifu.Framework.UI.BunifuImageButton btnPay;
        private Bunifu.Framework.UI.BunifuImageButton btnSearch;
        private Bunifu.Framework.UI.BunifuImageButton btnPrint;
        private Bunifu.Framework.UI.BunifuImageButton btnExportPdf;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStudentNameSurname;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStudentId;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtRemainingDebt;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtRemainingInstallment;
        private System.Windows.Forms.Panel panelDgw;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgwStudentDebt;
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
        private System.Windows.Forms.Panel panelTxts;
    }
}
