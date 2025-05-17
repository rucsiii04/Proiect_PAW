using Seminar5.Entities;
using Seminar5.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar5
{
    public partial class addCarForm: Form
    {
        private CarService _carService=new CarService();
        public addCarForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var car = new Car();
            car.Id = Guid.NewGuid();
            car.Make = makeTextBox.Text;
            car.Model = modelTextbox.Text;
            car.Year = Convert.ToInt32(yearNumericUpDown.Value);
            car.Seats = Convert.ToInt32(seatsNumericUpDown.Value);
            car.LicenseNumber = LicenseNumberTextBox.Text;
            car.HasInsurance = hasInsuranceCheckBox.Checked;
            try { _carService.AddCar(car); } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
