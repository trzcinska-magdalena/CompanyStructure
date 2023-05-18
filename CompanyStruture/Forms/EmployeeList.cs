using CompanyStruture.Forms;
using CompanyStruture.Models;
using CompanyStruture.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CompanyStruture
{

    public partial class EmployeeForm : Form
    {
        private readonly IStructureRepository _structureRepository;
        public EmployeeForm()
        {
            _structureRepository = new StructureRepository();
            InitializeComponent();
            AddEmployeesToList();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee additionEmployee = new AddEmployee(this);
            additionEmployee.ShowDialog();
        }

        public void AddEmployeesToList()
        {
            ShowListEmployee.Items.Clear();
            List<Employee> employees = _structureRepository.GetEmployees();

            foreach (Employee emp in employees)
            {
                ListViewItem listViewItem = new ListViewItem(emp.getPersonalData());
                ShowListEmployee.Items.Add(listViewItem);
            }
        }

        private void ShowListEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ShowListEmployee.SelectedItems.Count > 0)
            {
                ListViewItem item = ShowListEmployee.SelectedItems[0];

                EmployeeDetails employeeDetail = new EmployeeDetails(item.Text);
                employeeDetail.ShowDialog();
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
