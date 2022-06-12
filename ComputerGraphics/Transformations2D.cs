using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace ComputerGraphics
{
    public partial class Transformations2D : Form
    {
        Bitmap bmp;
        Graphics g;

        int width, height; // Size of the canvas
        int midWidth, midHeight; // Middle point of the canvas

        int pixelSize = 10; // Size of each pixel in the plane

        Dictionary<String, Point> points;
        List<Tuple<String, String>> paths;

        public Transformations2D()
        {
            // Set the initial size of the canvas
            width = 750;
            height = 750;

            // IDK what does this method do
            InitializeComponent();
            
            // Create a new image for the canvas
            InitializeCanvas();

            // Refresh completely the canvas to create the initial plane
            ClearPlane();
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
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\Anton\Documents",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ReadFile(openFileDialog1.FileName);
                Plot();
            }
        }

        private void ReadFile(String path)
        {
            pointsDataGrid.Rows.Clear();
            pointsDataGrid.Refresh();

            pathsDataGrid.Rows.Clear();
            pathsDataGrid.Refresh();

            points = new Dictionary<string, Point>();
            paths = new List<Tuple<String, String>>();

            var reader = new StreamReader(File.OpenRead(path));

            Regex pointRegex = new Regex("[A-Z]+(\\s*,\\s*)\\-?\\d+\\1\\-?\\d+");
            Regex lineRegex = new Regex("[A-Z]+\\s*,\\s*[A-Z]");

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(",", StringSplitOptions.TrimEntries);

                if (pointRegex.IsMatch(line))
                {
                    int x = Int32.Parse(values[1]);
                    int y = Int32.Parse(values[2]);

                    // True X and Y axes of the plane, not of the canvas
                    int xPlane = midWidth + x * pixelSize - pixelSize / 2;
                    int yPlane = midHeight - y * pixelSize - pixelSize / 2;

                    points.Add(values[0], new Point(xPlane, yPlane));

                    pointsDataGrid.Rows.Add(new string[] { values[0], values[1], values[2] });
                }
                else if (lineRegex.IsMatch(line))
                {
                    paths.Add(Tuple.Create(values[0], values[1]));
                    pathsDataGrid.Rows.Add(new string[] { values[0], values[1] });
                }
            }
        }

        public void Plot()
        {
            foreach (var path in paths)
            {
                DrawLine(path.Item1, path.Item2, Color.MediumBlue);
            }
            foreach (var point in points)
                //Console.WriteLine(lbls[i] + "," + Pts[i].X.ToString() + ", " + Pts[i].Y.ToString());
                DrawPixel(point.Value.X, point.Value.Y, Color.Blue, point.Key);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }



        // Draws the plane axes int the canvas
        private void DrawAxes()
        {
            Pen mainAxesPen = new Pen(Color.Black); // Pen to draw the main two axes
            Pen subAxesPen = new Pen(Color.FromArgb(255, 190, 190, 190)); // Pen to draw the secondary axes
            Pen subSubAxesPen = new Pen(Color.FromArgb(255, 240, 240, 240)); // Pen to draw the little axes

            // Draw the little axes
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

            // Draw the secondary axes
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

            // Draw the main axes
            g.DrawLine(mainAxesPen, midWidth, 0, midWidth, height);   //y axis
            g.DrawLine(mainAxesPen, 0, midHeight, width, midHeight);  //x axis

            UpdateCanvas(); // Update the canvas
        }

        // Fills a pixel
        private void DrawPixel(int x, int y, Color color, String label)
        {
            g = Graphics.FromImage(bmp);

            float stringSize = pixelSize / 1.2f;
            Font font = new Font("Arial", Pixel2Em(stringSize));

            // Brush for painting pixels
            SolidBrush pixelBrush = new SolidBrush(color);
            SolidBrush stringBrush = new SolidBrush(Color.Black);

            // Draw a pixel filling a ellipse with a SolidBrush
            g.FillEllipse(pixelBrush, x, y, pixelSize - 1, pixelSize - 1);
            g.DrawString(label, font, stringBrush, x, y);

            UpdateCanvas(); // Updates the canvas
        }

        private void DrawLine(String A, String B, Color color)
        {
            g = Graphics.FromImage(bmp);

            // Brush for painting pixels
            Pen linePen = new Pen(color, 5);

            // Obtains the center of the point
            int AX = points[A].X + pixelSize / 2,
                AY = points[A].Y + pixelSize / 2;
            int BX = points[B].X + pixelSize / 2,
                BY = points[B].Y + pixelSize / 2;

            g.DrawLine(linePen, AX, AY, BX, BY);

            UpdateCanvas(); // Updates the canvas
        }

        private float Pixel2Em(float pixel)
        {
            return pixel * 10.0f / 16.0f;
        }

        // Updates the canvas
        private void UpdateCanvas()
        {
            g.Dispose();
            canvasPictureBox.Image = bmp;
        }

        private void Transformations2D_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(scaleRadioButton.Checked)
            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);

            } else if(moveRadioButton.Checked)
            {

            } else if (rotateRadioButton.Checked)
            {

            }
            
        }

        // Initializes a new image for the canvas
        private void InitializeCanvas()
        {
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
    }
}
