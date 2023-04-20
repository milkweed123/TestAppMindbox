using FiguresLibrary.Consts;
using FiguresLibrary.Figures;
using FiguresLibrary.Services;
using NUnit.Framework;
using System;

namespace FiguresLibrary.Test
{
    public class Tests
    {

        [Test]
        public void Circle_Calculation_Area()
        {
            var circle = new Circle(4);
            var area = CalculationService.CalculationArea(circle);
            Assert.That(area, Is.EqualTo(50.26548245).Within(Consts.Consts.Deviation));
        }
        [Test]
        public void Circle_Check_Argument()
        {
            Assert.Catch<ArgumentOutOfRangeException>(() => new Circle(-1));
        }
        [Test]
        public void Triangle_Check_First_Side()
        {
            Assert.Catch<ArgumentOutOfRangeException>(() => new Triangle(-1, 1, 1));
        }
        [Test]
        public void Triangle_Check_Second_Side()
        {
            Assert.Catch<ArgumentOutOfRangeException>(() => new Triangle(1, -1, 1));
        }
        [Test]
        public void Triangle_Check_Third_Side()
        {
            Assert.Catch<ArgumentOutOfRangeException>(() => new Triangle(1, 1, -1));
        }
        [Test]
        public void Triangle_Is_Not_Exists()
        {
            Assert.Catch<Exception>(() => new Triangle(1, 1, 20));
        }
        [Test]
        public void Triangle_Is_Right1()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.IsRight());
        }
        [Test]
        public void Triangle_Is_Right2()
        {
            var triangle = new Triangle(5, 4, 3);
            Assert.That(triangle.IsRight());
        }
        [Test]
        public void Triangle_Is_Right3()
        {
            var triangle = new Triangle(12, 13, 5);
            Assert.That(triangle.IsRight());
        }
        [Test]
        public void Triangle_Is_Right4()
        {
            var triangle = new Triangle(12, 13, 10);
            Assert.That(!triangle.IsRight());
        }
        [Test]
        public void Triangle_Calculation_Area1()
        {
            var triangle = new Triangle(3, 4, 5);
            var area = CalculationService.CalculationArea(triangle);
            Assert.That(area, Is.EqualTo(6).Within(Consts.Consts.Deviation));
        }
        [Test]
        public void Triangle_Calculation_Area2()
        {
            var triangle = new Triangle(4, 4, 5);
            var area = CalculationService.CalculationArea(triangle);
            Assert.That(area, Is.EqualTo(7.80624749).Within(Consts.Consts.Deviation));
        }
    }
}