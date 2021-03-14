using AreaLibrary.Figures;
using AreaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
  public static class AreaService
    {
        /// <summary>
        /// Площадь окружности
        /// </summary>
        /// <param name="r">Радиус окружности</param>
        /// <returns></returns>
       public static double GetArea(double r)
        {           
            IFigure figure = new Circle(r);
            return GetArea(figure);
        }

        /// <summary>
        /// Площадь треугольника
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public  static double GetArea(double a, double b, double c)
        {
            IFigure figure = new Triangle(a, b, c);
            return GetArea(figure);
        }

        /// <summary>
        /// Общий метод вычисления S любой фигуры поддерживающией интерфейс IFigure
        /// </summary>
        /// <param name="figure"></param>
        /// <returns></returns>
        public static double GetArea(IFigure figure)
        {
            return figure.GetArea();
        }
    }
}
