using FiguresLibrary.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Services
{
    public static class CalculationService
    {
        public static double CalculationArea(Figure figure) => figure.Area(); 
    }
}
