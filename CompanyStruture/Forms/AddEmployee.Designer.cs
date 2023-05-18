namespace CompanyStruture
{
    partial class AddEmployee
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
            this.addBtn = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.peselTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.peselLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.streetComboBox = new System.Windows.Forms.TextBox();
            this.addressInfoLabel = new System.Windows.Forms.Label();
            this.localNrLabel = new System.Windows.Forms.Label();
            this.buildingNrLabel = new System.Windows.Forms.Label();
            this.localNumberTextBox = new System.Windows.Forms.TextBox();
            this.buildingNumberTextBox = new System.Windows.Forms.TextBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.peselError = new System.Windows.Forms.ErrorProvider(this.components);
            this.nameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.surnameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.streetError = new System.Windows.Forms.ErrorProvider(this.components);
            this.buildingNrError = new System.Windows.Forms.ErrorProvider(this.components);
            this.localNrError = new System.Windows.Forms.ErrorProvider(this.components);
            this.cityError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.peselError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingNrError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localNrError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityError)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(205, 411);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(95, 27);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Location = new System.Drawing.Point(138, 34);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(162, 22);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnameTextBox.Location = new System.Drawing.Point(138, 73);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(162, 22);
            this.surnameTextBox.TabIndex = 2;
            this.surnameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.surnameTextBox_Validating);
            // 
            // peselTextBox
            // 
            this.peselTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.peselTextBox.Location = new System.Drawing.Point(138, 116);
            this.peselTextBox.Name = "peselTextBox";
            this.peselTextBox.Size = new System.Drawing.Size(162, 22);
            this.peselTextBox.TabIndex = 3;
            this.peselTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PeselTextBox_Validating);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 37);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 16);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(12, 79);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(61, 16);
            this.surnameLabel.TabIndex = 5;
            this.surnameLabel.Text = "Surname";
            // 
            // peselLabel
            // 
            this.peselLabel.AutoSize = true;
            this.peselLabel.Location = new System.Drawing.Point(12, 122);
            this.peselLabel.Name = "peselLabel";
            this.peselLabel.Size = new System.Drawing.Size(42, 16);
            this.peselLabel.TabIndex = 6;
            this.peselLabel.Text = "Pesel";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(12, 205);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(42, 16);
            this.streetLabel.TabIndex = 9;
            this.streetLabel.Text = "Street";
            // 
            // streetComboBox
            // 
            this.streetComboBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.streetComboBox.Location = new System.Drawing.Point(138, 199);
            this.streetComboBox.Name = "streetComboBox";
            this.streetComboBox.Size = new System.Drawing.Size(162, 22);
            this.streetComboBox.TabIndex = 8;
            this.streetComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.streetComboBox_Validating);
            // 
            // addressInfoLabel
            // 
            this.addressInfoLabel.AutoSize = true;
            this.addressInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addressInfoLabel.Location = new System.Drawing.Point(12, 170);
            this.addressInfoLabel.Name = "addressInfoLabel";
            this.addressInfoLabel.Size = new System.Drawing.Size(65, 16);
            this.addressInfoLabel.TabIndex = 7;
            this.addressInfoLabel.Text = "Address";
            // 
            // localNrLabel
            // 
            this.localNrLabel.AutoSize = true;
            this.localNrLabel.Location = new System.Drawing.Point(12, 291);
            this.localNrLabel.Name = "localNrLabel";
            this.localNrLabel.Size = new System.Drawing.Size(88, 16);
            this.localNrLabel.TabIndex = 13;
            this.localNrLabel.Text = "Local number";
            // 
            // buildingNrLabel
            // 
            this.buildingNrLabel.AutoSize = true;
            this.buildingNrLabel.Location = new System.Drawing.Point(12, 248);
            this.buildingNrLabel.Name = "buildingNrLabel";
            this.buildingNrLabel.Size = new System.Drawing.Size(103, 16);
            this.buildingNrLabel.TabIndex = 12;
            this.buildingNrLabel.Text = "Building number";
            // 
            // localNumberTextBox
            // 
            this.localNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.localNumberTextBox.Location = new System.Drawing.Point(138, 285);
            this.localNumberTextBox.Name = "localNumberTextBox";
            this.localNumberTextBox.Size = new System.Drawing.Size(162, 22);
            this.localNumberTextBox.TabIndex = 11;
            this.localNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.localNumberTextBox_Validating);
            // 
            // buildingNumberTextBox
            // 
            this.buildingNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buildingNumberTextBox.Location = new System.Drawing.Point(138, 242);
            this.buildingNumberTextBox.Name = "buildingNumberTextBox";
            this.buildingNumberTextBox.Size = new System.Drawing.Size(162, 22);
            this.buildingNumberTextBox.TabIndex = 10;
            this.buildingNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.buildingNumberTextBox_Validating);
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(138, 330);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(162, 24);
            this.cityComboBox.TabIndex = 14;
            this.cityComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.cityComboBox_Validating);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(12, 338);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(29, 16);
            this.cityLabel.TabIndex = 15;
            this.cityLabel.Text = "City";
            // 
            // peselError
            // 
            this.peselError.ContainerControl = this;
            // 
            // nameError
            // 
            this.nameError.ContainerControl = this;
            // 
            // surnameError
            // 
            this.surnameError.ContainerControl = this;
            // 
            // streetError
            // 
            this.streetError.ContainerControl = this;
            // 
            // buildingNrError
            // 
            this.buildingNrError.ContainerControl = this;
            // 
            // localNrError
            // 
            this.localNrError.ContainerControl = this;
            // 
            // cityError
            // 
            this.cityError.ContainerControl = this;
            // 
            // AdditionEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 450);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.localNrLabel);
            this.Controls.Add(this.buildingNrLabel);
            this.Controls.Add(this.localNumberTextBox);
            this.Controls.Add(this.buildingNumberTextBox);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.streetComboBox);
            this.Controls.Add(this.addressInfoLabel);
            this.Controls.Add(this.peselLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.peselTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addBtn);
            this.Name = "AdditionEmployee";
            this.Text = "AdditionEmployee";
            this.Load += new System.EventHandler(this.AdditionEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peselError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingNrError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localNrError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox peselTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label peselLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.TextBox streetComboBox;
        private System.Windows.Forms.Label addressInfoLabel;
        private System.Windows.Forms.Label localNrLabel;
        private System.Windows.Forms.Label buildingNrLabel;
        private System.Windows.Forms.TextBox localNumberTextBox;
        private System.Windows.Forms.TextBox buildingNumberTextBox;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.ErrorProvider peselError;
        private System.Windows.Forms.ErrorProvider nameError;
        private System.Windows.Forms.ErrorProvider surnameError;
        private System.Windows.Forms.ErrorProvider streetError;
        private System.Windows.Forms.ErrorProvider buildingNrError;
        private System.Windows.Forms.ErrorProvider localNrError;
        private System.Windows.Forms.ErrorProvider cityError;
    }
}