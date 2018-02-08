using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        /// <summary>
        /// Проверка радиуса на положительное значение
        /// </summary>
        private bool IsValid
        {
            get
            {
                if (Radius > 0)
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
                result = Math.PI * Radius * Radius;
            }
            return result;
        }
    }
}
