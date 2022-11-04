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
        PointF A = new PointF(50, 400);
        PointF B = new PointF(300, 50);
        PointF C = new PointF(0, 0);
        PointF D = new PointF(450,300);
        private void Form1_Load(object sender, EventArgs e)
        {
            demo = new Graph();
            demo.Load(@"..\..\demo.in");
            graphic = new Graphic();
            graphic.InitGraph(pictureBox1);
            graphic.ClearGraph();
            demo.Dispersion(new PointF(pictureBox1.Width / 2, pictureBox1.Height / 2), 150);
            demo.Draw(graphic);
            demo.NrI(graphic);
            //PointF S = myMath.Inters(A, B, C, D);
            //graphic.grp.DrawLine(Pens.Black, A, B);
            //graphic.grp.DrawLine(Pens.Black, C, D);
            //graphic.grp.DrawEllipse(Pens.Red, S.X - 5, S.Y - 5, 11, 11);
            graphic.RefreshGraph();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}