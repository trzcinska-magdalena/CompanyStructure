namespace CompanyStruture.Forms
{
    partial class AddAbsence
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
            this.employeeInfoLabel = new System.Windows.Forms.Label();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.DateFromLabel = new System.Windows.Forms.Label();
            this.dateToLabel = new System.Windows.Forms.Label();
            this.dateToPicker = new System.Windows.Forms.DateTimePicker();
            this.dateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.addBtn = new System.Windows.Forms.Button();
            this.nameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateFromError = new System.Windows.Forms.ErrorProvider(this.components);
            this.datetoError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFromError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetoError)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeInfoLabel
            // 
            this.employeeInfoLabel.AutoSize = true;
            this.employeeInfoLabel.Location = new System.Drawing.Point(12, 9);
            this.employeeInfoLabel.Name = "employeeInfoLabel";
            this.employeeInfoLabel.Size = new System.Drawing.Size(43, 16);
            this.employeeInfoLabel.TabIndex = 0;
            this.employeeInfoLabel.Text = "............";
            // 
            // nameComboBox
            // 
            this.nameComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(98, 50);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(136, 24);
            this.nameComboBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 53);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 16);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // DateFromLabel
            // 
            this.DateFromLabel.AutoSize = true;
            this.DateFromLabel.Location = new System.Drawing.Point(12, 87);
            this.DateFromLabel.Name = "DateFromLabel";
            this.DateFromLabel.Size = new System.Drawing.Size(65, 16);
            this.DateFromLabel.TabIndex = 4;
            this.DateFromLabel.Text = "Date from";
            // 
            // dateToLabel
            // 
            this.dateToLabel.AutoSize = true;
            this.dateToLabel.Location = new System.Drawing.Point(12, 119);
            this.dateToLabel.Name = "dateToLabel";
            this.dateToLabel.Size = new System.Drawing.Size(50, 16);
            this.dateToLabel.TabIndex = 6;
            this.dateToLabel.Text = "Date to";
            // 
            // dateToPicker
            // 
            this.dateToPicker.CustomFormat = "yyyy-MM-dd";
            this.dateToPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateToPicker.Location = new System.Drawing.Point(98, 114);
            this.dateToPicker.Margin = new System.Windows.Forms.Padding(5);
            this.dateToPicker.Name = "dateToPicker";
            this.dateToPicker.Size = new System.Drawing.Size(112, 22);
            this.dateToPicker.TabIndex = 5;
            this.dateToPicker.Value = new System.DateTime(2023, 5, 18, 7, 41, 18, 0);
            // 
            // dateFromPicker
            // 
            this.dateFromPicker.CustomFormat = "yyyy-MM-dd";
            this.dateFromPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFromPicker.Location = new System.Drawing.Point(98, 82);
            this.dateFromPicker.Margin = new System.Windows.Forms.Padding(5);
            this.dateFromPicker.Name = "dateFromPicker";
            this.dateFromPicker.Size = new System.Drawing.Size(112, 22);
            this.dateFromPicker.TabIndex = 7;
            this.dateFromPicker.Value = new System.DateTime(2023, 5, 18, 7, 41, 18, 0);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(222, 164);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(72, 26);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // nameError
            // 
            this.nameError.ContainerControl = this;
            // 
            // dateFromError
            // 
            this.dateFromError.ContainerControl = this;
            // 
            // datetoError
            // 
            this.datetoError.ContainerControl = this;
            // 
            // AddAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 202);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dateFromPicker);
            this.Controls.Add(this.dateToLabel);
            this.Controls.Add(this.dateToPicker);
            this.Controls.Add(this.DateFromLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.employeeInfoLabel);
            this.Name = "AddAbsence";
            this.Text = "Add absence";
            this.Load += new System.EventHandler(this.AddAbsence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFromError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetoError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeInfoLabel;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label DateFromLabel;
        private System.Windows.Forms.Label dateToLabel;
        private System.Windows.Forms.DateTimePicker dateToPicker;
        private System.Windows.Forms.DateTimePicker dateFromPicker;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ErrorProvider nameError;
        private System.Windows.Forms.ErrorProvider dateFromError;
        private System.Windows.Forms.ErrorProvider datetoError;
    }
}