namespace Excercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chọn phương trình : \n1.Phương trinh bac 1 \n2.Phuong trinh bac 2");
            int choice = int.Parse(Console.ReadLine());
            int a, b, c;
            switch(choice)
            {
                case 1:
                    do
                    {
                        Console.WriteLine("Nhap so a :");
                        a = int.Parse(Console.ReadLine());
                    } while (a == 0);
                    Console.WriteLine("Nhap so b :");
                    b = int.Parse(Console.ReadLine());
                    double x = -b / a;
                    Console.WriteLine("Nghiem cua phuong trinh x = {0}",(double)x);
                    break;
                case 2:
                    do
                    {
                        Console.WriteLine("Nhap so a :");
                        a = int.Parse(Console.ReadLine());
                    } while (a == 0);
                    Console.WriteLine("Nhap so b :");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap so c :");
                    c = int.Parse(Console.ReadLine());
                    double denta = Math.Pow(b, 2) - 4 * a * c;
                    if(denta < 0)
                    {
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }else if(denta == 0) {
                        Console.WriteLine("Phuong trinh co nghiem kep : x1 = x2 = {0}", (double)-b / 2 * a);
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh co 2 nghiem phan biet : x1 = {0}, x2 = {1}", (double)(-b + Math.Sqrt(denta)) / (2 * a), (double)(-b - Math.Sqrt(denta)) / (2 * a));
                    }
                    break;
            }
        }
    }
}
