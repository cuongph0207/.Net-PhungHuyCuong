namespace Excercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số a : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số b : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Chọn phép tính(nhập số) : \n1. Cộng \n2. Trừ \n3.Nhân \n4.Chia");
            int pheptinh = int.Parse(Console.ReadLine());
            switch (pheptinh)
            {
                case 1:
                    Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                    break;
                case 2:
                    Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                    break;
                case 3:
                    Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                    break;
                case 4:
                    if(b == 0)
                    {
                        Console.WriteLine("Không thể chia cho 0");
                    }
                    else
                    {
                        Console.WriteLine("{0} / {1} = {2}", a, b, (float)a / b);
                    }
                    break;
            }
        }
    }
}
