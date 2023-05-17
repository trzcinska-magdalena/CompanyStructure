﻿using CompanyStruture.Models;
using CompanyStruture.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            showPersonalData();
            showAbsence();
        }

        private void showPersonalData()
        {
            Employee employee = _structureRepository.GetEmployee(employeeId);

            string[] data = employee.getPersonalData();
            string[] address = employee.Address.getAddress();

            NameEmp.Text = $"{data[1]} {data[2]}\nPesel: {data[3]}\n\nAddress: {address[1]} {address[2]}{address[3]} {address[0]}";
        }

        private void showAbsence()
        {
            Dictionary<string, List<Absence>> absences = _structureRepository.GetAbsences(employeeId);

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
    }
}
