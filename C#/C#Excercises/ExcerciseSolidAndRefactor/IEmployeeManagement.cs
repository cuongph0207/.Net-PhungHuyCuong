using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseSolidAndRefactor
{
    public interface IEmployeeManagement
    {
        void AddEmployee(Employee employee);
        void UpdateEmployee(string id, Employee updatedEmployee);
        void RemoveEmployee(string id);
        List<Employee> SearchEmployeeByName(string name);
    }
}
