using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicRedactor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private PaintService paintService;

        private Point prevPoint;
        private string namePen;


        private void Form1_Load(object sender, EventArgs e)
        {
            paintService = new PaintService();

            pictureBox1.Image = paintService.Clear(pictureBox1.Width, pictureBox1.Height);

            labelCount.Text = trackBarBorder.Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                paintService.SetColor(colorDialog1.Color);
                labelColor.BackColor = colorDialog1.Color;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            namePen = picturePen.Name;
            cleanBG();
            picturePen.BackColor = Color.Coral;
        }

        private void pictureRectangle_Click(object sender, EventArgs e)
        {
            namePen = pictureRectangle.Name;
            cleanBG();
            pictureRectangle.BackColor = Color.Coral;
        }

        private void pictureText_Click(object sender, EventArgs e)
        {
            namePen = pictureText.Name;
            cleanBG();
            pictureText.BackColor = Color.Coral;
        }

        private void pictureEllipse_Click(object sender, EventArgs e)
        {
            namePen = pictureEllipse.Name;
            cleanBG();
            pictureEllipse.BackColor = Color.Coral;
        }

        public void cleanBG()
        {
            picturePen.BackColor = Color.White;
            pictureRectangle.BackColor = Color.White;
            pictureText.BackColor = Color.White;
            pictureEllipse.BackColor = Color.White;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && namePen == "picturePen")
            {
                SwitchPaint(e);
                pictureBox1.Image = PaintService.Bitmap; //Отображение изменений в виде нарисованной линии
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prevPoint = e.Location;
            SwitchPaint(e);
            pictureBox1.Image = PaintService.Bitmap;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            SwitchPaint(e);
            pictureBox1.Image = PaintService.Bitmap;
        }

        public void SwitchPaint(MouseEventArgs e)
        {
            switch (namePen)
            {
                case "picturePen":
                    paintService.PaintPen(prevPoint, e.Location);
                    break;

                case "pictureRectangle":
                    paintService.PaintRectangle(prevPoint, e.Location);
                    break;

                case "pictureEllipse":
                    paintService.PaintEllipse(prevPoint, e.Location);
                    break;

                case "pictureText":
                    paintService.PaintText(e.Location);
                    break;
            }
            prevPoint = e.Location;
        }

        private void trackBarBorder_Scroll(object sender, EventArgs e)
        {
            paintService.SetWidthPen(trackBarBorder.Value);
            labelCount.Text = trackBarBorder.Value.ToString();
        }

        private void pictureSave_Click(object sender, EventArgs e)
        {
            paintService.Save();
        }

        private void pictureNew_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = paintService.Clear(pictureBox1.Width, pictureBox1.Height);
        }
    }
}
