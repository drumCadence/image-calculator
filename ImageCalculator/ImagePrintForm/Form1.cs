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

            int i = 0;
            while (i <= 6)
            {
                Point[] t0 = {
                            new Point(0, 0),
                            new Point(50, 0),
                            new Point(50, 50),
                        };
                g = pictureBox1.CreateGraphics();
                g.DrawPolygon(pen1, t0);

                Point[] t2 = {
                            new Point(50, 0),
                            new Point(100, 0),
                            new Point(100, 50),
                        };
                g = pictureBox1.CreateGraphics();
                g.DrawPolygon(pen1, t2);

                Point[] t4 = {
                            new Point(100, 0),
                            new Point(150, 0),
                            new Point(150, 50),
                        };
                g = pictureBox1.CreateGraphics();
                g.DrawPolygon(pen1, t4);

                Point[] t6 = {
                            new Point(150, 0),
                            new Point(200, 0),
                            new Point(200, 50),
                        };
                g = pictureBox1.CreateGraphics();
                g.DrawPolygon(pen1, t6);

                Point[] t8 = {
                            new Point(200, 0),
                            new Point(250, 0),
                            new Point(250, 50),
                        };
                g = pictureBox1.CreateGraphics();
                g.DrawPolygon(pen1, t8);

                Point[] t11 = {
                            new Point(250, 0),
                            new Point(300, 0),
                            new Point(300, 50),
                        };
                g = pictureBox1.CreateGraphics();
                g.DrawPolygon(pen1, t11);

                i++;
            }

            int j = 0;
            while (j <= 6)
            {
                Point[] t1 = {
                            new Point(0, 50),
                            new Point(0, 0),
                            new Point(50, 50),
                        };
                g = pictureBox1.CreateGraphics();
                g.DrawPolygon(pen2, t1);

                Point[] t3 = {
                            new Point(50, 50),
                            new Point(50, 0),
                            new Point(100, 50),
                        };
                g = pictureBox1.CreateGraphics();
                g.DrawPolygon(pen2, t3);

                Point[] t5 = {
                            new Point(100, 50),
                            new Point(100, 0),
                            new Point(150, 50),
                        };
                g = pictureBox1.CreateGraphics();
                g.DrawPolygon(pen2, t5);

                Point[] t7 = {
                            new Point(150, 50),
                            new Point(150, 0),
                            new Point(200, 50),
                        };
                g = pictureBox1.CreateGraphics();
                g.DrawPolygon(pen2, t7);

                Point[] t9 = {
                            new Point(200, 50),
                            new Point(200, 0),
                            new Point(250, 50),
                        };
                g = pictureBox1.CreateGraphics();
                g.DrawPolygon(pen2, t9);

                Point[] t11 = {
                            new Point(250, 50),
                            new Point(250, 0),
                            new Point(300, 50),
                        };
                g = pictureBox1.CreateGraphics();
                g.DrawPolygon(pen2, t11);

                j++;
            }


        }

        private void butClear_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

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
