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
    public partial class LineDrawing : Form
    {
        Bitmap bmp;
        Graphics g;

        int width, height;
        int midWidth, midHeight;

        int pixelSize = 5;
        int offset;

        public LineDrawing()
        {
            offset = pixelSize / 2; 

            width = 750;
            height = 750;

            InitializeComponent();

            basicRadioButton.Checked = true;
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

        private void graphicButton_Click(object sender, EventArgs e)
        {
            try
            {
                int x1 = Int32.Parse(x1TextBox.Text);
                int y1 = Int32.Parse(y1TextBox.Text);

                int x2 = Int32.Parse(x2TextBox.Text);
                int y2 = Int32.Parse(y2TextBox.Text);

                if (basicRadioButton.Checked)
                {
                    basicAlgorithm(x1, y1, x2, y2);
                }
                else if (ddaRadioButton.Checked)
                {
                    ddaAlgorithm(x1, y1, x2, y2);
                }
                else if (bressenhamRadioButton.Checked)
                {
                    bressenhamAlgorithm(x1, y1, x2, y2);
                }
                else
                {
                    MessageBox.Show("Please, select an algorithm");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please, enter a only numbers");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeCanvas();

            ClearPlane();
        }



        private void basicAlgorithm(int x1, int y1, int x2, int y2)
        {
            ClearPlane();

            dataGridView.Rows.Clear();
            dataGridView.Refresh();

            double dx = (x2 - x1); 
            double dy = (y2 - y1); 

            double m = dy / dx; 
            double b = y1 - m * (double)x1; 

            if (dx > dy)
            {
                for (int x = x1; x < x2; x++)
                {
                    int y = (int)Math.Round((m * (double)x + b), 0, MidpointRounding.AwayFromZero);

                    dataGridView.Rows.Add(new string[] { x.ToString(), y.ToString() });

                    DrawPixel(x, y, Color.Black);
                }
            }
            else
            {
                for (int y = y1; y < y2; y++)
                {
                    int x = (int)Math.Round((y - b) / m, 0, MidpointRounding.AwayFromZero);
                    dataGridView.Rows.Add(new string[] { x.ToString(), y.ToString() });

                    DrawPixel(x, y, Color.Black);
                }
            }

            dataGridView.Rows.Add(new string[] { x2.ToString(), y2.ToString() });

            DrawPixel(x1, y1, Color.Green);
            DrawPixel(x2, y2, Color.Red);
        }

        private void ddaAlgorithm(int x1, int y1, int x2, int y2)
        {
            ClearPlane();

            dataGridView.Rows.Clear();
            dataGridView.Refresh();

            double dy = y2 - y1; 
            double dx = x2 - x1; 

            double step = (dy > dx) ? dy : dx;

            double stepX = dx / step;
            double stepY = dy / step;

            double x;
            double y;
            for (x = x1, y = y1;
                x < x2;
                x += stepX, y += stepY)
            {
                dataGridView.Rows.Add(new string[] { ((int)x).ToString(), ((int)Math.Round(y)).ToString() });

                DrawPixel((int)x, (int)Math.Round(y), Color.Black);
            }

            dataGridView.Rows.Add(new string[] { x2.ToString(), y2.ToString() });

            DrawPixel(x1, y1, Color.Green);
            DrawPixel(x2, y2, Color.Red);
        }

        private void bressenhamAlgorithm(int x1, int y1, int x2, int y2)
        {
            ClearPlane();

            dataGridView.Rows.Clear();
            dataGridView.Refresh();

            int dy = y2 - y1;
            int dx = x2 - x1;

            if (dx >= dy)
            {
                int E = 2 * dy;
                int Pi = E - dx;
                int NE = Pi - dx;

                int x = x1, y = y1;

                for (int i = 0; i < dx; i++)
                {
                    dataGridView.Rows.Add(new string[] { x.ToString(), y.ToString() });
                    DrawPixel(x, y, Color.Black);
                    x += 1;
                    if (Pi <= 0)
                    {
                        Pi += E;
                    }
                    else
                    {
                        Pi += NE;
                        y += 1;
                    }
                }
            }
            else
            {
                int E = 2 * dx;
                int Pi = E - dy;
                int NE = Pi - dy;

                int x = x1, y = y1;
                for (int i = 0; i < dy; i++)
                {
                    dataGridView.Rows.Add(new string[] { x.ToString(), y.ToString() });
                    DrawPixel(x, y, Color.Black);
                    y += 1;
                    if (Pi <= 0)
                    {
                        Pi += E;
                    }
                    else
                    {
                        Pi += NE;
                        x += 1;
                    }
                }
            }

            dataGridView.Rows.Add(new string[] { x2.ToString(), y2.ToString() });

            DrawPixel(x1, y1, Color.Green);
            DrawPixel(x2, y2, Color.Red);
        }

        private void DrawAxes()
        {
            Pen mainAxesPen = new Pen(Color.Black); 
            Pen subAxesPen = new Pen(Color.FromArgb(255, 190, 190, 190)); 
            Pen subSubAxesPen = new Pen(Color.FromArgb(255, 240, 240, 240)); 

            for (int i = offset; i < midWidth; i += pixelSize)
            {
                g.DrawLine(subSubAxesPen, midWidth + i, 0, midWidth + i, height);
                g.DrawLine(subSubAxesPen, midWidth - i, 0, midWidth - i, height);
            }
            for (int i = offset; i < midHeight; i += pixelSize)
            {
                g.DrawLine(subSubAxesPen, 0, midHeight + i, width, midHeight + i);
                g.DrawLine(subSubAxesPen, 0, midHeight - i, width, midHeight - i);
            }

            for (int i = offset; i < midWidth; i += pixelSize * 5)
            {
                g.DrawLine(subAxesPen, midWidth + i, 0, midWidth + i, height);
                g.DrawLine(subAxesPen, midWidth - i, 0, midWidth - i, height);
            }
            for (int i = offset; i < midHeight; i += pixelSize * 5)
            {
                g.DrawLine(subAxesPen, 0, midHeight + i, width, midHeight + i);
                g.DrawLine(subAxesPen, 0, midHeight - i, width, midHeight - i);
            }

            g.DrawLine(mainAxesPen, midWidth, 0, midWidth, height);   
            g.DrawLine(mainAxesPen, 0, midHeight, width, midHeight);  

            UpdateCanvas(); 
        }

        private void DrawPixel(int x, int y, Color color)
        {
            g = Graphics.FromImage(bmp);

            SolidBrush pixelBrush = new SolidBrush(color);

            int xPlane = midWidth - offset;
            int yPlane = midHeight - offset;

            g.FillRectangle(pixelBrush, xPlane + x * pixelSize + 1, yPlane - y * pixelSize + 1, pixelSize - 1, pixelSize - 1);

            UpdateCanvas(); 
        }

        private void UpdateCanvas()
        {
            g.Dispose();
            canvasPictureBox.Image = bmp;
        }

        private void InitializeCanvas()
        {
            offset = pixelSize / 2;

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
    }
}
