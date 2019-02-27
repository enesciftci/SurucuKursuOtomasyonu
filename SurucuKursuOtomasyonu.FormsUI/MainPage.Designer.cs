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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panelMainPage = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnStudentRecord = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnStudentSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnStudentRegulation = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStudentRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStudentSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStudentRegulation)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainPage
            // 
            this.panelMainPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainPage.Location = new System.Drawing.Point(206, 0);
            this.panelMainPage.Name = "panelMainPage";
            this.panelMainPage.Size = new System.Drawing.Size(1341, 585);
            this.panelMainPage.TabIndex = 5;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnStudentRegulation);
            this.panelMenu.Controls.Add(this.bunifuImageButton5);
            this.panelMenu.Controls.Add(this.bunifuImageButton4);
            this.panelMenu.Controls.Add(this.bunifuImageButton3);
            this.panelMenu.Controls.Add(this.btnStudentSearch);
            this.panelMenu.Controls.Add(this.btnStudentRecord);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 585);
            this.panelMenu.TabIndex = 7;
            // 
            // btnStudentRecord
            // 
            this.btnStudentRecord.BackColor = System.Drawing.Color.White;
            this.btnStudentRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentRecord.Image")));
            this.btnStudentRecord.ImageActive = null;
            this.btnStudentRecord.Location = new System.Drawing.Point(0, 0);
            this.btnStudentRecord.Name = "btnStudentRecord";
            this.btnStudentRecord.Size = new System.Drawing.Size(200, 84);
            this.btnStudentRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStudentRecord.TabIndex = 0;
            this.btnStudentRecord.TabStop = false;
            this.btnStudentRecord.Zoom = 20;
            this.btnStudentRecord.Click += new System.EventHandler(this.btnStudentRecord_Click);
            // 
            // btnStudentSearch
            // 
            this.btnStudentSearch.BackColor = System.Drawing.Color.White;
            this.btnStudentSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentSearch.Image")));
            this.btnStudentSearch.ImageActive = null;
            this.btnStudentSearch.Location = new System.Drawing.Point(0, 84);
            this.btnStudentSearch.Name = "btnStudentSearch";
            this.btnStudentSearch.Size = new System.Drawing.Size(200, 84);
            this.btnStudentSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStudentSearch.TabIndex = 1;
            this.btnStudentSearch.TabStop = false;
            this.btnStudentSearch.Zoom = 20;
            this.btnStudentSearch.Click += new System.EventHandler(this.btnStudentSearch_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(0, 501);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(200, 84);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 2;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 20;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(0, 418);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(200, 83);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 3;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 20;
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(0, 335);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(200, 83);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 4;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 20;
            // 
            // btnStudentRegulation
            // 
            this.btnStudentRegulation.BackColor = System.Drawing.Color.White;
            this.btnStudentRegulation.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStudentRegulation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentRegulation.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentRegulation.Image")));
            this.btnStudentRegulation.ImageActive = null;
            this.btnStudentRegulation.Location = new System.Drawing.Point(0, 168);
            this.btnStudentRegulation.Name = "btnStudentRegulation";
            this.btnStudentRegulation.Size = new System.Drawing.Size(200, 84);
            this.btnStudentRegulation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStudentRegulation.TabIndex = 6;
            this.btnStudentRegulation.TabStop = false;
            this.btnStudentRegulation.Zoom = 20;
            this.btnStudentRegulation.Click += new System.EventHandler(this.btnStudentRegulation_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1547, 585);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelMainPage);
            this.Name = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.SizeChanged += new System.EventHandler(this.MainPage_SizeChanged);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnStudentRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStudentSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStudentRegulation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMainPage;
        private System.Windows.Forms.Panel panelMenu;
        private Bunifu.Framework.UI.BunifuImageButton btnStudentRegulation;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton btnStudentSearch;
        private Bunifu.Framework.UI.BunifuImageButton btnStudentRecord;
    }
}

