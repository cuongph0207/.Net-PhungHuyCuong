using System.Text;

namespace Excercise16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();
            int choice;
            bool isValidChoice;
            bool test = false;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Update student by ID");
                Console.WriteLine("3. Remove student by ID");
                Console.WriteLine("4. Find student by name");
                Console.WriteLine("5. Sort students by GPA");
                Console.WriteLine("6. Sort students by name");
                Console.WriteLine("7. Sort students by ID");
                Console.WriteLine("8. Display all students");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string userInput = Console.ReadLine();
                isValidChoice = int.TryParse(userInput, out choice);

                if (!isValidChoice)
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter student details:");
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Gender: ");
                        string gender = Console.ReadLine();
                        Console.Write("Age: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Math score: ");
                        double mathScore = double.Parse(Console.ReadLine());
                        Console.Write("Physics score: ");
                        double physicsScore = double.Parse(Console.ReadLine());
                        Console.Write("Chemistry score: ");
                        double chemistryScore = double.Parse(Console.ReadLine());

                        manager.AddStudent(new Student(name, gender, age, mathScore, physicsScore, chemistryScore));
                        break;
                    case 2:
                        Console.Write("Enter student ID to update: ");
                        Guid updateId = Guid.Parse(Console.ReadLine());
                        Student updatedStudent = new Student("", "", 0, 0, 0, 0);
                        Console.WriteLine("Enter updated student details:");
                        Console.Write("Name: ");
                        updatedStudent.Name = Console.ReadLine();
                        Console.Write("Gender: ");
                        updatedStudent.Gender = Console.ReadLine();
                        Console.Write("Age: ");
                        updatedStudent.Age = int.Parse(Console.ReadLine());
                        Console.Write("Math score: ");
                        updatedStudent.MathScore = double.Parse(Console.ReadLine());
                        Console.Write("Physics score: ");
                        updatedStudent.PhysicsScore = double.Parse(Console.ReadLine());
                        Console.Write("Chemistry score: ");
                        updatedStudent.ChemistryScore = double.Parse(Console.ReadLine());

                        manager.UpdateStudent(updateId, updatedStudent);
                        break;
                    case 3:
                        Console.Write("Enter student ID to remove: ");
                        Guid removeId = Guid.Parse(Console.ReadLine());
                        manager.RemoveStudent(removeId);
                        break;
                    case 4:
                        Console.Write("Enter student name to find: ");
                        string findName = Console.ReadLine();
                        Student foundStudent = manager.FindStudentByName(findName);
                        if (foundStudent != null)
                        {
                            Console.WriteLine($"Student found!\nID: {foundStudent.Id}\nName: {foundStudent.Name}\nGender: {foundStudent.Gender}\nAge: {foundStudent.Age}\nMath Score: {foundStudent.MathScore}\nPhysics Score: {foundStudent.PhysicsScore}\nChemistry Score: {foundStudent.ChemistryScore}\nAverage Score: {foundStudent.AverageScore}\nAcademic Performance: {foundStudent.AcademicPerformance}");
                        }
                        else
                        {
                            Console.WriteLine("Student not found!");
                        }
                        break;
                    case 5:
                        manager.SortByGPA();
                        Console.WriteLine("Students sorted by GPA:");
                        manager.DisplayAllStudents();
                        break;
                    case 6:
                        manager.SortByName();
                        Console.WriteLine("Students sorted by name:");
                        manager.DisplayAllStudents();
                        break;
                    case 7:
                        manager.SortById();
                        Console.WriteLine("Students sorted by ID:");
                        manager.DisplayAllStudents();
                        break;
                    case 8:
                        Console.WriteLine("List of all students:");
                        manager.DisplayAllStudents();
                        break;
                    case 0:
                        Console.WriteLine("Exiting program...");
                        test = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            } while (test = true);
        }
    }
}
