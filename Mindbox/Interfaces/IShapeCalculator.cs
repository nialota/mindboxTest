namespace Mindbox
{
	public interface IShapeCalculator
	{
        /// <summary>
        /// Вычислить площадь фигуры
        /// </summary>
        double GetArea(params double[] values);
        /// <summary>
        /// Проверить является ли треугольник прямоугольным
        /// </summary>
        bool IsRightTriangle(params double[] values);
    }
}