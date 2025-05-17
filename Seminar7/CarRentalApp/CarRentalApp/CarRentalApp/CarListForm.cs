using CarRentalApp.Database;
using CarRentalApp.Entities;
using CarRentalApp.Services;
using System;
using System.Data.Common;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class CarListForm: Form
    { private CarService _carService;
        public CarListForm() {
            InitializeComponent();

            carsDataGridView.AutoGenerateColumns = false;
            carsDataGridView.DataSource = FakeDatabase.Cars;

            AddTextBoxColumn("Id", "ID", isVisible: false);
            AddTextBoxColumn("Make", "Marca", 200);
            AddTextBoxColumn("Model", "Model", 180);
            AddTextBoxColumn("Year", "An");
            AddTextBoxColumn("Seats", "Locuri");
            AddCheckBoxColumn("HasInsurance", "Are asigurare");
            AddTextBoxColumn("LicenseNumber", "Numar de inmatriculare");
            AddButtonColumn("Editeza", "Editeaza","editColumn");
            AddButtonColumn("Sterge", "Sterge", "deleteColumn");
        }
        private void AddButtonColumn(string headerText,string buttonText,string nameColumn)
        {
            var column = new DataGridViewButtonColumn();
            column.HeaderText = headerText;
            column.Text = buttonText;
            column.UseColumnTextForButtonValue = true;
            column.Name = nameColumn;
            carsDataGridView.Columns.Add(column);
        }
        private void AddTextBoxColumn(string propertyName, string headerText, int width = 100, bool isVisible = true) {
            var column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = propertyName;
            column.HeaderText = headerText;
            column.Width = width;
            column.Name = propertyName;
            column.Visible = isVisible;
            carsDataGridView.Columns.Add(column);
        }

        private void AddCheckBoxColumn(string propertyName, string headerText, int width = 100) {
            var column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = propertyName;
            column.HeaderText = headerText;
            column.Width = width;
            column.Name = propertyName;
            carsDataGridView.Columns.Add(column);            
        }

        private void addCarToolStripMenuItem_Click(object sender, System.EventArgs e) {
            var addCarForm = new AddCarForm();
            addCarForm.ShowDialog();
            carsDataGridView.DataSource = null;
            carsDataGridView.DataSource = FakeDatabase.Cars;
        }

        private void carsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = sender as DataGridView;//cast la datagridviw
            var ColumnName = dataGridView.Columns[e.ColumnIndex].Name;
            if (ColumnName == "editColumn")
            {//fac edit
                var car = dataGridView.Rows[e.RowIndex].DataBoundItem as Car;
                var updateCarForm = new UpdateCarForm(car);//constructor?
                updateCarForm.ShowDialog();
            }
            if (ColumnName == "deleteColumn")
            {
                var car = dataGridView.Rows[e.RowIndex].DataBoundItem as Car;
                try
                {
                    _carService.Delete(car);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
           
        }
    }
}
