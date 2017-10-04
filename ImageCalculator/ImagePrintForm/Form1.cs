using ImageCalculator.Service.Calculators;
using ImageCalculator.Service.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


namespace ImagePrintForm
{

    public partial class Form1 : Form
    {
        private System.Drawing.Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        Pen pen1 = new Pen(Color.Blue, 2);
        Pen pen2 = new Pen(Color.Red, 2);

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int startRow = 65; // 'A';

            DrawRow(new CalculatorA(), startRow);
            DrawRow(new CalculatorB(), startRow++);

            // 
            // TODO: The following are depricated. To replace with DrawRow method...
            //
            PrintRowC(startRow++);
            PrintRowD(startRow++);
            PrintRowE(startRow++);
            PrintRowF(startRow++);

            //var tw = TriangleWidth(50);
            //Debug.WriteLine("tw = {0}", tw);
        }
        
        // Depricated...
        public void PrintRowC(int startRow)
        {
            var vertexes = new List<Vertex>();

            // even colums
            int col = 1;
            while (col <= 6)
            {
                char rowName = (char)(startRow + col);

                // points represent V1, V2, and V3
                Point[] t0 = { new Point(0, 150), new Point(0, 100), new Point(50, 150) };
                vertexes.Add(new Vertex { Name = $"{rowName}{2}", Points = t0, Pen = pen1 });

                Point[] t2 = { new Point(50, 150), new Point(50, 100), new Point(100, 150) };
                vertexes.Add(new Vertex { Name = $"{rowName}{4}", Points = t2, Pen = pen1 });

                Point[] t4 = { new Point(100, 150), new Point(100, 100), new Point(150, 150) };
                vertexes.Add(new Vertex { Name = $"{rowName}{6}", Points = t4, Pen = pen1 });

                Point[] t6 = { new Point(150, 150), new Point(150, 100), new Point(200, 150) };
                vertexes.Add(new Vertex { Name = $"{rowName}{8}", Points = t6, Pen = pen1 });

                Point[] t8 = { new Point(200, 150), new Point(200, 100), new Point(250, 150) };
                vertexes.Add(new Vertex { Name = $"{rowName}{10}", Points = t8, Pen = pen1 });

                Point[] t10 = { new Point(250, 150), new Point(250, 100), new Point(300, 150) };
                vertexes.Add(new Vertex { Name = $"{rowName}{12}", Points = t10, Pen = pen1 });

                col++;
            }

            for (int r = 0; r < 6; r++)
            {
                g = pictureBox1.CreateGraphics();
                g.DrawPolygon(vertexes[r].Pen, vertexes[r].Points);
            }


            var vertexes2 = new List<Vertex>();
            col = 1;
            while (col <= 6)
            {
                var rowName = (char)(startRow + col);

                Point[] t1 = { new Point(50, 100), new Point(50, 150), new Point(0, 100) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{1}", Points = t1, Pen = pen2 });

                Point[] t3 = { new Point(100, 100), new Point(100, 150), new Point(50, 100) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{3}", Points = t3, Pen = pen2 });

                Point[] t5 = { new Point(150, 100), new Point(150, 150), new Point(100, 100) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{5}", Points = t5, Pen = pen2 });
                //
                Point[] t7 = { new Point(200, 100), new Point(200, 150), new Point(200, 100) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{7}", Points = t7, Pen = pen2 });

                Point[] t9 = { new Point(250, 100), new Point(250, 150), new Point(200, 100) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{9}", Points = t9, Pen = pen2 });

                Point[] t11 = { new Point(300, 100), new Point(300, 150), new Point(300, 100) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{11}", Points = t11, Pen = pen2 });

                col++;
            }

            for (int r = 0; r < 6; r++)
            {
                g = pictureBox1.CreateGraphics();
                g.DrawPolygon(vertexes2[r].Pen, vertexes2[r].Points);
            }
        }

        // Depricated...
        public void PrintRowD(int startRow)
        {
            var vertexes = new List<Vertex>();

            // even colums
            int col = 1;
            while (col <= 6)
            {
                char rowName = (char)(startRow + col);

                // points represent V1, V2, and V3
                Point[] t0 = { new Point(0, 200), new Point(0, 150), new Point(50, 200) };
                vertexes.Add(new Vertex { Name = $"{rowName}{2}", Points = t0, Pen = pen1 });

                Point[] t2 = { new Point(50, 200), new Point(50, 150), new Point(100, 200) };
                vertexes.Add(new Vertex { Name = $"{rowName}{4}", Points = t2, Pen = pen1 });

                Point[] t4 = { new Point(100, 200), new Point(100, 150), new Point(150, 200) };
                vertexes.Add(new Vertex { Name = $"{rowName}{6}", Points = t4, Pen = pen1 });


                Point[] t6 = { new Point(150, 200), new Point(150, 150), new Point(200, 200) };
                vertexes.Add(new Vertex { Name = $"{rowName}{8}", Points = t6, Pen = pen1 });

                Point[] t8 = { new Point(200, 200), new Point(200, 150), new Point(250, 200) };
                vertexes.Add(new Vertex { Name = $"{rowName}{10}", Points = t8, Pen = pen1 });

                Point[] t10 = { new Point(250, 200), new Point(250, 150), new Point(300, 200) };
                vertexes.Add(new Vertex { Name = $"{rowName}{12}", Points = t10, Pen = pen1 });

                col++;
            }

            for (int r = 0; r < 6; r++)
            {
                g = pictureBox1.CreateGraphics();
                g.DrawPolygon(vertexes[r].Pen, vertexes[r].Points);
            }


            var vertexes2 = new List<Vertex>();
            col = 1;
            while (col <= 6)
            {
                var rowName = (char)(startRow + col);

                Point[] t1 = { new Point(50, 150), new Point(50, 200), new Point(0, 150) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{1}", Points = t1, Pen = pen2 });

                Point[] t3 = { new Point(100, 150), new Point(100, 200), new Point(50, 150) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{3}", Points = t3, Pen = pen2 });

                Point[] t5 = { new Point(150, 150), new Point(150, 200), new Point(100, 150) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{5}", Points = t5, Pen = pen2 });

                //
                Point[] t7 = { new Point(200, 150), new Point(200, 200), new Point(150, 150) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{7}", Points = t7, Pen = pen2 });

                Point[] t9 = { new Point(250, 150), new Point(250, 200), new Point(200, 150) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{9}", Points = t9, Pen = pen2 });

                Point[] t11 = { new Point(300, 150), new Point(300, 200), new Point(250, 150) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{11}", Points = t11, Pen = pen2 });

                col++;
            }

            for (int r = 0; r < 6; r++)
            {
                g = pictureBox1.CreateGraphics();
                g.DrawPolygon(vertexes2[r].Pen, vertexes2[r].Points);
            }
        }

        // Depricated...
        public void PrintRowE(int startRow)
        {
            var vertexes = new List<Vertex>();

            // even colums
            int col = 1;
            while (col <= 6)
            {
                char rowName = (char)(startRow + col);

                // points represent V1, V2, and V3
                Point[] t0 = { new Point(0, 250), new Point(0, 200), new Point(50, 250) };
                vertexes.Add(new Vertex { Name = $"{rowName}{2}", Points = t0, Pen = pen1 });

                Point[] t2 = { new Point(50, 250), new Point(50, 200), new Point(100, 250) };
                vertexes.Add(new Vertex { Name = $"{rowName}{4}", Points = t2, Pen = pen1 });

                //
                Point[] t4 = { new Point(100, 250), new Point(100, 200), new Point(150, 250) };
                vertexes.Add(new Vertex { Name = $"{rowName}{6}", Points = t4, Pen = pen1 });

                Point[] t6 = { new Point(150, 250), new Point(150, 200), new Point(200, 250) };
                vertexes.Add(new Vertex { Name = $"{rowName}{8}", Points = t6, Pen = pen1 });

                Point[] t8 = { new Point(200, 250), new Point(200, 200), new Point(250, 250) };
                vertexes.Add(new Vertex { Name = $"{rowName}{10}", Points = t8, Pen = pen1 });

                Point[] t10 = { new Point(250, 250), new Point(250, 200), new Point(300, 250) };
                vertexes.Add(new Vertex { Name = $"{rowName}{12}", Points = t10, Pen = pen1 });

                col++;
            }

            for (int r = 0; r < 6; r++)
            {
                g = pictureBox1.CreateGraphics();
                g.DrawPolygon(vertexes[r].Pen, vertexes[r].Points);
            }


            var vertexes2 = new List<Vertex>();
            col = 1;
            while (col <= 6)
            {
                var rowName = (char)(startRow + col);

                Point[] t1 = { new Point(50, 200), new Point(50, 250), new Point(0, 200) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{1}", Points = t1, Pen = pen2 });

                Point[] t3 = { new Point(100, 200), new Point(100, 250), new Point(50, 200) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{3}", Points = t3, Pen = pen2 });

                Point[] t5 = { new Point(150, 200), new Point(150, 250), new Point(100, 200) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{5}", Points = t5, Pen = pen2 });
                //
                Point[] t7 = { new Point(200, 200), new Point(200, 250), new Point(150, 200) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{7}", Points = t7, Pen = pen2 });

                Point[] t9 = { new Point(250, 200), new Point(250, 250), new Point(200, 200) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{9}", Points = t9, Pen = pen2 });

                Point[] t11 = { new Point(300, 200), new Point(300, 250), new Point(250, 200) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{11}", Points = t11, Pen = pen2 });

                col++;
            }

            for (int r = 0; r < 6; r++)
            {
                g = pictureBox1.CreateGraphics();
                g.DrawPolygon(vertexes2[r].Pen, vertexes2[r].Points);
            }
        }

        // Depricated...
        public void PrintRowF(int startRow)
        {
            var vertexes = new List<Vertex>();

            // even colums
            int col = 1;
            while (col <= 6)
            {
                char rowName = (char)(startRow + col);

                // points represent V1, V2, and V3
                Point[] t0 = { new Point(0, 300), new Point(0, 250), new Point(50, 300) };
                vertexes.Add(new Vertex { Name = $"{rowName}{2}", Points = t0, Pen = pen1 });

                Point[] t2 = { new Point(50, 300), new Point(50, 250), new Point(100, 300) };
                vertexes.Add(new Vertex { Name = $"{rowName}{4}", Points = t2, Pen = pen1 });

                //
                Point[] t4 = { new Point(100, 300), new Point(100, 250), new Point(150, 300) };
                vertexes.Add(new Vertex { Name = $"{rowName}{6}", Points = t4, Pen = pen1 });

                Point[] t6 = { new Point(150, 300), new Point(150, 250), new Point(200, 300) };
                vertexes.Add(new Vertex { Name = $"{rowName}{8}", Points = t6, Pen = pen1 });

                Point[] t8 = { new Point(200, 300), new Point(200, 250), new Point(250, 300) };
                vertexes.Add(new Vertex { Name = $"{rowName}{10}", Points = t8, Pen = pen1 });

                Point[] t10 = { new Point(250, 300), new Point(250, 250), new Point(300, 300) };
                vertexes.Add(new Vertex { Name = $"{rowName}{12}", Points = t10, Pen = pen1 });

                col++;
            }

            for (int r = 0; r < 6; r++)
            {
                g = pictureBox1.CreateGraphics();
                g.DrawPolygon(vertexes[r].Pen, vertexes[r].Points);
            }


            var vertexes2 = new List<Vertex>();
            col = 1;
            while (col <= 6)
            {
                var rowName = (char)(startRow + col);

                Point[] t1 = { new Point(50, 250), new Point(50, 300), new Point(0, 250) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{1}", Points = t1, Pen = pen2 });

                Point[] t3 = { new Point(100, 250), new Point(100, 300), new Point(50, 250) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{3}", Points = t3, Pen = pen2 });

                Point[] t5 = { new Point(150, 250), new Point(150, 300), new Point(100, 250) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{5}", Points = t5, Pen = pen2 });
                //
                Point[] t7 = { new Point(200, 250), new Point(200, 300), new Point(150, 250) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{7}", Points = t7, Pen = pen2 });

                Point[] t9 = { new Point(250, 250), new Point(250, 300), new Point(200, 250) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{9}", Points = t9, Pen = pen2 });

                Point[] t11 = { new Point(300, 250), new Point(300, 300), new Point(250, 250) };
                vertexes2.Add(new Vertex { Name = $"{rowName}{11}", Points = t11, Pen = pen2 });

                col++;
            }

            for (int r = 0; r < 6; r++)
            {
                g = pictureBox1.CreateGraphics();
                g.DrawPolygon(vertexes2[r].Pen, vertexes2[r].Points);
            }
        }
    

        // Return the width of a triangle.
        private float TriangleWidth(float height)
        {
            return (float)(2 * height / Math.Sqrt(3));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var g = pictureBox1.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
        }

        private void DrawRow(ICalculator calc, int startRow)
        {
            if(calc == null) throw new ArgumentNullException();

            var results = calc.Draw(startRow);
            for (int r = 0; r < 6; r++)
            {
                g = pictureBox1.CreateGraphics();
                g.DrawPolygon(results.EvenVertexes[r].Pen, results.EvenVertexes[r].Points);

                g = pictureBox1.CreateGraphics();
                g.DrawPolygon(results.OddVertexes[r].Pen, results.OddVertexes[r].Points);
            }
        }
    }
}
