using System.Text;

namespace Excercise16
{
    internal class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nMENU:");
                Console.WriteLine("1. Thêm sinh viên");
                Console.WriteLine("2. Cập nhật thông tin sinh viên bởi ID");
                Console.WriteLine("3. Xóa sinh viên bởi ID");
                Console.WriteLine("4. Tìm kiếm sinh viên theo tên");
                Console.WriteLine("5. Sắp xếp sinh viên theo điểm trung bình (GPA)");
                Console.WriteLine("6. Sắp xếp sinh viên theo tên");
                Console.WriteLine("7. Sắp xếp sinh viên theo ID");
                Console.WriteLine("8. Hiển thị danh sách sinh viên");
                Console.WriteLine("9. Thoát");
                Console.Write("Nhập lựa chọn của bạn: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        UpdateStudent();
                        break;
                    case 3:
                        RemoveStudent();
                        break;
                    case 4:
                        SearchStudentByName();
                        break;
                    case 5:
                        SortStudentsByGPA();
                        break;
                    case 6:
                        SortStudentsByName();
                        break;
                    case 7:
                        SortStudentsById();
                        break;
                    case 8:
                        DisplayStudents();
                        break;
                    case 9:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }
            }
        }
        static void AddStudent()
        {
            Console.WriteLine("\nNhập thông tin sinh viên:");
            Console.Write("Tên: ");
            string name = Console.ReadLine();
            Console.Write("Giới tính: ");
            string gender = Console.ReadLine();
            Console.Write("Tuổi: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Điểm Toán: ");
            double mathScore = Convert.ToDouble(Console.ReadLine());
            Console.Write("Điểm Lý: ");
            double physicsScore = Convert.ToDouble(Console.ReadLine());
            Console.Write("Điểm Hóa: ");
            double chemistryScore = Convert.ToDouble(Console.ReadLine());

            students.Add(new Student(name, gender, age, mathScore, physicsScore, chemistryScore));
            Console.WriteLine("Thêm sinh viên thành công.");
        }
        static void UpdateStudent()
        {
            Console.Write("\nNhập ID của sinh viên cần cập nhật: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Student student = students.Find(s => s.Id == id);
            if (student != null)
            {
                Console.WriteLine("Thông tin hiện tại của sinh viên:");
                Console.WriteLine($"ID: {student.Id}, Tên: {student.Name}, Giới tính: {student.Gender}, Tuổi: {student.Age}, Điểm Toán: {student.MathScore}, Điểm Lý: {student.PhysicsScore}, Điểm Hóa: {student.ChemistryScore}");
                Console.WriteLine("Nhập thông tin mới:");
                Console.Write("Tên: ");
                student.Name = Console.ReadLine();
                Console.Write("Giới tính: ");
                student.Gender = Console.ReadLine();
                Console.Write("Tuổi: ");
                student.Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Điểm Toán: ");
                student.MathScore = Convert.ToDouble(Console.ReadLine());
                Console.Write("Điểm Lý: ");
                student.PhysicsScore = Convert.ToDouble(Console.ReadLine());
                Console.Write("Điểm Hóa: ");
                student.ChemistryScore = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Cập nhật thông tin sinh viên thành công.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên có ID này.");
            }
        }
        static void RemoveStudent()
        {
            Console.Write("\nNhập ID của sinh viên cần xóa: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Student student = students.Find(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Xóa sinh viên thành công.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên có ID này.");
            }
        }
        static void SearchStudentByName()
        {
            Console.Write("\nNhập tên sinh viên cần tìm kiếm: ");
            string name = Console.ReadLine();
            List<Student> searchResults = students.Where(s => s.Name.Contains(name)).ToList();
            if (searchResults.Count > 0)
            {
                Console.WriteLine("Kết quả tìm kiếm:");
                DisplayStudents(searchResults);
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên có tên này.");
            }
        }
        static void SortStudentsByGPA()
        {
            List<Student> sortedStudents = students.OrderBy(s => s.AverageScore).ToList();
            Console.WriteLine("Danh sách sinh viên sau khi sắp xếp theo điểm trung bình:");
            DisplayStudents(sortedStudents);
        }

        static void SortStudentsByName()
        {
            List<Student> sortedStudents = students.OrderBy(s => s.Name).ToList();
            Console.WriteLine("Danh sách sinh viên sau khi sắp xếp theo tên:");
            DisplayStudents(sortedStudents);
        }

        static void SortStudentsById()
        {
            List<Student> sortedStudents = students.OrderBy(s => s.Id).ToList();
            Console.WriteLine("Danh sách sinh viên sau khi sắp xếp theo ID:");
            DisplayStudents(sortedStudents);
        }

        static void DisplayStudents(List<Student> studentsList = null)
        {
            List<Student> displayList = studentsList ?? students;
            foreach (var student in displayList)
            {
                Console.WriteLine($"ID: {student.Id}, Tên: {student.Name}, Tuổi: {student.Age}, Giới tính: {student.Gender}, Điểm Toán: {student.MathScore}, Điểm Lý: {student.PhysicsScore}, Điểm Hóa: {student.ChemistryScore}, Điểm Trung Bình: {student.AverageScore}, Học lực: {student.AcademicPerformance}");
            }
        }
    }
}
