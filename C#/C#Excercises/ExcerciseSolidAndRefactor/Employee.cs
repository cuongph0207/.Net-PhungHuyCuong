using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseSolidAndRefactor
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public double BasicSalary { get; set; }
        public double Coefficient { get; protected set; } // Hệ số lương
        public double Allowance { get; set; }   
        public double TotalSalary => BasicSalary * Coefficient + Allowance;

        public Employee(string id, string name, string gender, int age, double basicSalary, double coefficient, double allowance) {
            Id = id;
            Name = name;
            Gender = gender;
            Age = age;
            BasicSalary = basicSalary;
            Coefficient = 2.0;
            Allowance = 0;
        }

        public Employee(string id, string name, string gender, int age, double basicSalary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Age = age;
            BasicSalary = basicSalary;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Gender: {Gender}, Age: {Age}, Basic Salary: {BasicSalary}, Total Salary: {TotalSalary}");
        }
    }
}
