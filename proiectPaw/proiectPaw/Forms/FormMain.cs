using proiectPaw.Forms;
using proiectPaw.Forms.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectPaw
{
    public partial class FormMain: Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonOpenProducts_Click(object sender, EventArgs e)
        {
            ProductsForm productForm = new ProductsForm();
            productForm.ShowDialog();
        }
        private void viewBatchesButton_Click(object sender, EventArgs e)
        {
            var viewBatchesForm = new ViewBatchesForm(); 
            viewBatchesForm.ShowDialog(); 
        }
        private void addBatchButton_Click(object sender, EventArgs e)
        {
            var addBatchForm = new AddBatchForm();
            addBatchForm.ShowDialog();
        }
        private void addProductButton_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }
      
        private void viewOrders_Click(object sender, EventArgs e)
        {using(var conn = Database.CreateConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("Select count(*) from orders", conn);
                int count = (int)cmd.ExecuteScalar();
                if (count == 0)
                {
                    MessageBox.Show("Nu exista nici o comanda", "Info", MessageBoxButtons.OK);
                }
                else
                {
                    var viewOrders = new ViewOrdersForms();
                    viewOrders.Show();
                }
            }
        }
        private void addOrder_Click(object sender, EventArgs e)
        {
            var adauga = new AddOrderForm();
            adauga.Show();
        }
    }
}
