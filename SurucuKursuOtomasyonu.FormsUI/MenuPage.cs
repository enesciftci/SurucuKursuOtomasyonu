﻿using Bunifu.Framework.UI;
using System;
using System.Windows.Forms;
using SurucuKursuOtomasyonu.FormsUI.UserControllers;

namespace SurucuKursuOtomasyonu.FormsUI
{
    public partial class MenuPage : Form
    {
        public MenuPage()
        {
            InitializeComponent();
            
        }

        private bool _menuExpanded = false;
    
        void texthide(BunifuFlatButton bunifu)
     {       
            bunifu.Text = "";
         
        }
      
        void textShow()
        {
          
            btnStudentRegister.Text= @"Kayıt";
            btnStudentSearch.Text=@"       Sorgulama";
            btnStudentRegulation.Text= @"      Düzenleme";
            btnStudentDebt.Text= @"Ödeme";
            btnBankData.Text= @"         Banka Bilgileri";
            btnDebtInformation.Text=@"       Bilgilendirme";
            //   MessageBox.Show(dizi.Length.ToString());

        }
     
        private void MouseDetecter_Tick(object sender, EventArgs e)
        {
           
          /*  if (bunifuTransition1.IsCompleted) return;
            {
               
            }*/
             if (panelMainMenu.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
             {
                 if (!_menuExpanded)
                 {
                     textShow();
                     _menuExpanded = true;

                     panelMainMenu.Width = 255;
                 
                 }

             }
             else
             {
                 if (_menuExpanded)
                 {
                     texthide(btnStudentRegister);
                    texthide(btnStudentSearch);
                     texthide(btnStudentRegulation);
                     texthide(btnStudentDebt);
                     texthide(btnBankData);
                     texthide(btnDebtInformation);
                    _menuExpanded = false;
                     panelMainMenu.Visible =false;
                     panelMainMenu.Width = 95;
                     bunifuTransition1.Show(panelMainMenu);
                 }
             }
        }

        private void panelMainMenu_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void panelMainMenu_MouseEnter(object sender, EventArgs e)
        {
           

        }

        private void PanelMainMenu_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void btnStudentRegister_Click(object sender, EventArgs e)
        {
            
           
            if (!panelMainPage.Controls.Contains(ucStudentRecord.InstanceStudentRecord))
            {
                panelMainPage.Controls.Add(ucStudentRecord.InstanceStudentRecord);
                ucStudentRecord.InstanceStudentRecord.Dock = DockStyle.Fill;
               
                ucStudentRecord.InstanceStudentRecord.BringToFront();
                 
             }
            else
            {
                ucStudentRecord.InstanceStudentRecord.BringToFront();

            }
           

        }

        private void MenuPage_SizeChanged(object sender, EventArgs e)
        {
           //this.Text = "Yükselik" + this.Height + "Genişlik" + this.Width;
        }

        private void MenuPage_Load(object sender, EventArgs e)
        {
           
        }

        private void btnStudentSearch_Click(object sender, EventArgs e)
        {
            if (!panelMainPage.Controls.Contains(ucStudentSearch.InstanceStudentSearch))
            {
                panelMainPage.Controls.Add(ucStudentSearch.InstanceStudentSearch);
                ucStudentSearch.InstanceStudentSearch.Dock = DockStyle.Fill;

                ucStudentSearch.InstanceStudentSearch.Refresh();
                ucStudentSearch.InstanceStudentSearch.BringToFront();

            }
            else
            {

                ucStudentSearch.InstanceStudentSearch.BringToFront();
            }
        }

        private void btnStudentRegulation_Click(object sender, EventArgs e)
        {
            if (!panelMainPage.Controls.Contains(UcStudentRegulation.InstanceStudentRegulation))
            {
                panelMainPage.Controls.Add(UcStudentRegulation.InstanceStudentRegulation);
                UcStudentRegulation.InstanceStudentRegulation.Dock = DockStyle.Fill;

                UcStudentRegulation.InstanceStudentRegulation.BringToFront();

            }
            else
            {
                UcStudentRegulation.InstanceStudentRegulation.BringToFront();

            }
        }

        private void btnStudentDebt_Click(object sender, EventArgs e)
        {
            if (!panelMainMenu.Controls.Contains(UcStudentDebt.InstanceStudentDebt))
            {
                panelMainPage.Controls.Add(UcStudentDebt.InstanceStudentDebt);
                UcStudentDebt.InstanceStudentDebt.Dock = DockStyle.Fill;
                UcStudentDebt.InstanceStudentDebt.BringToFront();
            }
            else
            {
                UcStudentDebt.InstanceStudentDebt.BringToFront();
            }
        }
    }
}
