using System.Text;

namespace ExcerciseSolidAndRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager manager = new EmployeeManager();

            // Menu
            int choice;
            do
            {
                Console.WriteLine("\nEmployee Management System");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Update Employee");
                Console.WriteLine("3. Remove Employee");
                Console.WriteLine("4. Search Employee by Name");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Adding New Employee:");
                        Console.Write("Enter ID: ");
                        string id = Console.ReadLine();
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Gender: ");
                        string gender = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Basic Salary: ");
                        double basicSalary = Convert.ToDouble(Console.ReadLine());

                        // Tạo mới đối tượng nhân viên văn phòng
                        OfficeEmployee newEmployee = new OfficeEmployee(id, name, gender, age, basicSalary);
                        manager.AddEmployee(newEmployee);
                        Console.WriteLine("Employee added successfully.");
                        break;
                    case 2:
                        Console.WriteLine("Updating Employee:");
                        Console.Write("Enter ID of Employee to Update: ");
                        string updateId = Console.ReadLine();

                        // Tìm kiếm nhân viên bởi ID
                        Employee foundEmployee = manager.SearchEmployeeByName(updateId).FirstOrDefault();
                        if (foundEmployee != null)
                        {
                            Console.Write("Enter Updated Name: ");
                            string updatedName = Console.ReadLine();
                            Console.Write("Enter Updated Gender: ");
                            string updatedGender = Console.ReadLine();
                            Console.Write("Enter Updated Age: ");
                            int updatedAge = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Updated Basic Salary: ");
                            double updatedBasicSalary = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter Updated Allowance: ");
                            double updatedAllowance = Convert.ToDouble(Console.ReadLine());

                            // Tạo đối tượng Employee mới với thông tin cập nhật
                            Employee updatedEmployee = new Employee(updateId, updatedName, updatedGender, updatedAge, updatedBasicSalary);
                            updatedEmployee.Allowance = updatedAllowance;

                            // Cập nhật thông tin nhân viên
                            manager.UpdateEmployee(updateId, updatedEmployee);
                            Console.WriteLine("Employee updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Employee not found.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Removing Employee:");
                        Console.Write("Enter ID of Employee to Remove: ");
                        string removeId = Console.ReadLine();
                        manager.RemoveEmployee(removeId);
                        Console.WriteLine("Employee removed successfully.");
                        break;
                    case 4:
                        Console.WriteLine("Searching Employee by Name:");
                        Console.Write("Enter Name to Search: ");
                        string searchName = Console.ReadLine();
                        List<Employee> searchResults = manager.SearchEmployeeByName(searchName);
                        if (searchResults.Count > 0)
                        {
                            Console.WriteLine("Search Results:");
                            foreach (var emp in searchResults)
                            {
                                emp.DisplayInfo();
                            }
                        }
                        else
                        {
                            Console.WriteLine("No employee found with the given name.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Exiting Program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 5);
        }
    }
}