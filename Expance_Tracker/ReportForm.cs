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

namespace Expance_Tracker
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void TopExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Move Layout Variables
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

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterComboBox.SelectedIndex == 0)
            {
                FilterLabel.Text = "";
                FilterComboBox2.Enabled = false;
                Filterlabel2.Text = "";
                OptionalFilterComboBox.Enabled = false;


            }
            else if (FilterComboBox.SelectedIndex == 1)
            {
                FilterLabel.Text = "Select Year";
                FilterComboBox2.DataSource = GetAllYear();
                FilterComboBox2.DisplayMember = "Year";
                FilterComboBox2.Enabled = true;
                Filterlabel2.Text = "";
                OptionalFilterComboBox.Enabled = false;
            }
            else if (FilterComboBox.SelectedIndex == 2)
            {
                FilterLabel.Text = "Select Month";
                FilterComboBox2.DataSource = null;
                FilterComboBox2.Items.Clear();
                FilterComboBox2.Items.Add("January");
                FilterComboBox2.Items.Add("February");
                FilterComboBox2.Items.Add("March");
                FilterComboBox2.Items.Add("April");
                FilterComboBox2.Items.Add("May");
                FilterComboBox2.Items.Add("June");
                FilterComboBox2.Items.Add("July");
                FilterComboBox2.Items.Add("August");
                FilterComboBox2.Items.Add("September");
                FilterComboBox2.Items.Add("October");
                FilterComboBox2.Items.Add("November");
                FilterComboBox2.Items.Add("December");
                FilterComboBox2.Enabled = true;
                Filterlabel2.Text = "Select Year";
                OptionalFilterComboBox.Enabled = true;
                OptionalFilterComboBox.DataSource = GetAllYear();
                OptionalFilterComboBox.DisplayMember = "Year";
            }
        }

        private DataTable GetAllYear()
        {
            DataTable DtYear = new DataTable();
            string ConnStaring = DBConfiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(ConnStaring))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllExpYears", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtYear.Load(reader);
                }
            }

            return DtYear;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            FilterComboBox.SelectedIndex = 0;
        }

        private void ShowReportButton_Click(object sender, EventArgs e)
        {
            if (FilterComboBox.SelectedIndex == 0)
            {
                CrystalReport1 CR1 = new CrystalReport1();
                CR1.ShowDialog();
            }
            if (FilterComboBox.SelectedIndex == 1)
            {
                CrystalReport2 CR2 = new CrystalReport2(FilterComboBox2.Text);
                CR2.ShowDialog();
            }
            if (FilterComboBox.SelectedIndex == 2)
            {
                int temp = FilterComboBox2.SelectedIndex + 1;
                CrystalReport3 CR3 = new CrystalReport3(OptionalFilterComboBox.Text,temp);
                CR3.ShowDialog();
            }
        }
        
    }
}
