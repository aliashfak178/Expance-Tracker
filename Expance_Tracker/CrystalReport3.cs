using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utility;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace Expance_Tracker
{
    public partial class CrystalReport3 : Form
    {
        int Month;
        string Year;
        public CrystalReport3(string Y,int M)
        {
            InitializeComponent();
            Year = Y;
            Month = M;
        }
        //Move Layout Variables
        private bool drag = false;
        private Point Start_Point = new Point(0, 0);
        //
        private void TopExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrystalReport3_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            Start_Point = new Point(e.X, e.Y);
        }

        private void CrystalReport3_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - Start_Point.X, p.Y - Start_Point.Y);
            }
        }

        private void CrystalReport3_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void CrystalReport3_Load(object sender, EventArgs e)
        {
            DataTable DtReport = GetData();

            ShowReport(DtReport);
        }

        private void ShowReport(DataTable DtReport)
        {
 	        ReportDocument rdoc = new ReportDocument();
            rdoc.Load(@"Reports\Report3.rpt");
            rdoc.SetDataSource(DtReport);
            crystalReportViewer1.ReportSource = rdoc;
        }

        private DataTable GetData()
        {
            DataTable DtReport = new DataTable();
            string ConnStaring = DBConfiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(ConnStaring))
            {
                using (SqlCommand cmd = new SqlCommand("usp_CrystalReportByMonth", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Year", Year);
                    cmd.Parameters.AddWithValue("@Month", Month);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtReport.Load(reader);
                }
            }
            return DtReport;
        }
    }
}
