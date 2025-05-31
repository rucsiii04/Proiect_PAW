using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proiectPaw.Forms
{
    public partial class AddProductForm: Form
    {
        public AddProductForm()
        {
            InitializeComponent();
            LoadBatches();
        }
        private void LoadBatches()
        {
            var batchIds = new List<Guid>();
            using (var conn = Database.CreateConnection())
            {
                conn.Open();
                string sql = "SELECT Id FROM Batches";
                using (var cmd = new SqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        batchIds.Add(reader.GetGuid(0));
                }
            }
            comboBoxBatches.DataSource = batchIds;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string productName = nameTextBox.Text;
            string category = categoryTextBox.Text;
            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Completati numele produsului!");
                return;
            }
            if(!decimal.TryParse(priceTextBox.Text,out decimal price) || price < 0)
            {
                MessageBox.Show("Introduceti un pret valid!");
                return;
            }
            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Completati categoria produsului");
                return;
            }
            if (comboBoxBatches.SelectedItem == null)
            {
                MessageBox.Show("Selectati un lot!");
                return;
            }
            Guid selectedBatchId = (Guid)comboBoxBatches.SelectedItem;
            Guid productId = Guid.NewGuid();
            string sql = "INSERT into Products(Id,Name,Category,Price,BatchId) VALUES (@Id,@Name,@Category,@Price,@BatchId)";
            using(var conn = Database.CreateConnection())
            {
                using(SqlCommand cmd=new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", productId);
                    cmd.Parameters.AddWithValue("@Name", productName);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Price",price);
                    cmd.Parameters.AddWithValue("@BatchId", selectedBatchId);
                    try
                    {
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Produs adaugat cu succes!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Nu s a putut insera produsul in baza de date!");
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Eroare la inserare: " + ex.Message);
                    }
                }
            }
        }
    }
}
