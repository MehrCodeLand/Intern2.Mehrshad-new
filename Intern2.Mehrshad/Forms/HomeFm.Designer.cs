namespace Intern2.Mehrshad.Forms
{
    partial class HomeFm
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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SeeAllBtn = new System.Windows.Forms.Button();
            this.AllKalaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(249, 157);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(112, 23);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SeeAllBtn
            // 
            this.SeeAllBtn.Location = new System.Drawing.Point(249, 128);
            this.SeeAllBtn.Name = "SeeAllBtn";
            this.SeeAllBtn.Size = new System.Drawing.Size(112, 23);
            this.SeeAllBtn.TabIndex = 1;
            this.SeeAllBtn.Text = "Create Kala";
            this.SeeAllBtn.UseVisualStyleBackColor = true;
            this.SeeAllBtn.Click += new System.EventHandler(this.SeeAllBtn_Click);
            // 
            // AllKalaBtn
            // 
            this.AllKalaBtn.Location = new System.Drawing.Point(249, 99);
            this.AllKalaBtn.Name = "AllKalaBtn";
            this.AllKalaBtn.Size = new System.Drawing.Size(112, 23);
            this.AllKalaBtn.TabIndex = 2;
            this.AllKalaBtn.Text = "All Kala";
            this.AllKalaBtn.UseVisualStyleBackColor = true;
            this.AllKalaBtn.Click += new System.EventHandler(this.AllKalaBtn_Click);
            // 
            // HomeFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 304);
            this.Controls.Add(this.AllKalaBtn);
            this.Controls.Add(this.SeeAllBtn);
            this.Controls.Add(this.ExitBtn);
            this.Name = "HomeFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeFm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button SeeAllBtn;
        private System.Windows.Forms.Button AllKalaBtn;
    }
}