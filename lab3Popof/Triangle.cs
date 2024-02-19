using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3Popof
{
    internal class Triangle
    {
        public double SideA {  get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double AngleA { get; set; }
        public double AngleB { get; set; }
        public double AngleC { get; set; }

        public Triangle(double sideA, double sideB, double sideC, double angleA, double angleB, double angleC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            AngleA = angleA;
            AngleB = angleB;
            AngleC = angleC;
        }
        public double CalcArea()
        {
            double s=(SideA+SideB+SideC)/2;
            return Math.Sqrt(s*(s-SideA)*(s-SideB) * (s - SideC));
        }
        public double CalcPerimetr()
        {
            return SideA+SideB+SideC;
        }
        public double CalcHeight()
        {
            double area =CalcArea();
            return 2 * area / SideA;
        }
        public string TriangleType()
        {
            if (SideA == SideB && SideB == SideC)
            {
                return "Равносторонний треугольник";
            }
            else if (SideA == SideB || SideA == SideC || SideB == SideC)
            {
                return "Равнобедренный треугольник";

            }
            else if (Math.Round(AngleA) == 90 || Math.Round(AngleB) == 90 || Math.Round(AngleC) == 90)
            {
                return "Прямоугольный треугольник";
            }
            else 
            {
                return "Обычный треугольник";
            }

        }

    }

}
