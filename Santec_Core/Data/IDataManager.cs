using Santec_Core.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Santec_Core.Data
{
    public interface IDataManager
    {
        List<Employee> GetAllEmployees();
        Task<List<Employee>> GetAllEmployeesAsync();
        Employee GetEmployeeByID(int Id);
        void AddEmployee(Employee newEmployee);
    }
}
