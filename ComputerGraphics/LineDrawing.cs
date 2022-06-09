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

        int width, height; // Size of the canvas
        int midWidth, midHeight; // Middle point of the canvas

        int pixelSize = 5; // Size of each pixel in the plane
        int offset; // Offset needed to draw the 0 axes.

        public LineDrawing()
        {
            offset = pixelSize / 2; // Initialize the offset

            // Set the initial size of the canvas
            width = 750;
            height = 750;

            // IDK what does this method do
            InitializeComponent();

            // Check the Basic Algorithm Radio Button 
            basicRadioButton.Checked = true;
        }

        private void plusZoomButton_Click(object sender, EventArgs e)
        {
            if (pixelSize < 50) // Sets the upperbound of the zoom
            {
                pixelSize += 5; // Increases the size of the pixel

                // Increases the size of the panel
                // Since it's a square width and height are the same
                // TODO I Should probably remove one of these variables
                width = pixelSize * 150;
                height = width;

                // Reload the canvas and clears it
                InitializeCanvas();
                ClearPlane();
            }
        }

        private void minusZoomButton_Click(object sender, EventArgs e)
        {
            if (pixelSize > 5) // Sets the underbound of the zoom
            {
                // Increases the size of the pixel
                pixelSize -= 5;

                // Increases the size of the panel
                // Since it's a square width and height are the same
                width = pixelSize * 150;
                height = width;

                // Reload the canvas and clears it
                InitializeCanvas();
                ClearPlane();
            }
        }

        private void graphicButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get X and Y from first point in the plane
                int x1 = Int32.Parse(x1TextBox.Text);
                int y1 = Int32.Parse(y1TextBox.Text);

                // Get X and Y from second point in the plane
                int x2 = Int32.Parse(x2TextBox.Text);
                int y2 = Int32.Parse(y2TextBox.Text);

                if (basicRadioButton.Checked)
                {
                    // Use the basic line drawing algorithm
                    basicAlgorithm(x1, y1, x2, y2);
                }
                else if (ddaRadioButton.Checked)
                {
                    // Use the Digital Differential Analyzer algorithm
                    ddaAlgorithm(x1, y1, x2, y2);
                }
                else if (bressenhamRadioButton.Checked)
                {
                    // Use the Bressenham Line Generating Algorithm
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
            // Create a new image for the canvas
            InitializeCanvas();

            // Refresh completely the canvas to create the initial plane
            ClearPlane();
        }



        // Basic Algorithm
        private void basicAlgorithm(int x1, int y1, int x2, int y2)
        {
            // Clears the plane
            ClearPlane();

            // Clears the dataGridView and refreshes it
            dataGridView.Rows.Clear();
            dataGridView.Refresh();

            double dx = (x2 - x1); // Delta X
            double dy = (y2 - y1); // Delta Y

            double m = dy / dx; // Calculates the gradient of the line
            double b = y1 - m * (double)x1; // Calculates the cordinate Y where the line intersect with the Y axis

            // Draws a line for each of two posible cases
            // When the line extends more to the X axis and
            // When the line extends more to the Y axis, respectively
            if (dx > dy)
            {
                for (int x = x1; x < x2; x++)
                {
                    int y = (int)Round((m * (double)x + b));

                    // Puts X and Y to the DataGrid
                    dataGridView.Rows.Add(new string[] { x.ToString(), y.ToString() });

                    DrawPixel(x, y, Color.Black);
                }
            }
            else
            {
                for (int y = y1; y < y2; y++)
                {
                    int x = (int)Round((y - b) / m);

                    // Puts X and Y to the DataGrid
                    dataGridView.Rows.Add(new string[] { x.ToString(), y.ToString() });

                    DrawPixel(x, y, Color.Black);
                }
            }

            // Puts x2 and y2 to the DataGrid
            dataGridView.Rows.Add(new string[] { x2.ToString(), y2.ToString() });

            // Draws the first and last pixels of the line
            DrawPixel(x1, y1, Color.Green);
            DrawPixel(x2, y2, Color.Red);
        }

        // DDA Algorithm
        private void ddaAlgorithm(int x1, int y1, int x2, int y2)
        {
            // Clears the plane
            ClearPlane();

            // Clears the dataGridView and refreshes it
            dataGridView.Rows.Clear();
            dataGridView.Refresh();

            double dy = y2 - y1; // Delta X
            double dx = x2 - x1; // Delta Y

            double step = (dy > dx) ? dy : dx;

            // Obtains the step size of each cordinate (X and Y)
            double stepX = dx / step;
            double stepY = dy / step;

            double x;
            double y;
            for (x = x1, y = y1;
                x < x2;
                x += stepX, y += stepY)
            {
                // Puts the X and Y cordinates in the DataGrid
                dataGridView.Rows.Add(new string[] { ((int)x).ToString(), ((int)Math.Round(y)).ToString() });

                DrawPixel((int)x, (int)Math.Round(y), Color.Black);
            }

            // Puts x2 and y2 in the DataGrid
            dataGridView.Rows.Add(new string[] { x2.ToString(), y2.ToString() });

            // Draws the first and last pixels of the line
            DrawPixel(x1, y1, Color.Green);
            DrawPixel(x2, y2, Color.Red);
        }

        // Bressenham Algorithm
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

        // Draws the plane axes int the canvas
        private void DrawAxes()
        {
            Pen mainAxesPen = new Pen(Color.Black); // Pen to draw the main two axes
            Pen subAxesPen = new Pen(Color.FromArgb(255, 190, 190, 190)); // Pen to draw the secondary axes
            Pen subSubAxesPen = new Pen(Color.FromArgb(255, 240, 240, 240)); // Pen to draw the little axes

            // Draw the little axes
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

            // Draw the secondary axes
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

            // Draw the main axes
            g.DrawLine(mainAxesPen, midWidth, 0, midWidth, height);   //y axis
            g.DrawLine(mainAxesPen, 0, midHeight, width, midHeight);  //x axis

            UpdateCanvas(); // Update the canvas
        }

        // Fills a pixel
        private void DrawPixel(int x, int y, Color color)
        {
            g = Graphics.FromImage(bmp);

            // Brush for painting pixels
            SolidBrush pixelBrush = new SolidBrush(color);

            // True X and Y axes of the plane, not of the canvas
            int xPlane = midWidth - offset;
            int yPlane = midHeight - offset;

            // Draw a pixel filling a rectangle with a SolidBrush
            g.FillRectangle(pixelBrush, xPlane + x * pixelSize + 1, yPlane - y * pixelSize + 1, pixelSize - 1, pixelSize - 1);

            UpdateCanvas(); // Updates the canvas
        }

        // Updates the canvas
        private void UpdateCanvas()
        {
            g.Dispose();
            canvasPictureBox.Image = bmp;
        }

        // Initializes a new image for the canvas
        private void InitializeCanvas()
        {
            offset = pixelSize / 2;

            // Get the middle points of the canvas
            midWidth = width / 2;
            midHeight = height / 2;

            // Create a new Bitmap Image with the current size of the canvas
            bmp = new Bitmap(width, height);
        }

        // Clears the plane
        private void ClearPlane()
        {
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            DrawAxes();
        }

        // Personal Round function
        private double Round(double number)
        {
            return Math.Round(number, 0, MidpointRounding.AwayFromZero);
        }
    }
}
