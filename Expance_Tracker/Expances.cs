using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Expance_Tracker
{
    public partial class Expanses : Form
    {
        public Expanses()
        {
            InitializeComponent();
             
        }
        private void movePanal(Control btn)
        {
            SlidePanel.Width = btn.Width;
            SlidePanel.Left = btn.Left;
        }
        private void ManageExpButton_Click(object sender, EventArgs e)
        {
            movePanal(ManageExpButton);
            ShowSubMenu(panel2);
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            movePanal(ReportButton);
            HideSubMenu();
            ReportForm ReportF = new ReportForm();
            ReportF.ShowDialog();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            movePanal(AboutButton);
            HideSubMenu();
            AboutForm AboutF = new AboutForm();
            AboutF.ShowDialog();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            movePanal(ExitButton);
            HideSubMenu();
            Application.Exit();
        }
        private void HideSubMenu()
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
        }
        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }
        private void ExpanseButton_Click_1(object sender, EventArgs e)
        {
            movePanal(ExpanseButton);
            ShowSubMenu(panel1);
        }
        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            AddRecordForm addformrecord = new AddRecordForm();
            addformrecord.ShowDialog();
        }

        private void TopExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Form Satate
        bool Form_State = true;
        //
        private void TopExpandButton_Click(object sender, EventArgs e)
        {
            if (Form_State)
            {
                this.WindowState = FormWindowState.Maximized;
                Form_State = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                Form_State = true;
            }
        }
        private void TopMinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void UpdateRecordButton_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            UpdateRecordForm UpdateFrom = new UpdateRecordForm();
            UpdateFrom.ShowDialog();
        }
        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            UpdateRecordForm update = new UpdateRecordForm();
            update.ShowDialog();
        }

        private void ExpListButton_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ExpListForm ExpListform = new ExpListForm();
            ExpListform.ShowDialog();
        }

        private void ViewChartButton_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ViewChartForm startist = new ViewChartForm();
            startist.ShowDialog();
        }

        private void Expanses_Load(object sender, EventArgs e)
        {

        }
    }
}
