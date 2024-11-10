using System;

namespace ConsoleApp1
{
    delegate void hisobla_p_s(double a);


    partial class Trapetsiya
    {
        public event hisobla_p_s value;
        public double a, b, h, c, d;

        public Trapetsiya(double a, double b, double h, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.h = h;
            this.c = c;
            this.d = d;
        }



        public double Perimetrhisobla()
        {
            double p;
            p = a + b + c + d;
            return p;
        }
        public double Yuzahisobla()
        {
            double S;
            S = ((a + b) * h / 2);
            return S;
        }
        public void button1_Click(double a)
        {
            if (value != null)
                value.Invoke(a);
        }

    }
    internal class Program
    {
        public static void Perimetr(double a)
        {
            Trapetsiya t = new Trapetsiya(5, 20, 15, 12, 13);
            double perimeter = t.Perimetrhisobla();
            Console.WriteLine($"Perimetr: {perimeter}");
        }
        public static void Yuza(double a)
        {
            Trapetsiya t = new Trapetsiya(5, 20, 15, 12, 13);
            double area = t.Yuzahisobla();
            Console.WriteLine($"Yuza: {area}");
        }
        [STAThread]
        static void Main(string[] args)
        {//14. Teng yonli trapetsiyaning   asoslari va
         //balandligi asosida trapetsiyaning yuzasi va perimetrini
         //hisoblash dasturini tuzing. Bunda  intervalda bo’lganda hisoblash natijalarini chiqarish
         //hodisasi va unga mos delegat, metodlar yordamida bajarilsin.
            Trapetsiya t = new Trapetsiya(5, 20, 15, 12, 13);


            // Yuzani va perimetrni hisoblash
            t.value += Perimetr;
            t.value += Yuza;
            t.button1_Click(5);

        }
    }
}
