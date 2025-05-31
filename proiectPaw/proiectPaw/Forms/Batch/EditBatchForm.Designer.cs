using System.Windows.Forms;

namespace proiectPaw.Forms
{
    partial class EditBatchForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePickerExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerProductionDate = new System.Windows.Forms.DateTimePicker();
            this.productionDateLabel = new System.Windows.Forms.Label();
            this.expirationDateLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(629, 224);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Anuleaza";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(453, 224);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Modifica";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(285, 110);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.quantityTextBox.TabIndex = 2;
            // 
            // dateTimePickerExpirationDate
            // 
            this.dateTimePickerExpirationDate.Location = new System.Drawing.Point(273, 63);
            this.dateTimePickerExpirationDate.Name = "dateTimePickerExpirationDate";
            this.dateTimePickerExpirationDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerExpirationDate.TabIndex = 3;
            // 
            // dateTimePickerProductionDate
            // 
            this.dateTimePickerProductionDate.Location = new System.Drawing.Point(273, 12);
            this.dateTimePickerProductionDate.Name = "dateTimePickerProductionDate";
            this.dateTimePickerProductionDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerProductionDate.TabIndex = 4;
            // 
            // productionDateLabel
            // 
            this.productionDateLabel.AutoSize = true;
            this.productionDateLabel.Location = new System.Drawing.Point(13, 18);
            this.productionDateLabel.Name = "productionDateLabel";
            this.productionDateLabel.Size = new System.Drawing.Size(99, 16);
            this.productionDateLabel.TabIndex = 5;
            this.productionDateLabel.Text = "Data producerii";
            // 
            // expirationDateLabel
            // 
            this.expirationDateLabel.AutoSize = true;
            this.expirationDateLabel.Location = new System.Drawing.Point(12, 69);
            this.expirationDateLabel.Name = "expirationDateLabel";
            this.expirationDateLabel.Size = new System.Drawing.Size(86, 16);
            this.expirationDateLabel.TabIndex = 6;
            this.expirationDateLabel.Text = "Data expirarii";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(13, 110);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(128, 16);
            this.quantityLabel.TabIndex = 7;
            this.quantityLabel.Text = "Cantitate disponibila";
            // 
            // EditBatchForm
            // 
            this.ClientSize = new System.Drawing.Size(902, 341);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.expirationDateLabel);
            this.Controls.Add(this.productionDateLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.dateTimePickerExpirationDate);
            this.Controls.Add(this.dateTimePickerProductionDate);
            this.Name = "EditBatchForm";
            this.Text = "Editare lot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cancelButton;
        private Button updateButton;
        private TextBox quantityTextBox;
        private DateTimePicker dateTimePickerExpirationDate;
        private DateTimePicker dateTimePickerProductionDate;
        private Label productionDateLabel;
        private Label expirationDateLabel;
        private Label quantityLabel;
    }
}