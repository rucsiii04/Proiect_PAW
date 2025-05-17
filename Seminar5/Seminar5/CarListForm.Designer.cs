namespace Seminar5
{
    partial class CarListForm
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
            this.CarsDataGridView = new System.Windows.Forms.DataGridView();
            this.carListMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carListMenu = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.CarsDataGridView)).BeginInit();
            this.carListMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarsDataGridView
            // 
            this.CarsDataGridView.AllowUserToAddRows = false;
            this.CarsDataGridView.AllowUserToDeleteRows = false;
            this.CarsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsDataGridView.Location = new System.Drawing.Point(-3, 61);
            this.CarsDataGridView.Name = "CarsDataGridView";
            this.CarsDataGridView.ReadOnly = true;
            this.CarsDataGridView.RowHeadersWidth = 51;
            this.CarsDataGridView.RowTemplate.Height = 24;
            this.CarsDataGridView.Size = new System.Drawing.Size(871, 456);
            this.CarsDataGridView.TabIndex = 0;
            // 
            // carListMenuStrip
            // 
            this.carListMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCarToolStripMenuItem});
            this.carListMenuStrip.Name = "carListMenuStrip";
            this.carListMenuStrip.Size = new System.Drawing.Size(66, 24);
            this.carListMenuStrip.Text = "Masini";
            // 
            // addCarToolStripMenuItem
            // 
            this.addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            this.addCarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addCarToolStripMenuItem.Text = "Adauga";
            this.addCarToolStripMenuItem.Click += new System.EventHandler(this.addCarToolStripMenuItem_Click);
            // 
            // carListMenu
            // 
            this.carListMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.carListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carListMenuStrip});
            this.carListMenu.Location = new System.Drawing.Point(0, 0);
            this.carListMenu.Name = "carListMenu";
            this.carListMenu.Size = new System.Drawing.Size(868, 28);
            this.carListMenu.TabIndex = 1;
            this.carListMenu.Text = "carMenuStrip";
            // 
            // CarListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.CarsDataGridView);
            this.Controls.Add(this.carListMenu);
            this.MainMenuStrip = this.carListMenu;
            this.Name = "CarListForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CarsDataGridView)).EndInit();
            this.carListMenu.ResumeLayout(false);
            this.carListMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CarsDataGridView;
        private System.Windows.Forms.ToolStripMenuItem carListMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addCarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip carListMenu;
    }
}

