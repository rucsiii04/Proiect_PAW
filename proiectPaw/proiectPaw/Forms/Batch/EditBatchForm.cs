using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proiectPaw.Forms
{
    public partial class EditBatchForm : Form
    {
        private readonly Guid batchId;
        public EditBatchForm(Guid batchId)
        {
            InitializeComponent();
            this.batchId = batchId;
            LoadBatchDetails();
        }
        private void LoadBatchDetails()
        {
            using (var conn = Database.CreateConnection())
            {
                conn.Open();
                const string query = "SELECT ProductionDate, ExpirationDate, Quantity FROM Batches WHERE Id = @Id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", batchId);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        dateTimePickerProductionDate.Value = Convert.ToDateTime(reader["ProductionDate"]);
                        dateTimePickerExpirationDate.Value = Convert.ToDateTime(reader["ExpirationDate"]);
                        quantityTextBox.Text = reader["Quantity"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Lotul nu a fost găsit.");
                        Close();
                    }
                }
                    
            }
           
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(quantityTextBox.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Introduceți o cantitate validă - numar pozitiv.");
                return;
            }

            if (dateTimePickerExpirationDate.Value <= dateTimePickerProductionDate.Value)
            {
                MessageBox.Show("Data expirării trebuie să fie după data producției.");
                return;
            }
            using (var conn = Database.CreateConnection()){
                    conn.Open();

                const string query = @"
                    UPDATE Batches 
                    SET ProductionDate = @ProductionDate, 
                        ExpirationDate = @ExpirationDate, 
                        Quantity = @Quantity
                    WHERE Id = @Id";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductionDate", dateTimePickerProductionDate.Value);
                cmd.Parameters.AddWithValue("@ExpirationDate", dateTimePickerExpirationDate.Value);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Id", batchId);
                int rows=cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Lotul a fost actualizat cu succes.");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Lotul nu a putut fi actulizat!");
                }
                Close();
               
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
