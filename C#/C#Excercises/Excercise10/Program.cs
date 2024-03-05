namespace Excercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 1 so bat ki : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Chu tuong ung voi {number} la : {convertNumberToChar(number)}");
        }

        static string convertNumberToChar(int number)
        {
            if (number == 0)
                return "khong";
            if (number < 0)
                return "am " + convertNumberToChar(-number);

            string[] numberChar = { "", "mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin" };

            if (number < 10)
                return numberChar[number];
            if (number == 10)
                return "muoi";
            if (number < 20)
                return "muoi " + convertNumberToChar(number % 10);
            if (number < 100)
                return numberChar[number / 10] + " muoi " + convertNumberToChar(number % 10);
            if (number < 1000)
                return numberChar[number / 100] + " tram " + convertNumberToChar(number % 100);
            if (number < 1000000)
                return convertNumberToChar(number / 1000) + " nghin " + convertNumberToChar(number % 1000);
            if (number < 1000000000)
                return convertNumberToChar(number / 1000000) + " trieu " + convertNumberToChar(number % 1000000);
            return convertNumberToChar(number / 1000000000) + " ty " + convertNumberToChar(number % 1000000000);
        }
    }
}
