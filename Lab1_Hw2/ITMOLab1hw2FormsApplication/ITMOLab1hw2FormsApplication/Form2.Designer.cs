﻿namespace ITMOLab1hw2FormsApplication
{
    partial class Form2
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
            this.callForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // callForm1
            // 
            this.callForm1.Location = new System.Drawing.Point(88, 69);
            this.callForm1.Name = "callForm1";
            this.callForm1.Size = new System.Drawing.Size(75, 23);
            this.callForm1.TabIndex = 0;
            this.callForm1.Text = "Call Form1";
            this.callForm1.UseVisualStyleBackColor = true;
            this.callForm1.Click += new System.EventHandler(this.callForm1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.callForm1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button callForm1;
    }
}