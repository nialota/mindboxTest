using Mindbox.Interfaces;

namespace Mindbox.Models
{
    public class Triangle : BaseCalculation, IArea
    {

        /// <summary>
        /// Рассчитать площадь треугольника
        /// </summary>
        public double Area(double[] values)
        {
            var halfPerimeter = GetHalfPerimeter(values);
            var area = Math.Sqrt(halfPerimeter * (halfPerimeter - values[0]) * (halfPerimeter - values[1]) * (halfPerimeter - values[2]));
            return area;
        }

        /// <summary>
        /// Теорема Пифагора, проверка что треугольник прямоугольный
        /// Если теорема Пифагора будет верна, и квадрат большей стороны треугольника равен сумме квадратов двух меньших сторон, то треугольник прямоугольный.
        /// </summary>
        public bool IsRightTriangle(IEnumerable<double> values)
        {
            if (values.Count() != 3)
                throw new Exception("Переданы некорректные данные для проверки треугольника");
            var maxValue = values.First();
            var leftoverValues = values.Skip(1).ToArray();
            var summOfPowLeftoverValues = CalculateSumOfPow(leftoverValues);
            var powMaxValue = Math.Pow(maxValue, 2);
            return powMaxValue == summOfPowLeftoverValues;
        }
    }
}