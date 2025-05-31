using proiectPaw.Others;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectPaw.Forms.Orders
{
    public partial class ViewOrdersForms: Form
    {
        public ViewOrdersForms()
        {
            InitializeComponent();
            SetupOrdersGrid();
            setupProductsGrid();
            LoadOrders();
            Helper.StyleForm(this);
            Helper.StyleDataGrid(dataGridViewOrders);
            Helper.StyleDataGrid(dataGridViewProducts);
        }
        private void SetupOrdersGrid()
        {
            dataGridViewOrders.AutoGenerateColumns = false;
            dataGridViewOrders.Columns.Clear();
            dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                DataPropertyName="Id",
                Visible = false
            });
            dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OrderDate",
                HeaderText = "Data comenzii",
                DataPropertyName = "OrderDate"
            });
            dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CustomerName",
                HeaderText = "Nume client",
                DataPropertyName = "CustomerName"
            });
            var editButton = new DataGridViewButtonColumn
            {
                Name = "editColumn",
                HeaderText = "Editeaza",
                Text = "Editeaza",
                UseColumnTextForButtonValue = true
            };
            dataGridViewOrders.Columns.Add(editButton);
            var deleteButton = new DataGridViewButtonColumn
            {
                Name = "deleteColumn",
                HeaderText = "Sterge",
                Text = "Sterge",
                UseColumnTextForButtonValue = true
            };
            dataGridViewOrders.Columns.Add(deleteButton);
        }
        private void setupProductsGrid()
        {
            dataGridViewProducts.AutoGenerateColumns = false;
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
                HeaderText = "Produs",
                DataPropertyName = "Name"
            });
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Pret",
                DataPropertyName = "Price"
            });
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Quantity",
                HeaderText = "Cantitate",
                DataPropertyName = "Quantity"
            });

        }
        private void LoadOrders()
        {
            var orders = new List<Order>();
            using (var conn = Database.CreateConnection())
            {
                conn.Open();
                string query = "SELECT Id, OrderDate, CustomerName FROM Orders";
                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orders.Add(new Order(
                            orderDate: Convert.ToDateTime(reader["OrderDate"]),
                            customerName: reader["CustomerName"].ToString()
                        )
                        {
                            Id = (Guid)reader["Id"]
                        });
                    }
                }
            }

            dataGridViewOrders.DataSource = null;
            dataGridViewOrders.DataSource = orders;
        }
        private void LoadProducts(Guid givenOrderId)
        {
            using(var conn = Database.CreateConnection())
            {
                conn.Open();
                string query = @"Select P.Id,P.Name,P.Price,OP.Quantity FROM Products P JOIN OrderProducts OP ON P.id=OP.productId where OP.orderId=@OrderId";
                using(SqlDataAdapter da=new SqlDataAdapter(query, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@OrderId", givenOrderId);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewProducts.DataSource = dt;
                }  
            }
        }
        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var selectedRow = dataGridViewOrders.Rows[e.RowIndex];
            object cellValue = selectedRow.Cells["Id"].Value;
            Guid orderId = Guid.Empty;
            if (cellValue == null || !Guid.TryParse(cellValue.ToString(), out orderId))
            {
                MessageBox.Show("Id ul comenzii este invalid!");
                return;
            }
            var columnName = dataGridViewOrders.Columns[e.ColumnIndex].Name;
            if (columnName == "editColumn")
            {
                var editForm = new AddOrderForm(orderId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadOrders();
                    
                }
            }
            else if (columnName == "deleteColumn")
            {
                var confirm = MessageBox.Show("Sigur vrei sa stergi comanda?", "Confirmare", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    DeleteOrder(orderId);
                }
            }
            else
            {
                LoadProducts(orderId);
            }
        }
        private void DeleteOrder(Guid orderId)
        {
            using(var conn = Database.CreateConnection())
            {
                conn.Open();
                string query = "Delete from OrderProducts Where OrderId=@Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", orderId);
                    int rows = cmd.ExecuteNonQuery();
                }
                query = "Delete FROM Orders where Id=@Id";
                using (SqlCommand cmd=new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", orderId);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows>=0)
                    {
                        MessageBox.Show("Comanda stearsa cu succes!");
                        LoadOrders();
                    }
                    else
                    {
                        MessageBox.Show("Eroare la stergerea comenzii");
                    }
                }
               
            }
        }
    }
}
