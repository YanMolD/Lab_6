using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab_6
{
    partial class Form1
    {
        public static double Calc_All_Areas(List<IFigure> figures)
        {
            double sum = 0;
            for (int i = 0; i < 4; i++)
                sum += figures[i].CalcArea();
            return sum;
        }

        public static double Calc_All_Perimeterms(List<IFigure> figures)
        {
            double sum = 0;
            for (int i = 0; i < 4; i++)
                sum += figures[i].CalcPerimeter();
            return sum;
        }

        public static IFigure Calc_Max_P(List<IFigure> figures)
        {
            double max = 0;
            int save_pos = 0;
            for (int i = 0; i < 4; i++)
                if (figures[i].CalcPerimeter() > max)
                {
                    max = figures[i].CalcPerimeter();
                    save_pos = i;
                }
            return figures[save_pos];
        }

        public static IFigure Calc_Max_A(List<IFigure> figures)
        {
            double max = 0;
            int save_pos = 0;
            for (int i = 0; i < 4; i++)
                if (figures[i].CalcArea() > max)
                {
                    max = figures[i].CalcArea();
                    save_pos = i;
                }
            return figures[save_pos];
        }

        public static IFigure Calc_Min_P(List<IFigure> figures)
        {
            double min = figures[0].CalcPerimeter();
            int save_pos = 0;
            for (int i = 0; i < 4; i++)
                if (figures[i].CalcPerimeter() < min)
                {
                    min = figures[i].CalcPerimeter();
                    save_pos = i;
                }
            return figures[save_pos];
        }

        public static IFigure Calc_Min_A(List<IFigure> figures)
        {
            double min = figures[0].CalcArea();
            int save_pos = 0;
            for (int i = 0; i < 4; i++)
                if (figures[i].CalcArea() < min)
                {
                    min = figures[i].CalcArea();
                    save_pos = i;
                }
            return figures[save_pos];
        }

        public static double Calc_dist(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        }
    }
}