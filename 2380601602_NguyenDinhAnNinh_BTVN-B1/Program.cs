using System;

namespace B1_2380601602_NguyenDinhAnNinh_BTVN {
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao c: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Ket qua cua input ban nhap: ");
            PhuongTrinhBac2 pt = new PhuongTrinhBac2(a, b, c);
            Console.WriteLine(pt.Calc());

            Console.WriteLine("Test case: ");
            List<PhuongTrinhBac2> tests = new List<PhuongTrinhBac2>();
            tests.Add(new PhuongTrinhBac2(0, 2, -4));  
            tests.Add(new PhuongTrinhBac2(0, 0, 0)); 
            tests.Add(new PhuongTrinhBac2(0, 0, 5));  
            tests.Add(new PhuongTrinhBac2(1, -5, 6)); 
            tests.Add(new PhuongTrinhBac2(1, 2, 1));   
            tests.Add(new PhuongTrinhBac2(2, 3, 4));   
            tests.Add(new PhuongTrinhBac2(5, 0, -20));
            foreach (PhuongTrinhBac2 x in tests) Console.WriteLine(x.Calc());


        }
    }    
}