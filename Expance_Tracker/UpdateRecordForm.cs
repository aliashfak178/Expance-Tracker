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
    public partial class UpdateRecordForm : Form
    {
        public UpdateRecordForm()
        {
            InitializeComponent();
        }
        
        //Moving Layout Variables
            private bool drag = false;
            private Point Start_Point = new Point(0, 0);
       //End



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

       private void UpdateRecordForm_Load(object sender, EventArgs e)
       {
           GetAllExpances();
           DoingAllLoadRuntimeDesign();
           GetAllCatagory();
       }
       private void GetAllCatagory()
       {
           CatagoryComboBox.DataSource = GetExpCatagory(1);
           CatagoryComboBox.DisplayMember = "Description";
           CatagoryComboBox.SelectedIndex = -1;
       }
       private DataTable GetExpCatagory(int CatagoryType)
       {
           DataTable DtExpTable = new DataTable();
           string ConnStaring = DBConfiguration.ConnectionString;
           using (SqlConnection conn = new SqlConnection(ConnStaring))
           {
               using (SqlCommand cmd = new SqlCommand("usp_GetAllCategory", conn))
               {
                   cmd.CommandType = CommandType.StoredProcedure;

                   conn.Open();
                   cmd.Parameters.AddWithValue("@ListDataTypeId", CatagoryType);
                   SqlDataReader reader = cmd.ExecuteReader();
                   DtExpTable.Load(reader);
               }
           }

           return DtExpTable;
       }

       private void DoingAllLoadRuntimeDesign()
       {
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
           if(SearchByComboBox.SelectedIndex==0)
                DvExp.RowFilter = "Date LIKE '%" + SearchTextBox.Text + "%'";
           else
               DvExp.RowFilter = "Catagory LIKE '%" + SearchTextBox.Text + "%'";
       }

       private void ExpDataGridView_DoubleClick(object sender, EventArgs e)
       {
            int rowToUpdate = ExpDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int ExpId = (int)ExpDataGridView.Rows[rowToUpdate].Cells["ID"].Value;

            DataTable DtExpancesinfo = GetExpancesById(ExpId);
            DataRow row = DtExpancesinfo.Rows[0];
            IDTextBox.Text = row["ID"].ToString();
            ExpDateTimePicker.Value = Convert.ToDateTime(row["Date"]);
            CatagoryComboBox.Text = row["Catagory"].ToString();
            AmountTextBox.Text = row["Amount"].ToString();
            ExpDescTextBox.Text = row["Description"].ToString();
       }

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

       private void ExpDateTimePicker_ValueChanged(object sender, EventArgs e)
       {
           ExpDateTimePicker.CustomFormat = "dd-MM-yyyy";
       }

       private void EditButton_Click(object sender, EventArgs e)
       {
           //AllCodes Are Here
           if (IsValidate())
           {
               UpdateAllRecords();
               MessageBox.Show("Record is Updated SucessFully ", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
               ClearAllToolBoxs();
           }
       }

       private void ClearAllToolBoxs()
       {
           IDTextBox.Clear();
           ExpDateTimePicker.CustomFormat = " ";
           CatagoryComboBox.SelectedIndex = -1;
           SearchTextBox.Clear();
           AmountTextBox.Clear();
           ExpDescTextBox.Clear();
           IDTextBox.Focus();
           GetAllExpances();
       }

       private bool IsValidate()
       {
           if (IDTextBox.Text.Trim() == "")
           {
               ValidationMessage(IDTextBox, "Pleas Select Any Record Before Update OR Delete");
               return false;
           }
           if (ExpDateTimePicker.Text.Trim() == "")
           {
               ValidationMessage(ExpDateTimePicker,"Pleas Select Any Date Before Update OR Delete");
               return false;
           }
           if (CatagoryComboBox.Text.Trim() == "")
           {
               ValidationMessage(CatagoryComboBox, "Pleas Select Any Catagory Before Update OR Delete");
               return false;
           }
           if (AmountTextBox.Text.Trim() == "")
           {
               ValidationMessage(AmountTextBox, "Pleas Select Any Catagory Before Update OR Delete");
               return false;
           }
           return true;
       }
       private void ValidationMessage(Control ctrl, string Message)
       {
           //ctrl.BackColor = Color.OrangeRed;
           MessageBox.Show(Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           ctrl.Focus();
       }

       private void UpdateAllRecords()
       {
           string ConnString = DBConfiguration.ConnectionString;
           using (SqlConnection conn = new SqlConnection(ConnString))
           {
               using (SqlCommand cmd = new SqlCommand("usp_UpdateExpDetails", conn))
               {
                   cmd.CommandType = CommandType.StoredProcedure;
                   conn.Open();
                   cmd.Parameters.AddWithValue("@ExpId", IDTextBox.Text);
                   cmd.Parameters.AddWithValue("@ExpDate", ExpDateTimePicker.Value);
                   cmd.Parameters.AddWithValue("@ExpCatagory", CatagoryComboBox.Text);
                   cmd.Parameters.AddWithValue("@ExpAmount", AmountTextBox.Text);
                   cmd.Parameters.AddWithValue("@ExpDesCription",ExpDescTextBox.Text);

                   cmd.ExecuteNonQuery();
               }
           }
       }

       private void DeleteButton_Click(object sender, EventArgs e)
       {
           //AllCodes Are Here
           DialogResult result = MessageBox.Show("Do You Raily Want To Delete This Record...", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

           if (IsValidate() && result==DialogResult.Yes) 
           {
               DeleteTheRecord();
               MessageBox.Show("Record is Deleted SucessFully ", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
               ClearAllToolBoxs();
           }
       }

       private void DeleteTheRecord()
       {
           string ConnString = DBConfiguration.ConnectionString;
           using (SqlConnection conn = new SqlConnection(ConnString))
           {
               using (SqlCommand cmd = new SqlCommand("usp_DeleteExpDeltails", conn))
               {
                   cmd.CommandType = CommandType.StoredProcedure;
                   conn.Open();
                   cmd.Parameters.AddWithValue("@ExpId", IDTextBox.Text);

                   cmd.ExecuteNonQuery();
               }
           }
       }   
    }
}
