namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graph demo;
        Graphic graphic;
        private void Form1_Load(object sender, EventArgs e)
        {
            demo = new Graph();
            demo.Load(@"..\..\demo.in");
            graphic = new Graphic();
            graphic.InitGraph(pictureBox1);
            graphic.ClearGraph();
            demo.Dispersion(new PointF(pictureBox1.Width / 2, pictureBox1.Height / 2), 150);
            demo.Draw(graphic);
            graphic.RefreshGraph();
        }
    }
}