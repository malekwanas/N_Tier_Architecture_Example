using Malek_Attempt.BusinessLogicLayer;
using Malek_Attempt.DataAccessLayer;
using Malek_Attempt.Models;
using System.Collections.Generic;

namespace Malek_Attempt.BusinessLogicLayer
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAll();
        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeRepository.GetById(id);
        }

        public void CreateEmployee(Employee employee)
        {
            _employeeRepository.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeRepository.Update(employee);
        }

        public void DeleteEmployee(int id)
        {
            _employeeRepository.Delete(id);
        }
    }
}
