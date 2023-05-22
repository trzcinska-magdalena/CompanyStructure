using CompanyStruture.Models;
using System;
using System.Collections;
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
        void AddEmployee(Employee employee);
        List<City> GetCities();
        List<Address> GetAddresses();
        List<Absence> GetAbsencesNames();
        Dictionary<string, List<EmployeeAbsence>> GetEmployeeAbsence(int id);
        void AddAbsence(EmployeeAbsence absence);
        List<Contract> GetEmployeeContracts(int id);
        void RemoveEmployeeContract(int EmployeeId, int ContractId);
    }

    public class StructureRepository : IStructureRepository
    {
        private readonly string _connectionString;
        public StructureRepository() 
        {
            _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=company_structure;Integrated Security=True;";
        }

        public SqlDataReader executeReaderSql(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            try
            {
                return sqlCommand.ExecuteReader();
            } 
            catch (SqlException ex)
            {
                Console.WriteLine($"{ex.Message}");
                throw;
            }
            
        }

        public void executeInsertSql(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"{ex.Message}");
                throw;
            }
        }

        public List<Employee> GetEmployees()
        {
            string query = $"SELECT Employee.ID, Employee.Name, Employee.Surname, Employee.PESEL, Address.ID, City.Name, Address.Street, Address.BuildingNumber, Address.ApartmentNumber FROM Employee " +
                        $"INNER JOIN Address on Employee.AddressID = Address.ID " +
                        $"INNER JOIN City on Address.CityID = City.ID";
            List<Employee> employees = new List<Employee>();

            var data = executeReaderSql(query);
            while (data.Read())
            {
                employees.Add(new Employee()
                {
                    Id = data.GetInt32(0),
                    Name = data.GetString(1),
                    Surname = data.GetString(2),
                    Pesel = data.GetString(3),

                    Address = new Address()
                    {
                        Id = data.GetInt32(4),
                        City = data.GetString(5),
                        Street = data.GetString(6),
                        BuildingNumber = data.GetString(7),
                        ApartmentNumber = data.IsDBNull(8) ? (int?)null : data.GetInt32(8)
                    }
                });
            }

            return employees;
        }

        public Employee GetEmployee(int id)
        {
            string query = $"SELECT Employee.ID, Employee.Name, Employee.Surname, Employee.PESEL, Address.ID, City.Name, Address.Street, Address.BuildingNumber, Address.ApartmentNumber FROM Employee " +
                        $"INNER JOIN Address on Employee.AddressID = Address.ID " +
                        $"INNER JOIN City on Address.CityID = City.ID " +
                        $"WHERE Employee.ID = {id}";

            Employee employee = new Employee();
           
            var data = executeReaderSql(query);
            while (data.Read())
            {
                employee = new Employee()
                {
                    Id = data.GetInt32(0),
                    Name = data.GetString(1),
                    Surname = data.GetString(2),
                    Pesel = data.GetString(3),

                    Address = new Address()
                    {
                        Id = data.GetInt32(4),
                        City = data.GetString(5),
                        Street = data.GetString(6),
                        BuildingNumber = data.GetString(7),
                        ApartmentNumber = data.IsDBNull(8) ? (int?)null : data.GetInt32(8)
                    }
                };
            }

            return employee;
        }

        public void AddEmployee(Employee employee)
        {
            int employeeId = (int)(GetEmployees().Max(x => x.Id) + 1);
            int cityId = GetCities().Where(x => x.Name.Equals(employee.Address.City)).Select(x => x.Id).FirstOrDefault();
            int addressId = (int)(GetAddresses().Max(x => x.Id) + 1);

            string query = $"SET IDENTITY_INSERT Address ON " +
                $"INSERT INTO Address(ID, CityID, Street, BuildingNumber, ApartmentNumber) " +
                $"VALUES ({addressId}, {cityId}, '{employee.Address.Street}', '{employee.Address.BuildingNumber}', '{employee.Address.ApartmentNumber}') " +
                $"SET IDENTITY_INSERT Address OFF " +
                $"SET IDENTITY_INSERT Employee ON " +
                $"INSERT INTO Employee(ID, Name, Surname, PESEL, AddressID) " +
                $"VALUES ({employeeId}, '{employee.Name}', '{employee.Surname}', '{employee.Pesel}', {addressId}) " +
                $"SET IDENTITY_INSERT Employee OFF";

            executeInsertSql(query);
        }

        public List<City> GetCities()
        {
            string query = $"SELECT * FROM City";
            List<City> cities = new List<City>();

            var data = executeReaderSql(query);
            while (data.Read())
            {
                cities.Add(new City()
                {
                    Id = data.GetInt32(0),
                    Name = data.GetString(1),
                });
            }

            return cities;
        }

        public List<Address> GetAddresses()
        {
            string query = $"SELECT Address.ID, City.Name, Address.Street, Address.BuildingNumber, Address.ApartmentNumber FROM Address " +
                $"INNER JOIN City on Address.CityID = City.ID";
            List<Address> addresses = new List<Address>();

            var data = executeReaderSql(query);
            while (data.Read())
            {
                addresses.Add(new Address
                {
                    Id = data.GetInt32(0),
                    City = data.GetString(1),
                    Street = data.GetString(2),
                    BuildingNumber = data.GetString(3),
                    ApartmentNumber = data.IsDBNull(4) ? (int?)null : data.GetInt32(4)
                });
            }

            return addresses;
        }

        public Dictionary<string, List<EmployeeAbsence>> GetEmployeeAbsence(int id)
        {
            string query = $"SELECT Absence.Name, Employee_Absence.DateFrom, Employee_Absence.DateTo FROM Employee_Absence " +
                        $"INNER JOIN Absence on Employee_Absence.AbsenceID = Absence.ID " +
                        $"WHERE Employee_Absence.EmployeeID = {id}";

            Dictionary<string, List<EmployeeAbsence>> absences = new Dictionary<string, List<EmployeeAbsence>>();

            var data = executeReaderSql(query);
            while (data.Read())
            {
                if(absences.ContainsKey(data.GetString(0)))
                {
                    absences[data.GetString(0)].Add(new EmployeeAbsence()
                    {
                        EmployeeID = id,
                        AbsenceName = data.GetString(0),
                        DateFrom = data.GetDateTime(1),
                        DateTo = data.GetDateTime(2)
                    });
                }
                else
                {
                    absences.Add(data.GetString(0), new List<EmployeeAbsence>
                    {
                        new EmployeeAbsence()
                        {
                            EmployeeID = id,
                            AbsenceName = data.GetString(0),
                            DateFrom = data.GetDateTime(1),
                            DateTo = data.GetDateTime(2)
                        }
                    });
                }
            }
            return absences;
        }

        public void AddAbsence(EmployeeAbsence absence)
        {
            int absenceId = GetAbsencesNames().Where(x => x.Name.Equals(absence.AbsenceName)).Select(x => x.Id).FirstOrDefault();
            Console.Write(absenceId.ToString());
            string query = $"" +
                $"INSERT INTO Employee_Absence(EmployeeID, AbsenceID, DateFrom, DateTo) " +
                $"VALUES ({absence.EmployeeID}, {absenceId}, '{absence.DateFrom.ToString("yyyy-MM-dd")}', '{absence.DateTo.ToString("yyyy-MM-dd")}') " +
                $"";

            executeInsertSql(query);
        }

        public List<Absence> GetAbsencesNames()
        {
            string query = $"SELECT * FROM Absence";
            List<Absence> absences = new List<Absence>();

            var data = executeReaderSql(query);
            while (data.Read())
            {
                absences.Add(new Absence()
                {
                    Id = data.GetInt32(0),
                    Name = data.GetString(1),
                });
            }

            return absences;
        }

        public List<Contract> GetEmployeeContracts(int id)
        {
            string query = $"SELECT Employee_Contract.EmployeeID, Department.Name, Contract.Number, ContractType.Type, Position.Name, " +
                        $"Contract.DateFrom, Contract.DateTo, SalaryType.Type, Contract.Salary FROM Employee_Contract " +
                        $"INNER JOIN Department on Employee_Contract.DepartmentCode = Department.Code " +
                        $"INNER JOIN Contract on Employee_Contract.ContractNumber = Contract.Number " +
                        $"INNER JOIN ContractType on Contract.ContractTypeID = ContractType.ID " +
                        $"INNER JOIN Position on Contract.PositionID = Position.ID " +
                        $"INNER JOIN SalaryType on Contract.SalaryTypeID = SalaryType.ID " +
                        $"WHERE Employee_Contract.EmployeeID = {id}";

            List<Contract> contracts = new List<Contract>();

            var data = executeReaderSql(query);
            while (data.Read())
            {
                contracts.Add(new Contract()
                {
                    EmployeeID = id,
                    Department = data.GetString(1),
                    ContractNumber = data.GetString(2),
                    ContractType = data.GetString(3),
                    Position = data.GetString(4),
                    DateFrom = data.GetDateTime(5),
                    DateTo = data.IsDBNull(6) ? (DateTime?)null : data.GetDateTime(6),
                    SalaryType = data.GetString(7),
                    Salary = data.GetDouble(8),
                });
            }

            return contracts;
        }

        public void RemoveEmployeeContract(int employeeId, int contractId)
        {
            string query = $"DELETE FROM Employee_Contract " +
               $"WHERE EmployeeID = {employeeId} AND ContractID = {contractId}";

            executeInsertSql(query);
        }
    }
}
