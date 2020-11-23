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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void TopExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Form Satate
        private bool Form_State = true;
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

        //Moving Layout Variable
        private bool drag = false;
        private Point Start_Point = new Point(0, 0);
        //

        private void TaskPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            Start_Point = new Point(e.X, e.Y);
        }

        private void TaskPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - Start_Point.X, p.Y - Start_Point.Y);
            }
        }

        private void TaskPanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            AboutLabel.ForeColor = Color.LimeGreen;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            AboutLabel.ForeColor = Color.DarkRed;
        }

        private void AboutLabel_MouseLeave(object sender, EventArgs e)
        {
            AboutLabel.ForeColor = Color.DarkRed;
        }
    }
}
