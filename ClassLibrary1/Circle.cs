using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSquare
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(string TypeName, double Radius) : base(TypeName)
        {
            this.Radius = Radius;
        }
        // расчёт площади окружности
        public override double CalcSquare()
        {
            if (Radius > 0)
            {
                return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
            }
            else
                return 0;
        }
    }
}
