using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab_6
{
    [Serializable]
    public abstract class IFigure
    {
        protected Point[] array;

        public abstract double CalcArea();

        public abstract double CalcPerimeter();

        public Point[] GetPoints()
        {
            return array;
        }
    }

    partial class Form1
    {
        [Serializable]
        private class Circle : IFigure
        {
            public override double CalcArea()
            {
                double Avalue = Math.PI * (Math.Pow(Calc_dist(array[0], array[1]), 2));
                return Avalue;
            }

            public override double CalcPerimeter()
            {
                double Pvalue = 2 * Math.PI * Math.Sqrt(Math.Pow(Calc_dist(array[0], array[1]), 2));
                return Pvalue;
            }

            public Circle(Point[] array)
            {
                if (array.Length != 2)
                    throw new ArgumentException("Переданный массив неправильного размера");
                if ((array[1].X == array[0].X) || (array[1].X < array[0].X))
                    throw new ArgumentException("Неправильный радиус");
                this.array = array;
            }

            public override string ToString()
            {
                return $"Круг, центр { array[0].X}, {array[0].Y} радиус { array[1].X - array[0].X}";
            }
        }

        [Serializable]
        private class Square : IFigure
        {
            public override double CalcArea()
            {
                double Avalue = Math.Pow(Calc_dist(array[0], array[1]), 2);
                return Avalue;
            }

            public override double CalcPerimeter()
            {
                double Pvalue = 4 * Calc_dist(array[0], array[1]);
                return Pvalue;
            }

            public Square(Point[] array)
            {
                if (array.Length != 4)
                    throw new ArgumentException("Переданный массив неправильного размера");
                if ((Calc_dist(array[0], array[2]) != Calc_dist(array[1], array[3])) || //стороны не равны
                    ((Calc_dist(array[0], array[1]) != Calc_dist(array[1], array[2])) ||
                    (Calc_dist(array[1], array[2]) != Calc_dist(array[2], array[3])) ||
                    (Calc_dist(array[1], array[2]) != Calc_dist(array[2], array[3]))) ||
                    (Calc_dist(array[0], array[1]) == 0)) //если все точки одинаковые
                    throw new ArgumentException("Неправильные значения точек");
                this.array = array;
            }

            public override string ToString()
            {
                return $"Квадрат, ({ array[0].X}, {array[0].Y})({ array[1].X}, {array[1].Y})({ array[2].X}, {array[2].Y})({ array[3].X}, {array[3].Y})";
            }
        }

        [Serializable]
        private class Rectangle : IFigure
        {
            public override double CalcArea()
            {
                double Avalue = Calc_dist(array[0], array[1]) * Calc_dist(array[1], array[2]);
                return Avalue;
            }

            public override double CalcPerimeter()
            {
                double Pvalue = Calc_dist(array[0], array[1]) * 2 + Calc_dist(array[1], array[2]) * 2;
                return Pvalue;
            }

            public Rectangle(Point[] array)
            {
                if (array.Length != 4)
                    throw new ArgumentException("Переданный массив неправильного размера");
                if ((Calc_dist(array[0], array[2]) != Calc_dist(array[1], array[3])) || //диагонали не равны
                ((Calc_dist(array[0], array[1]) != Calc_dist(array[2], array[3])) ||
                (Calc_dist(array[1], array[2]) != Calc_dist(array[3], array[0]))) || //стороны не равны попарно
                (Calc_dist(array[0], array[1]) == 0) || //стороны равны 0
                (Calc_dist(array[0], array[3]) > Calc_dist(array[0], array[2]) ||
                Calc_dist(array[0], array[1]) > Calc_dist(array[0], array[2]))) //неправильный порядок ввода точек
                    throw new ArgumentException("Неправильные значения точек");
                if (Calc_dist(array[0], array[1]) == Calc_dist(array[1], array[2]))
                    throw new ArgumentException("Это квадрат");
                this.array = array;
            }

            public override string ToString()
            {
                return $"Прямоугольник, ({ array[0].X}, {array[0].Y})({ array[1].X}, {array[1].Y})({ array[2].X}, {array[2].Y})({ array[3].X}, {array[3].Y})";
            }
        }

        [Serializable]
        private class Triangle : IFigure
        {
            public override double CalcArea()
            {
                double Avalue = Math.Sqrt(CalcPerimeter() / 2 *
                    (CalcPerimeter() / 2 - Calc_dist(array[0], array[1])) *
                    (CalcPerimeter() / 2 - Calc_dist(array[1], array[2])) *
                    (CalcPerimeter() / 2 - Calc_dist(array[2], array[0])));
                return Avalue;
            }

            public override double CalcPerimeter()
            {
                double Pvalue = Calc_dist(array[0], array[1]) + Calc_dist(array[1], array[2]) + Calc_dist(array[2], array[0]);
                return Pvalue;
            }

            public Triangle(Point[] array)
            {
                if (array.Length != 3)
                    throw new ArgumentException("Переданный массив неправильного размера");
                if (((array[0].X == array[1].X) && (array[0].Y == array[1].Y)) ||
              ((array[1].X == array[2].X) && (array[1].Y == array[2].Y)) ||
              ((array[0].X == array[2].X) && (array[0].Y == array[2].Y)))//Точки совпадают
                    throw new ArgumentException("Неправильные значения точек");
                if ((array[0].X - array[2].X) * (array[1].Y - array[2].Y) == (array[1].X - array[2].X) * (array[0].Y - array[2].Y))
                    throw new ArgumentException("Точки лежат на одной прямой");
                this.array = array;
            }

            public override string ToString()
            {
                return $"Треугольник, ({ array[0].X}, {array[0].Y})({ array[1].X}, {array[1].Y})({ array[2].X}, {array[2].Y})";
            }
        }
    }
}