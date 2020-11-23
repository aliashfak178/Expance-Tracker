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
    public partial class AddRecordForm : Form
    {
        public AddRecordForm()
        {
            InitializeComponent();
        }

        private void TopExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TopMinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
                this.Location = new Point(p.X - Start_Point.X,p.Y - Start_Point.Y);
            }
        }
        private void TaskPanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void ExpDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ExpDateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void ExpDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                ExpDateTimePicker.CustomFormat = " ";
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            TodayDateRadioButton.Checked = true;
            ExpDateTimePicker.CustomFormat = " ";
            CatagoryComboBox.SelectedIndex = -1;
            AmountTextBox.Clear();
            ExpDescTextBox.Clear();
            ExpDateTimePicker.Focus();
        }

        private void AddExpButton_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                GetAllRecored();
                MessageBox.Show("New Record Added SuccsessFully...", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TodayDateRadioButton.Checked = true;
                ExpDateTimePicker.CustomFormat = " ";
                CatagoryComboBox.SelectedIndex = -1;
                AmountTextBox.Clear();
                ExpDescTextBox.Clear();
                ExpDateTimePicker.Focus();
            }
        }

        private void GetAllRecored()
        {
            string ConnString = DBConfiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetExpRecord", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    if (TodayDateRadioButton.Checked)
                    {
                        string tempDate = DateTime.Now.ToString();
                        cmd.Parameters.AddWithValue("@ExpDate", tempDate);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ExpDate", ExpDateTimePicker.Value);
                    }
                    cmd.Parameters.AddWithValue("@ExpCataGary", CatagoryComboBox.Text);
                    cmd.Parameters.AddWithValue("@ExpAmount", AmountTextBox.Text);
                    cmd.Parameters.AddWithValue("@ExpDesCription", ExpDescTextBox.Text);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private bool IsValidated()
        {
            if (CustomDateRadioButton.Checked)
            {
                if (ExpDateTimePicker.Text.Trim() == "")
                {
                    ValidationMessage(ExpDateTimePicker, "Plese Select The Date");
                    return false;
                }
            }
            if (CatagoryComboBox.Text.Trim() == "")
            {
                ValidationMessage(CatagoryComboBox, "Plese Select The Expenses Catagory");
                return false;  
            }
            if (AmountTextBox.Text.Trim() == "")
            {
                ValidationMessage(AmountTextBox, "Plese Select The Please Fill The Amount");
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

        private void AddRecordForm_Load(object sender, EventArgs e)
        {
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

        private void CustomDateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomDateRadioButton.Checked)
            {
                ExpDateTimePicker.Enabled = true;
            }
            else
            {
                ExpDateTimePicker.Enabled = false;
                ExpDateTimePicker.CustomFormat = " ";
            }
        }

        private void AmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
