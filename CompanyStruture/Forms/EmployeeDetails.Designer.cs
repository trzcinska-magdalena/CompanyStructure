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
            this.Department = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContractNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SalaryType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Salary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContractType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // NameEmp
            // 
            this.NameEmp.AutoSize = true;
            this.NameEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameEmp.Location = new System.Drawing.Point(12, 84);
            this.NameEmp.Name = "NameEmp";
            this.NameEmp.Size = new System.Drawing.Size(31, 13);
            this.NameEmp.TabIndex = 0;
            this.NameEmp.Text = "......";
            // 
            // AddAbsenceBtn
            // 
            this.AddAbsenceBtn.Location = new System.Drawing.Point(15, 21);
            this.AddAbsenceBtn.Name = "AddAbsenceBtn";
            this.AddAbsenceBtn.Size = new System.Drawing.Size(120, 32);
            this.AddAbsenceBtn.TabIndex = 1;
            this.AddAbsenceBtn.Text = "Add absence";
            this.AddAbsenceBtn.UseVisualStyleBackColor = true;
            this.AddAbsenceBtn.Click += new System.EventHandler(this.AddAbsenceBtn_Click);
            // 
            // absenceTreeView
            // 
            this.absenceTreeView.Location = new System.Drawing.Point(365, 21);
            this.absenceTreeView.Name = "absenceTreeView";
            this.absenceTreeView.Size = new System.Drawing.Size(284, 282);
            this.absenceTreeView.TabIndex = 2;
            // 
            // ContractListView
            // 
            this.ContractListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ContractNumber,
            this.ContractType,
            this.Department,
            this.Position,
            this.DateFrom,
            this.DateTo,
            this.SalaryType,
            this.Salary});
            this.ContractListView.HideSelection = false;
            this.ContractListView.Location = new System.Drawing.Point(12, 325);
            this.ContractListView.Name = "ContractListView";
            this.ContractListView.Size = new System.Drawing.Size(637, 97);
            this.ContractListView.TabIndex = 3;
            this.ContractListView.UseCompatibleStateImageBehavior = false;
            this.ContractListView.View = System.Windows.Forms.View.Details;
            // 
            // Department
            // 
            this.Department.DisplayIndex = 1;
            this.Department.Text = "Department";
            this.Department.Width = 101;
            // 
            // ContractNumber
            // 
            this.ContractNumber.Text = "Number";
            // 
            // Position
            // 
            this.Position.DisplayIndex = 2;
            this.Position.Text = "Position";
            this.Position.Width = 71;
            // 
            // DateFrom
            // 
            this.DateFrom.DisplayIndex = 3;
            this.DateFrom.Text = "Date from";
            this.DateFrom.Width = 98;
            // 
            // DateTo
            // 
            this.DateTo.DisplayIndex = 4;
            this.DateTo.Text = "Date to";
            this.DateTo.Width = 86;
            // 
            // SalaryType
            // 
            this.SalaryType.DisplayIndex = 5;
            this.SalaryType.Text = "Salary type";
            this.SalaryType.Width = 102;
            // 
            // Salary
            // 
            this.Salary.DisplayIndex = 6;
            this.Salary.Text = "Salary";
            // 
            // ContractType
            // 
            this.ContractType.Text = "Contract type";
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
        private System.Windows.Forms.ColumnHeader ContractNumber;
        private System.Windows.Forms.ColumnHeader Department;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.ColumnHeader DateFrom;
        private System.Windows.Forms.ColumnHeader DateTo;
        private System.Windows.Forms.ColumnHeader SalaryType;
        private System.Windows.Forms.ColumnHeader Salary;
        private System.Windows.Forms.ColumnHeader ContractType;
    }
}