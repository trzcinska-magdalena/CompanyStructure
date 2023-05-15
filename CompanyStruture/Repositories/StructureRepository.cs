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
        List<Employee> GetEmployee();
        List<City> GetCities();

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

        public List<Employee> GetEmployee()
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            var query = $"SELECT * FROM Employee";
            var employees = new List<Employee>();

            sqlConnection.Open();

            SqlCommand myCommand = new SqlCommand(query, sqlConnection);


            var data = myCommand.ExecuteReader();
            while (data.Read())
            {
                employees.Add(new Employee
                {
                    Id = data.GetInt32(0),
                    Name = data.GetString(1),
                    Surname = data.GetString(2),
                    Pesel = data.GetString(3)
                });
            }

            return employees;
        }
    }
}
