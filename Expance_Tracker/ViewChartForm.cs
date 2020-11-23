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
    public partial class ViewChartForm : Form
    {
        public ViewChartForm()
        {
            InitializeComponent();
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

        private void TopExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Form State
        private bool FormState = true;
        //
        private void TopExpandButton_Click(object sender, EventArgs e)
        {
            if (FormState)
            {
                this.WindowState = FormWindowState.Maximized;
                FormState = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                FormState = true;
            }
        }

        private void TopMinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ViewChartForm_Load(object sender, EventArgs e)
        {
            FilterComboBox.SelectedIndex = 0;
            LoadPIChartAll();
            LoadAllColumnChart();
            LoadAmountByAll();
        }

        private void LoadAmountByAll()
        {
            DataTable DtAmount = GetAmountByAll();
            DataRow Row = DtAmount.Rows[0];
            AmountLable.Text = "R.S " + Row["Amount"].ToString();
        }

        private DataTable GetAmountByAll()
        {
            DataTable DtAmount = new DataTable();
            string ConnStaring = DBConfiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(ConnStaring))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAmountByAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtAmount.Load(reader);
                }
            }
            return DtAmount;
        }

        private void LoadAllColumnChart()
        {
            if (FilterComboBox.SelectedIndex == 0)
            {
                ColumnChart1.DataSource = GetColumnChartByAll();
                ColumnChart1.Series["Series1"].Points.Clear();
                ColumnChart1.Series["Series1"].XValueMember = "Year";
                ColumnChart1.Series["Series1"].YValueMembers = "Amount";
            }
        }

        private DataTable GetColumnChartByAll()
        {
            DataTable DtYear = new DataTable();
            string ConnStaring = DBConfiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(ConnStaring))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetColumnChartByAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtYear.Load(reader);
                }
            }
            return DtYear;
        }

        private void LoadPIChartAll()
        {
            if (FilterComboBox.SelectedIndex == 0)
            {
                PIChart1.DataSource = GetAllDataByAll();
                PIChart1.Series["Series1"].XValueMember = "Catagory";
                PIChart1.Series["Series1"].YValueMembers = "Amount";
            }  
        }
        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (FilterComboBox.SelectedIndex == 0)
            {
                PIChart1.DataSource = GetAllDataByAll();
                PIChart1.Series["Series1"].Points.Clear();
                PIChart1.Series["Series1"].XValueMember = "Catagory";
                PIChart1.Series["Series1"].YValueMembers = "Amount";

                LoadAllColumnChart();

                LoadAmountByAll();
            }
            else if (FilterComboBox.SelectedIndex == 1)
            {
                PIChart1.DataSource = GetAllDataByYear(FilterComboBox2.Text);
                PIChart1.Series["Series1"].Points.Clear();
                PIChart1.Series["Series1"].XValueMember = "Catagory";
                PIChart1.Series["Series1"].YValueMembers = "Amount";

                ColumnChart1.DataSource = GetColumnChartByYear(FilterComboBox2.Text);
                ColumnChart1.Series["Series1"].Points.Clear();
                ColumnChart1.Series["Series1"].XValueMember = "Year";
                ColumnChart1.Series["Series1"].YValueMembers = "Amount";

                DataTable DtAmount = GetAmountByYear(FilterComboBox2.Text);
                DataRow Row = DtAmount.Rows[0];
                AmountLable.Text = "R.S " + Row["Amount"].ToString();
            }
            else if (FilterComboBox.SelectedIndex == 2)
            {
                int temp = FilterComboBox2.SelectedIndex + 1; 
                PIChart1.DataSource = GetAllDataByYear(OptionalFilterComboBox.Text, temp);
                PIChart1.Series["Series1"].Points.Clear();
                PIChart1.Series["Series1"].XValueMember = "Catagory";
                PIChart1.Series["Series1"].YValueMembers = "Amount";

                ColumnChart1.DataSource = GetColumnChartByMonth(OptionalFilterComboBox.Text, temp);
                ColumnChart1.Series["Series1"].Points.Clear();
                ColumnChart1.Series["Series1"].XValueMember = "Year";
                ColumnChart1.Series["Series1"].YValueMembers = "Amount";

                DataTable DtAmount = GetAmountByMonth(OptionalFilterComboBox.Text, temp);
                DataRow Row = DtAmount.Rows[0];
                AmountLable.Text = "R.S " + Row["Amount"].ToString();
            }
        }

        private DataTable GetAmountByMonth(string Year, int Month)
        {
            DataTable DtMonth = new DataTable();
            string ConnStaring = DBConfiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(ConnStaring))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAmountByMonth", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Year", Year);
                    cmd.Parameters.AddWithValue("@Month", Month);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtMonth.Load(reader);
                }
            }
            return DtMonth;
        }

        private DataTable GetAmountByYear(string Year)
        {
            DataTable DtAmount = new DataTable();
            string ConnStaring = DBConfiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(ConnStaring))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAmountByYear", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Year", Year);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtAmount.Load(reader);
                }
            }
            return DtAmount;
        }

        private DataTable GetColumnChartByMonth(string Year, int temp)
        {
            DataTable DtMonth = new DataTable();
            string ConnStaring = DBConfiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(ConnStaring))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetColumnChartByMonth", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Year", Year);
                    cmd.Parameters.AddWithValue("@Month", temp);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtMonth.Load(reader);
                }
            }
            return DtMonth;
        }

        private DataTable GetColumnChartByYear(string Year)
        {
            DataTable DtYear = new DataTable();
            string ConnStaring = DBConfiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(ConnStaring))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetColumnCgartByYear", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Years", Year);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtYear.Load(reader);
                }
            }
            return DtYear;
        }

        private DataTable GetAllDataByYear(string Year, int Month)
        {
            DataTable DtMonth = new DataTable();
            string ConnStaring = DBConfiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(ConnStaring))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetPICatagoryByMonth", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Year", Year);
                    cmd.Parameters.AddWithValue("@Month", Month);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtMonth.Load(reader);
                }
            }
            return DtMonth;
        }
        private DataTable GetAllDataByYear(string Year)
        {
            DataTable DtYear = new DataTable();
            string ConnStaring = DBConfiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(ConnStaring))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetPICatagoryByYear", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Years", Year);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtYear.Load(reader);
                }
            }
            return DtYear;
        }

        private DataTable GetAllDataByAll()
        {
            DataTable DtPichart = new DataTable();
            string ConnStaring = DBConfiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(ConnStaring))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetPICatagoryByAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtPichart.Load(reader);
                }
            }
            return DtPichart;
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

        private void Filterlabel2_Click(object sender, EventArgs e)
        {

        }

        private void FilterLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OptionalFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FilterComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
