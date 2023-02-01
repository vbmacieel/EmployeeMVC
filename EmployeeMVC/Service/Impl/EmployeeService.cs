using EmployeeMVC.Models;

namespace EmployeeMVC.Service.Impl
{
    public class EmployeeService : IEmployeeService
    {
        private static List<Employee> _employees = new List<Employee>();

        public void Create(Employee employee)
        {
            var random = new Random();
            employee.Id = random.Next();
            _employees.Add(employee);
        }

        public void Delete(int id)
        {
            Employee employee = GetEmployee(id);
            if (employee != null)
            {
                _employees.Remove(employee);
            }
        }

        public IEnumerable<Employee> GetAll() 
        {
            return _employees;
        } 

        public Employee GetById(int id)
        {
            return GetEmployee(id);
        }
            

        public void Update(Employee newEmployee, int id)
        {
            Employee employee = GetEmployee(id);
            if (employee != null)
            {
                employee.Id = newEmployee.Id;
                employee.Name = newEmployee.Name;
                employee.Salary = newEmployee.Salary;
                employee.Department = newEmployee.Department;
            }
        }

        private Employee GetEmployee(int id)
        {
            return _employees.FirstOrDefault(employee => employee.Id == id);
        }
    }
}
