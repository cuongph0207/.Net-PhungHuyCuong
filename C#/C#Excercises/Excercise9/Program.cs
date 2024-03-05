namespace Excercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 21, 32, 82, 2, 6, 7, 8, 10};
            Array.Sort(intArray);
            Console.WriteLine("Mang sap xep tang dan : ");
            foreach (int i in intArray)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Array.Reverse(intArray);
            Console.WriteLine("Mang sap xep giam dan : ");
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
        }
    }
}
