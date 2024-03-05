using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace Excercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 1 so can kiem tra :");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Cac so nguyen to nho hon {0} : ",n);
            for (int i = 2; i < n; i++)
            {
                if (isPrime(i))
                {
                    Console.Write(i + " ");
                }
            }

        }
        static bool isPrime(int number)
        {
            if (number <= 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
