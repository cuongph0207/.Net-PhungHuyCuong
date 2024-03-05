namespace Excercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so n : ");
            int n = int.Parse(Console.ReadLine());
            if (isPrime(n))
            {
                Console.WriteLine("{0} la so nguyen to",n);
            }
            else
            {
                Console.WriteLine("{0} khong phai la so nguyen to",n);
            }
        }
        static bool isPrime(int n)
        {
            if ( n <= 1 )
            {
                return false;
            }
            for(int i = 2;i< Math.Sqrt(n); i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
