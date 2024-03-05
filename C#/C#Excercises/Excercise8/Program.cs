namespace Excercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            Console.WriteLine("Mang so chan la : ");
            foreach (int i in intArray)
            {
                if(i %2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Mang so le la : ");
            foreach (int i in intArray)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
