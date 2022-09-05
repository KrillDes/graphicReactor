using Microsoft.VisualBasic;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicRedactor.Basic
{
    /// <summary>
    /// Базовое представление отрисовки текста
    /// </summary>
    internal class BasicText
    {
        public void PaintText(Graphics graphics, Color color, Point newPoint)
        {
            string text = Interaction.InputBox("Введите текст", "Ввод текста", "Текст", Screen.PrimaryScreen.Bounds.Width / 3, Screen.PrimaryScreen.Bounds.Height / 3);
            Font drawFont = new Font("Arial", 12);
            graphics.DrawString(text, drawFont, new SolidBrush(color), newPoint);
        }
    }
}
