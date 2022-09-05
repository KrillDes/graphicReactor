using System.Drawing;

namespace GraphicRedactor.Basic
{
    /// <summary>
    /// Базовое представление отрисовки эллипса
    /// </summary>
    internal class BasicEllipse
    {
        public void PaintEllipse(Graphics graphic, Pen pen, Point oldPoint, Point newPoint)
        {
            graphic.DrawEllipse(pen, new Rectangle(oldPoint.X, oldPoint.Y, (newPoint.X - oldPoint.X), (newPoint.Y - oldPoint.Y)));
        }
    }
}
