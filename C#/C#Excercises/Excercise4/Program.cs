namespace Excercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so can tinh giai thua : ");
            int so = int.Parse(Console.ReadLine());
            int giaiThua = 1;
            for(int i = 1;i <= so; i++)
            {
                giaiThua *= i;
            }
            Console.WriteLine("Giai thua cua {0} la {1}",so, giaiThua);
        }
    }
}
