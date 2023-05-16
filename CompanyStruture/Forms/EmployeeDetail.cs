using CompanyStruture.Models;
using CompanyStruture.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyStruture.Forms
{
    public partial class EmployeeDetail : Form
    {
        private readonly IStructureRepository _structureRepository;
        int employeeId;
        public EmployeeDetail(String employeeId)
        {
            _structureRepository = new StructureRepository();
            this.employeeId = int.Parse(employeeId);
            InitializeComponent();
        }

        private void EmployeeDetail_Load(object sender, EventArgs e)
        {
            Employee employee = _structureRepository.GetEmployee(employeeId);

            string[] data = employee.getPersonalData();
            string[] address = employee.getAddress();

            NameEmp.Text = $"{data[1]} {data[2]}\nPesel: {data[3]}\n\nAddress: {address[1]} {address[2]}{address[3]} {address[0]}";
        }
    }
}
