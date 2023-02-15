using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSquare
{
    // абстрактный класс фигуры
    public abstract class Shape
    {
        public string TypeName { get; set; }
        public Shape(string TypeName)
        {
            this.TypeName = TypeName;
        }
        public abstract double CalcSquare();
    }
}

