namespace CompanyStruture.Forms
{
    partial class EmployeeDetail
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
            this.SuspendLayout();
            // 
            // NameEmp
            // 
            this.NameEmp.AutoSize = true;
            this.NameEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameEmp.Location = new System.Drawing.Point(12, 9);
            this.NameEmp.Name = "NameEmp";
            this.NameEmp.Size = new System.Drawing.Size(31, 16);
            this.NameEmp.TabIndex = 0;
            this.NameEmp.Text = "......";
            // 
            // AddAbsenceBtn
            // 
            this.AddAbsenceBtn.Location = new System.Drawing.Point(529, 9);
            this.AddAbsenceBtn.Name = "AddAbsenceBtn";
            this.AddAbsenceBtn.Size = new System.Drawing.Size(120, 32);
            this.AddAbsenceBtn.TabIndex = 1;
            this.AddAbsenceBtn.Text = "Add absence";
            this.AddAbsenceBtn.UseVisualStyleBackColor = true;
            // 
            // EmployeeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.AddAbsenceBtn);
            this.Controls.Add(this.NameEmp);
            this.Name = "EmployeeDetail";
            this.Text = "Employee detail";
            this.Load += new System.EventHandler(this.EmployeeDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameEmp;
        private System.Windows.Forms.Button AddAbsenceBtn;
    }
}