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
    public partial class ExpDetailsForm : Form
    {

        //Recived All Data Variables
        private int id;
        private string datetime;
        private string catagory;
        private string Amount;
        private string Desc;
        //END

        public ExpDetailsForm(int Id, string Datetimes, string cat, string rs, string descption)
        {
            InitializeComponent();
            id = Id;
            datetime = Datetimes;
            catagory = cat;
            Amount = rs;
            Desc = descption;
        }
        //Moving Layout Variable
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

        private void ExpDetailsForm_Load(object sender, EventArgs e)
        {
            ExpIdlable.Text = "Expance ID is: " + id;
            DateTimelabel.Text = "Date Is: " + datetime;
            Catagorylabel.Text = "Catagory is: " + catagory;
            Amountlabel.Text = "Amount is R.s " + Amount;
            if (Desc == "")
            {
                Desclabel.Text = "There are no Description";
            }
            else
            {
                Desclabel.Text = "Description :- "+ Desc;
            }
        }
    }
}
