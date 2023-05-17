using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyStruture.Models
{
    public class Address
    {
        public int? Id { get; set; } = null;
        public string City { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public int? ApartmentNumber { get; set; } = null;
        public string[] getAddress()
        {
            string[] data = new string[4];
            data[0] = City;
            data[1] = Street;
            data[2] = BuildingNumber;
            data[3] = ApartmentNumber == null ? "" : "/" + ApartmentNumber.ToString();
            return data;
        }
    }
}
