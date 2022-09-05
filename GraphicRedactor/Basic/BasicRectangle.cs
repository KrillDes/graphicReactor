using System.Drawing;

namespace GraphicRedactor.Basic
{
    /// <summary>
    /// Базовое представление отрисовки прямоугольника
    /// </summary>
    internal class BasicRectangle
    {
        public void PaintRectangle(Graphics graphic, Pen pen, Point oldPoint, Point newPoint)
        {
            graphic.DrawRectangle(pen, new Rectangle(oldPoint.X, oldPoint.Y, (newPoint.X - oldPoint.X), (newPoint.Y - oldPoint.Y)));
        }
    }
}
