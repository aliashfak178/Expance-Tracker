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
    public partial class ExpListForm : Form
    {
        public ExpListForm()
        {
            InitializeComponent();
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
            //Move Layout Variables
                private bool drag = false;
                private Point Start_Point=new Point(0,0);
            //
            
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            Start_Point = new Point(e.X,e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - Start_Point.X, p.Y - Start_Point.Y);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void ExpListForm_Load(object sender, EventArgs e)
        {
            GetAllExpances();
            SearchByComboBox.SelectedIndex = 0;
        }

        private DataTable DtExpance = new DataTable();
        private void GetAllExpances()
        {
            DtExpance = GetAllData();
            ExpDataGridView.DataSource = DtExpance;
        }

        private DataTable GetAllData()
        {
            DataTable DtExpance = new DataTable();
            string ConnString = DBConfiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllEpances", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtExpance.Load(reader);
                }
            }

            return DtExpance;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataView DvExp = DtExpance.DefaultView;
            if (SearchByComboBox.SelectedIndex == 0)
                DvExp.RowFilter = "Date LIKE '%" + SearchTextBox.Text + "%'";
            else
                DvExp.RowFilter = "Catagory LIKE '%" + SearchTextBox.Text + "%'";
        }
        //Transfer All Data Variables
             private int id;
             private string datetime;
             private string catagory;
             private string Amount;
             private string Desc;
        //END

        private DataTable GetExpancesById(int ExpId)
        {
            DataTable DtExpances = new DataTable();

            string ConnString = DBConfiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetExpancesinfoById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@ExpanceId", ExpId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    DtExpances.Load(reader);
                }
            }

            return DtExpances;
        }

        private void ExpDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int rowToUpdate = ExpDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int ExpId = (int)ExpDataGridView.Rows[rowToUpdate].Cells["ID"].Value;

            DataTable DtExpancesinfo = GetExpancesById(ExpId);
            DataRow row = DtExpancesinfo.Rows[0];
            id = (Int32)row["ID"];
            datetime = row["Date"].ToString();
            catagory = row["Catagory"].ToString();
            Amount = row["Amount"].ToString();
            Desc = row["Description"].ToString();
            ExpDetailsForm EDF = new ExpDetailsForm(id, datetime, catagory, Amount, Desc);
            EDF.ShowDialog();
        }
    }
}
