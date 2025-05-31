using proiectPaw.Others;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectPaw.Forms
{
    public partial class AddBatchForm: Form
    {
        public AddBatchForm()
        {
            InitializeComponent();
            Helper.StyleButton(cancelButton);
            Helper.StyleButton(saveButton);
            Helper.StyleForm(this);
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(quantityTextBox.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Introduceți o cantitate validă - numar pozitiv.");
                return;
            }
            if (dateTimePickerExpirationDate.Value <= dateTimePickerProductionDate.Value)
            {
                MessageBox.Show("Data expirării trebuie să fie după data producției.");
                return;
            }
            DateTime productionDate = dateTimePickerProductionDate.Value;
            DateTime expirationDate = dateTimePickerExpirationDate.Value;
            string sql = "INSERT into BATCHES(Id,ProductionDate,ExpirationDate,Quantity) VALUES (@Id,@ProductionDate,@ExpirationDate,@Quantity)";
            using (var conn = Database.CreateConnection())
            {
                using(SqlCommand cmd=new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Guid.NewGuid());
                    cmd.Parameters.AddWithValue("@ProductionDate", productionDate);
                    cmd.Parameters.AddWithValue("@ExpirationDate", expirationDate);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    try
                    {
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Lot adaugat cu succes!");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Inserarea lotului a eșiat!");
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
