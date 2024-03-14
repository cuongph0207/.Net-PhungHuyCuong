using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseSolidAndRefactor
{
    public class EmployeeManager:IEmployeeManagement
    {
        private List<Employee> employees = new List<Employee>();
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public void UpdateEmployee(string id, Employee updatedEmployee)
        {
            Employee employee = employees.Find(e => e.Id == id);
            if (employee != null)
            {
                // Cập nhật thông tin nhân viên
                employee.Name = updatedEmployee.Name;
                employee.Gender = updatedEmployee.Gender;
                employee.Age = updatedEmployee.Age;
                employee.BasicSalary = updatedEmployee.BasicSalary;
                employee.Allowance = updatedEmployee.Allowance;
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
        public void RemoveEmployee(string id)
        {
            Employee employee = employees.Find(e => e.Id == id);
            if (employee != null)
            {
                employees.Remove(employee);
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
        public List<Employee> SearchEmployeeByName(string name)
        {
            return employees.FindAll(e => e.Name.ToLower().Contains(name.ToLower()));
        }
    }
}
