using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Figures
{
    public class Triangle : Figure
    {
        private readonly double _firstSide;
        private readonly double _secondSide;
        private readonly double _thirdSide;
        private const string _outOfRangeErrorMessage = "Сторона треугольника должна быть положительным числом";
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0)
                throw new ArgumentOutOfRangeException(nameof(firstSide), _outOfRangeErrorMessage);
            if (secondSide <= 0)
                throw new ArgumentOutOfRangeException(nameof(secondSide), _outOfRangeErrorMessage);
            if (thirdSide <= 0)
                throw new ArgumentOutOfRangeException(nameof(thirdSide), _outOfRangeErrorMessage);
            if (firstSide + secondSide > thirdSide
                && firstSide + thirdSide > secondSide
                && secondSide + thirdSide > firstSide)
            {
                _firstSide = firstSide;
                _secondSide = secondSide;
                _thirdSide = thirdSide;
            }
            else
            {
                throw new Exception("Треугольник с заданными сторонами не существует");
            }
        }

        public override double Area()
        {
            var semiPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;
            var area = Math.Sqrt(semiPerimeter * (semiPerimeter - _firstSide)
                * (semiPerimeter - _secondSide)
                * (semiPerimeter - _thirdSide));
            return area;
        }
        public bool IsRight()
        {
            var deviation = 0.0;
            if (_firstSide >= _secondSide && _firstSide >= _thirdSide)
                deviation = _firstSide * _firstSide - (_secondSide * _secondSide + _thirdSide * _thirdSide);
            if (_secondSide >= _thirdSide && _secondSide >= _firstSide)
                deviation = _secondSide * _secondSide - (_firstSide * _firstSide + _thirdSide * _thirdSide);
            if (_thirdSide >= _firstSide && _thirdSide >= _secondSide)
                deviation = _thirdSide * _thirdSide - (_firstSide * _firstSide + _secondSide * _secondSide);
            return deviation >= 0 && deviation < Consts.Consts.Deviation;
        }
    }
}
