namespace Expance_Tracker
{
    partial class Expanses
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
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.SlidePanel = new System.Windows.Forms.Panel();
            this.TaskPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TopMinimizeButton = new ePOSOne.btnProduct.Button_WOC();
            this.TopExitButton = new ePOSOne.btnProduct.Button_WOC();
            this.TopExpandButton = new ePOSOne.btnProduct.Button_WOC();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.ManageExpButton = new System.Windows.Forms.Button();
            this.ExpanseButton = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteRecordButton = new System.Windows.Forms.Button();
            this.UpdateRecordButton = new System.Windows.Forms.Button();
            this.AddRecordButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ViewChartButton = new System.Windows.Forms.Button();
            this.ExpListButton = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            this.TaskPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(100)))), ((int)(((byte)(73)))));
            this.HeaderPanel.Controls.Add(this.SlidePanel);
            this.HeaderPanel.Controls.Add(this.TaskPanel);
            this.HeaderPanel.Controls.Add(this.ExitButton);
            this.HeaderPanel.Controls.Add(this.AboutButton);
            this.HeaderPanel.Controls.Add(this.ReportButton);
            this.HeaderPanel.Controls.Add(this.ManageExpButton);
            this.HeaderPanel.Controls.Add(this.ExpanseButton);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1084, 132);
            this.HeaderPanel.TabIndex = 1;
            // 
            // SlidePanel
            // 
            this.SlidePanel.BackColor = System.Drawing.Color.Cyan;
            this.SlidePanel.Location = new System.Drawing.Point(3, 41);
            this.SlidePanel.Name = "SlidePanel";
            this.SlidePanel.Size = new System.Drawing.Size(185, 10);
            this.SlidePanel.TabIndex = 2;
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
            this.TaskPanel.Size = new System.Drawing.Size(1084, 40);
            this.TaskPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(368, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Expanse Tracker";
            // 
            // TopMinimizeButton
            // 
            this.TopMinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopMinimizeButton.BorderColor = System.Drawing.Color.Silver;
            this.TopMinimizeButton.ButtonColor = System.Drawing.Color.Lime;
            this.TopMinimizeButton.FlatAppearance.BorderSize = 0;
            this.TopMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopMinimizeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopMinimizeButton.Location = new System.Drawing.Point(976, 5);
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
            this.TopExitButton.Location = new System.Drawing.Point(1044, 5);
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
            this.TopExpandButton.Location = new System.Drawing.Point(1010, 5);
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
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitButton.Image = global::Expance_Tracker.Properties.Resources.application_exit_4;
            this.ExitButton.Location = new System.Drawing.Point(776, 57);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(185, 73);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AboutButton.Image = global::Expance_Tracker.Properties.Resources.help_about_2;
            this.AboutButton.Location = new System.Drawing.Point(585, 57);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(185, 73);
            this.AboutButton.TabIndex = 0;
            this.AboutButton.Text = "About";
            this.AboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.FlatAppearance.BorderSize = 0;
            this.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ReportButton.Image = global::Expance_Tracker.Properties.Resources.office_chart_ring;
            this.ReportButton.Location = new System.Drawing.Point(394, 54);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(185, 73);
            this.ReportButton.TabIndex = 0;
            this.ReportButton.Text = "Report";
            this.ReportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // ManageExpButton
            // 
            this.ManageExpButton.FlatAppearance.BorderSize = 0;
            this.ManageExpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageExpButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageExpButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ManageExpButton.Image = global::Expance_Tracker.Properties.Resources.preferences_system_session_manager;
            this.ManageExpButton.Location = new System.Drawing.Point(204, 54);
            this.ManageExpButton.Name = "ManageExpButton";
            this.ManageExpButton.Size = new System.Drawing.Size(185, 73);
            this.ManageExpButton.TabIndex = 0;
            this.ManageExpButton.Text = "Manage Expanses";
            this.ManageExpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManageExpButton.UseVisualStyleBackColor = true;
            this.ManageExpButton.Click += new System.EventHandler(this.ManageExpButton_Click);
            // 
            // ExpanseButton
            // 
            this.ExpanseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExpanseButton.FlatAppearance.BorderSize = 0;
            this.ExpanseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpanseButton.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpanseButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExpanseButton.Image = global::Expance_Tracker.Properties.Resources.application_vnd_ms_excel;
            this.ExpanseButton.Location = new System.Drawing.Point(0, 57);
            this.ExpanseButton.Name = "ExpanseButton";
            this.ExpanseButton.Size = new System.Drawing.Size(185, 73);
            this.ExpanseButton.TabIndex = 0;
            this.ExpanseButton.Text = "Expanses";
            this.ExpanseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExpanseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExpanseButton.UseVisualStyleBackColor = true;
            this.ExpanseButton.Click += new System.EventHandler(this.ExpanseButton_Click_1);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(16)))));
            this.BottomPanel.Controls.Add(this.label2);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 610);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1084, 32);
            this.BottomPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Engravers MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(471, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "All Right Reserved From Ashfaque Ali";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(100)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.DeleteRecordButton);
            this.panel1.Controls.Add(this.UpdateRecordButton);
            this.panel1.Controls.Add(this.AddRecordButton);
            this.panel1.Location = new System.Drawing.Point(2, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 242);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.FlatAppearance.BorderSize = 0;
            this.DeleteRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRecordButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRecordButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteRecordButton.Image = global::Expance_Tracker.Properties.Resources.edit_delete_3;
            this.DeleteRecordButton.Location = new System.Drawing.Point(-2, 161);
            this.DeleteRecordButton.Name = "DeleteRecordButton";
            this.DeleteRecordButton.Size = new System.Drawing.Size(185, 73);
            this.DeleteRecordButton.TabIndex = 0;
            this.DeleteRecordButton.Text = "Delete Record";
            this.DeleteRecordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteRecordButton.UseVisualStyleBackColor = true;
            this.DeleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
            // 
            // UpdateRecordButton
            // 
            this.UpdateRecordButton.FlatAppearance.BorderSize = 0;
            this.UpdateRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateRecordButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateRecordButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateRecordButton.Image = global::Expance_Tracker.Properties.Resources.system_software_update;
            this.UpdateRecordButton.Location = new System.Drawing.Point(4, 82);
            this.UpdateRecordButton.Name = "UpdateRecordButton";
            this.UpdateRecordButton.Size = new System.Drawing.Size(181, 73);
            this.UpdateRecordButton.TabIndex = 0;
            this.UpdateRecordButton.Text = "Update Record";
            this.UpdateRecordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateRecordButton.UseVisualStyleBackColor = true;
            this.UpdateRecordButton.Click += new System.EventHandler(this.UpdateRecordButton_Click);
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.FlatAppearance.BorderSize = 0;
            this.AddRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRecordButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRecordButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddRecordButton.Image = global::Expance_Tracker.Properties.Resources.list_add_4;
            this.AddRecordButton.Location = new System.Drawing.Point(-1, 3);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(185, 73);
            this.AddRecordButton.TabIndex = 0;
            this.AddRecordButton.Text = "Add Record";
            this.AddRecordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddRecordButton.UseVisualStyleBackColor = true;
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(100)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.ViewChartButton);
            this.panel2.Controls.Add(this.ExpListButton);
            this.panel2.Location = new System.Drawing.Point(204, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 172);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // ViewChartButton
            // 
            this.ViewChartButton.FlatAppearance.BorderSize = 0;
            this.ViewChartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewChartButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewChartButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ViewChartButton.Image = global::Expance_Tracker.Properties.Resources.office_chart_area_stacked;
            this.ViewChartButton.Location = new System.Drawing.Point(-3, 87);
            this.ViewChartButton.Name = "ViewChartButton";
            this.ViewChartButton.Size = new System.Drawing.Size(185, 73);
            this.ViewChartButton.TabIndex = 0;
            this.ViewChartButton.Text = "Statistic";
            this.ViewChartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ViewChartButton.UseVisualStyleBackColor = true;
            this.ViewChartButton.Click += new System.EventHandler(this.ViewChartButton_Click);
            // 
            // ExpListButton
            // 
            this.ExpListButton.FlatAppearance.BorderSize = 0;
            this.ExpListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpListButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpListButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExpListButton.Image = global::Expance_Tracker.Properties.Resources.preferences_contact_list;
            this.ExpListButton.Location = new System.Drawing.Point(3, 8);
            this.ExpListButton.Name = "ExpListButton";
            this.ExpListButton.Size = new System.Drawing.Size(179, 73);
            this.ExpListButton.TabIndex = 0;
            this.ExpListButton.Text = "Expanses List";
            this.ExpListButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExpListButton.UseVisualStyleBackColor = true;
            this.ExpListButton.Click += new System.EventHandler(this.ExpListButton_Click);
            // 
            // Expanses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(1084, 642);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Expanses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Expanses_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.TaskPanel.ResumeLayout(false);
            this.TaskPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button ExpanseButton;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button ManageExpButton;
        private System.Windows.Forms.Panel SlidePanel;
        private System.Windows.Forms.Panel TaskPanel;
        private ePOSOne.btnProduct.Button_WOC TopExitButton;
        private ePOSOne.btnProduct.Button_WOC TopMinimizeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DeleteRecordButton;
        private System.Windows.Forms.Button UpdateRecordButton;
        private System.Windows.Forms.Button AddRecordButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ViewChartButton;
        private System.Windows.Forms.Button ExpListButton;
        private ePOSOne.btnProduct.Button_WOC TopExpandButton;
        private System.Windows.Forms.Label label2;
    }
}

