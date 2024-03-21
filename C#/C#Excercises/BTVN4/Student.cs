using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN4
{
    public class Student
    {
        public int CurrentId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public double MathScores { get; set; }
        public double PhysicalScores { get; set; }
        public double ChemicalScores { get; set; }
        public double AverageScores { get; set; }
        public string AcademicPerformance { get; set; }

        public Student(string name, string gender, int age, double mathScores, double physicalScores, double chemicalScores)
        {
            Id = CurrentId++;
            Name = name;
            Gender = gender;
            Age = age;
            MathScores = mathScores;
            PhysicalScores = physicalScores;
            ChemicalScores = chemicalScores;
        }
        public void CalculateAverageScore()
        {
            AverageScores = (MathScores + PhysicalScores + ChemicalScores)/3;
        }
        public void CalculateAcademicPerformance()
        {
            if (AverageScores >= 8)
            {
                AcademicPerformance = "Giỏi";
            }
            else if (AverageScores >= 6.5)
            {
                AcademicPerformance = "Khá";
            }
            else if (AverageScores >= 5)
            {
                AcademicPerformance = "Trung bình";
            }
            else
            {
                AcademicPerformance = "Yếu";
            }
        }
    }
}
