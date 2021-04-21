using Santec_Core.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Santec_Core.Data
{
    public class SQLDataManager : IDataManager
    {
        private List<Employee> listOfEmployees;
        public SQLDataManager()
        {
            listOfEmployees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    HireDate = new DateTime(2021, 1, 31)
                },
                new Employee()
                {
                    Id = 2,
                    FirstName = "Jenny",
                    LastName = "Doe",
                    HireDate = new DateTime(2021, 2, 11)
                }

            };
        }

        public void AddEmployee(Employee newEmployee)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            return listOfEmployees;
        }

        public Task<List<Employee>> GetAllEmployeesAsync()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeByID(int Id)
        {
            Employee result = listOfEmployees.Where(e => e.Id == Id).FirstOrDefault();
            return result;
        }
    }
}
