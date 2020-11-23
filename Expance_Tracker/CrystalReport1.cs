using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Expance_Tracker
{
    public partial class CrystalReport1 : Form
    {
        public CrystalReport1()
        {
            InitializeComponent();
        }
        //Move Layout Variables
        private bool drag = false;
        private Point Start_Point = new Point(0, 0);
        //
        private void TopExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void CrystalReport1_Load(object sender, EventArgs e)
        {
            ShowReport();
        }

        private void ShowReport()
        {
            ReportDocument rdoc = new ReportDocument();

            rdoc.Load(@"Reports\Report1.rpt");
            crystalReportViewer1.ReportSource = rdoc;
        }

    }
}
