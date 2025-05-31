using proiectPaw.Others;

namespace proiectPaw
{
    partial class FormMain
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
            this.viewProductsButton = new System.Windows.Forms.Button();
            this.viewBatchesButton = new System.Windows.Forms.Button();
            this.addBatchButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.viewOrders = new System.Windows.Forms.Button();
            this.addOrder = new System.Windows.Forms.Button();
            this.totalValueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewProductsButton
            // 
            this.viewProductsButton.Location = new System.Drawing.Point(37, 54);
            this.viewProductsButton.Name = "viewProductsButton";
            this.viewProductsButton.Size = new System.Drawing.Size(132, 23);
            this.viewProductsButton.TabIndex = 0;
            this.viewProductsButton.Text = "Vezi produse";
            this.viewProductsButton.UseVisualStyleBackColor = true;
            this.viewProductsButton.Click += new System.EventHandler(this.buttonOpenProducts_Click);
            // 
            // viewBatchesButton
            // 
            this.viewBatchesButton.Location = new System.Drawing.Point(37, 101);
            this.viewBatchesButton.Name = "viewBatchesButton";
            this.viewBatchesButton.Size = new System.Drawing.Size(132, 23);
            this.viewBatchesButton.TabIndex = 1;
            this.viewBatchesButton.Text = "Vezi loturi";
            this.viewBatchesButton.UseVisualStyleBackColor = true;
            this.viewBatchesButton.Click += new System.EventHandler(this.viewBatchesButton_Click);
            // 
            // addBatchButton
            // 
            this.addBatchButton.Location = new System.Drawing.Point(216, 101);
            this.addBatchButton.Name = "addBatchButton";
            this.addBatchButton.Size = new System.Drawing.Size(128, 23);
            this.addBatchButton.TabIndex = 2;
            this.addBatchButton.Text = "Adaugă lot";
            this.addBatchButton.UseVisualStyleBackColor = true;
            this.addBatchButton.Click += new System.EventHandler(this.addBatchButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(216, 54);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(128, 23);
            this.addProductButton.TabIndex = 3;
            this.addProductButton.Text = "Adaugă produs";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // viewOrders
            // 
            this.viewOrders.Location = new System.Drawing.Point(37, 145);
            this.viewOrders.Name = "viewOrders";
            this.viewOrders.Size = new System.Drawing.Size(132, 23);
            this.viewOrders.TabIndex = 4;
            this.viewOrders.Text = "Vezi comenzi";
            this.viewOrders.UseVisualStyleBackColor = true;
            this.viewOrders.Click += new System.EventHandler(this.viewOrders_Click);
            // 
            // addOrder
            // 
            this.addOrder.Location = new System.Drawing.Point(216, 145);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(128, 23);
            this.addOrder.TabIndex = 5;
            this.addOrder.Text = "Adauga comanda";
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // totalValueButton
            // 
            this.totalValueButton.Location = new System.Drawing.Point(37, 197);
            this.totalValueButton.Name = "totalValueButton";
            this.totalValueButton.Size = new System.Drawing.Size(307, 23);
            this.totalValueButton.TabIndex = 6;
            this.totalValueButton.Text = "Calculeaza valoare totala comenzi";
            this.totalValueButton.UseVisualStyleBackColor = true;
            this.totalValueButton.Click += new System.EventHandler(this.totalValueButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(395, 245);
            this.Controls.Add(this.totalValueButton);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.viewOrders);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.addBatchButton);
            this.Controls.Add(this.viewBatchesButton);
            this.Controls.Add(this.viewProductsButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormMain";
            this.Text = "Pagina principala";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewProductsButton;
        private System.Windows.Forms.Button viewBatchesButton;
        private System.Windows.Forms.Button addBatchButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button viewOrders;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.Button totalValueButton;
    }
}

