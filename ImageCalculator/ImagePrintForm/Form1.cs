using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImagePrintForm
{
    public class Vertex
    {
        public string Name { get; set; }
        public Point[] Points { get; set; }
        public Pen Pen { get; set; }
    }

    public partial class Form1 : Form
    {
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Blue, 2F);

        public Form1()
        {
            InitializeComponent();
        }

        private void OffsetPoint(PaintEventArgs e)
        {
            Point point1 = new Point(10, 10);
            point1.Offset(50, 0);
            Point point2 = new Point(250, 10);
            e.Graphics.DrawLine(Pens.Red, point1, point2);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Pen pen1 = new Pen(Color.Blue, 2);
            Pen pen2 = new Pen(Color.Red, 2);
            int startRow = 65;

            var evenDictRow = new Dictionary<string, List<Vertex>>();

            for (int row = 1; row <= 6; row++)
            {
                var vertexes = new List<Vertex>();

                // even colums
                int i = 0;
                while (i <= 6)
                {
                    char rowName = (char)(startRow + i);

                    // points represent V1, V2, and V3
                    Point[] t0 = { new Point(50, 0), new Point(50, 50), new Point(0, 0) };
                    vertexes.Add(new Vertex { Name = $"{rowName}{2}", Points = t0, Pen = pen1 });

                    Point[] t2 = { new Point(100, 0), new Point(100, 50), new Point(50, 0) };
                    vertexes.Add(new Vertex { Name = $"{rowName}{4}", Points = t2, Pen = pen1 });

                    Point[] t4 = { new Point(150, 0), new Point(150, 50), new Point(100, 0) };
                    vertexes.Add(new Vertex { Name = $"{rowName}{6}", Points = t4, Pen = pen1 });

                    Point[] t6 = { new Point(200, 0), new Point(200, 50), new Point(150, 0) };
                    vertexes.Add(new Vertex { Name = $"{rowName}{8}", Points = t6, Pen = pen1 });

                   
                    Point[] t8 = { new Point(250, 0), new Point(250, 50), new Point(200, 0) };
                    vertexes.Add(new Vertex { Name = $"{rowName}{10}", Points = t8, Pen = pen1 });

                    Point[] t10 = { new Point(300, 0), new Point(300, 50), new Point(250, 0) };
                    vertexes.Add(new Vertex { Name = $"{rowName}{12}", Points = t10, Pen = pen1 });
                    
                    i++;
                }

                for (int r = 0; r < 6; r++)
                {
                    g = pictureBox1.CreateGraphics();
                    g.DrawPolygon(vertexes[r].Pen, vertexes[r].Points);
                }


                var vertexes2 = new List<Vertex>();
                i = 0;
                while (i <= 6)
                {
                    var rowName = (char)(startRow + i);

                    Point[] t1 = { new Point(0, 50), new Point(0, 0), new Point(50, 50) };
                    vertexes2.Add(new Vertex { Name = $"{rowName}{1}", Points = t1, Pen = pen2 });

                    Point[] t3 = { new Point(50, 50), new Point(50, 0), new Point(100, 50) };
                    vertexes2.Add(new Vertex { Name = $"{rowName}{3}", Points = t3, Pen = pen2 });

                    Point[] t5 = { new Point(100, 50), new Point(100, 0), new Point(150, 50) };
                    vertexes2.Add(new Vertex { Name = $"{rowName}{5}", Points = t5, Pen = pen2 });

                    Point[] t7 = { new Point(150, 50), new Point(150, 0), new Point(200, 50) };
                    vertexes2.Add(new Vertex { Name = $"{rowName}{7}", Points = t7, Pen = pen2 });

                    Point[] t9 = { new Point(200, 50), new Point(200, 0), new Point(250, 50) };
                    vertexes2.Add(new Vertex { Name = $"{rowName}{9}", Points = t9, Pen = pen2 });

                    Point[] t11 = { new Point(250, 50), new Point(250, 0), new Point(300, 50) };
                    vertexes2.Add(new Vertex { Name = $"{rowName}{11}", Points = t11, Pen = pen2 });

                    i++;
                }

                for (int r = 0; r < 6; r++)
                {
                    g = pictureBox1.CreateGraphics();
                    g.DrawPolygon(vertexes2[r].Pen, vertexes2[r].Points);
                }
            }

        }

        //private void butClear_Click(object sender, EventArgs e)
        //{
        //    pictureBox1.Refresh();
        //}

        //private void Draw()
        //{
        //    Graphics l = new Graphics();
        //    Pen p = new Pen(Color.Red, 5);
        //    Point[] a = {
        //        new Point(10, 10),
        //        new Point(20, 20),
        //        new Point(30, 30),
        //    };
        //    l.DrawPolygon(p, a);
        //    l.Dispose();
        //}
    }
}
