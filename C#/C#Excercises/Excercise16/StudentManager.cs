using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise16
{
    internal class StudentManager
    {
        public List<Student> students;

        public StudentManager()
        {
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("Add student successfully");
        }

        public void UpdateStudent(Guid id, Student updatedStudent)
        {
            Student student = students.Find(s => s.Id == id);
            if (student != null)
            {
                int index = students.IndexOf(student);
                students[index] = updatedStudent;
                Console.WriteLine("Update student successfully");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }

        public void RemoveStudent(Guid id)
        {
            Student student = students.Find(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Remove student successfully");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }

        public Student FindStudentByName(string name)
        {
            return students.Find(s => s.Name.ToLower() == name.ToLower());
        }

        public void SortByGPA()
        {
            students = students.OrderByDescending(s => s.AverageScore).ToList();
        }

        public void SortByName()
        {
            students = students.OrderBy(s => s.Name).ToList();
        }

        public void SortById()
        {
            students = students.OrderBy(s => s.Id).ToList();
        }

        public void DisplayAllStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}\nName: {student.Name}\nGender: {student.Gender}\nAge: {student.Age}\nMath Score: {student.MathScore}\nPhysics Score: {student.PhysicsScore}\nChemistry Score: {student.ChemistryScore}\nAverage Score: {student.AverageScore}\nAcademic Performance: {student.AcademicPerformance}\n");
            }
        }
    }
}
