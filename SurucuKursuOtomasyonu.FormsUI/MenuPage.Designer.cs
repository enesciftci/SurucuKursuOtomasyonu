namespace SurucuKursuOtomasyonu.FormsUI
{
    partial class MenuPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPage));
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.btnDebtInformation = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBankData = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStudentDebt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStudentRegulation = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStudentSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStudentRegister = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MouseDetecter = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelMainPage = new System.Windows.Forms.Panel();
            this.panelMainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.Black;
            this.panelMainMenu.Controls.Add(this.btnDebtInformation);
            this.panelMainMenu.Controls.Add(this.btnBankData);
            this.panelMainMenu.Controls.Add(this.btnStudentDebt);
            this.panelMainMenu.Controls.Add(this.btnStudentRegulation);
            this.panelMainMenu.Controls.Add(this.btnStudentSearch);
            this.panelMainMenu.Controls.Add(this.btnStudentRegister);
            this.panelMainMenu.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this.panelMainMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(87, 981);
            this.panelMainMenu.TabIndex = 0;
            // 
            // btnDebtInformation
            // 
            this.btnDebtInformation.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnDebtInformation.BackColor = System.Drawing.Color.Black;
            this.btnDebtInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDebtInformation.BorderRadius = 0;
            this.btnDebtInformation.ButtonText = "";
            this.btnDebtInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnDebtInformation, BunifuAnimatorNS.DecorationType.None);
            this.btnDebtInformation.DisabledColor = System.Drawing.Color.Gray;
            this.btnDebtInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDebtInformation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDebtInformation.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDebtInformation.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDebtInformation.Iconimage")));
            this.btnDebtInformation.Iconimage_right = null;
            this.btnDebtInformation.Iconimage_right_Selected = null;
            this.btnDebtInformation.Iconimage_Selected = null;
            this.btnDebtInformation.IconMarginLeft = 0;
            this.btnDebtInformation.IconMarginRight = 0;
            this.btnDebtInformation.IconRightVisible = true;
            this.btnDebtInformation.IconRightZoom = 0D;
            this.btnDebtInformation.IconVisible = true;
            this.btnDebtInformation.IconZoom = 80D;
            this.btnDebtInformation.IsTab = false;
            this.btnDebtInformation.Location = new System.Drawing.Point(0, 540);
            this.btnDebtInformation.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnDebtInformation.Name = "btnDebtInformation";
            this.btnDebtInformation.Normalcolor = System.Drawing.Color.Black;
            this.btnDebtInformation.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnDebtInformation.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDebtInformation.selected = false;
            this.btnDebtInformation.Size = new System.Drawing.Size(87, 88);
            this.btnDebtInformation.TabIndex = 5;
            this.btnDebtInformation.Tag = "5";
            this.btnDebtInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDebtInformation.Textcolor = System.Drawing.Color.White;
            this.btnDebtInformation.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebtInformation.Click += new System.EventHandler(this.btnDebtInformation_Click);
            // 
            // btnBankData
            // 
            this.btnBankData.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnBankData.BackColor = System.Drawing.Color.Black;
            this.btnBankData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBankData.BorderRadius = 0;
            this.btnBankData.ButtonText = "";
            this.btnBankData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnBankData, BunifuAnimatorNS.DecorationType.None);
            this.btnBankData.DisabledColor = System.Drawing.Color.Gray;
            this.btnBankData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBankData.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankData.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBankData.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBankData.Iconimage")));
            this.btnBankData.Iconimage_right = null;
            this.btnBankData.Iconimage_right_Selected = null;
            this.btnBankData.Iconimage_Selected = null;
            this.btnBankData.IconMarginLeft = 0;
            this.btnBankData.IconMarginRight = 0;
            this.btnBankData.IconRightVisible = true;
            this.btnBankData.IconRightZoom = 0D;
            this.btnBankData.IconVisible = true;
            this.btnBankData.IconZoom = 80D;
            this.btnBankData.IsTab = false;
            this.btnBankData.Location = new System.Drawing.Point(0, 452);
            this.btnBankData.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnBankData.Name = "btnBankData";
            this.btnBankData.Normalcolor = System.Drawing.Color.Black;
            this.btnBankData.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnBankData.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBankData.selected = false;
            this.btnBankData.Size = new System.Drawing.Size(87, 88);
            this.btnBankData.TabIndex = 4;
            this.btnBankData.Tag = "4";
            this.btnBankData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBankData.Textcolor = System.Drawing.Color.White;
            this.btnBankData.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBankData.Click += new System.EventHandler(this.btnBankData_Click);
            // 
            // btnStudentDebt
            // 
            this.btnStudentDebt.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnStudentDebt.BackColor = System.Drawing.Color.Black;
            this.btnStudentDebt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudentDebt.BorderRadius = 0;
            this.btnStudentDebt.ButtonText = "";
            this.btnStudentDebt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnStudentDebt, BunifuAnimatorNS.DecorationType.None);
            this.btnStudentDebt.DisabledColor = System.Drawing.Color.Gray;
            this.btnStudentDebt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentDebt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStudentDebt.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStudentDebt.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStudentDebt.Iconimage")));
            this.btnStudentDebt.Iconimage_right = null;
            this.btnStudentDebt.Iconimage_right_Selected = null;
            this.btnStudentDebt.Iconimage_Selected = null;
            this.btnStudentDebt.IconMarginLeft = 0;
            this.btnStudentDebt.IconMarginRight = 0;
            this.btnStudentDebt.IconRightVisible = true;
            this.btnStudentDebt.IconRightZoom = 0D;
            this.btnStudentDebt.IconVisible = true;
            this.btnStudentDebt.IconZoom = 80D;
            this.btnStudentDebt.IsTab = false;
            this.btnStudentDebt.Location = new System.Drawing.Point(0, 364);
            this.btnStudentDebt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnStudentDebt.Name = "btnStudentDebt";
            this.btnStudentDebt.Normalcolor = System.Drawing.Color.Black;
            this.btnStudentDebt.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnStudentDebt.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStudentDebt.selected = false;
            this.btnStudentDebt.Size = new System.Drawing.Size(87, 88);
            this.btnStudentDebt.TabIndex = 3;
            this.btnStudentDebt.Tag = "3";
            this.btnStudentDebt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStudentDebt.Textcolor = System.Drawing.Color.White;
            this.btnStudentDebt.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentDebt.Click += new System.EventHandler(this.btnStudentDebt_Click);
            // 
            // btnStudentRegulation
            // 
            this.btnStudentRegulation.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnStudentRegulation.BackColor = System.Drawing.Color.Black;
            this.btnStudentRegulation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudentRegulation.BorderRadius = 0;
            this.btnStudentRegulation.ButtonText = "";
            this.btnStudentRegulation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnStudentRegulation, BunifuAnimatorNS.DecorationType.None);
            this.btnStudentRegulation.DisabledColor = System.Drawing.Color.Gray;
            this.btnStudentRegulation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentRegulation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStudentRegulation.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStudentRegulation.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStudentRegulation.Iconimage")));
            this.btnStudentRegulation.Iconimage_right = null;
            this.btnStudentRegulation.Iconimage_right_Selected = null;
            this.btnStudentRegulation.Iconimage_Selected = null;
            this.btnStudentRegulation.IconMarginLeft = 0;
            this.btnStudentRegulation.IconMarginRight = 0;
            this.btnStudentRegulation.IconRightVisible = true;
            this.btnStudentRegulation.IconRightZoom = 0D;
            this.btnStudentRegulation.IconVisible = true;
            this.btnStudentRegulation.IconZoom = 80D;
            this.btnStudentRegulation.IsTab = false;
            this.btnStudentRegulation.Location = new System.Drawing.Point(0, 276);
            this.btnStudentRegulation.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnStudentRegulation.Name = "btnStudentRegulation";
            this.btnStudentRegulation.Normalcolor = System.Drawing.Color.Black;
            this.btnStudentRegulation.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnStudentRegulation.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStudentRegulation.selected = false;
            this.btnStudentRegulation.Size = new System.Drawing.Size(87, 88);
            this.btnStudentRegulation.TabIndex = 2;
            this.btnStudentRegulation.Tag = "2";
            this.btnStudentRegulation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStudentRegulation.Textcolor = System.Drawing.Color.White;
            this.btnStudentRegulation.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentRegulation.Click += new System.EventHandler(this.btnStudentRegulation_Click);
            // 
            // btnStudentSearch
            // 
            this.btnStudentSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnStudentSearch.BackColor = System.Drawing.Color.Black;
            this.btnStudentSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudentSearch.BorderRadius = 0;
            this.btnStudentSearch.ButtonText = "";
            this.btnStudentSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnStudentSearch, BunifuAnimatorNS.DecorationType.None);
            this.btnStudentSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnStudentSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStudentSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStudentSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStudentSearch.Iconimage")));
            this.btnStudentSearch.Iconimage_right = null;
            this.btnStudentSearch.Iconimage_right_Selected = null;
            this.btnStudentSearch.Iconimage_Selected = null;
            this.btnStudentSearch.IconMarginLeft = 0;
            this.btnStudentSearch.IconMarginRight = 0;
            this.btnStudentSearch.IconRightVisible = true;
            this.btnStudentSearch.IconRightZoom = 0D;
            this.btnStudentSearch.IconVisible = true;
            this.btnStudentSearch.IconZoom = 80D;
            this.btnStudentSearch.IsTab = false;
            this.btnStudentSearch.Location = new System.Drawing.Point(0, 188);
            this.btnStudentSearch.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnStudentSearch.Name = "btnStudentSearch";
            this.btnStudentSearch.Normalcolor = System.Drawing.Color.Black;
            this.btnStudentSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnStudentSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStudentSearch.selected = false;
            this.btnStudentSearch.Size = new System.Drawing.Size(87, 88);
            this.btnStudentSearch.TabIndex = 1;
            this.btnStudentSearch.Tag = "1";
            this.btnStudentSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStudentSearch.Textcolor = System.Drawing.Color.White;
            this.btnStudentSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentSearch.Click += new System.EventHandler(this.btnStudentSearch_Click);
            // 
            // btnStudentRegister
            // 
            this.btnStudentRegister.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnStudentRegister.BackColor = System.Drawing.Color.Black;
            this.btnStudentRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudentRegister.BorderRadius = 0;
            this.btnStudentRegister.ButtonText = "";
            this.btnStudentRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnStudentRegister, BunifuAnimatorNS.DecorationType.None);
            this.btnStudentRegister.DisabledColor = System.Drawing.Color.Gray;
            this.btnStudentRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStudentRegister.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStudentRegister.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStudentRegister.Iconimage")));
            this.btnStudentRegister.Iconimage_right = null;
            this.btnStudentRegister.Iconimage_right_Selected = null;
            this.btnStudentRegister.Iconimage_Selected = null;
            this.btnStudentRegister.IconMarginLeft = 0;
            this.btnStudentRegister.IconMarginRight = 0;
            this.btnStudentRegister.IconRightVisible = true;
            this.btnStudentRegister.IconRightZoom = 0D;
            this.btnStudentRegister.IconVisible = true;
            this.btnStudentRegister.IconZoom = 80D;
            this.btnStudentRegister.IsTab = false;
            this.btnStudentRegister.Location = new System.Drawing.Point(0, 100);
            this.btnStudentRegister.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnStudentRegister.Name = "btnStudentRegister";
            this.btnStudentRegister.Normalcolor = System.Drawing.Color.Black;
            this.btnStudentRegister.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnStudentRegister.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStudentRegister.selected = false;
            this.btnStudentRegister.Size = new System.Drawing.Size(87, 88);
            this.btnStudentRegister.TabIndex = 0;
            this.btnStudentRegister.Tag = "0";
            this.btnStudentRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStudentRegister.Textcolor = System.Drawing.Color.White;
            this.btnStudentRegister.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentRegister.Click += new System.EventHandler(this.btnStudentRegister_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 100);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MouseDetecter
            // 
            this.MouseDetecter.Enabled = true;
            this.MouseDetecter.Interval = 1;
            this.MouseDetecter.Tick += new System.EventHandler(this.MouseDetecter_Tick);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // panelMainPage
            // 
            this.bunifuTransition1.SetDecoration(this.panelMainPage, BunifuAnimatorNS.DecorationType.None);
            this.panelMainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainPage.Location = new System.Drawing.Point(87, 0);
            this.panelMainPage.Name = "panelMainPage";
            this.panelMainPage.Size = new System.Drawing.Size(1162, 981);
            this.panelMainPage.TabIndex = 1;
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1249, 981);
            this.Controls.Add(this.panelMainPage);
            this.Controls.Add(this.panelMainMenu);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(800, 1028);
            this.Name = "MenuPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPage_Load);
            this.SizeChanged += new System.EventHandler(this.MenuPage_SizeChanged);
            this.panelMainMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnDebtInformation;
        private Bunifu.Framework.UI.BunifuFlatButton btnBankData;
        private Bunifu.Framework.UI.BunifuFlatButton btnStudentDebt;
        private Bunifu.Framework.UI.BunifuFlatButton btnStudentRegulation;
        private Bunifu.Framework.UI.BunifuFlatButton btnStudentSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnStudentRegister;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer MouseDetecter;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Panel panelMainPage;
    }
}