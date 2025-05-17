using Seminar5.Database;
using Seminar5.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar5
{
    public partial class CarListForm: Form
    {
        public CarListForm()
        {
            InitializeComponent();
            CarsDataGridView.AutoGenerateColumns = false;//afisez doar ce coloane vr io dc e pe false
            CarsDataGridView.DataSource = FakeDatabase.Cars;
            var car = new Car();
            AddTextBoxColumn("Id", "Id", isVisible:false);//am sarit peste param optional width
            AddTextBoxColumn("Make","Marca",200);
            AddTextBoxColumn("Model", "Model", 100);
            AddCheckBoxColumn("HasInsurance", "Are asigurare");
            AddTextBoxColumn("Year", "An");
            AddTextBoxColumn("Seats", "Locuri");
            AddCheckBoxColumn(nameof(car.LicenseNumber), "Numar de inmatriculare");
        }

        private void AddTextBoxColumn(string propertyName,string headerText,int width=100,bool isVisible=true)//dc nu trimit nmc default va fi 100
        {
            var column = new DataGridViewTextBoxColumn();//instanta noua de coloana
            column.DataPropertyName = propertyName;//se leaga de coloana Make
            column.HeaderText = headerText;//numele coloanei
            column.Width = width;
            column.Name = propertyName;
            column.Visible = isVisible;
            CarsDataGridView.Columns.Add(column);
        }
        private void AddCheckBoxColumn(string propertyName,string headerText,int width = 100)
        {
            var column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = propertyName;
            column.HeaderText = headerText;
            column.Width = width;
            column.Name = propertyName;
            CarsDataGridView.Columns.Add(column);

        }

       

       
        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addCarForm = new addCarForm();
            addCarForm.ShowDialog();
            CarsDataGridView.DataSource = null;
            CarsDataGridView.DataSource = FakeDatabase.Cars;
        }
    }
}
//parametrii nulabili trebuie sa fie mereu ultimii, int? variabila nulalbila a oricarui tip de data
//metoda de extensie