namespace CompanyStruture.Forms
{
    partial class EmployeeDetails
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
            this.NameEmp = new System.Windows.Forms.Label();
            this.AddAbsenceBtn = new System.Windows.Forms.Button();
            this.absenceTreeView = new System.Windows.Forms.TreeView();
            this.ContractListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // NameEmp
            // 
            this.NameEmp.AutoSize = true;
            this.NameEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameEmp.Location = new System.Drawing.Point(12, 9);
            this.NameEmp.Name = "NameEmp";
            this.NameEmp.Size = new System.Drawing.Size(31, 13);
            this.NameEmp.TabIndex = 0;
            this.NameEmp.Text = "......";
            // 
            // AddAbsenceBtn
            // 
            this.AddAbsenceBtn.Location = new System.Drawing.Point(15, 107);
            this.AddAbsenceBtn.Name = "AddAbsenceBtn";
            this.AddAbsenceBtn.Size = new System.Drawing.Size(120, 32);
            this.AddAbsenceBtn.TabIndex = 1;
            this.AddAbsenceBtn.Text = "Add absence";
            this.AddAbsenceBtn.UseVisualStyleBackColor = true;
            this.AddAbsenceBtn.Click += new System.EventHandler(this.AddAbsenceBtn_Click);
            // 
            // absenceTreeView
            // 
            this.absenceTreeView.Location = new System.Drawing.Point(15, 145);
            this.absenceTreeView.Name = "absenceTreeView";
            this.absenceTreeView.Size = new System.Drawing.Size(292, 277);
            this.absenceTreeView.TabIndex = 2;
            // 
            // ContractListView
            // 
            this.ContractListView.HideSelection = false;
            this.ContractListView.Location = new System.Drawing.Point(322, 145);
            this.ContractListView.Name = "ContractListView";
            this.ContractListView.Size = new System.Drawing.Size(327, 97);
            this.ContractListView.TabIndex = 3;
            this.ContractListView.UseCompatibleStateImageBehavior = false;
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 434);
            this.Controls.Add(this.ContractListView);
            this.Controls.Add(this.absenceTreeView);
            this.Controls.Add(this.AddAbsenceBtn);
            this.Controls.Add(this.NameEmp);
            this.Name = "EmployeeDetails";
            this.Text = "Employee detail";
            this.Load += new System.EventHandler(this.EmployeeDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameEmp;
        private System.Windows.Forms.Button AddAbsenceBtn;
        private System.Windows.Forms.TreeView absenceTreeView;
        private System.Windows.Forms.ListView ContractListView;
    }
}