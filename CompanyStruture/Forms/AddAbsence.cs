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
    public partial class AddAbsence : Form
    {
        private readonly IStructureRepository _structureRepository;
        private EmployeeDetails _employeeDetails;
        int employeeId;
        public AddAbsence(int employeeId, EmployeeDetails employeeDetails)
        {
            _structureRepository = new StructureRepository();
            _employeeDetails = employeeDetails;
            this.employeeId = employeeId;
            InitializeComponent();
        }

        private void AddAbsence_Load(object sender, EventArgs e)
        {
            showPersonalData();
            FuelComboBox();
        }

        private void showPersonalData()
        {
            Employee employee = _structureRepository.GetEmployee(employeeId);

            string[] data = employee.getPersonalData();

            employeeInfoLabel.Text = $"{data[1]} {data[2]}";
        }

        private void FuelComboBox()
        {
            List<Absence> absences = _structureRepository.GetAbsencesNames();

            foreach (Absence absence in absences)
            {
                nameComboBox.Items.Add(absence.Name);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(nameComboBox.SelectedIndex.ToString() == "")
            {
                throw new Exception("values cannot be empty");
            }

            EmployeeAbsence absence = new EmployeeAbsence()
            {
                EmployeeID = employeeId,
                AbsenceName = nameComboBox.Text,
                DateFrom = dateFromPicker.Value.Date,
                DateTo = dateToPicker.Value.Date
            };

            _structureRepository.AddAbsence(absence);
            _employeeDetails.showAbsence();
        }
    }
}
