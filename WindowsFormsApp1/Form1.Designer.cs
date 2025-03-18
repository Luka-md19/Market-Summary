namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnReadAllData = new System.Windows.Forms.Button();
            this.lblElementRead = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnReadAllData
            // 
            this.btnReadAllData.Location = new System.Drawing.Point(44, 105);
            this.btnReadAllData.Name = "btnReadAllData";
            this.btnReadAllData.Size = new System.Drawing.Size(170, 43);
            this.btnReadAllData.TabIndex = 0;
            this.btnReadAllData.Text = "Read All Data";
            this.btnReadAllData.UseVisualStyleBackColor = true;
            this.btnReadAllData.Click += new System.EventHandler(this.btnReadAllData_Click);
            // 
            // lblElementRead
            // 
            this.lblElementRead.AutoSize = true;
            this.lblElementRead.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElementRead.Location = new System.Drawing.Point(40, 181);
            this.lblElementRead.Name = "lblElementRead";
            this.lblElementRead.Size = new System.Drawing.Size(209, 23);
            this.lblElementRead.TabIndex = 1;
            this.lblElementRead.Text = "28 items read from File ";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(44, 252);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(170, 43);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report ";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(399, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 388);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 529);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.lblElementRead);
            this.Controls.Add(this.btnReadAllData);
            this.Name = "Form1";
            this.Text = "Quiz3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadAllData;
        private System.Windows.Forms.Label lblElementRead;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ListBox listBox1;
    }
}

