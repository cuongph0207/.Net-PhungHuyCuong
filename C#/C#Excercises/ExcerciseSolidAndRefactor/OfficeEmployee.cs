using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseSolidAndRefactor
{
    public class OfficeEmployee:Employee
    {
        public OfficeEmployee(string id, string name, string gender, int age, double basicSalary) : base(id, name, gender, age, basicSalary)
        {
            // Các thuộc tính khác cần khởi tạo
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Office Employee Information:");
            base.DisplayInfo();
        }
    }
}
