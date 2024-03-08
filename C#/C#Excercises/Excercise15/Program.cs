using Microsoft.VisualBasic;
using System.Globalization;
using System.Text;

namespace Excercise15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.setAge(21);
            Console.WriteLine("Hello I am a student and I'm {0} years old", student.Age);
            student.goToClass();

            Teacher teacher = new Teacher();
            teacher.setAge(30);
            Console.WriteLine("Hello I am a teacher and I'm {0} years old", teacher.Age);
            teacher.goToClass();
        }
    }
}
