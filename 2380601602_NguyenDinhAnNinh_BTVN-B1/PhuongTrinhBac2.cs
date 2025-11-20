using System;

namespace B1_2380601602_NguyenDinhAnNinh_BTVN
{
    class PhuongTrinhBac2 : PhuongTrinhBac1
    {
        protected int c { get; set; }

        public PhuongTrinhBac2 (int a, int b, int c) : base(a, b)
        {
            this.c = c;
        }
        public string Calc()
        {
            if (a == 0)
            {
                if (b != 0)
                {
                    PhuongTrinhBac1 pt1 = new PhuongTrinhBac1(b, c);
                    return $"Phuong trinh bac 1 co nghiem: x = {pt1.Calc():N0}";
                }
                else
                {
                    if (c == 0) return $"Phuong trinh vo so nghiem";
                    else return $"Phuong trinh vo nghiem";
                }

            }
            double delta = 1l *b * b - 4 * a * c * 1l;
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return $"Phuong trinh co 2 nghiem: x1 = {x1} va x2 = {x2}";
            } else if (delta == 0) return $"Phuong trinh co nghiem kep: x = {-b/(2.0*a):F2}";
            return "Phuong trinh vo nghiem (delta < 0)";
        }

    }

}