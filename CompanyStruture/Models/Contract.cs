using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CompanyStruture.Models
{
    public class Contract
    {
        public int EmployeeID { get; set; }
        public string Department { get; set; }
        public string ContractNumber { get; set; }
        public string ContractType { get; set; }
        public string Position { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; } = null;
        public string SalaryType { get; set; }
        public double Salary { get; set; }

        public string[] getData()
        {
            string[] data = new string[8];
            data[0] = ContractNumber;
            data[1] = ContractType;
            data[2] = Department;
            data[3] = Position;
            data[4] = DateFrom.ToString("yyyy-MM-dd");
            data[5] = DateTo == null ? "" : ((DateTime)DateTo).ToString("yyyy-MM-dd");
            data[6] = SalaryType;
            data[7] = Salary + "";
            return data;
        }
    }
}
