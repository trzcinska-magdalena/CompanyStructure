using CompanyStruture.Models;
using CompanyStruture.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            AdditionEmployee additionEmployee = new AdditionEmployee();
            additionEmployee.ShowDialog();
        }


        public void AddEmployeesToList()
        {
            List<Employee> employees = _structureRepository.GetEmployee();

            foreach (Employee emp in employees)
            {
                ListViewItem listViewItem = new ListViewItem(emp.getData());
                ShowListEmployee.Items.Add(listViewItem);
            }
        }

        private void ShowListEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ShowListEmployee.SelectedItems.Count > 0)
            {
                ListViewItem item = ShowListEmployee.SelectedItems[0];
                //int id = item.SubItems[0].Text;
                Console.WriteLine(item.SubItems[0].Text);
                //item.SubItems[0].Text;
                //item.SubItems[1].Text;

                //AdditionEmployee additionEmployee = new AdditionEmployee();
                //additionEmployee.ShowDialog();
            }
        }
    }
}
