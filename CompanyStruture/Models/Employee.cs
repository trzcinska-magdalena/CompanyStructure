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

        public string[] getData()
        {
            string[] data = new string[4];
            data[0] = Id + "";
            data[1] = Name;
            data[2] = Surname;
            data[3] = Pesel;
            return data;
        }
    }
}
