﻿using proiectPaw.Others;

namespace proiectPaw.Forms
{
    partial class ViewBatchesForm
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
            this.dataGridViewBatches = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBatches)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBatches
            // 
            this.dataGridViewBatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBatches.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewBatches.Name = "dataGridViewBatches";
            this.dataGridViewBatches.RowHeadersWidth = 51;
            this.dataGridViewBatches.RowTemplate.Height = 24;
            this.dataGridViewBatches.Size = new System.Drawing.Size(776, 387);
            this.dataGridViewBatches.TabIndex = 0;
            this.dataGridViewBatches.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewBatches_CellContentClick);
            // 
            // ViewBatchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewBatches);
            this.Name = "ViewBatchesForm";
            this.Text = "Vizualizare loturi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBatches)).EndInit();
            this.ResumeLayout(false);
        
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBatches;
    }
}