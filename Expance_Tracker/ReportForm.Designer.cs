namespace Expance_Tracker
{
    partial class ReportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TaskPanel = new System.Windows.Forms.Panel();
            this.ShowReportButton = new System.Windows.Forms.Button();
            this.Filterlabel2 = new System.Windows.Forms.Label();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OptionalFilterComboBox = new System.Windows.Forms.ComboBox();
            this.FilterComboBox2 = new System.Windows.Forms.ComboBox();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.TopMinimizeButton = new ePOSOne.btnProduct.Button_WOC();
            this.TopExitButton = new ePOSOne.btnProduct.Button_WOC();
            this.TopExpandButton = new ePOSOne.btnProduct.Button_WOC();
            this.TaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "REPORTS";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskPanel_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TaskPanel_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TaskPanel_MouseUp);
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
            this.TaskPanel.Size = new System.Drawing.Size(832, 40);
            this.TaskPanel.TabIndex = 5;
            this.TaskPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskPanel_MouseDown);
            this.TaskPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TaskPanel_MouseMove);
            this.TaskPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TaskPanel_MouseUp);
            // 
            // ShowReportButton
            // 
            this.ShowReportButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ShowReportButton.FlatAppearance.BorderSize = 0;
            this.ShowReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowReportButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowReportButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ShowReportButton.Location = new System.Drawing.Point(171, 324);
            this.ShowReportButton.Name = "ShowReportButton";
            this.ShowReportButton.Size = new System.Drawing.Size(495, 40);
            this.ShowReportButton.TabIndex = 15;
            this.ShowReportButton.Text = "Show Report";
            this.ShowReportButton.UseVisualStyleBackColor = false;
            this.ShowReportButton.Click += new System.EventHandler(this.ShowReportButton_Click);
            // 
            // Filterlabel2
            // 
            this.Filterlabel2.AutoSize = true;
            this.Filterlabel2.BackColor = System.Drawing.Color.Transparent;
            this.Filterlabel2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filterlabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Filterlabel2.Location = new System.Drawing.Point(167, 167);
            this.Filterlabel2.Name = "Filterlabel2";
            this.Filterlabel2.Size = new System.Drawing.Size(78, 24);
            this.Filterlabel2.TabIndex = 13;
            this.Filterlabel2.Text = "Filter :-";
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.BackColor = System.Drawing.Color.Transparent;
            this.FilterLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FilterLabel.Location = new System.Drawing.Point(167, 260);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(78, 24);
            this.FilterLabel.TabIndex = 14;
            this.FilterLabel.Text = "Filter :-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(167, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Filter :-";
            // 
            // OptionalFilterComboBox
            // 
            this.OptionalFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OptionalFilterComboBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionalFilterComboBox.FormattingEnabled = true;
            this.OptionalFilterComboBox.Location = new System.Drawing.Point(424, 162);
            this.OptionalFilterComboBox.Name = "OptionalFilterComboBox";
            this.OptionalFilterComboBox.Size = new System.Drawing.Size(242, 34);
            this.OptionalFilterComboBox.TabIndex = 9;
            // 
            // FilterComboBox2
            // 
            this.FilterComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterComboBox2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterComboBox2.FormattingEnabled = true;
            this.FilterComboBox2.Location = new System.Drawing.Point(424, 250);
            this.FilterComboBox2.Name = "FilterComboBox2";
            this.FilterComboBox2.Size = new System.Drawing.Size(242, 34);
            this.FilterComboBox2.TabIndex = 10;
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterComboBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Items.AddRange(new object[] {
            "All",
            "By Year ",
            "By Month"});
            this.FilterComboBox.Location = new System.Drawing.Point(424, 74);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(242, 34);
            this.FilterComboBox.TabIndex = 11;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // TopMinimizeButton
            // 
            this.TopMinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopMinimizeButton.BorderColor = System.Drawing.Color.Silver;
            this.TopMinimizeButton.ButtonColor = System.Drawing.Color.Lime;
            this.TopMinimizeButton.Enabled = false;
            this.TopMinimizeButton.FlatAppearance.BorderSize = 0;
            this.TopMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopMinimizeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopMinimizeButton.Location = new System.Drawing.Point(724, 5);
            this.TopMinimizeButton.Name = "TopMinimizeButton";
            this.TopMinimizeButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.TopMinimizeButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.TopMinimizeButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.TopMinimizeButton.Size = new System.Drawing.Size(28, 28);
            this.TopMinimizeButton.TabIndex = 4;
            this.TopMinimizeButton.Text = "-";
            this.TopMinimizeButton.TextColor = System.Drawing.Color.Black;
            this.TopMinimizeButton.UseVisualStyleBackColor = true;
            // 
            // TopExitButton
            // 
            this.TopExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopExitButton.BorderColor = System.Drawing.Color.Silver;
            this.TopExitButton.ButtonColor = System.Drawing.Color.Red;
            this.TopExitButton.FlatAppearance.BorderSize = 0;
            this.TopExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopExitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopExitButton.Location = new System.Drawing.Point(792, 5);
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
            this.TopExpandButton.Location = new System.Drawing.Point(758, 5);
            this.TopExpandButton.Name = "TopExpandButton";
            this.TopExpandButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.TopExpandButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.TopExpandButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.TopExpandButton.Size = new System.Drawing.Size(28, 28);
            this.TopExpandButton.TabIndex = 4;
            this.TopExpandButton.Text = "[]";
            this.TopExpandButton.TextColor = System.Drawing.Color.White;
            this.TopExpandButton.UseVisualStyleBackColor = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(832, 414);
            this.Controls.Add(this.ShowReportButton);
            this.Controls.Add(this.Filterlabel2);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OptionalFilterComboBox);
            this.Controls.Add(this.FilterComboBox2);
            this.Controls.Add(this.FilterComboBox);
            this.Controls.Add(this.TaskPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.TaskPanel.ResumeLayout(false);
            this.TaskPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC TopMinimizeButton;
        private System.Windows.Forms.Panel TaskPanel;
        private ePOSOne.btnProduct.Button_WOC TopExitButton;
        private ePOSOne.btnProduct.Button_WOC TopExpandButton;
        private System.Windows.Forms.Button ShowReportButton;
        private System.Windows.Forms.Label Filterlabel2;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox OptionalFilterComboBox;
        private System.Windows.Forms.ComboBox FilterComboBox2;
        private System.Windows.Forms.ComboBox FilterComboBox;
    }
}