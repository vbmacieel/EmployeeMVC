using EmployeeMVC.Models;

namespace EmployeeMVC.Service
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        void Create(Employee employee);
        void Update(Employee newEmployee, int id);
        void Delete(int id);
    }
}
