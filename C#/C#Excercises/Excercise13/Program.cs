using System.Reflection;

namespace Excercise13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HocSinh hocSinh = new HocSinh();
            hocSinh.name = "Cuong";
            hocSinh.age = 20;
            hocSinh.toString();
        }
        public struct HocSinh
        {
            private int id {  get; set; }
            public string name {  get; set; }   
            public int age {  get; set; } 

            public void toString()
            {
                Console.WriteLine("Ten : {0} \nTuoi : {1}",name,age);
            }

        }
    }
}


