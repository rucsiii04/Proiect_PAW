using proiectPaw.Others;

namespace proiectPaw.Forms
{
    partial class AddBatchForm
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
            this.productionDateLabel = new System.Windows.Forms.Label();
            this.expirationDateLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.dateTimePickerProductionDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productionDateLabel
            // 
            this.productionDateLabel.AutoSize = true;
            this.productionDateLabel.Location = new System.Drawing.Point(58, 37);
            this.productionDateLabel.Name = "productionDateLabel";
            this.productionDateLabel.Size = new System.Drawing.Size(99, 16);
            this.productionDateLabel.TabIndex = 0;
            this.productionDateLabel.Text = "Data producerii";
            // 
            // expirationDateLabel
            // 
            this.expirationDateLabel.AutoSize = true;
            this.expirationDateLabel.Location = new System.Drawing.Point(61, 86);
            this.expirationDateLabel.Name = "expirationDateLabel";
            this.expirationDateLabel.Size = new System.Drawing.Size(86, 16);
            this.expirationDateLabel.TabIndex = 1;
            this.expirationDateLabel.Text = "Data expirării";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(61, 141);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(59, 16);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Cantitate";
            // 
            // dateTimePickerProductionDate
            // 
            this.dateTimePickerProductionDate.Location = new System.Drawing.Point(225, 37);
            this.dateTimePickerProductionDate.Name = "dateTimePickerProductionDate";
            this.dateTimePickerProductionDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerProductionDate.TabIndex = 3;
            // 
            // dateTimePickerExpirationDate
            // 
            this.dateTimePickerExpirationDate.Location = new System.Drawing.Point(225, 80);
            this.dateTimePickerExpirationDate.Name = "dateTimePickerExpirationDate";
            this.dateTimePickerExpirationDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerExpirationDate.TabIndex = 4;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(225, 134);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(200, 22);
            this.quantityTextBox.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(350, 209);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Salvează";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(497, 209);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Anulează";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddBatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 296);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.dateTimePickerExpirationDate);
            this.Controls.Add(this.dateTimePickerProductionDate);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.expirationDateLabel);
            this.Controls.Add(this.productionDateLabel);
            this.Name = "AddBatchForm";
            this.Text = "Adaugare lot";
            this.ResumeLayout(false);
            this.PerformLayout();
           
        }

        #endregion

        private System.Windows.Forms.Label productionDateLabel;
        private System.Windows.Forms.Label expirationDateLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerProductionDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpirationDate;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}