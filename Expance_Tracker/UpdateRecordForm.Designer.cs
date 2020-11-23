namespace Expance_Tracker
{
    partial class UpdateRecordForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TaskPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TopMinimizeButton = new ePOSOne.btnProduct.Button_WOC();
            this.TopExitButton = new ePOSOne.btnProduct.Button_WOC();
            this.TopExpandButton = new ePOSOne.btnProduct.Button_WOC();
            this.ExpGridViewPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchByComboBox = new System.Windows.Forms.ComboBox();
            this.ExpDataGridView = new System.Windows.Forms.DataGridView();
            this.CatagoryComboBox = new System.Windows.Forms.ComboBox();
            this.ExpDescTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.ExpDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditButton = new ePOSOne.btnProduct.Button_WOC();
            this.DeleteButton = new ePOSOne.btnProduct.Button_WOC();
            this.TaskPanel.SuspendLayout();
            this.ExpGridViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.TaskPanel.Size = new System.Drawing.Size(1068, 40);
            this.TaskPanel.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(298, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Update And Delete Decords";
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
            this.TopMinimizeButton.Location = new System.Drawing.Point(960, 5);
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
            this.TopExitButton.Location = new System.Drawing.Point(1028, 5);
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
            this.TopExpandButton.Enabled = false;
            this.TopExpandButton.FlatAppearance.BorderSize = 0;
            this.TopExpandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopExpandButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopExpandButton.Location = new System.Drawing.Point(994, 5);
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
            // ExpGridViewPanel
            // 
            this.ExpGridViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpGridViewPanel.BackColor = System.Drawing.Color.Teal;
            this.ExpGridViewPanel.Controls.Add(this.label3);
            this.ExpGridViewPanel.Controls.Add(this.SearchTextBox);
            this.ExpGridViewPanel.Controls.Add(this.label2);
            this.ExpGridViewPanel.Controls.Add(this.SearchByComboBox);
            this.ExpGridViewPanel.Controls.Add(this.ExpDataGridView);
            this.ExpGridViewPanel.Location = new System.Drawing.Point(0, 40);
            this.ExpGridViewPanel.Name = "ExpGridViewPanel";
            this.ExpGridViewPanel.Size = new System.Drawing.Size(574, 532);
            this.ExpGridViewPanel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search :-";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.BackColor = System.Drawing.Color.Teal;
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.SearchTextBox.Location = new System.Drawing.Point(178, 66);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(313, 35);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search By :-";
            // 
            // SearchByComboBox
            // 
            this.SearchByComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchByComboBox.BackColor = System.Drawing.Color.Thistle;
            this.SearchByComboBox.DropDownHeight = 130;
            this.SearchByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchByComboBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByComboBox.FormattingEnabled = true;
            this.SearchByComboBox.IntegralHeight = false;
            this.SearchByComboBox.Items.AddRange(new object[] {
            "Search By Date",
            "Search By Catagory"});
            this.SearchByComboBox.Location = new System.Drawing.Point(178, 12);
            this.SearchByComboBox.Name = "SearchByComboBox";
            this.SearchByComboBox.Size = new System.Drawing.Size(313, 34);
            this.SearchByComboBox.TabIndex = 0;
            // 
            // ExpDataGridView
            // 
            this.ExpDataGridView.AllowUserToAddRows = false;
            this.ExpDataGridView.AllowUserToDeleteRows = false;
            this.ExpDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExpDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ExpDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ExpDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ExpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpDataGridView.EnableHeadersVisualStyles = false;
            this.ExpDataGridView.Location = new System.Drawing.Point(9, 135);
            this.ExpDataGridView.Name = "ExpDataGridView";
            this.ExpDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.ExpDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ExpDataGridView.RowTemplate.Height = 35;
            this.ExpDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExpDataGridView.Size = new System.Drawing.Size(556, 385);
            this.ExpDataGridView.TabIndex = 2;
            this.ExpDataGridView.DoubleClick += new System.EventHandler(this.ExpDataGridView_DoubleClick);
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
            this.CatagoryComboBox.Location = new System.Drawing.Point(179, 149);
            this.CatagoryComboBox.Name = "CatagoryComboBox";
            this.CatagoryComboBox.Size = new System.Drawing.Size(306, 39);
            this.CatagoryComboBox.TabIndex = 5;
            // 
            // ExpDescTextBox
            // 
            this.ExpDescTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpDescTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpDescTextBox.Location = new System.Drawing.Point(179, 264);
            this.ExpDescTextBox.Multiline = true;
            this.ExpDescTextBox.Name = "ExpDescTextBox";
            this.ExpDescTextBox.Size = new System.Drawing.Size(306, 88);
            this.ExpDescTextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Description: -";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(173, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "R.S";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountTextBox.BackColor = System.Drawing.Color.MediumAquamarine;
            this.AmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmountTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTextBox.Location = new System.Drawing.Point(179, 212);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(306, 28);
            this.AmountTextBox.TabIndex = 6;
            this.AmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExpDateTimePicker
            // 
            this.ExpDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpDateTimePicker.CustomFormat = " ";
            this.ExpDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpDateTimePicker.Location = new System.Drawing.Point(181, 91);
            this.ExpDateTimePicker.Name = "ExpDateTimePicker";
            this.ExpDateTimePicker.Size = new System.Drawing.Size(304, 32);
            this.ExpDateTimePicker.TabIndex = 4;
            this.ExpDateTimePicker.ValueChanged += new System.EventHandler(this.ExpDateTimePicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Category :-";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amount :-";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Date : -";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Id :-";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.IDTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.Location = new System.Drawing.Point(181, 35);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(304, 29);
            this.IDTextBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CatagoryComboBox);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.IDTextBox);
            this.panel1.Controls.Add(this.ExpDescTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AmountTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ExpDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(571, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 532);
            this.panel1.TabIndex = 12;
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EditButton.BorderColor = System.Drawing.Color.Blue;
            this.EditButton.ButtonColor = System.Drawing.Color.Lime;
            this.EditButton.CausesValidation = false;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(60, 446);
            this.EditButton.Name = "EditButton";
            this.EditButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.EditButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EditButton.OnHoverTextColor = System.Drawing.Color.Azure;
            this.EditButton.Size = new System.Drawing.Size(139, 49);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Edit";
            this.EditButton.TextColor = System.Drawing.Color.Black;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteButton.BorderColor = System.Drawing.Color.Blue;
            this.DeleteButton.ButtonColor = System.Drawing.Color.Red;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(328, 446);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.DeleteButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.DeleteButton.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.DeleteButton.Size = new System.Drawing.Size(139, 49);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.TextColor = System.Drawing.Color.White;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1068, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExpGridViewPanel);
            this.Controls.Add(this.TaskPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UpdateRecordForm_Load);
            this.TaskPanel.ResumeLayout(false);
            this.TaskPanel.PerformLayout();
            this.ExpGridViewPanel.ResumeLayout(false);
            this.ExpGridViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TaskPanel;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC TopMinimizeButton;
        private ePOSOne.btnProduct.Button_WOC TopExitButton;
        private ePOSOne.btnProduct.Button_WOC TopExpandButton;
        private System.Windows.Forms.Panel ExpGridViewPanel;
        private System.Windows.Forms.DataGridView ExpDataGridView;
        private System.Windows.Forms.ComboBox SearchByComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ComboBox CatagoryComboBox;
        private System.Windows.Forms.TextBox ExpDescTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.DateTimePicker ExpDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IDTextBox;
        private ePOSOne.btnProduct.Button_WOC DeleteButton;
        private ePOSOne.btnProduct.Button_WOC EditButton;
        private System.Windows.Forms.Panel panel1;
    }
}