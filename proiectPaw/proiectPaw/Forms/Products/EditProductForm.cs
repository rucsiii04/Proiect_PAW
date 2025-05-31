using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Collections.Generic;

namespace proiectPaw.Forms
{
    public partial class EditProductForm : Form
    {
        private Guid productId;
        public EditProductForm(Guid productId)
        {
            InitializeComponent();
            this.productId = productId;
            LoadBatches();
            LoadProduct(productId);
        }
        private void LoadBatches()
        {
            var batches = new List<Batch>();
            using (var conn = Database.CreateConnection())
            {
                conn.Open();
                string query = "SELECT Id, ProductionDate, ExpirationDate, Quantity FROM Batches";
                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        batches.Add(new Batch
                        {
                            Id = (Guid)reader["Id"],
                            ProductionDate = (DateTime)reader["ProductionDate"],
                            ExpirationDate =(DateTime)reader["ExpirationDate"],
                            Quantity = (int)reader["Quantity"]
                        });
                    }
                }
            }
            comboBoxBatches.DataSource = batches;
            comboBoxBatches.ValueMember = "Id";
        }
        private void LoadProduct(Guid productId)
        {
            using (var conn = Database.CreateConnection())
            {
                conn.Open();
                string query = "SELECT Name, Category, Price, BatchId FROM Products WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", productId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nameTextBox.Text = reader["Name"].ToString();
                            priceTextBox.Text = reader["Price"].ToString();
                            categoryTextBox.Text = reader["Category"].ToString();
                            Guid batchId = (Guid)reader["BatchId"];
                            comboBoxBatches.SelectedValue = batchId;
                        }
                    }
                }
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var selectedBatch = (Batch)comboBoxBatches.SelectedItem;
            if (selectedBatch == null)
            {
                MessageBox.Show("Alege un batch valid!");
                return;
            }
            Guid selectedBatchId = selectedBatch.Id;
                using (var conn = Database.CreateConnection())
                {
                    conn.Open();
                    string query = "UPDATE Products SET Name = @Name, Price = @Price, BatchId = @BatchId, Category = @Category WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Price", decimal.Parse(priceTextBox.Text));
                        cmd.Parameters.AddWithValue("@BatchId", selectedBatchId);
                        cmd.Parameters.AddWithValue("@Category", categoryTextBox.Text);
                        cmd.Parameters.AddWithValue("@Id", productId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Produsul a fost modificat cu succes!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            
        }
    }
}
