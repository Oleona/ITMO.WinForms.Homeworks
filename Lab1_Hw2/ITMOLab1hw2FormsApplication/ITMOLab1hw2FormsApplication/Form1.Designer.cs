namespace ITMOLab1hw2FormsApplication
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
            this.GREENPEACE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GREENPEACE
            // 
            this.GREENPEACE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GREENPEACE.Location = new System.Drawing.Point(166, 205);
            this.GREENPEACE.Name = "GREENPEACE";
            this.GREENPEACE.Size = new System.Drawing.Size(142, 65);
            this.GREENPEACE.TabIndex = 0;
            this.GREENPEACE.Text = " GREENPEACE";
            this.GREENPEACE.UseVisualStyleBackColor = true;
            this.GREENPEACE.Click += new System.EventHandler(this.GREENPEACE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(475, 505);
            this.Controls.Add(this.GREENPEACE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GREENPEACE;
    }
}

