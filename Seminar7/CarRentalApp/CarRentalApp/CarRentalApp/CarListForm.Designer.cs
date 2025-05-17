﻿namespace CarRentalApp {
    partial class CarListForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.carsDataGridView = new System.Windows.Forms.DataGridView();
            this.carListMenuStrip = new System.Windows.Forms.MenuStrip();
            this.masiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            this.carListMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.AllowUserToAddRows = false;
            this.carsDataGridView.AllowUserToDeleteRows = false;
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.Location = new System.Drawing.Point(16, 68);
            this.carsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.ReadOnly = true;
            this.carsDataGridView.RowHeadersWidth = 51;
            this.carsDataGridView.Size = new System.Drawing.Size(1205, 471);
            this.carsDataGridView.TabIndex = 0;
            this.carsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carsDataGridView_CellContentClick);
            // 
            // carListMenuStrip
            // 
            this.carListMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.carListMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masiniToolStripMenuItem});
            this.carListMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.carListMenuStrip.Name = "carListMenuStrip";
            this.carListMenuStrip.Size = new System.Drawing.Size(1221, 28);
            this.carListMenuStrip.TabIndex = 1;
            this.carListMenuStrip.Text = "menuStrip1";
            // 
            // masiniToolStripMenuItem
            // 
            this.masiniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCarToolStripMenuItem});
            this.masiniToolStripMenuItem.Name = "masiniToolStripMenuItem";
            this.masiniToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.masiniToolStripMenuItem.Text = "Masini";
            // 
            // addCarToolStripMenuItem
            // 
            this.addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            this.addCarToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.addCarToolStripMenuItem.Text = "Adauga";
            this.addCarToolStripMenuItem.Click += new System.EventHandler(this.addCarToolStripMenuItem_Click);
            // 
            // CarListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 554);
            this.Controls.Add(this.carsDataGridView);
            this.Controls.Add(this.carListMenuStrip);
            this.MainMenuStrip = this.carListMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CarListForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            this.carListMenuStrip.ResumeLayout(false);
            this.carListMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView carsDataGridView;
        private System.Windows.Forms.MenuStrip carListMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem masiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCarToolStripMenuItem;
    }
}

