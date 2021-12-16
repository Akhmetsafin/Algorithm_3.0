using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_3._0
{
    class PointDoubleClass
    {
        public double X { get; set; }
        public double Y { get; set; }
        public PointDoubleClass(double x, double y)
        {
            X = x;
            Y = y;
        }
        public void ClassDouble()
        {
            Console.WriteLine("================== PointDoubleClass");
            int n = 10;
            int k = 10;
            double[] mas = new double[n];
            Random r = new Random(); // объявление переменной для генерации случ. чисел

            for (int j = 1; j < k; j++)
            {
                var PointDoubleClass_A = new PointDoubleClass(r.Next(100), r.Next(100));
                var PointDoubleClass_B = new PointDoubleClass(r.Next(100), r.Next(100));
                mas[j] = Math.Sqrt((PointDoubleClass_A.X + PointDoubleClass_B.X) + (PointDoubleClass_A.Y + PointDoubleClass_B.Y));
                Console.WriteLine(mas[j]);
            }
        }
        public struct PointDoublestruct

        {
            public double X { get; set; }
            public double Y { get; set; }
            public PointDoublestruct(double x, double y)
            {
                X = x;
                Y = y;
            }
            public void ClassDouble()
            {
                Console.WriteLine("================== PointDoubleClass");
                int n = 10;
                int k = 10;
                double[] mas = new double[n];
                Random r = new Random(); // объявление переменной для генерации случ. чисел

                for (int j = 1; j < k; j++)
                {
                    var PointDoublestruct_A = new PointDoublestruct(r.Next(100), r.Next(100));
                    var PointDoublestruct_B = new PointDoublestruct(r.Next(100), r.Next(100));
                    mas[j] = Math.Sqrt((PointDoublestruct_A.X + PointDoublestruct_B.X) + (PointDoublestruct_A.Y + PointDoublestruct_B.Y));
                    Console.WriteLine(mas[j]);
                }
            }

            public void Run_ClassDouble()
            {
                Console.WriteLine("Teст Benchmark");
                ClassDouble();
            }
        }
    }
}
