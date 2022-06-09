namespace ComputerGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lineDrawingButton_Click(object sender, EventArgs e)
        {
            LineDrawing lineDrawing = new LineDrawing();
            lineDrawing.ShowDialog();
        }

        private void polygonDrawingButton_Click(object sender, EventArgs e)
        {
            PolygonDrawing polygonDrawing = new PolygonDrawing();
            polygonDrawing.ShowDialog();
        }

        private void transformationsButton_Click(object sender, EventArgs e)
        {
            Transformations transformations = new Transformations();
            transformations.ShowDialog();
        }

        private void fractalsButton_Click(object sender, EventArgs e)
        {
            Fractals fractals = new Fractals();
            fractals.ShowDialog();
        }
    }
}