namespace Expance_Tracker
{
    partial class AddRecordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TaskPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TopMinimizeButton = new ePOSOne.btnProduct.Button_WOC();
            this.TopExitButton = new ePOSOne.btnProduct.Button_WOC();
            this.TopExpandButton = new ePOSOne.btnProduct.Button_WOC();
            this.DatePicPanel = new System.Windows.Forms.Panel();
            this.TodayDateRadioButton = new System.Windows.Forms.RadioButton();
            this.CustomDateRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ExpDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ExpDescTextBox = new System.Windows.Forms.TextBox();
            this.CatagoryComboBox = new System.Windows.Forms.ComboBox();
            this.CloseButton = new ePOSOne.btnProduct.Button_WOC();
            this.ResetButton = new ePOSOne.btnProduct.Button_WOC();
            this.AddExpButton = new ePOSOne.btnProduct.Button_WOC();
            this.TaskPanel.SuspendLayout();
            this.DatePicPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskPanel
            // 
            this.TaskPanel.BackColor = System.Drawing.Color.SeaGreen;
            this.TaskPanel.Controls.Add(this.label1);
            this.TaskPanel.Controls.Add(this.TopMinimizeButton);
            this.TaskPanel.Controls.Add(this.TopExitButton);
            this.TaskPanel.Controls.Add(this.TopExpandButton);
            this.TaskPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TaskPanel.Location = new System.Drawing.Point(0, 0);
            this.TaskPanel.Name = "TaskPanel";
            this.TaskPanel.Size = new System.Drawing.Size(798, 40);
            this.TaskPanel.TabIndex = 1;
            this.TaskPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskPanel_MouseDown);
            this.TaskPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TaskPanel_MouseMove);
            this.TaskPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TaskPanel_MouseUp);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(225, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Insert All Records";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskPanel_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TaskPanel_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TaskPanel_MouseUp);
            // 
            // TopMinimizeButton
            // 
            this.TopMinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopMinimizeButton.BorderColor = System.Drawing.Color.Silver;
            this.TopMinimizeButton.ButtonColor = System.Drawing.Color.Lime;
            this.TopMinimizeButton.FlatAppearance.BorderSize = 0;
            this.TopMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopMinimizeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopMinimizeButton.Location = new System.Drawing.Point(690, 5);
            this.TopMinimizeButton.Name = "TopMinimizeButton";
            this.TopMinimizeButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.TopMinimizeButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.TopMinimizeButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.TopMinimizeButton.Size = new System.Drawing.Size(28, 28);
            this.TopMinimizeButton.TabIndex = 4;
            this.TopMinimizeButton.Text = "-";
            this.TopMinimizeButton.TextColor = System.Drawing.Color.Black;
            this.TopMinimizeButton.UseVisualStyleBackColor = true;
            this.TopMinimizeButton.Click += new System.EventHandler(this.TopMinimizeButton_Click);
            // 
            // TopExitButton
            // 
            this.TopExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopExitButton.BorderColor = System.Drawing.Color.Silver;
            this.TopExitButton.ButtonColor = System.Drawing.Color.Red;
            this.TopExitButton.FlatAppearance.BorderSize = 0;
            this.TopExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopExitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopExitButton.Location = new System.Drawing.Point(758, 5);
            this.TopExitButton.Name = "TopExitButton";
            this.TopExitButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.TopExitButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.TopExitButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.TopExitButton.Size = new System.Drawing.Size(28, 28);
            this.TopExitButton.TabIndex = 4;
            this.TopExitButton.Text = "X";
            this.TopExitButton.TextColor = System.Drawing.Color.White;
            this.TopExitButton.UseVisualStyleBackColor = true;
            this.TopExitButton.Click += new System.EventHandler(this.TopExitButton_Click);
            // 
            // TopExpandButton
            // 
            this.TopExpandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopExpandButton.BorderColor = System.Drawing.Color.Silver;
            this.TopExpandButton.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.TopExpandButton.FlatAppearance.BorderSize = 0;
            this.TopExpandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopExpandButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopExpandButton.Location = new System.Drawing.Point(724, 5);
            this.TopExpandButton.Name = "TopExpandButton";
            this.TopExpandButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.TopExpandButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.TopExpandButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.TopExpandButton.Size = new System.Drawing.Size(28, 28);
            this.TopExpandButton.TabIndex = 4;
            this.TopExpandButton.Text = "[]";
            this.TopExpandButton.TextColor = System.Drawing.Color.White;
            this.TopExpandButton.UseVisualStyleBackColor = true;
            this.TopExpandButton.Click += new System.EventHandler(this.TopExpandButton_Click);
            // 
            // DatePicPanel
            // 
            this.DatePicPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePicPanel.Controls.Add(this.TodayDateRadioButton);
            this.DatePicPanel.Controls.Add(this.CustomDateRadioButton);
            this.DatePicPanel.Location = new System.Drawing.Point(299, 83);
            this.DatePicPanel.Name = "DatePicPanel";
            this.DatePicPanel.Size = new System.Drawing.Size(313, 45);
            this.DatePicPanel.TabIndex = 7;
            // 
            // TodayDateRadioButton
            // 
            this.TodayDateRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TodayDateRadioButton.AutoSize = true;
            this.TodayDateRadioButton.Checked = true;
            this.TodayDateRadioButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayDateRadioButton.Location = new System.Drawing.Point(173, 9);
            this.TodayDateRadioButton.Name = "TodayDateRadioButton";
            this.TodayDateRadioButton.Size = new System.Drawing.Size(78, 26);
            this.TodayDateRadioButton.TabIndex = 8;
            this.TodayDateRadioButton.TabStop = true;
            this.TodayDateRadioButton.Text = "Today";
            this.TodayDateRadioButton.UseVisualStyleBackColor = true;
            // 
            // CustomDateRadioButton
            // 
            this.CustomDateRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomDateRadioButton.AutoSize = true;
            this.CustomDateRadioButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomDateRadioButton.Location = new System.Drawing.Point(48, 9);
            this.CustomDateRadioButton.Name = "CustomDateRadioButton";
            this.CustomDateRadioButton.Size = new System.Drawing.Size(91, 26);
            this.CustomDateRadioButton.TabIndex = 8;
            this.CustomDateRadioButton.TabStop = true;
            this.CustomDateRadioButton.Text = "Custom";
            this.CustomDateRadioButton.UseVisualStyleBackColor = true;
            this.CustomDateRadioButton.CheckedChanged += new System.EventHandler(this.CustomDateRadioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Date: -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Choose Date: -";
            // 
            // ExpDateTimePicker
            // 
            this.ExpDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpDateTimePicker.CustomFormat = " ";
            this.ExpDateTimePicker.Enabled = false;
            this.ExpDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpDateTimePicker.Location = new System.Drawing.Point(299, 148);
            this.ExpDateTimePicker.Name = "ExpDateTimePicker";
            this.ExpDateTimePicker.Size = new System.Drawing.Size(313, 32);
            this.ExpDateTimePicker.TabIndex = 0;
            this.ExpDateTimePicker.ValueChanged += new System.EventHandler(this.ExpDateTimePicker_ValueChanged);
            this.ExpDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExpDateTimePicker_KeyDown);
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountTextBox.BackColor = System.Drawing.Color.MediumAquamarine;
            this.AmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AmountTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTextBox.Location = new System.Drawing.Point(304, 265);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(320, 28);
            this.AmountTextBox.TabIndex = 2;
            this.AmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount :-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Category :-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(242, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 31);
            this.label6.TabIndex = 3;
            this.label6.Text = "R.S";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(93, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Description: -";
            // 
            // ExpDescTextBox
            // 
            this.ExpDescTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpDescTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpDescTextBox.Location = new System.Drawing.Point(299, 344);
            this.ExpDescTextBox.Multiline = true;
            this.ExpDescTextBox.Name = "ExpDescTextBox";
            this.ExpDescTextBox.Size = new System.Drawing.Size(317, 88);
            this.ExpDescTextBox.TabIndex = 3;
            // 
            // CatagoryComboBox
            // 
            this.CatagoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CatagoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CatagoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CatagoryComboBox.BackColor = System.Drawing.Color.Thistle;
            this.CatagoryComboBox.DropDownHeight = 180;
            this.CatagoryComboBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatagoryComboBox.FormattingEnabled = true;
            this.CatagoryComboBox.IntegralHeight = false;
            this.CatagoryComboBox.Location = new System.Drawing.Point(299, 205);
            this.CatagoryComboBox.Name = "CatagoryComboBox";
            this.CatagoryComboBox.Size = new System.Drawing.Size(313, 39);
            this.CatagoryComboBox.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CloseButton.BorderColor = System.Drawing.Color.Blue;
            this.CloseButton.ButtonColor = System.Drawing.Color.Red;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(541, 455);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.CloseButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.CloseButton.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.CloseButton.Size = new System.Drawing.Size(139, 49);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.TextColor = System.Drawing.Color.White;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ResetButton.BorderColor = System.Drawing.Color.Blue;
            this.ResetButton.ButtonColor = System.Drawing.Color.Gold;
            this.ResetButton.FlatAppearance.BorderSize = 0;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(330, 455);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.ResetButton.OnHoverButtonColor = System.Drawing.Color.Lime;
            this.ResetButton.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.ResetButton.Size = new System.Drawing.Size(139, 49);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Reset";
            this.ResetButton.TextColor = System.Drawing.Color.Black;
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // AddExpButton
            // 
            this.AddExpButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddExpButton.BorderColor = System.Drawing.Color.Blue;
            this.AddExpButton.ButtonColor = System.Drawing.Color.Lime;
            this.AddExpButton.CausesValidation = false;
            this.AddExpButton.FlatAppearance.BorderSize = 0;
            this.AddExpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddExpButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddExpButton.Location = new System.Drawing.Point(119, 455);
            this.AddExpButton.Name = "AddExpButton";
            this.AddExpButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.AddExpButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddExpButton.OnHoverTextColor = System.Drawing.Color.Azure;
            this.AddExpButton.Size = new System.Drawing.Size(139, 49);
            this.AddExpButton.TabIndex = 4;
            this.AddExpButton.Text = "ADD";
            this.AddExpButton.TextColor = System.Drawing.Color.Black;
            this.AddExpButton.UseVisualStyleBackColor = true;
            this.AddExpButton.Click += new System.EventHandler(this.AddExpButton_Click);
            // 
            // AddRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(798, 541);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CatagoryComboBox);
            this.Controls.Add(this.ExpDescTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddExpButton);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.ExpDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DatePicPanel);
            this.Controls.Add(this.TaskPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRecordForm";
            this.Load += new System.EventHandler(this.AddRecordForm_Load);
            this.TaskPanel.ResumeLayout(false);
            this.TaskPanel.PerformLayout();
            this.DatePicPanel.ResumeLayout(false);
            this.DatePicPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TaskPanel;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC TopMinimizeButton;
        private ePOSOne.btnProduct.Button_WOC TopExitButton;
        private ePOSOne.btnProduct.Button_WOC TopExpandButton;
        private System.Windows.Forms.Panel DatePicPanel;
        private System.Windows.Forms.RadioButton CustomDateRadioButton;
        private System.Windows.Forms.RadioButton TodayDateRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker ExpDateTimePicker;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ePOSOne.btnProduct.Button_WOC AddExpButton;
        private System.Windows.Forms.Label label6;
        private ePOSOne.btnProduct.Button_WOC ResetButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ExpDescTextBox;
        private System.Windows.Forms.ComboBox CatagoryComboBox;
        private ePOSOne.btnProduct.Button_WOC CloseButton;

    }
}