using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN4
{
    public class Controller
    {
        static List<Student> students = new List<Student>();
        public void AddStudent()
        {
            Program program = new Program();
            Console.WriteLine("Thêm sinh viên:");
            Console.Write("Tên sinh viên: ");
            string name = Console.ReadLine();

            Console.Write("Giới tính: ");
            string gender = Console.ReadLine();
            Console.Write("Tuổi: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Điểm toán: ");
            double mathScore = Convert.ToDouble(Console.ReadLine());

            Console.Write("Điểm lý: ");
            double physicsScore = Convert.ToDouble(Console.ReadLine());

            Console.Write("Điểm hóa: ");
            double chemistryScore = Convert.ToDouble(Console.ReadLine());
            Student student = new Student(name, gender, age, mathScore, physicsScore, chemistryScore);
            students.Add(student);
        }
        public void DisplayStudents(List<Student> studentList = null)
        {
            List<Student> displayList = studentList != null ? studentList : students;

            foreach (var student in displayList)
            {
                Console.WriteLine($"ID: {student.Id}, Tên: {student.Name}, Giới tính: {student.Gender}, Tuổi: {student.Age}, Điểm trung bình: {student.AverageScores}, Học lực: {student.AcademicPerformance}");
            }
        }
    }
}
