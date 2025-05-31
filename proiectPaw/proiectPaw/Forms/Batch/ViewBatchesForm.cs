using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proiectPaw.Forms
{
    public partial class ViewBatchesForm: Form
    {
        public ViewBatchesForm()
        {
            InitializeComponent();
            dataGridViewBatches.AutoGenerateColumns = false;
            SetupDataGridView();
            LoadBatches();
        }
        private void SetupDataGridView()
        {
            dataGridViewBatches.Columns.Clear();

            dataGridViewBatches.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                DataPropertyName = "Id",
                Visible = false
            });

            dataGridViewBatches.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductionDate",
                HeaderText = "Data producției",
                DataPropertyName = "ProductionDate"
            });

            dataGridViewBatches.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ExpirationDate",
                HeaderText = "Data expirării",
                DataPropertyName = "ExpirationDate"
            });

            dataGridViewBatches.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Quantity",
                HeaderText = "Cantitate",
                DataPropertyName = "Quantity"
            });

            var editButton = new DataGridViewButtonColumn
            {
                Name = "editColumn",
                HeaderText = "Editeaza",
                Text = "Editeaza",
                UseColumnTextForButtonValue = true
            };
            dataGridViewBatches.Columns.Add(editButton);

            var deleteButton = new DataGridViewButtonColumn
            {
                Name = "deleteColumn",
                HeaderText = "Sterge",
                Text = "Sterge",
                UseColumnTextForButtonValue = true
            };
            dataGridViewBatches.Columns.Add(deleteButton);   
        }
        private List<Batch> GetAllBatches()
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
                        var batch = new Batch
                        {
                            Id = (Guid)reader["Id"],
                            ProductionDate = (DateTime)reader["ProductionDate"],
                            ExpirationDate = (DateTime)reader["ExpirationDate"],
                            Quantity = (int)reader["Quantity"]
                        };
                        batches.Add(batch);
                    }
                }
            }
            return batches;
        } 
        private void LoadBatches()
        {
            var batches = GetAllBatches();
            dataGridViewBatches.DataSource = batches;
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadBatches();
        }
        private void DataGridViewBatches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var batch = (Batch)dataGridViewBatches.Rows[e.RowIndex].DataBoundItem;
            Guid batchId = batch.Id;
            string colName = dataGridViewBatches.Columns[e.ColumnIndex].Name;
            if (colName == "editColumn")
            {
                var form = new EditBatchForm(batchId);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadBatches();
            }
            else if (colName == "deleteColumn")
            {
                var confirm = MessageBox.Show("Sigur vrei să stergi lotul?", "Confirmare stergere", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                    DeleteBatch(batchId);
            }
        }
        private void DeleteBatch(Guid batchId)
        {
          using (var conn = Database.CreateConnection())
            {
                conn.Open();
                string query = "DELETE FROM Batches WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", batchId);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Lot sters cu succes.");
                        LoadBatches();
                    }
                    else
                    {
                        MessageBox.Show("Eroare la stergere.");
                    }
                }
            }
        }
    }
}
