﻿using System;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using SurucuKursuOtomasyonu.FormsUI.UserControllers;

namespace SurucuKursuOtomasyonu.FormsUI
{
    public partial class MenuPage : Form
    {
        private bool _menuExpanded;

        public MenuPage()
        {
            InitializeComponent();
        }

        private void texthide(BunifuFlatButton bunifu)
        {
            bunifu.Text = "";
        }

        private void textShow()
        {
            btnStudentRegister.Text = @"Kayıt";
            btnStudentSearch.Text = @"       Sorgulama";
            btnStudentRegulation.Text = @"      Düzenleme";
            btnStudentDebt.Text = @"Ödeme";
            btnBankData.Text = @"         Banka Bilgileri";
            btnDebtInformation.Text = @"       Bilgilendirme";
            //   MessageBox.Show(dizi.Length.ToString());
        }

        private void MouseDetecter_Tick(object sender, EventArgs e)
        {
            /*  if (bunifuTransition1.IsCompleted) return;
              {
                 
              }*/
            if (panelMainMenu.ClientRectangle.Contains(PointToClient(MousePosition)))
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
                    panelMainMenu.Visible = false;
                    panelMainMenu.Width = 95;
                    bunifuTransition1.Show(panelMainMenu);
                }
            }
        }


        private void btnStudentRegister_Click(object sender, EventArgs e)
        {
            if (!panelMainPage.Controls.Contains(UcStudentRecord.InstanceStudentRecord))
            {
                panelMainPage.Controls.Add(UcStudentRecord.InstanceStudentRecord);
                UcStudentRecord.InstanceStudentRecord.Dock = DockStyle.Fill;

                UcStudentRecord.InstanceStudentRecord.BringToFront();
            }
            else
            {
                UcStudentRecord.InstanceStudentRecord.BringToFront();
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
            if (!panelMainPage.Controls.Contains(UcStudentSearch.InstanceStudentSearch))
            {
                panelMainPage.Controls.Add(UcStudentSearch.InstanceStudentSearch);
                UcStudentSearch.InstanceStudentSearch.Dock = DockStyle.Fill;

                UcStudentSearch.InstanceStudentSearch.Refresh();
                UcStudentSearch.InstanceStudentSearch.BringToFront();
            }
            else
            {
                UcStudentSearch.InstanceStudentSearch.BringToFront();
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

        private void btnDebtInformation_Click(object sender, EventArgs e)
        {
            if (!panelMainMenu.Controls.Contains(UcDebtInformation.InstanceDebtInformation))
            {
                panelMainPage.Controls.Add(UcDebtInformation.InstanceDebtInformation);
                UcDebtInformation.InstanceDebtInformation.Dock = DockStyle.Fill;
                UcDebtInformation.InstanceDebtInformation.BringToFront();
            }
            else
            {
                UcDebtInformation.InstanceDebtInformation.BringToFront();
            }
        }

        private void btnBankData_Click(object sender, EventArgs e)
        {
        }
    }
}