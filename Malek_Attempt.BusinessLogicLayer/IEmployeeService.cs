using Malek_Attempt.Models;
using System.Collections.Generic;

namespace Malek_Attempt.BusinessLogicLayer
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        void CreateEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
    }
}
