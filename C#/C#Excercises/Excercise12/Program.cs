namespace Excercise12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            Console.WriteLine("Mang so nguyen ban dau : ");
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            int sum = 0;
            Console.WriteLine("Mang so le : ");
            foreach (int i in intArray)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                    sum += i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Tong cua mang so le : " + sum);

        }
    }
}
