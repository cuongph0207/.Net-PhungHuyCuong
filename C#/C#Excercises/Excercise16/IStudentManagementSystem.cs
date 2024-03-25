using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise16
{
    public interface IStudentManagementSystem
    {
        void AddStudent(Student student);
        void UpdateStudent(Guid id, Student updatedStudent);
        void RemoveStudent(Guid id);
        Student FindStudentByName(string name);
        void SortByGPA();
        void SortByName();
        void SortById();
        void DisplayAllStudents();
    }
}
