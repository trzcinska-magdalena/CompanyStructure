using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyStruture.Models
{
    public class Contract
    {
        public int EmployeeID { get; set; }
        public string ContractNumber { get; set; }
        public string ContractType { get; set; }
        public string Position { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; } = null;
        public string SalaryType { get; set; }
        public int Salary { get; set; }
    }
}
