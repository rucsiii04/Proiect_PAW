using proiectPaw.Entities;
using proiectPaw.Others;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;

namespace proiectPaw.Forms
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            dataGridViewProducts.AutoGenerateColumns = false;
            SetupDataGridView();
            LoadProducts();
            Helper.StyleDataGrid(dataGridViewProducts);
        }
        private void SetupDataGridView()
        {
            dataGridViewProducts.Columns.Clear();
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                DataPropertyName = "Id",
                Visible = false
            });
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Nume",
                DataPropertyName = "Name",
                Width = 200
            });
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Category",
                HeaderText = "Categorie",
                DataPropertyName = "Category",
                Width = 150
            });
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Preț",
                DataPropertyName = "Price"
            });
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "BatchId",
                HeaderText = "Batch ID",
                DataPropertyName = "BatchId"
            });
            var editButton = new DataGridViewButtonColumn
            {
                Name = "editColumn",
                HeaderText = "Editează",
                Text = "Editează",
                UseColumnTextForButtonValue = true,
                Width = 70
            };
            dataGridViewProducts.Columns.Add(editButton);
            var deleteButton = new DataGridViewButtonColumn
            {
                Name = "deleteColumn",
                HeaderText = "Șterge",
                Text = "Șterge",
                UseColumnTextForButtonValue = true,
                Width = 70
            };
            dataGridViewProducts.Columns.Add(deleteButton);           
        }
        private void LoadProducts()
        {
            var products = new List<Product>();
            using (var conn = Database.CreateConnection())
            {
                conn.Open();
                string query = "SELECT Id, Name, Category, Price, BatchId FROM Products";
                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            Id = Guid.Parse(reader["Id"].ToString()),
                            Name = reader["Name"].ToString(),
                            Category = reader["Category"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"]),
                            BatchId = Guid.Parse(reader["BatchId"].ToString())
                        });
                    }
                }
            }
            dataGridViewProducts.DataSource = products;
        }
        private void DataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var product = (Product) dataGridViewProducts.Rows[e.RowIndex].DataBoundItem;
            if (dataGridViewProducts.Columns[e.ColumnIndex].Name == "editColumn")
            {
                EditProduct(product.Id);
            }
            else if (dataGridViewProducts.Columns[e.ColumnIndex].Name == "deleteColumn")
            {
                DeleteProduct(product.Id);
            }
        }
        private void EditProduct(Guid productId)
        {
            var editForm = new EditProductForm(productId);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }
        private void DeleteProduct(Guid productId)
        {
            var confirmResult = MessageBox.Show("Sigur vrei sa stergi acest produs?", "Confirmare stergere", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (var conn = Database.CreateConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Products WHERE Id = @Id";
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", productId);
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Produs sters cu succes.");
                            LoadProducts();
                        }
                        else
                        {
                            MessageBox.Show("Produsul nu a fost gasit sau nu a putut fi sters.");
                        }
                    }
                }
            }
        }
    }
}
