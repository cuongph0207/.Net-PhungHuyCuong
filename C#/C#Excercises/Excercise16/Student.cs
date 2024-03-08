using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise16
{
    internal class Student
    {
        private static int nextId = 1;
        public int Id { get; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public double MathScore { get; set; }
        public double PhysicsScore { get; set; }
        public double ChemistryScore { get; set; }
        public double AverageScore => (MathScore + PhysicsScore + ChemistryScore) / 3;
        public string AcademicPerformance
        {
            get
            {
                if (AverageScore >= 8)
                    return "Giỏi";
                else if (AverageScore >= 6.5)
                    return "Khá";
                else if (AverageScore >= 5)
                    return "Trung Bình";
                else
                    return "Yếu";
            }
        }
        public Student(string name, string gender, int age, double mathScore, double physicsScore, double chemistryScore)
        {
            Id = nextId++;
            Name = name;
            Gender = gender;
            Age = age;
            MathScore = mathScore;
            PhysicsScore = physicsScore;
            ChemistryScore = chemistryScore;
        }
    }
}
