using proiectPaw.Entities;
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
using System.Xml.Linq;

namespace proiectPaw.Forms.Orders
{
    public partial class AddOrderForm : Form
    {
        private Guid? OrderIdToEdit;
        public AddOrderForm(Guid? orderId=null)
        {
            InitializeComponent();
            OrderIdToEdit = orderId;
            SetupDataGridProducts();
            LoadProducts();
            if (OrderIdToEdit.HasValue)
            {
                Text = "Modifica comanda";
                LoadOrder(OrderIdToEdit.Value);
            }
            else
            {
                Text = "Adauga comanda";
            }

        }
        void LoadOrder(Guid id)
        {
            using (var conn = Database.CreateConnection())
            {
                conn.Open();
                string sql = "Select OrderDate, CustomerName from Orders where Id=@Id";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        customerTextbox.Text = reader["CustomerName"].ToString();
                        dateTimePicker1.Value = Convert.ToDateTime(reader["OrderDate"]);
                    }
                    reader.Close();
                }
            }
        }
        private void SetupDataGridProducts()
        {
            productDataGridView.Columns.Clear();
            productDataGridView.AllowUserToAddRows = false;
            productDataGridView.Columns.Add(new DataGridViewCheckBoxColumn() { Name = "Selected", HeaderText = "Selectat" });
            productDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ProductId", Visible = false });
            productDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Name", HeaderText = "Produs" });
            productDataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Quantity", HeaderText = "Cantitate" });
        }
        private void LoadProducts()
        {
            productDataGridView.Rows.Clear();
            using (var conn = Database.CreateConnection())
            {
                conn.Open();
                string sql = @"SELECT p.Id,p.Name, ISNULL(op.Quantity, 0) AS Quantity,
                    CASE WHEN op.OrderId IS NOT NULL THEN 1 ELSE 0 END AS Selected
                    FROM Products p
                    LEFT JOIN OrderProducts op ON p.Id = op.ProductId AND op.OrderId = @Id";
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", OrderIdToEdit.HasValue ? OrderIdToEdit.Value : Guid.Empty);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bool selected = Convert.ToBoolean(reader["Selected"]);
                    int quantity = Convert.ToInt32(reader["Quantity"]);
                    productDataGridView.Rows.Add(selected,
                        reader["Id"],
                        reader["Name"],
                        quantity);
                }
            }
        }
        private bool InsertSelectedProducts(SqlConnection conn, Guid orderId)
        {
            foreach (DataGridViewRow row in productDataGridView.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["Selected"].Value);
                if (isChecked)
                {
                    Guid productId = (Guid)row.Cells["ProductId"].Value;
                    int quantity;
                    if (!int.TryParse(row.Cells["Quantity"].Value.ToString(), out quantity) || quantity <= 0)
                    {
                        MessageBox.Show("Cantitatea trebuie sa fie un nr intreg, pozitiv!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    string sql = "INSERT INTO OrderProducts (Id, OrderId, ProductId, Quantity) VALUES (@Id, @OrderId, @ProductId, @Quantity)";
                    using (SqlCommand cmdInsert = new SqlCommand(sql, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@Id", Guid.NewGuid());
                        cmdInsert.Parameters.AddWithValue("@OrderId", orderId);
                        cmdInsert.Parameters.AddWithValue("@ProductId", productId);
                        cmdInsert.Parameters.AddWithValue("@Quantity", quantity);
                            int rows = cmdInsert.ExecuteNonQuery();
                            if (rows <= 0)
                            {
                                MessageBox.Show($"Inserarea pentru produsul {productId} si comanda {orderId} a esuat");
                                return false;
                            }
                    }
                }
            }
            return true;
        }
        private bool insertOrder()
        {
            Guid orderId = Guid.NewGuid();
            string sql = "INSERT INTO Orders (Id, OrderDate, CustomerName) VALUES (@Id, @OrderDate, @CustomerName)";
            using (var conn = Database.CreateConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Id", orderId);
                cmd.Parameters.AddWithValue("@OrderDate", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@CustomerName", customerTextbox.Text);
                conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        if (InsertSelectedProducts(conn, orderId))
                        {
                            MessageBox.Show("Comanda a fost adaugata cu succes!");
                            return true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Inserarea comenzii a esuat.");
                        return false;
                    }
            }
            return false;
        }
        private bool validateProducts()
        {
            using (var conn = Database.CreateConnection())
            {
                conn.Open();
                foreach (DataGridViewRow row in productDataGridView.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells["Selected"].Value);
                    if (isChecked)
                    {
                        if (!int.TryParse(row.Cells["Quantity"].Value?.ToString(), out int quantity) || quantity <= 0)
                        {
                            MessageBox.Show("Cantitatea trebuie să fie un număr întreg pozitiv!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        Guid productId = (Guid)row.Cells["ProductId"].Value;
                        string sql = @"SELECT b.Quantity AS total, COALESCE(
                          (SELECT SUM(op.Quantity) 
                          FROM OrderProducts op 
                          WHERE op.ProductId = p.Id), 0) AS alreadyBuyed,
                          p.Name
                          FROM Products p 
                          JOIN Batches b ON p.BatchId = b.Id
                          WHERE p.Id = @ProductId";
                        using (var cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@ProductId", productId);
                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    int totalQuantity = (int)reader["total"];
                                    int buyedQuantity= (int)reader["alreadyBuyed"];
                                    string name = reader["Name"].ToString();
                                    int available = totalQuantity - buyedQuantity;
                                    if (quantity >available)
                                    {
                                        MessageBox.Show($"Stoc insuficient pentru produsul {name}.\nDisponibil: {available}, cerut: {quantity}.", "Stoc epuizat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }
        private bool updateOrder(Guid id)
        {
            using (var conn = Database.CreateConnection())
            {
                conn.Open();
                string sql = "UPDATE Orders SET CustomerName = @CustomerName, OrderDate = @OrderDate WHERE Id = @Id";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@CustomerName", customerTextbox.Text);
                    cmd.Parameters.AddWithValue("@OrderDate", dateTimePicker1.Value);
                    cmd.ExecuteNonQuery();
                }
                 sql = "DELETE FROM OrderProducts WHERE OrderId = @OrderId";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderId", id);
                    cmd.ExecuteNonQuery();
                }
                return InsertSelectedProducts(conn, id) ;
               
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            bool valid = true;
            string customerName = customerTextbox.Text;
            if (string.IsNullOrEmpty(customerName) || customerName.Length < 3)
            {
                valid = false;
                MessageBox.Show("Numele este invalid", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bool produsSelectat = false;
            foreach (DataGridViewRow row in productDataGridView.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells[0].Value);
                if (isChecked)
                {
                    produsSelectat = true;
                    break;
                }
            }
            if (!produsSelectat)
            {
                valid = false;
                MessageBox.Show("Trebuie selectat macar un produs!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (valid)
            {
                if (!validateProducts())
                {
                    return;
                }
                bool succes;
                if (OrderIdToEdit.HasValue && OrderIdToEdit != Guid.Empty)
                {
                   succes= updateOrder(OrderIdToEdit.Value);  
                }
                else
                {
                    succes=insertOrder(); 
                }
                if (succes)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
