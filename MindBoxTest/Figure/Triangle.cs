using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{
    public class Triangle : IFigure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Проверка треугольника на существование
        /// </summary>
        private bool IsValid
        {
            get
            {
                if (SideA > 0 && SideB > 0 && SideC > 0 && SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA)
                    return true;
                else
                    return false;
            }
        }
        
        public double? Square()
        {
            double? result = null;
                        
            if (IsValid)
            {
                //по формуле Герона
                double halfPerimeter = (SideA + SideB + SideC) / 2;
                result = Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
            }
            return result;
        }
    }
}
