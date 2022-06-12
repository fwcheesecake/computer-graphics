using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerGraphics
{
    public partial class Fractals : Form
    {
        Bitmap bmp;
        Graphics g;

        int width, height; // Size of the canvas
        int midWidth, midHeight; // Middle point of the canvas

        int n;

        int pixelSize = 10; // Size of each pixel in the plane

        struct ChromePoint
        {
            public double X, Y;
            public int R, G, B;

            public ChromePoint(double x, double y, int r, int g, int b)
            {
                X = x;
                Y = y;
                R = r;
                G = g;
                B = b;
            }
        }

        private ChromePoint PointRatio(ChromePoint start, ChromePoint end, double ratio)
        {
            ChromePoint point = new ChromePoint();

            point.X = (start.X + ratio * end.X) / (1 + ratio);
            point.Y = (start.Y + ratio * end.Y) / (1 + ratio);

            point.R = (int)((start.R + ratio * end.R) / (1 + ratio));
            point.G = (int)((start.G + ratio * end.G) / (1 + ratio));
            point.B = (int)((start.B + ratio * end.B) / (1 + ratio));

            return point;
        }

        private void sierpinskiTriangleDrawer(ChromePoint p1, ChromePoint p2, ChromePoint p3, int n)
        {
            Pen pen1;
            ChromePoint i1, i2, i3;
            if (n == 0) 
            {
                pen1 = new Pen(Color.FromArgb(255, p1.R, p1.G, p1.B));
                g.DrawLine(pen1, (int) p1.X, (int) p1.Y, (int) p2.X, (int) p2.Y);
                pen1 = new Pen(Color.FromArgb(255, p2.R, p2.G, p2.B));
                g.DrawLine(pen1, (int) p2.X, (int) p2.Y, (int) p3.X, (int) p3.Y);
                pen1 = new Pen(Color.FromArgb(255, p3.R, p3.G, p3.B));
                g.DrawLine(pen1, (int) p3.X, (int) p3.Y, (int) p1.X, (int) p1.Y);
            }
            else 
            {
                i1 = PointRatio(p1, p2, 1.0);
                i2 = PointRatio(p2, p3, 1.0);
                i3 = PointRatio(p3, p1, 1.0);

                sierpinskiTriangleDrawer(i1, p2, i2, n - 1);
                sierpinskiTriangleDrawer(i3, i2, p3, n - 1);
                sierpinskiTriangleDrawer(p1, i1, i3, n - 1);
            }
        }

        private ChromePoint Pol2cart(double r, double theta)
        {
            ChromePoint p = new ChromePoint();
            theta = theta * Math.PI / 180;
            p.X = midWidth + (int)(r * Math.Cos(theta));
            p.Y = midHeight - (int)(r * Math.Sin(theta));

            return p;
        }

        private void SierpinskiTriangle()
        {
            ChromePoint p1, p2, p3;

            p1 = Pol2cart(midHeight, 90);
            p2 = Pol2cart(midHeight, 210);
            p3 = Pol2cart(midHeight, 330);

            p1.R = 255;
            p2.G = 255;
            p3.B = 255;

            g = Graphics.FromImage(bmp);
            g.Clear(Color.Black);

            int n = (int)nNumericUpDown.Value;

            //g.DrawEllipse(pen1, xo - yo, 0, 2*yo, 2*yo);                      
            sierpinskiTriangleDrawer(p1, p2, p3, n);
            //CurvaVonKoch(p2, p3);
            canvasPictureBox.Image = bmp;
            g.Dispose();
        }

        private void vonkochCurveDrawer(ChromePoint p1, ChromePoint p2, int n)
        {
            ChromePoint i1, i2, i3;
            Pen pen1 = new Pen(Color.FromArgb(255, p2.R, p2.G, p2.B));
            pen1.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;

            if (n == 0) {
                g.DrawLine(pen1, (int)p1.X, (int)p1.Y, (int)p2.X, (int)p2.Y);
            }
            else
            {
                i1 = PointRatio(p1, p2, 0.5);
                i3 = PointRatio(p1, p2, 2.0);
                i2 = RotatePoint(i3, i1, Math.PI / 3.0);

                vonkochCurveDrawer(p1, i1, n - 1);
                vonkochCurveDrawer(i1, i2, n - 1);
                vonkochCurveDrawer(i2, i3, n - 1);
                vonkochCurveDrawer(i3, p2, n - 1);
            }
        }

        private void VonkochCurve()
        {
            ChromePoint pi, pf, pm;
            int n;
            n = (int) nNumericUpDown.Value;
            pi = new ChromePoint(80, midHeight + 200, 0, 255, 0);
            pf = new ChromePoint(width - 80, midHeight + 200, 255, 0, 0);

            g = Graphics.FromImage(bmp);
            g.Clear(Color.Black);

            pm = RotatePoint(pf, pi, Math.PI / 3);

            vonkochCurveDrawer(pi, pm, n);
            vonkochCurveDrawer(pm, pf, n);
            vonkochCurveDrawer(pf, pi, n);
            //vonkochCurveDrawer(pi, pf, n); 

            canvasPictureBox.Image = bmp;
            g.Dispose();
        }

        private ChromePoint RotatePoint(ChromePoint v, ChromePoint c, double theta)
        {
            ChromePoint p = PointRatio(v, c, 1.0);

            double dx, dy, ang, r;

            dx = v.X - c.X;
            dy = v.Y - c.Y;

            r = Math.Sqrt(dx * dx + dy * dy);

            ang = Math.Atan2(dy, dx);
            ang -= theta;

            p.X = c.X + r * Math.Cos(ang);
            p.Y = c.Y + r * Math.Sin(ang);

            return p;
        }

        private void DrawSquare(ChromePoint start, ChromePoint end)
        {
            SolidBrush brush;

            int x, y, w, h;

            brush = new SolidBrush(Color.FromArgb(255, start.R, start.G, start.B));

            x = (int) start.X;
            y = (int) start.Y;

            w = (int) end.X - (int) start.X;
            h = (int) end.Y - (int) start.Y;

            g.FillRectangle(brush, x, y, w, h);
        }

        private void VicsekSquareDrawer(ChromePoint pi, ChromePoint pii, ChromePoint pf, ChromePoint pff, int n)
        {
            ChromePoint p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12;
            ChromePoint e1, e2, e3, e4;

            if (n == 0)
            {
                DrawSquare(pi, pf);
            }
            else
            {
                p1 = PointRatio(pi, pii, 0.5);
                p2 = PointRatio(pi, pii, 2.0);

                p3 = PointRatio(pii, pf, 0.5);
                p4 = PointRatio(pii, pf, 2.0);

                p5 = PointRatio(pf, pff, 0.5);
                p6 = PointRatio(pf, pff, 2.0);

                p7 = PointRatio(pff, pi, 0.5);
                p8 = PointRatio(pff, pi, 2.0);

                p9 = PointRatio(p8, p3, 0.5);
                p10 = PointRatio(p8, p3, 2.0);

                p11 = PointRatio(p7, p4, 0.5);
                p12 = PointRatio(p7, p4, 2.0);

                VicsekSquareDrawer(p1, p2, p10, p9, n - 1);
                VicsekSquareDrawer(p8, p9, p11, p7, n - 1);
                VicsekSquareDrawer(p9, p10, p12, p11, n - 1);
                VicsekSquareDrawer(p10, p3, p4, p12, n - 1);
                VicsekSquareDrawer(p11, p12, p5, p6, n - 1);
            }
        }

        private void VicsekDiagonalDrawer(ChromePoint pi, ChromePoint pii, ChromePoint pf, ChromePoint pff, int n)
        {
            ChromePoint p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12;
            ChromePoint e1, e2, e3, e4;

            if (n == 0)
            {
                DrawSquare(pi, pf);
            }
            else
            {
                p1 = PointRatio(pi, pii, 0.5);
                p2 = PointRatio(pi, pii, 2.0);

                p3 = PointRatio(pii, pf, 0.5);
                p4 = PointRatio(pii, pf, 2.0);

                p5 = PointRatio(pf, pff, 0.5);
                p6 = PointRatio(pf, pff, 2.0);

                p7 = PointRatio(pff, pi, 0.5);
                p8 = PointRatio(pff, pi, 2.0);

                p9 = PointRatio(p8, p3, 0.5);
                p10 = PointRatio(p8, p3, 2.0);

                p11 = PointRatio(p7, p4, 0.5);
                p12 = PointRatio(p7, p4, 2.0);

                //CRUZ 
                /*
                    g = VicsekR(g, p1, p10, n  -1);
                    g = VicsekR(g, p8, p11, n - 1);
                    g = VicsekR(g, p9, p12, n - 1);
                    g = VicsekR(g, p10, p4, n - 1);
                    g = VicsekR(g, p11, p5, n - 1);
                */

                // OTRA FORMA
                VicsekDiagonalDrawer(pi, p1, p9, p8, n - 1);
                VicsekDiagonalDrawer(p2, pii, p3, p10, n - 1);
                VicsekDiagonalDrawer(p9, p10, p12, p11, n - 1);
                VicsekDiagonalDrawer(p7, p11, p6, pff, n - 1);
                VicsekDiagonalDrawer(p12, p4, pf, p5, n - 1);
            }
        }

        private void VicsekDiagonal()
        {
            ChromePoint pi, pf, pii, pff;

            pi = new ChromePoint(10, 10, 255, 0, 0);
            pii = new ChromePoint(width - 10, 10, 0, 0, 255);
            pff = new ChromePoint(10, height - 10, 0, 255, 0);
            pf = new ChromePoint(width - 10, height - 10, 255, 0, 255);

            g = Graphics.FromImage(bmp);
            g.Clear(Color.Black);

            VicsekDiagonalDrawer(pi, pii, pf, pff, n);

            canvasPictureBox.Image = bmp;
            g.Dispose();
        }
        
        private void VicsekSquare()
        {
            ChromePoint pi, pf, pii, pff;

            pi = new ChromePoint(10, 10, 255, 0, 0);
            pii = new ChromePoint(width - 10, 10, 0, 0, 255);
            pff = new ChromePoint(10, height - 10, 0, 255, 0);
            pf = new ChromePoint(width - 10, height - 10, 255, 0, 255);

            g = Graphics.FromImage(bmp);
            g.Clear(Color.Black);

            VicsekSquareDrawer(pi, pii, pf, pff, n);

            canvasPictureBox.Image = bmp;
            g.Dispose();
        }

        public Fractals()
        {
            width = 750;
            height = 750;

            InitializeComponent();

            InitializeCanvas();
            ClearPlane();
        }

        private void plusZoomButton_Click(object sender, EventArgs e)
        {
            if (pixelSize < 50) 
            {
                pixelSize += 5;

                width = pixelSize * 150;
                height = width;

                InitializeCanvas();
                ClearPlane();
            }
        }

        private void minusZoomButton_Click(object sender, EventArgs e)
        {
            if (pixelSize > 5)
            {
                pixelSize -= 5;

                width = pixelSize * 150;
                height = width;

                InitializeCanvas();
                ClearPlane();
            }
        }

        private void DrawAxes()
        {
            Pen mainAxesPen = new Pen(Color.Black);
            Pen subAxesPen = new Pen(Color.FromArgb(255, 190, 190, 190));
            Pen subSubAxesPen = new Pen(Color.FromArgb(255, 240, 240, 240));

            for (int i = 0; i < midWidth; i += pixelSize)
            {
                g.DrawLine(subSubAxesPen, midWidth + i, 0, midWidth + i, height);
                g.DrawLine(subSubAxesPen, midWidth - i, 0, midWidth - i, height);
            }
            for (int i = 0; i < midHeight; i += pixelSize)
            {
                g.DrawLine(subSubAxesPen, 0, midHeight + i, width, midHeight + i);
                g.DrawLine(subSubAxesPen, 0, midHeight - i, width, midHeight - i);
            }

            for (int i = 0; i < midWidth; i += pixelSize * 5)
            {
                g.DrawLine(subAxesPen, midWidth + i, 0, midWidth + i, height);
                g.DrawLine(subAxesPen, midWidth - i, 0, midWidth - i, height);
            }
            for (int i = 0; i < midHeight; i += pixelSize * 5)
            {
                g.DrawLine(subAxesPen, 0, midHeight + i, width, midHeight + i);
                g.DrawLine(subAxesPen, 0, midHeight - i, width, midHeight - i);
            }

            g.DrawLine(mainAxesPen, midWidth, 0, midWidth, height);   //y axis
            g.DrawLine(mainAxesPen, 0, midHeight, width, midHeight);  //x axis

            UpdateCanvas();
        }

        private float Pixel2Em(float pixel)
        {
            return pixel * 10.0f / 16.0f;
        }

        private void DrawPixel(int x, int y, Color color, String label)
        {
            g = Graphics.FromImage(bmp);

            float stringSize = pixelSize / 1.5f;
            Font font = new Font("Arial", Pixel2Em(stringSize));

            SolidBrush pixelBrush = new SolidBrush(color);
            SolidBrush stringBrush = new SolidBrush(Color.White);

            g.FillEllipse(pixelBrush, x, y, pixelSize - 1, pixelSize - 1);
            g.DrawString(label, font, stringBrush, x + stringSize / 3, y + stringSize / 3);

            UpdateCanvas(); 
        }

        private void UpdateCanvas()
        {
            g.Dispose();
            canvasPictureBox.Image = bmp;
        }

        private void InitializeCanvas()
        {
            midWidth = width / 2;
            midHeight = height / 2;

            bmp = new Bitmap(width, height);
        }

        private void ClearPlane()
        {
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            DrawAxes();
        }

        private void graphicButton_Click(object sender, EventArgs e)
        {
            n = (int)nNumericUpDown.Value;

            InitializeCanvas();
            UpdateCanvas();

            if (sierpinskiCarpetRadioButton.Checked)
            {

            }
            else if (sierpinskiTriangleRadioButton4.Checked)
            {
                SierpinskiTriangle();
            }
            else if (vonkochCurveRadioButton.Checked)
            {
                VonkochCurve();
            } else if (vicsekDiagonalRadioButton.Checked)
            {
                VicsekDiagonal();
            } else
            {
                VicsekSquare();
            }
        }
    }
}
