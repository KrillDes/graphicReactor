using System.Drawing;

namespace GraphicRedactor
{
    /// <summary>
    /// Базовое представление отрисовки линии
    /// </summary>
    internal class BasicPen
    {
        public void PaintLine(Graphics graphics, Pen pen, Point oldPoint, Point newPoint)
        {
            graphics.DrawLine(pen, oldPoint, newPoint);
        }
    }
}
