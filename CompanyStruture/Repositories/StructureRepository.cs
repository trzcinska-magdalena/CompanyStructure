using CompanyStruture.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyStruture.Repository
{
    public interface IStructureRepository
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int id);
        List<City> GetCities();
        void AddEmployee(Employee employee);

    }

    public class StructureRepository : IStructureRepository
    {
        private readonly string _connectionString;
        public StructureRepository() 
        {
            _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=company_structure;Integrated Security=True;";
        }

        public List<City> GetCities()
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            var query = $"SELECT * FROM City";
            var cities = new List<City>();

            sqlConnection.Open();

            SqlCommand myCommand = new SqlCommand(query, sqlConnection);


            var data = myCommand.ExecuteReader();
            while (data.Read())
            {
                cities.Add(new City
                {
                    Id = data.GetInt32(0),
                    Name = data.GetString(1),
                });
            }

            return cities;
        }

        public List<Employee> GetEmployees()
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            var query = $"SELECT Employee.ID, Employee.Name, Employee.Surname, Employee.PESEL, City.Name, Address.Street, Address.BuildingNumber, Address.ApartmentNumber FROM Employee " +
                        $"INNER JOIN Address on Employee.AddressID = Address.ID " +
                        $"INNER JOIN City on Address.CityID = City.ID";
            var employees = new List<Employee>();

            sqlConnection.Open();

            SqlCommand myCommand = new SqlCommand(query, sqlConnection);


            var data = myCommand.ExecuteReader();
            Console.WriteLine(data.ToString());
            while (data.Read())
            {
                employees.Add(new Employee
                {
                    Id = data.GetInt32(0),
                    Name = data.GetString(1),
                    Surname = data.GetString(2),
                    Pesel = data.GetString(3),
                    City = data.GetString(4),
                    Street = data.GetString(5),
                    BuildingNumber = data.GetString(6),
                    ApartmentNumber = data.IsDBNull(7) ? -1 : data.GetInt32(7)
                });
            }

            return employees;
        }

        public Employee GetEmployee(int id)
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            var query = $"SELECT Employee.ID, Employee.Name, Employee.Surname, Employee.PESEL, City.Name, Address.Street, Address.BuildingNumber, Address.ApartmentNumber FROM Employee " +
                        $"INNER JOIN Address on Employee.AddressID = Address.ID " +
                        $"INNER JOIN City on Address.CityID = City.ID " +
                        $"WHERE Employee.ID = {id}";


            Employee employee = new Employee();

            sqlConnection.Open();

            SqlCommand myCommand = new SqlCommand(query, sqlConnection);


            var data = myCommand.ExecuteReader();
            while (data.Read())
            {
                employee = new Employee
                {
                    Id = data.GetInt32(0),
                    Name = data.GetString(1),
                    Surname = data.GetString(2),
                    Pesel = data.GetString(3),
                    City = data.GetString(4),
                    Street = data.GetString(5),
                    BuildingNumber = data.GetString(6),
                    ApartmentNumber = data.IsDBNull(7) ? (int?)null : data.GetInt32(7)
                };
            }

            return employee;
        }

        public void AddEmployee(Employee employee)
        {
            /*
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            var query = $"SELECT Employee VALUES()";        
            sqlConnection.Open();

            SqlCommand myCommand = new SqlCommand(query, sqlConnection);


            var data = myCommand.ExecuteReader();
            */
        }
    }
}
