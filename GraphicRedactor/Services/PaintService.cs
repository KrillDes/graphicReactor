using GraphicRedactor.Basic;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicRedactor
{
    /// <summary>
    /// Сервис отрисовки
    /// </summary>
    public class PaintService
    {
        private BasicPen basicPen;
        private BasicRectangle basicRectangle;
        private BasicEllipse basicEllipse;
        private BasicText basicText;

        private Graphics graphic;

        #region Singleton

        private static Bitmap bitmap;

        public static Bitmap Bitmap
        {
            get
            {
                if (bitmap == null)
                    bitmap = new Bitmap(0, 0);
                return bitmap;
            }
        }

        #endregion

        private Pen pen;
        private Color color;

        public PaintService()
        {
            basicPen = new BasicPen();
            basicRectangle = new BasicRectangle();
            basicEllipse = new BasicEllipse();
            basicText = new BasicText();

            color = Color.Black;
            pen = new Pen(color);
        }

        /// <summary>
        /// Предваритиельная очистка полотна и создание нового
        /// </summary>
        /// <param name="width">Ширина полотна</param>
        /// <param name="height">высота полотна</param>
        /// <returns>Возвращает полотно заданных размеров</returns>
        public Bitmap Clear(int width, int height)
        {
            Color color = Color.White;

            bitmap = new Bitmap(width, height);
            graphic = Graphics.FromImage(bitmap);
            graphic.Clear(color);
            return bitmap;
        }

        public void PaintPen(Point oldPoint, Point newPoint)
        {
            basicPen.PaintLine(graphic, pen, oldPoint, newPoint);
        }

        public void PaintRectangle(Point oldPoint, Point newPoint)
        {
            basicRectangle.PaintRectangle(graphic,pen, oldPoint, newPoint);
        }

        public void PaintEllipse(Point oldPoint, Point newPoint)
        {
            basicEllipse.PaintEllipse(graphic, pen, oldPoint, newPoint);
        }

        public void PaintText(Point newPoint)
        {
            basicText.PaintText(graphic, color, newPoint);
        }

        public void SetColor(Color color)
        {
            this.color = color;
            pen.Color = color;          
        }

        public void SetWidthPen(int width)
        {
            pen.Width = width;
        }

        /// <summary>
        /// Сохранение полотна
        /// </summary>
        public void Save()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG|* .png|Jpeg|*.jpeg";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog.FileName);
            }
        }
    }
}
