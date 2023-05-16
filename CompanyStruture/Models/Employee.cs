using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CompanyStruture.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pesel { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public int? ApartmentNumber { get; set; } = null;

        public string[] getPersonalData()
        {
            string[] data = new string[4];
            data[0] = Id + "";
            data[1] = Name;
            data[2] = Surname;
            data[3] = Pesel;
            return data;
        }

        public string[] getAddress()
        {
            string[] data = new string[4];
            data[0] = City;
            data[1] = Street;
            data[2] = BuildingNumber;
            data[3] = ApartmentNumber == null ? "" : "/"+ApartmentNumber.ToString();
            return data;
        }
    }
}
