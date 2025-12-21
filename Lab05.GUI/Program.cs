using Lab05.DAL;
using Lab05.DAL.Models;

namespace Lab05.GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // --- BẮT ĐẦU TẠO DỮ LIỆU MẪU (SEED DATA) ---
            using (var context = new DBContext())
            {
                // 1. Xóa DB cũ đi tạo lại cho sạch (tránh lỗi trùng lặp khi chạy nhiều lần)
                // Lưu ý: Nếu cậu muốn giữ dữ liệu cũ thì comment dòng này lại, 
                // nhưng khuyên là nên Drop đi để có bộ dữ liệu mới chuẩn nhất.
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                // 2. TẠO KHOA (Để SQL tự sinh ID)
                var fCNTT = new Faculty { FacultyName = "Công Nghệ Thông Tin" };
                var fNNA = new Faculty { FacultyName = "Ngôn Ngữ Anh" };
                var fQTKD = new Faculty { FacultyName = "Quản Trị Kinh Doanh" };

                context.Faculties.AddRange(fCNTT, fNNA, fQTKD);
                context.SaveChanges(); // Lưu ngay để lấy ID

                // 3. TẠO CHUYÊN NGÀNH (Major)
                // Khoa CNTT
                context.Majors.Add(new Major { FacultyID = fCNTT.FacultyID, MajorID = 1, Name = "Công Nghệ Phần Mềm" });
                context.Majors.Add(new Major { FacultyID = fCNTT.FacultyID, MajorID = 2, Name = "An Toàn Thông Tin" });
                context.Majors.Add(new Major { FacultyID = fCNTT.FacultyID, MajorID = 3, Name = "Hệ Thống Thông Tin" });

                // Khoa NNA
                context.Majors.Add(new Major { FacultyID = fNNA.FacultyID, MajorID = 1, Name = "Tiếng Anh Thương Mại" });
                context.Majors.Add(new Major { FacultyID = fNNA.FacultyID, MajorID = 2, Name = "Tiếng Anh Biên Phiên Dịch" });

                // Khoa QTKD
                context.Majors.Add(new Major { FacultyID = fQTKD.FacultyID, MajorID = 1, Name = "Quản Trị Doanh Nghiệp" });
                context.Majors.Add(new Major { FacultyID = fQTKD.FacultyID, MajorID = 2, Name = "Kinh Doanh Quốc Tế" });

                context.SaveChanges();

                // 4. TẠO 70 SINH VIÊN (Dùng vòng lặp)
                var random = new Random();
                var listStudents = new List<Student>();

                // Danh sách các Khoa để random
                var faculties = new List<Faculty> { fCNTT, fNNA, fQTKD };

                for (int i = 1; i <= 70; i++)
                {
                    // Tạo MSSV: 110001, 110002...
                    string studentID = (110000 + i).ToString();

                    // Random Khoa
                    var selectedFaculty = faculties[random.Next(faculties.Count)];

                    // Random Chuyên ngành (Logic: 30% sinh viên chưa có chuyên ngành - Null)
                    int? selectedMajorID = null;
                    if (random.Next(1, 10) > 3) // 70% có chuyên ngành
                    {
                        // Lấy danh sách ID chuyên ngành của khoa đó (1, 2, 3...)
                        // Vì mình nhập cứng MajorID ở trên nên mình biết nó range từ 1 đến 2 hoặc 3
                        // Random đại 1 hoặc 2. Nếu khoa CNTT thì có thể 3.
                        int maxMajor = (selectedFaculty.FacultyName == "Công Nghệ Thông Tin") ? 3 : 2;
                        selectedMajorID = random.Next(1, maxMajor + 1);
                    }

                    listStudents.Add(new Student
                    {
                        StudentID = studentID,
                        FullName = $"Sinh Viên Thứ {i}", // Tên giả
                        AverageScore = Math.Round(random.NextDouble() * 10, 1), // Điểm từ 0.0 đến 10.0
                        FacultyID = selectedFaculty.FacultyID,
                        MajorID = selectedMajorID,
                        Avatar = "no_image.png"
                    });
                }

                context.Students.AddRange(listStudents);
                context.SaveChanges();
            }
            // -----------------------------------------------------------

            Application.Run(new frmMain());
        }
    }
}