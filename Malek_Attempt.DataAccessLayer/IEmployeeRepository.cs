using Malek_Attempt.Models;
using System.Collections.Generic;

namespace Malek_Attempt.DataAccessLayer
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
    }
}
