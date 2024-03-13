namespace Intern2.Mehrshad.Forms
{
    partial class EditKalaFm
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
            this.components = new System.ComponentModel.Container();
            this.EditBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryCat = new System.Windows.Forms.ComboBox();
            this.SerialNumberBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.intern2DataSet2 = new Intern2.Mehrshad.intern2DataSet2();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new Intern2.Mehrshad.intern2DataSet2TableAdapters.CategoryTableAdapter();
            this.intern3DataSet3 = new Intern2.Mehrshad.Intern3DataSet3();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter1 = new Intern2.Mehrshad.Intern3DataSet3TableAdapters.CategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.intern2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intern3DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(512, 358);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(104, 36);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(259, 358);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(104, 36);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "serial number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // CategoryCat
            // 
            this.CategoryCat.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryBindingSource, "CategoryID", true));
            this.CategoryCat.DataSource = this.categoryBindingSource1;
            this.CategoryCat.DisplayMember = "Name";
            this.CategoryCat.FormattingEnabled = true;
            this.CategoryCat.Location = new System.Drawing.Point(302, 194);
            this.CategoryCat.Name = "CategoryCat";
            this.CategoryCat.Size = new System.Drawing.Size(286, 21);
            this.CategoryCat.TabIndex = 8;
            this.CategoryCat.ValueMember = "CategoryID";
            // 
            // SerialNumberBox
            // 
            this.SerialNumberBox.Location = new System.Drawing.Point(302, 159);
            this.SerialNumberBox.Name = "SerialNumberBox";
            this.SerialNumberBox.Size = new System.Drawing.Size(286, 20);
            this.SerialNumberBox.TabIndex = 7;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(302, 118);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(286, 20);
            this.NameBox.TabIndex = 6;
            // 
            // intern2DataSet2
            // 
            this.intern2DataSet2.DataSetName = "intern2DataSet2";
            this.intern2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.intern2DataSet2;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // intern3DataSet3
            // 
            this.intern3DataSet3.DataSetName = "Intern3DataSet3";
            this.intern3DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "Category";
            this.categoryBindingSource1.DataSource = this.intern3DataSet3;
            // 
            // categoryTableAdapter1
            // 
            this.categoryTableAdapter1.ClearBeforeFill = true;
            // 
            // EditKalaFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoryCat);
            this.Controls.Add(this.SerialNumberBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.EditBtn);
            this.Name = "EditKalaFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditKalaFm";
            this.Load += new System.EventHandler(this.EditKalaFm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intern2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intern3DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CategoryCat;
        private System.Windows.Forms.TextBox SerialNumberBox;
        private System.Windows.Forms.TextBox NameBox;
        private intern2DataSet2 intern2DataSet2;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private intern2DataSet2TableAdapters.CategoryTableAdapter categoryTableAdapter;
        private Intern3DataSet3 intern3DataSet3;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private Intern3DataSet3TableAdapters.CategoryTableAdapter categoryTableAdapter1;
    }
}