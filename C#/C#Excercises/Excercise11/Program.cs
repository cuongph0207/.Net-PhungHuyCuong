namespace Excercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so phan tu cua mang : ");
            int number = int.Parse(Console.ReadLine());
            int[] intArray = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Nhap phan tu {0}",i+1);
                intArray[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for(int i = 0;i < intArray.Length; i++)
            {
                sum = sum + intArray[i];
            }
            Console.WriteLine("Tong cua cac phan tu trong mang la : " + sum);
        }
    }
}
