using AreaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary.Figures
{
    class Triangle : IFigure
    {
        double A, B, C;

        public Triangle(double a, double b, double c)
        {
            double[] sides = new double[] { a, b, c };
            Array.Sort(sides);
            A = sides[0];//minimal
            B = sides[1];
            C = sides[2];//maximal
        }

        private bool isRight()
        {

            if (Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2))
                return true;
            else
                return false;
        }

        private bool isEquilateral()
        {
            if (A == B && B == C)
                return true;
            else
                return false;
        }

        private double Geron()
        {
            double S = default;
            double P = (A + B + C) / 2.0;
            S = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
            return Math.Round(S, 2);
        }

        public double GetArea()
        {
            double S = default;
            if (isRight())
                S = 0.5 * A * B;
            else if (isEquilateral())
                S = Math.Pow(A, 2) * Math.Sqrt(3) / 4.0;
            else
                S = Geron();

            return Math.Round(S, 2);

        }


    }
}
