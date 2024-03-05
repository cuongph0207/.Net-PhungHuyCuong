namespace Excercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so can kiem tra chan le : ");
            int so = int.Parse(Console.ReadLine());
            if (so % 2 == 0)
            {
                Console.WriteLine("{0} la so chan", so);
            }
            else
            {
                Console.WriteLine("{0} la so le", so);
            }
        }
    }
}
