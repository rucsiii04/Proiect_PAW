using CarRentalApp.Entities;
using CarRentalApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class UpdateCarForm: Form
    {
        private Car _car;//asta ne trb ca sa putem salva undeva chestii despre car, ca altfel cand salvez eu nu mai am datele alea de le am trimissau cv
        private CarService _carService;
        public UpdateCarForm(Car car)
        {
            InitializeComponent();
            _car = car;
            _carService = new CarService();
            makeTextBox.Text = car.Make;
            modelTextBox.Text = car.Model;
            yearNumericUpDown.Value= car.Year;
            seatsNumericUpDown.Value = car.Seats;
            licenseNumberTextBox.Text = car.LicenseNumber;
            hasInsuranceCheckBox.Checked = car.HasInsurance;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _car.Id = Guid.NewGuid();
            _car.Make = makeTextBox.Text;
            _car.Model = modelTextBox.Text;
            _car.Year = Convert.ToInt32(yearNumericUpDown.Value);
            _car.Seats = Convert.ToInt32(seatsNumericUpDown.Value);
            _car.LicenseNumber = licenseNumberTextBox.Text;
            _car.HasInsurance = hasInsuranceCheckBox.Checked;
            try
            {
                _carService.UpdateCar(_car);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
