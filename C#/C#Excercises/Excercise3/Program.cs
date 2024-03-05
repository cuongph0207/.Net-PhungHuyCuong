namespace Excercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap do C : ");
            double doC = double.Parse(Console.ReadLine());
            Console.WriteLine("Do K : " + (doC + 273));
            Console.WriteLine("Do F : " + (doC * 18 / 10 + 32));
        }
    }
}
