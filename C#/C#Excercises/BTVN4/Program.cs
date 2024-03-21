namespace BTVN4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool exit = false;
            while (!false)
            {
                Console.WriteLine("Nhập lựa chọn của bạn : " +
                    "\n1. Thêm sinh viên" +
                    "\n2. Cập nhật thông tin sinh viên bởi ID" +
                    "\n3. Xóa sinh viên bởi ID" +
                    "\n4. Tìm kiếm sinh viên theo tên" +
                    "\n5. Sắp xếp sinh viên theo điểm trung bình (GPA)" +
                    "\n6. Sắp xếp sinh viên theo tên" +
                    "\n7. Sắp xếp sinh viên theo ID" +
                    "\n8. Hiển thị danh sách sinh viên" +
                    "\n9. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        controller.AddStudent();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        controller.DisplayStudents();
                        break;
                    case 9:
                        exit = false;
                        break;
                }
            }
        }
    }
}
