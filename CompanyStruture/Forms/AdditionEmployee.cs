using CompanyStruture.Models;
using CompanyStruture.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CompanyStruture
{
    public partial class AdditionEmployee : Form
    {
        private readonly IStructureRepository _structureRepository;
        private EmployeeForm employeeForm;
        public AdditionEmployee(EmployeeForm employeeForm)
        {
            this.employeeForm = employeeForm;
            _structureRepository = new StructureRepository();
            InitializeComponent();
            FuelComboBox();
        }

        private void AdditionEmployee_Load(object sender, EventArgs e)
        {
        }

        private void FuelComboBox()
        {
            List<City> cities = _structureRepository.GetCities();

            foreach (City city in cities)
            {
                cityComboBox.Items.Add(city.Name);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text == "" || surnameTextBox.Text == "" || peselTextBox.Text == "" || 
                streetComboBox.Text == "" || buildingNumberTextBox.Text == "" || localNumberTextBox.Text == "" || cityComboBox.SelectedIndex.ToString() == "")
            {
                throw new Exception("values cannot be empty");
            }

            Employee employee = new Employee()
            {
                Name = nameTextBox.Text,
                Surname = surnameTextBox.Text,
                Pesel = peselTextBox.Text,
                Address = new Address()
                {
                    City = cityComboBox.SelectedItem.ToString(),
                    Street = streetComboBox.Text,
                    BuildingNumber = buildingNumberTextBox.Text,
                    ApartmentNumber = int.Parse(localNumberTextBox.Text)
                }
            };
            _structureRepository.AddEmployee(employee);
            employeeForm.AddEmployeesToList();
        }

        private void PeselTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(peselTextBox.Text.Length != 11 || !peselTextBox.Text.All(Char.IsDigit))
            {
                e.Cancel = true;
                peselError.SetError(peselTextBox, "invalid pesel");
            }
            else
            {
                e.Cancel = false;
                peselError.Clear();
            }
        }

        private void nameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if ((nameTextBox.Text.Length > 50 || nameTextBox.Text.Length < 3) || !nameTextBox.Text.All(Char.IsLetter))
            {
                e.Cancel = true;
                nameError.SetError(nameTextBox, "invalid name");
            }
            else
            {
                e.Cancel = false;
                nameError.Clear();
            }
        }

        private void surnameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if ((surnameTextBox.Text.Length > 50 || surnameTextBox.Text.Length < 3) || !surnameTextBox.Text.All(Char.IsLetter))
            {
                e.Cancel = true;
                surnameError.SetError(surnameTextBox, "invalid surname");
            } 
            else
            {
                e.Cancel = false;
                surnameError.Clear();
            }
        }

        private void buildingNumberTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (buildingNumberTextBox.Text.Length < 0)
            {
                e.Cancel = true;
                buildingNrError.SetError(buildingNumberTextBox, "invalid building number");
            }
            else
            {
                e.Cancel = false;
                buildingNrError.Clear();
            }
        }

        private void localNumberTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (localNumberTextBox.Text.Length < 0 || !localNumberTextBox.Text.All(Char.IsDigit))
            {
                e.Cancel = true;
                localNrError.SetError(localNumberTextBox, "invalid local number");
            }
            else
            {
                e.Cancel = false;
                localNrError.Clear();
            }
        }

        private void cityComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(cityComboBox.SelectedIndex.ToString() == "")
            {
                e.Cancel = true;
                cityError.SetError(cityComboBox, "invalid city");
            }
            else
            {
                e.Cancel = false;
                cityError.Clear();
            }
        }

        private void streetComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if ((streetComboBox.Text.Length > 100 || streetComboBox.Text.Length < 3) || !streetComboBox.Text.All(Char.IsLetter))
            {
                e.Cancel = true;
                streetError.SetError(streetComboBox, "invalid name");
            }
            else
            {
                e.Cancel = false;
                streetError.Clear();
            }
        }
    }
}
