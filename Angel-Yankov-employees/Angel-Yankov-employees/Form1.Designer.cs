
namespace Angel_Yankov_employees
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Employee1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(344, 381);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(167, 43);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee1,
            this.Employee2,
            this.ProjectID,
            this.DaysWorked});
            this.dataGridView1.Location = new System.Drawing.Point(55, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(519, 318);
            this.dataGridView1.TabIndex = 4;
            // 
            // Employee1
            // 
            this.Employee1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Employee1.HeaderText = "Employee ID #1";
            this.Employee1.MinimumWidth = 6;
            this.Employee1.Name = "Employee1";
            this.Employee1.ReadOnly = true;
            this.Employee1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Employee1.Width = 144;
            // 
            // Employee2
            // 
            this.Employee2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Employee2.HeaderText = "Employee ID #2";
            this.Employee2.MinimumWidth = 6;
            this.Employee2.Name = "Employee2";
            this.Employee2.ReadOnly = true;
            this.Employee2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Employee2.Width = 144;
            // 
            // ProjectID
            // 
            this.ProjectID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ProjectID.HeaderText = "Project ID";
            this.ProjectID.MinimumWidth = 6;
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.ReadOnly = true;
            this.ProjectID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProjectID.Width = 103;
            // 
            // DaysWorked
            // 
            this.DaysWorked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DaysWorked.HeaderText = "Days Worked";
            this.DaysWorked.MinimumWidth = 6;
            this.DaysWorked.Name = "DaysWorked";
            this.DaysWorked.ReadOnly = true;
            this.DaysWorked.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DaysWorked.Width = 125;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(114, 381);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(167, 43);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload .CSV file";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Work Log";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysWorked;
        private System.Windows.Forms.Button btnUpload;
    }
}

