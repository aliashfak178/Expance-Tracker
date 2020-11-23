using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Utility;
using System.Data.SqlClient;

namespace Expance_Tracker
{
    public partial class CrystalReport2 : Form
    {
        string Filterstring;

        public CrystalReport2(string FilterText)
        {
            InitializeComponent();
            Filterstring = FilterText;
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

        private void CrystalReport2_Load(object sender, EventArgs e)
        {
            DataTable DtReport = GetData();

            ShowReport(DtReport);
        }

        private void ShowReport(DataTable DtReport)
        {
            
            ReportDocument rdoc = new ReportDocument();
            rdoc.Load(@"Reports\Report2.rpt");
            rdoc.SetDataSource(DtReport);
            crystalReportViewer2.ReportSource = rdoc;
        }

        private DataTable GetData()
        {
            DataTable DtReport = new DataTable();
            string ConnStaring = DBConfiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(ConnStaring))
            {
                using (SqlCommand cmd = new SqlCommand("usp_CrystalReportByYear", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Year", Filterstring);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtReport.Load(reader);
                }
            }
            return DtReport;
        }
    }
}
