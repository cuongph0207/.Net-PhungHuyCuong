namespace BTVN3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Bai 1
            HinhChuNhat hinhChuNhat1 = new HinhChuNhat();

            hinhChuNhat1.ChieuDai = InputValue("Chiều dài");

            hinhChuNhat1.ChieuRong = InputValue("Chiều rộng");
            Console.WriteLine("Chu vi hinh chu nhat : {0}",hinhChuNhat1.ChuVi());
            Console.WriteLine("Dien tich hinh chu nhat : {0}",hinhChuNhat1.DienTich());


            HinhTron hinhTron1 = new HinhTron();
            hinhTron1.BanKinh = 5;
            Console.WriteLine("Chu vi hinh tron : {0}", hinhTron1.ChuVi());
            Console.WriteLine("Dien tich hinh tron : {0}", hinhTron1.DienTich());
            //Bai 2
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            Console.WriteLine("Luong cua nhan vien toan thoi gian : {0}", fullTimeEmployee.Luong());
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            Console.WriteLine("Luong cua nhan vien ban thoi gian : {0}", partTimeEmployee.Luong());
            InternEmployee internEmployee = new InternEmployee();
            Console.WriteLine("Luong cua nhan vien thuc tap : {0}", internEmployee.Luong());
            //Bai 3
            Phone phone = new Phone("Samsung", 5000000);
            Book book = new Book("De men phieu lieu ky", 15000);
            Console.WriteLine($"Name : {phone.Name}, Total Price : {phone.CalculatePrice()}VND");
            Console.WriteLine($"Name : {book.Name}, Total Price : {book.CalculatePrice()}VND");

        }
        static double InputValue(string ValueName)
        {
            double dimension;
            while (true)
            {
                Console.Write($"Nhập {ValueName}: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out dimension))
                {
                    if (dimension > 0)
                    {
                        return dimension;
                    }
                    else
                    {
                        Console.WriteLine($"{ValueName} phải là một số dương.");
                    }
                }
                else
                {
                    Console.WriteLine($"{ValueName} phải là một số.");
                }
            }
        }
    }
}
