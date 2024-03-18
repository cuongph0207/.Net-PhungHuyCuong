using System.Globalization;

namespace BTVN2
{
    internal class Program
    {
        static List<HoaDon> danhSachHoaDon = new List<HoaDon>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int choice;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Nhập hóa đơn");
                Console.WriteLine("2. Xóa hóa đơn");
                Console.WriteLine("3. Sửa hóa đơn");
                Console.WriteLine("4. Danh sách hóa đơn");
                Console.WriteLine("5. Tìm kiếm hóa đơn theo mã hóa đơn");
                Console.WriteLine("0. Thoát");
                Console.Write("Nhập lựa chọn của bạn: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        HoaDon.NhapHoaDon(danhSachHoaDon);
                        break;
                    case 2:
                        HoaDon.XoaHoaDon(danhSachHoaDon);
                        break;
                    case 3:
                        HoaDon.SuaHoaDon(danhSachHoaDon);
                        break;
                    case 4:
                        HoaDon.HienThiDanhSachHoaDon(danhSachHoaDon);
                        break;
                    case 5:
                        HoaDon.TimKiemHoaDon(danhSachHoaDon);
                        break;
                    case 0:
                        Console.WriteLine("Kết thúc chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            } while (choice != 0);
        }
    }
    public struct HoaDon
    {
        public string MaHoaDon;
        public DateTime NgayPhatHanh;
        public double SoTien;
        public string NguoiMua;
        public DateTime NgayMua;

        public static void NhapHoaDon(List<HoaDon> danhSachHoaDon)
        {
            HoaDon hoaDon = new HoaDon();
            Console.Write("Nhập mã hóa đơn: ");
            hoaDon.MaHoaDon = Console.ReadLine();
            Console.Write("Nhập ngày phát hành (dd-MM-yyyy): ");
            string ngayPhatHanhString = Console.ReadLine();
            hoaDon.NgayPhatHanh = DateTime.ParseExact(ngayPhatHanhString, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Console.Write("Nhập số tiền: ");
            hoaDon.SoTien = double.Parse(Console.ReadLine());
            Console.Write("Nhập người mua: ");
            hoaDon.NguoiMua = Console.ReadLine();
            Console.Write("Nhập ngày mua (dd-MM-yyyy): ");
            string ngayMuaString = Console.ReadLine();
            hoaDon.NgayMua = DateTime.ParseExact(ngayMuaString, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            danhSachHoaDon.Add(hoaDon);
            Console.WriteLine("Hóa đơn đã được thêm vào danh sách.");
        }

        public static void XoaHoaDon(List<HoaDon> danhSachHoaDon)
        {
            Console.Write("Nhập mã hóa đơn cần xóa: ");
            string maHoaDon = Console.ReadLine();
            int index = danhSachHoaDon.FindIndex(hd => hd.MaHoaDon == maHoaDon);
            if (index != -1)
            {
                danhSachHoaDon.RemoveAt(index);
                Console.WriteLine("Hóa đơn đã được xóa.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy hóa đơn có mã {0}.", maHoaDon);
            }
        }

        public static void SuaHoaDon(List<HoaDon> danhSachHoaDon)
        {
            Console.Write("Nhập mã hóa đơn cần sửa: ");
            string maHoaDon = Console.ReadLine();
            int index = danhSachHoaDon.FindIndex(hd => hd.MaHoaDon == maHoaDon);
            if (index != -1)
            {
                HoaDon hoaDonMoi = danhSachHoaDon[index];
                Console.Write("Nhập ngày phát hành mới: ");
                hoaDonMoi.NgayPhatHanh = DateTime.Parse(Console.ReadLine());
                Console.Write("Nhập số tiền mới: ");
                hoaDonMoi.SoTien = double.Parse(Console.ReadLine());
                Console.Write("Nhập người mua mới: ");
                hoaDonMoi.NguoiMua = Console.ReadLine();
                Console.Write("Nhập ngày mua mới: ");
                hoaDonMoi.NgayMua = DateTime.Parse(Console.ReadLine());

                danhSachHoaDon[index] = hoaDonMoi;
                Console.WriteLine("Hóa đơn đã được sửa.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy hóa đơn có mã {0}.", maHoaDon);
            }
        }

        public static void HienThiDanhSachHoaDon(List<HoaDon> danhSachHoaDon)
        {
            Console.WriteLine("Danh sách hóa đơn:");
            foreach (var hoaDon in danhSachHoaDon)
            {
                Console.WriteLine("Mã hóa đơn: {0}, Ngày phát hành: {1}, Số tiền: {2}, Người mua: {3}, Ngày mua: {4}",
                                  hoaDon.MaHoaDon, hoaDon.NgayPhatHanh, hoaDon.SoTien, hoaDon.NguoiMua, hoaDon.NgayMua);
            }
        }

        public static void TimKiemHoaDon(List<HoaDon> danhSachHoaDon)
        {
            Console.Write("Nhập mã hóa đơn cần tìm kiếm: ");
            string maHoaDon = Console.ReadLine();
            HoaDon hoaDon = danhSachHoaDon.Find(hd => hd.MaHoaDon == maHoaDon);
            if (hoaDon.MaHoaDon != null)
            {
                Console.WriteLine("Thông tin hóa đơn:");
                Console.WriteLine("Mã hóa đơn: {0}, Ngày phát hành: {1}, Số tiền: {2}, Người mua: {3}, Ngày mua: {4}",
                                  hoaDon.MaHoaDon, hoaDon.NgayPhatHanh, hoaDon.SoTien, hoaDon.NguoiMua, hoaDon.NgayMua);
            }
            else
            {
                Console.WriteLine("Không tìm thấy hóa đơn có mã {0}.", maHoaDon);
            }
        }
    }
}
