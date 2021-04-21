using Santec_Core.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Santec_Core.Data
{
    public class SimpleDataManager:IDataManager
    {
        private List<Employee> listOfEmployees;
        public SimpleDataManager()
        {
            listOfEmployees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    FirstName = "Mario",
                    LastName = "Rossi",
                    HireDate = new DateTime(2021, 1, 31)
                },
                new Employee()
                {
                    Id = 2,
                    FirstName = "Maria",
                    LastName = "Verdi",
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
            return Task.Run(() =>
            {
                Thread.Sleep(5000);
                return listOfEmployees;
            });
        }

        public Employee GetEmployeeByID(int Id)
        {
            Employee result = listOfEmployees.Where(e => e.Id == Id).FirstOrDefault();
            return result;
        }

    }
}
