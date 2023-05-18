using System;

namespace CompanyStruture.Models
{
    public class EmployeeAbsence
    {
        public int EmployeeID { get; set; }
        public string AbsenceName { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
