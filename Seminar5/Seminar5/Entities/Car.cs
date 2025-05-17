using System;

namespace Seminar5.Entities
{
  public class Car
    {
        public Guid Id { get; set; }//global unique identifier, se bazeaza pe entropie
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }//mergea si unsigned int
        public int Seats { get; set; }
        public bool HasInsurance { get; set; }
        
        public string LicenseNumber { get; set; }
    }
}
//sealed??