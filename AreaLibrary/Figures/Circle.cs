using AreaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary.Figures
{
    class Circle : IFigure
    {
        double R;

        public Circle(double r)
        {
            R = r;
        }
        public double GetArea()
        {
            double S = Math.PI * Math.Pow(R, 2);
            return Math.Round(S, 2);
        }
    }
}
