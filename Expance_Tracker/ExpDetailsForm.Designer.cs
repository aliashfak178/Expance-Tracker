namespace Expance_Tracker
{
    partial class ExpDetailsForm
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
            this.TopExitButton = new ePOSOne.btnProduct.Button_WOC();
            this.ExpIdlable = new System.Windows.Forms.Label();
            this.DateTimelabel = new System.Windows.Forms.Label();
            this.Catagorylabel = new System.Windows.Forms.Label();
            this.Amountlabel = new System.Windows.Forms.Label();
            this.Desclabel = new System.Windows.Forms.Label();
            this.TaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskPanel
            // 
            this.TaskPanel.BackColor = System.Drawing.Color.SeaGreen;
            this.TaskPanel.Controls.Add(this.label1);
            this.TaskPanel.Controls.Add(this.TopExitButton);
            this.TaskPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TaskPanel.Location = new System.Drawing.Point(0, 0);
            this.TaskPanel.Name = "TaskPanel";
            this.TaskPanel.Size = new System.Drawing.Size(621, 40);
            this.TaskPanel.TabIndex = 4;
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
            this.label1.Location = new System.Drawing.Point(198, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Deatails";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskPanel_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TaskPanel_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TaskPanel_MouseUp);
            // 
            // TopExitButton
            // 
            this.TopExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopExitButton.BorderColor = System.Drawing.Color.Silver;
            this.TopExitButton.ButtonColor = System.Drawing.Color.Red;
            this.TopExitButton.FlatAppearance.BorderSize = 0;
            this.TopExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopExitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopExitButton.Location = new System.Drawing.Point(581, 5);
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
            // ExpIdlable
            // 
            this.ExpIdlable.AutoSize = true;
            this.ExpIdlable.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpIdlable.ForeColor = System.Drawing.Color.ForestGreen;
            this.ExpIdlable.Location = new System.Drawing.Point(218, 72);
            this.ExpIdlable.Name = "ExpIdlable";
            this.ExpIdlable.Size = new System.Drawing.Size(97, 36);
            this.ExpIdlable.TabIndex = 5;
            this.ExpIdlable.Text = "label2";
            // 
            // DateTimelabel
            // 
            this.DateTimelabel.AutoSize = true;
            this.DateTimelabel.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimelabel.ForeColor = System.Drawing.Color.Red;
            this.DateTimelabel.Location = new System.Drawing.Point(61, 171);
            this.DateTimelabel.Name = "DateTimelabel";
            this.DateTimelabel.Size = new System.Drawing.Size(97, 36);
            this.DateTimelabel.TabIndex = 5;
            this.DateTimelabel.Text = "label2";
            // 
            // Catagorylabel
            // 
            this.Catagorylabel.AutoSize = true;
            this.Catagorylabel.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catagorylabel.ForeColor = System.Drawing.Color.Olive;
            this.Catagorylabel.Location = new System.Drawing.Point(61, 244);
            this.Catagorylabel.Name = "Catagorylabel";
            this.Catagorylabel.Size = new System.Drawing.Size(97, 36);
            this.Catagorylabel.TabIndex = 5;
            this.Catagorylabel.Text = "label2";
            // 
            // Amountlabel
            // 
            this.Amountlabel.AutoSize = true;
            this.Amountlabel.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amountlabel.ForeColor = System.Drawing.Color.Turquoise;
            this.Amountlabel.Location = new System.Drawing.Point(61, 329);
            this.Amountlabel.Name = "Amountlabel";
            this.Amountlabel.Size = new System.Drawing.Size(97, 36);
            this.Amountlabel.TabIndex = 5;
            this.Amountlabel.Text = "label2";
            // 
            // Desclabel
            // 
            this.Desclabel.AutoSize = true;
            this.Desclabel.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desclabel.ForeColor = System.Drawing.Color.Blue;
            this.Desclabel.Location = new System.Drawing.Point(61, 408);
            this.Desclabel.Name = "Desclabel";
            this.Desclabel.Size = new System.Drawing.Size(97, 36);
            this.Desclabel.TabIndex = 5;
            this.Desclabel.Text = "label2";
            // 
            // ExpDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(621, 571);
            this.Controls.Add(this.Amountlabel);
            this.Controls.Add(this.Desclabel);
            this.Controls.Add(this.Catagorylabel);
            this.Controls.Add(this.DateTimelabel);
            this.Controls.Add(this.ExpIdlable);
            this.Controls.Add(this.TaskPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpDetailsForm";
            this.Load += new System.EventHandler(this.ExpDetailsForm_Load);
            this.TaskPanel.ResumeLayout(false);
            this.TaskPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TaskPanel;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC TopExitButton;
        private System.Windows.Forms.Label ExpIdlable;
        private System.Windows.Forms.Label DateTimelabel;
        private System.Windows.Forms.Label Catagorylabel;
        private System.Windows.Forms.Label Amountlabel;
        private System.Windows.Forms.Label Desclabel;
    }
}