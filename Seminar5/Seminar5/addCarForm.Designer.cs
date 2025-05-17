namespace Seminar5
{
    partial class addCarForm
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
            this.LicenseLabel = new System.Windows.Forms.Label();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextbox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.seatsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.seatsLabel = new System.Windows.Forms.Label();
            this.hasInsuranceCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.LicenseNumberTextBox = new System.Windows.Forms.TextBox();
            this.LicenseNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // LicenseLabel
            // 
            this.LicenseLabel.AutoSize = true;
            this.LicenseLabel.Location = new System.Drawing.Point(12, 9);
            this.LicenseLabel.Name = "LicenseLabel";
            this.LicenseLabel.Size = new System.Drawing.Size(45, 16);
            this.LicenseLabel.TabIndex = 0;
            this.LicenseLabel.Text = "Marca";
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(151, 9);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(120, 22);
            this.makeTextBox.TabIndex = 1;
            // 
            // modelTextbox
            // 
            this.modelTextbox.Location = new System.Drawing.Point(151, 41);
            this.modelTextbox.Name = "modelTextbox";
            this.modelTextbox.Size = new System.Drawing.Size(120, 22);
            this.modelTextbox.TabIndex = 2;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(13, 37);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(45, 16);
            this.modelLabel.TabIndex = 3;
            this.modelLabel.Text = "Model";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(16, 71);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(33, 16);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Anul";
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Location = new System.Drawing.Point(151, 69);
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.yearNumericUpDown.TabIndex = 5;
            // 
            // seatsNumericUpDown
            // 
            this.seatsNumericUpDown.Location = new System.Drawing.Point(151, 97);
            this.seatsNumericUpDown.Name = "seatsNumericUpDown";
            this.seatsNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.seatsNumericUpDown.TabIndex = 6;
            // 
            // seatsLabel
            // 
            this.seatsLabel.AutoSize = true;
            this.seatsLabel.Location = new System.Drawing.Point(15, 105);
            this.seatsLabel.Name = "seatsLabel";
            this.seatsLabel.Size = new System.Drawing.Size(82, 16);
            this.seatsLabel.TabIndex = 7;
            this.seatsLabel.Text = "Numar locuri";
            // 
            // hasInsuranceCheckBox
            // 
            this.hasInsuranceCheckBox.AutoSize = true;
            this.hasInsuranceCheckBox.Location = new System.Drawing.Point(123, 161);
            this.hasInsuranceCheckBox.Name = "hasInsuranceCheckBox";
            this.hasInsuranceCheckBox.Size = new System.Drawing.Size(110, 20);
            this.hasInsuranceCheckBox.TabIndex = 8;
            this.hasInsuranceCheckBox.Text = "Are asigurare";
            this.hasInsuranceCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(123, 197);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Salveaza";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(236, 197);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Anuleaza";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // LicenseNumberTextBox
            // 
            this.LicenseNumberTextBox.Location = new System.Drawing.Point(151, 128);
            this.LicenseNumberTextBox.Name = "LicenseNumberTextBox";
            this.LicenseNumberTextBox.Size = new System.Drawing.Size(120, 22);
            this.LicenseNumberTextBox.TabIndex = 11;
            // 
            // LicenseNumberLabel
            // 
            this.LicenseNumberLabel.AutoSize = true;
            this.LicenseNumberLabel.Location = new System.Drawing.Point(19, 131);
            this.LicenseNumberLabel.Name = "LicenseNumberLabel";
            this.LicenseNumberLabel.Size = new System.Drawing.Size(126, 16);
            this.LicenseNumberLabel.TabIndex = 12;
            this.LicenseNumberLabel.Text = "Numar inmatriculare";
            // 
            // addCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LicenseNumberLabel);
            this.Controls.Add(this.LicenseNumberTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.hasInsuranceCheckBox);
            this.Controls.Add(this.seatsLabel);
            this.Controls.Add(this.seatsNumericUpDown);
            this.Controls.Add(this.yearNumericUpDown);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.modelTextbox);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(this.LicenseLabel);
            this.Name = "addCarForm";
            this.Text = "addCarForm";
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LicenseLabel;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox modelTextbox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
        private System.Windows.Forms.NumericUpDown seatsNumericUpDown;
        private System.Windows.Forms.Label seatsLabel;
        private System.Windows.Forms.CheckBox hasInsuranceCheckBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox LicenseNumberTextBox;
        private System.Windows.Forms.Label LicenseNumberLabel;
    }
}