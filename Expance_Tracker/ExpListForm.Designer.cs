namespace Expance_Tracker
{
    partial class ExpListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TaskPanel = new System.Windows.Forms.Panel();
            this.TopMinimizeButton = new ePOSOne.btnProduct.Button_WOC();
            this.TopExitButton = new ePOSOne.btnProduct.Button_WOC();
            this.TopExpandButton = new ePOSOne.btnProduct.Button_WOC();
            this.ExpDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchByComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TaskPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(392, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "All Expanses List";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
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
            this.TaskPanel.Size = new System.Drawing.Size(1085, 40);
            this.TaskPanel.TabIndex = 3;
            this.TaskPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.TaskPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.TaskPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // TopMinimizeButton
            // 
            this.TopMinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopMinimizeButton.BorderColor = System.Drawing.Color.Silver;
            this.TopMinimizeButton.ButtonColor = System.Drawing.Color.Lime;
            this.TopMinimizeButton.FlatAppearance.BorderSize = 0;
            this.TopMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopMinimizeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopMinimizeButton.Location = new System.Drawing.Point(977, 5);
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
            this.TopExitButton.Location = new System.Drawing.Point(1045, 5);
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
            this.TopExpandButton.Location = new System.Drawing.Point(1011, 5);
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
            // ExpDataGridView
            // 
            this.ExpDataGridView.AllowUserToAddRows = false;
            this.ExpDataGridView.AllowUserToDeleteRows = false;
            this.ExpDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExpDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ExpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpDataGridView.EnableHeadersVisualStyles = false;
            this.ExpDataGridView.Location = new System.Drawing.Point(40, 166);
            this.ExpDataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.ExpDataGridView.Name = "ExpDataGridView";
            this.ExpDataGridView.ReadOnly = true;
            this.ExpDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.ExpDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ExpDataGridView.RowTemplate.Height = 40;
            this.ExpDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExpDataGridView.Size = new System.Drawing.Size(1005, 461);
            this.ExpDataGridView.TabIndex = 4;
            this.ExpDataGridView.DoubleClick += new System.EventHandler(this.ExpDataGridView_DoubleClick);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(386, 118);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(313, 35);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
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
            this.SearchByComboBox.Location = new System.Drawing.Point(386, 57);
            this.SearchByComboBox.Name = "SearchByComboBox";
            this.SearchByComboBox.Size = new System.Drawing.Size(313, 34);
            this.SearchByComboBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Search :-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search By :-";
            // 
            // ExpListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1085, 650);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchByComboBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ExpDataGridView);
            this.Controls.Add(this.TaskPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpListForm";
            this.Load += new System.EventHandler(this.ExpListForm_Load);
            this.TaskPanel.ResumeLayout(false);
            this.TaskPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TaskPanel;
        private ePOSOne.btnProduct.Button_WOC TopMinimizeButton;
        private ePOSOne.btnProduct.Button_WOC TopExitButton;
        private ePOSOne.btnProduct.Button_WOC TopExpandButton;
        private System.Windows.Forms.DataGridView ExpDataGridView;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ComboBox SearchByComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}