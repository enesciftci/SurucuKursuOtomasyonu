namespace SurucuKursuOtomasyonu.FormsUI
{
    partial class MainPage
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbRegistrationSeason = new MetroFramework.Controls.MetroComboBox();
            this.lblRegistrationSeason = new System.Windows.Forms.Label();
            this.dgwStudents = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolstripStudentOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripStudentRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripStudentSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.maliİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciBorcSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciBankaBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeHatırlatmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbStudentSearch = new System.Windows.Forms.GroupBox();
            this.maskedtxtStudentNationalNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolstripStudentRegulation = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gpbStudentSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbRegistrationSeason
            // 
            this.cmbRegistrationSeason.FormattingEnabled = true;
            this.cmbRegistrationSeason.ItemHeight = 24;
            this.cmbRegistrationSeason.Location = new System.Drawing.Point(122, 26);
            this.cmbRegistrationSeason.Name = "cmbRegistrationSeason";
            this.cmbRegistrationSeason.Size = new System.Drawing.Size(177, 30);
            this.cmbRegistrationSeason.TabIndex = 1;
            this.cmbRegistrationSeason.UseSelectable = true;
            // 
            // lblRegistrationSeason
            // 
            this.lblRegistrationSeason.AutoSize = true;
            this.lblRegistrationSeason.Location = new System.Drawing.Point(6, 30);
            this.lblRegistrationSeason.Name = "lblRegistrationSeason";
            this.lblRegistrationSeason.Size = new System.Drawing.Size(98, 17);
            this.lblRegistrationSeason.TabIndex = 2;
            this.lblRegistrationSeason.Text = "Eğitim Sezonu";
            // 
            // dgwStudents
            // 
            this.dgwStudents.AllowUserToAddRows = false;
            this.dgwStudents.AllowUserToDeleteRows = false;
            this.dgwStudents.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgwStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudents.GridColor = System.Drawing.Color.Maroon;
            this.dgwStudents.Location = new System.Drawing.Point(6, 62);
            this.dgwStudents.Name = "dgwStudents";
            this.dgwStudents.ReadOnly = true;
            this.dgwStudents.RowTemplate.Height = 24;
            this.dgwStudents.Size = new System.Drawing.Size(1511, 399);
            this.dgwStudents.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripStudentOperations,
            this.maliİşlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1547, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolstripStudentOperations
            // 
            this.toolstripStudentOperations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripStudentRecord,
            this.toolstripStudentSearch,
            this.toolstripStudentRegulation});
            this.toolstripStudentOperations.Name = "toolstripStudentOperations";
            this.toolstripStudentOperations.Size = new System.Drawing.Size(133, 24);
            this.toolstripStudentOperations.Text = "Öğrenci İşlemleri";
            // 
            // toolstripStudentRecord
            // 
            this.toolstripStudentRecord.Name = "toolstripStudentRecord";
            this.toolstripStudentRecord.Size = new System.Drawing.Size(216, 26);
            this.toolstripStudentRecord.Text = "Öğrenci Kayıt";
            this.toolstripStudentRecord.Click += new System.EventHandler(this.toolstripStudentRecord_Click);
            // 
            // toolstripStudentSearch
            // 
            this.toolstripStudentSearch.Name = "toolstripStudentSearch";
            this.toolstripStudentSearch.Size = new System.Drawing.Size(216, 26);
            this.toolstripStudentSearch.Text = "Öğrenci Sorgulama";
            // 
            // maliİşlemlerToolStripMenuItem
            // 
            this.maliİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciBorcSorgulamaToolStripMenuItem,
            this.öğrenciBankaBilgileriToolStripMenuItem,
            this.ödemeHatırlatmaToolStripMenuItem});
            this.maliİşlemlerToolStripMenuItem.Name = "maliİşlemlerToolStripMenuItem";
            this.maliİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.maliİşlemlerToolStripMenuItem.Text = "Mali İşlemler";
            // 
            // öğrenciBorcSorgulamaToolStripMenuItem
            // 
            this.öğrenciBorcSorgulamaToolStripMenuItem.Name = "öğrenciBorcSorgulamaToolStripMenuItem";
            this.öğrenciBorcSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.öğrenciBorcSorgulamaToolStripMenuItem.Text = "Öğrenci Borç Sorgulama";
            // 
            // öğrenciBankaBilgileriToolStripMenuItem
            // 
            this.öğrenciBankaBilgileriToolStripMenuItem.Name = "öğrenciBankaBilgileriToolStripMenuItem";
            this.öğrenciBankaBilgileriToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.öğrenciBankaBilgileriToolStripMenuItem.Text = "Öğrenci Banka Bilgileri";
            // 
            // ödemeHatırlatmaToolStripMenuItem
            // 
            this.ödemeHatırlatmaToolStripMenuItem.Name = "ödemeHatırlatmaToolStripMenuItem";
            this.ödemeHatırlatmaToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.ödemeHatırlatmaToolStripMenuItem.Text = "Ödeme Hatırlatma";
            // 
            // gpbStudentSearch
            // 
            this.gpbStudentSearch.Controls.Add(this.maskedtxtStudentNationalNumber);
            this.gpbStudentSearch.Controls.Add(this.txtStudentName);
            this.gpbStudentSearch.Controls.Add(this.lblStudentName);
            this.gpbStudentSearch.Controls.Add(this.label2);
            this.gpbStudentSearch.Controls.Add(this.cmbRegistrationSeason);
            this.gpbStudentSearch.Controls.Add(this.lblRegistrationSeason);
            this.gpbStudentSearch.Controls.Add(this.dgwStudents);
            this.gpbStudentSearch.Location = new System.Drawing.Point(12, 32);
            this.gpbStudentSearch.Name = "gpbStudentSearch";
            this.gpbStudentSearch.Size = new System.Drawing.Size(1523, 467);
            this.gpbStudentSearch.TabIndex = 6;
            this.gpbStudentSearch.TabStop = false;
            this.gpbStudentSearch.Text = "Öğrenci Sorgulama";
            // 
            // maskedtxtStudentNationalNumber
            // 
            this.maskedtxtStudentNationalNumber.Location = new System.Drawing.Point(516, 26);
            this.maskedtxtStudentNationalNumber.Mask = "00000000000";
            this.maskedtxtStudentNationalNumber.Name = "maskedtxtStudentNationalNumber";
            this.maskedtxtStudentNationalNumber.Size = new System.Drawing.Size(156, 22);
            this.maskedtxtStudentNationalNumber.TabIndex = 8;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(857, 26);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(156, 22);
            this.txtStudentName.TabIndex = 7;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(759, 29);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(82, 17);
            this.lblStudentName.TabIndex = 6;
            this.lblStudentName.Text = "Öğrenci Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "T.C Kimlik Numarası";
            // 
            // toolstripStudentRegulation
            // 
            this.toolstripStudentRegulation.Name = "toolstripStudentRegulation";
            this.toolstripStudentRegulation.Size = new System.Drawing.Size(216, 26);
            this.toolstripStudentRegulation.Text = "Öğrenci Düzenleme";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1547, 585);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gpbStudentSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpbStudentSearch.ResumeLayout(false);
            this.gpbStudentSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cmbRegistrationSeason;
        private System.Windows.Forms.Label lblRegistrationSeason;
        private System.Windows.Forms.DataGridView dgwStudents;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolstripStudentOperations;
        private System.Windows.Forms.ToolStripMenuItem toolstripStudentRecord;
        private System.Windows.Forms.ToolStripMenuItem toolstripStudentSearch;
        private System.Windows.Forms.ToolStripMenuItem maliİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciBorcSorgulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciBankaBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeHatırlatmaToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpbStudentSearch;
        private System.Windows.Forms.MaskedTextBox maskedtxtStudentNationalNumber;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem toolstripStudentRegulation;
    }
}

