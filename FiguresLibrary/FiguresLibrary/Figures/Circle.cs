using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Figures
{
    public class Circle : Figure
    {
        private readonly double _radius;
        private const string _outOfRangeErrorMessage = "Радиус должен быть положительным числом";
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), _outOfRangeErrorMessage);
            _radius = radius;
        }
        public override double Area() => Math.PI * _radius * _radius;
    }
}
