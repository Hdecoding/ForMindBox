using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSquare
{
    public class Triangle : Shape
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }
        public Triangle(string TypeName, double FirstSide, double SecondSide, double ThirdSide) : base(TypeName)
        {

            this.FirstSide = FirstSide;
            this.SecondSide = SecondSide;
            this.ThirdSide = ThirdSide;
        }
        // расчёт площади треугольника по 3 сторонам с проверкой на его существование
        public override double CalcSquare()
        {
            if (FirstSide > 0 || SecondSide > 0 || ThirdSide > 0)
            {
                double p = (FirstSide + SecondSide + ThirdSide) / 2;
                return Math.Round(Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide)), 2);
            }
            else if ((FirstSide > (SecondSide + ThirdSide)
                     || SecondSide > (FirstSide + ThirdSide)
                     || ThirdSide > (FirstSide + SecondSide)))
                return 0;
            else
                return 0;
        }
        // проверка на прямоугольность треугольника
        public bool isRectangularTriangle()
        {
            double[] massive = { FirstSide, SecondSide, ThirdSide };
            return ((massive.Max() * massive.Max()) + (massive.Max() * massive.Max())
                     == (FirstSide * FirstSide) + (SecondSide * SecondSide)
                     + (ThirdSide * ThirdSide));
        }
    }
}
