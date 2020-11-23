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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        // moving properties of hader
        private bool drag = false;
        Point Start_Point = new Point(0, 0);
        //Close
        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            Start_Point=new Point(e.X,e.Y);
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - Start_Point.X,p.Y - Start_Point.Y);
            }
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (!isValid())
            {
                MessageBox.Show("Please Fill User Name OR Password", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    bool IsUserNameCurrect, IsPasswordCurrect;
                    GetIsUserLoginCurrect(out IsUserNameCurrect,out IsPasswordCurrect);
                    if (IsUserNameCurrect && IsPasswordCurrect)
                    {
                        Expanses Exp = new Expanses();
                        Exp.Show();
                        this.Hide();
                    }
                    else
                    {
                        if (!IsUserNameCurrect)
                        {
                            MessageBox.Show("User Name is Not Currect.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            UserNameTextBox.Clear();
                            PasswordTextBox.Clear();
                            UserNameTextBox.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Password is Not Currect.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            PasswordTextBox.Clear();
                            PasswordTextBox.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GetIsUserLoginCurrect(out bool IsUserNameCurrect, out bool IsPasswordCurrect)
        {
            string connString = DBConfiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_UserChackLoginDetails", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    //output parameters
                    cmd.Parameters.Add("@IsUserNameCurrect", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@IsPasswordCurrect", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    //parameters
                    cmd.Parameters.AddWithValue("@UserName",UserNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text);

                    //Execute The Command
                    cmd.ExecuteNonQuery();

                    //Passed Parameter's Values From Db
                    IsUserNameCurrect = (bool)cmd.Parameters["@IsUserNameCurrect"].Value;
                    IsPasswordCurrect = (bool)cmd.Parameters["@IsPasswordCurrect"].Value;
                }
            }
        }

        private bool isValid()
        {
            if (UserNameTextBox.Text.Trim() == string.Empty)
            {
                return InvalidAction();
            }
            if (PasswordTextBox.Text.Trim() == string.Empty)
            {
                return InvalidAction();
            }

            return true;
        }

        private bool InvalidAction()
        {
            UserNameTextBox.Clear();
            PasswordTextBox.Clear();
            UserNameTextBox.Focus();
            return false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

    }
}
