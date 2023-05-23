namespace CompanyStruture
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddEmployee = new System.Windows.Forms.Button();
            this.ShowListEmployee = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pesel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // AddEmployee
            // 
            this.AddEmployee.Location = new System.Drawing.Point(12, 12);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(132, 33);
            this.AddEmployee.TabIndex = 0;
            this.AddEmployee.Text = "Add employee";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // ShowListEmployee
            // 
            this.ShowListEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Name2,
            this.Surname,
            this.Pesel});
            this.ShowListEmployee.FullRowSelect = true;
            this.ShowListEmployee.HideSelection = false;
            this.ShowListEmployee.Location = new System.Drawing.Point(13, 51);
            this.ShowListEmployee.Name = "ShowListEmployee";
            this.ShowListEmployee.Size = new System.Drawing.Size(571, 388);
            this.ShowListEmployee.TabIndex = 1;
            this.ShowListEmployee.UseCompatibleStateImageBehavior = false;
            this.ShowListEmployee.View = System.Windows.Forms.View.Details;
            this.ShowListEmployee.SelectedIndexChanged += new System.EventHandler(this.ShowListEmployee_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 130;
            // 
            // Name2
            // 
            this.Name2.Text = "Name";
            this.Name2.Width = 130;
            // 
            // Surname
            // 
            this.Surname.Text = "Surname";
            this.Surname.Width = 170;
            // 
            // Pesel
            // 
            this.Pesel.Text = "Pesel";
            this.Pesel.Width = 90;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 448);
            this.Controls.Add(this.ShowListEmployee);
            this.Controls.Add(this.AddEmployee);
            this.Name = "EmployeeForm";
            this.Text = "Employee";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.ListView ShowListEmployee;
        private System.Windows.Forms.ColumnHeader Name2;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader Pesel;
        private System.Windows.Forms.ColumnHeader Id;
    }
}

