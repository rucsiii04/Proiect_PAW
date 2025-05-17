using Seminar5.Database;
using Seminar5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar5.Repositories
{
   public class CarRepository
    { public bool ExistsByLicenseNumber(string licenseNumber)
        {
            var existingCar = FakeDatabase.Cars.FirstOrDefault(car => car.LicenseNumber == licenseNumber);
            return existingCar != null;
        }
        public void Add(Car car)
        {
            FakeDatabase.Cars.Add(car);
        }
    }
}
