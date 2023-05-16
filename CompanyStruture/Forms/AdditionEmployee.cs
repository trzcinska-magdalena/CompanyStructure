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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CompanyStruture
{
    public partial class AdditionEmployee : Form
    {
        private readonly IStructureRepository _structureRepository;
        public AdditionEmployee()
        {
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
                CityComboBox.Items.Add(city.Name);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
