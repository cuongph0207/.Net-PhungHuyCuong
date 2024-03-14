using System.Text;

namespace BTVN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập vào lựa chọn : \n1. Nhập vào tháng và năm -> in ra số lượng ngày của tháng đó " +
                "\n2. Nhập từ bàn phím vào 1 ngày bất kỳ và kiểm tra xem cái text đó có phải định dạng ngày tháng không ?" +
                "\n3. Viết một chương trình C# yêu cầu người dùng nhập vào một số nguyên dương N. Sau đó, sử dụng StringBuilder để xây dựng một chuỗi chứa các số từ 1 đến N, mỗi số cách nhau bởi dấu phẩy. Cuối cùng, in ra màn hình chuỗi kết quả." +
                "\n4. Viết một chương trình C# yêu cầu người dùng nhập vào một chuỗi. Sau đó, sử dụng StringBuilder để đảo ngược chuỗi đó và in ra kết quả.");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CalDay();
                    break;
                case 2:
                    TestDay();
                    break;
                case 3:
                    PrintString();
                    break;
                case 4:
                    Reverse();
                    break;
            }
        }
        static void CalDay()
        {
            Console.Write("Nhập tháng (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập năm: ");
            int year = Convert.ToInt32(Console.ReadLine());

            int daysInMonth = DateTime.DaysInMonth(year, month);
            Console.WriteLine($"Số lượng ngày của tháng {month}/{year} là: {daysInMonth}");
        }
        static void TestDay()
        {
            Console.Write("Nhập ngày (dd/MM/yyyy): ");
            string input = Console.ReadLine();

            DateTime date;
            if (DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out date))
            {
                Console.WriteLine("Định dạng ngày tháng hợp lệ.");
            }
            else
            {
                Console.WriteLine("Định dạng ngày tháng không hợp lệ.");
            }
        }
        static void PrintString()
        {
            Console.Write("Nhập một số nguyên dương N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 1; i <= N; i++)
            {
                stringBuilder.Append(i);
                if (i < N)
                    stringBuilder.Append(", ");
            }

            Console.WriteLine("Chuỗi kết quả: " + stringBuilder.ToString());
        }
        static void Reverse()
        {
            Console.Write("Nhập chuỗi cần đảo ngược: ");
            string input = Console.ReadLine();

            StringBuilder reversedString = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString.Append(input[i]);
            }

            Console.WriteLine("Chuỗi đảo ngược: " + reversedString.ToString());
        }
    }
}
