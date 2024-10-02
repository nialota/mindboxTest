using Mindbox.Models;

namespace Mindbox.Implementations
{
    public class ShapeCalculator : IShapeCalculator
    {
        public double GetArea(params double[] values)
        {
            var shape = GetShapeType(values);
            if (shape is null)
                throw new Exception("Не удалось определить форму");
            return AreaByShape(values, shape.Value);
        }

        /// <summary>
        /// Определить форму фигуры
        /// </summary>
        private static Shape? GetShapeType(double[] values)
        {
            return values.Length switch
            {
                1 => Shape.Circle,
                2 => Shape.Rectangle,
                3 => Shape.Triangle,
                4 => Shape.Quadrangle,
                _ => null,
            };
        }

        /// <summary>
        /// Рассчитать площадь фигуры по длинам ее сторон и типу фигуры
        /// </summary>
        private static double AreaByShape(double[] values, Shape shape)
        {
            return shape switch
            {
                Shape.Circle => new Circle().Area(values),
                Shape.Triangle => new Triangle().Area(values),
                Shape.Rectangle => new Rectangle().Area(values),
                Shape.Quadrangle => new Quadrangle().Area(values),
                _ => throw new Exception("Расчет площади для данной формы не реализован"),
            };
        }

        public bool IsRightTriangle(params double[] values)
            => new Triangle().IsRightTriangle(values.OrderByDescending(value => value));
    }
}