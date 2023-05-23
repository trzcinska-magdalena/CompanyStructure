using CompanyStruture.Models;
using CompanyStruture.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CompanyStruture.Forms
{
    public partial class EmployeeDetails : Form
    {
        private readonly IStructureRepository _structureRepository;
        int employeeId;
        public EmployeeDetails(String employeeId)
        {
            _structureRepository = new StructureRepository();
            this.employeeId = int.Parse(employeeId);
            InitializeComponent();
        }

        private void EmployeeDetail_Load(object sender, EventArgs e)
        {
            ShowPersonalData();
            ShowAbsence();
            ShowContracts();
        }

        private void ShowPersonalData()
        {
            Employee employee = _structureRepository.GetEmployee(employeeId);

            string[] data = employee.getPersonalData();
            string[] address = employee.Address.getAddress();

            NameEmp.Text = $"{data[1]} {data[2]}\nPesel: {data[3]}\n\nAddress: {address[1]} {address[2]}{address[3]} {address[0]}";
        }

        public void ShowAbsence()
        {
            absenceTreeView.Nodes.Clear();
            Dictionary<string, List<EmployeeAbsence>> absences = _structureRepository.GetEmployeeAbsence(employeeId);

            foreach (var ab in absences)
            {
                TreeNode parent = absenceTreeView.Nodes.Add(ab.Key);

                foreach(var val in ab.Value)
                {
                    string absence = $"{val.DateFrom.ToString("yyyy-MM-dd")} - {val.DateTo.ToString("yyyy-MM-dd")}";
                    parent.Nodes.Add(absence); 
                }
            }
        }

        public void ShowContracts()
        {
            ContractListView.Items.Clear();
            List<Contract> contracts = _structureRepository.GetEmployeeContracts(employeeId);

            foreach (Contract contract in contracts)
            {
                int icon = contract.DateTo < DateTime.Now ? 0 : 1;

                string[] data = contract.getData();
                ListViewItem listViewItem = new ListViewItem(new string[] { 
                    "", 
                    data[0],
                    data[1],
                    data[2],
                    data[3],
                    data[4],
                    data[5],
                    data[6],
                    data[7]}, icon);
                ContractListView.Items.Add(listViewItem);
            }
        }

        private void AddAbsenceBtn_Click(object sender, EventArgs e)
        {
            AddAbsence addAbsence = new AddAbsence(employeeId, this);
            addAbsence.Show();
        }
    }
}
