using System;

namespace Figure
{
    public interface IFigure
    {
        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        /// <returns>Площаль фигуры. Null - если фигура с такими параметрами не существует</returns>
        double? Square();
    }
}
