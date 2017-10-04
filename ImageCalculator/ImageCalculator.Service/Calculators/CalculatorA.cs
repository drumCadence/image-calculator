using ImageCalculator.Service.Models;
using System.Collections.Generic;
using System.Drawing;

namespace ImageCalculator.Service.Calculators
{
    public class CalculatorA : CalculatorBase, ICalculator
    {
        // 
        // TODO: REFACTOR TO USE DYNAMIC/CALCULATED POINTS.
        //
        public VertexesResult Draw(int startRow)
        {
            // even colums
            var evenVertexes = new List<Vertex>();
            int col = 1;
            while (col <= 6)
            {
                char rowName = (char)(startRow + col);

                // points represent V1, V2, and V3
                Point[] t0 = { new Point(50 * col, 0), new Point(50 * col, 50), new Point(0 * col, 0) };
                evenVertexes.Add(new Vertex { Name = $"{rowName}{2}", Points = t0, Pen = pen1 });

                Point[] t2 = { new Point(100 * col, 0), new Point(100 * col, 50), new Point(50 * col, 0) };
                evenVertexes.Add(new Vertex { Name = $"{rowName}{4}", Points = t2, Pen = pen1 });

                Point[] t4 = { new Point(150 * col, 0), new Point(150 * col, 50), new Point(100 * col, 0) };
                evenVertexes.Add(new Vertex { Name = $"{rowName}{6}", Points = t4, Pen = pen1 });

                Point[] t6 = { new Point(200 * col, 0), new Point(200 * col, 50), new Point(150 * col, 0) };
                evenVertexes.Add(new Vertex { Name = $"{rowName}{8}", Points = t6, Pen = pen1 });

                Point[] t8 = { new Point(250 * col, 0), new Point(250 * col, 50), new Point(200 * col, 0) };
                evenVertexes.Add(new Vertex { Name = $"{rowName}{10}", Points = t8, Pen = pen1 });

                Point[] t10 = { new Point(300 * col, 0), new Point(300 * col, 50), new Point(250 * col, 0) };
                evenVertexes.Add(new Vertex { Name = $"{rowName}{12}", Points = t10, Pen = pen1 });

                col++;
            }


            var oddVertexes = new List<Vertex>();
            col = 1;
            while (col <= 6)
            {
                var rowName = (char)(startRow + col);

                Point[] t1 = { new Point(0, 50), new Point(0, 0), new Point(50, 50) };
                oddVertexes.Add(new Vertex { Name = $"{rowName}{1}", Points = t1, Pen = pen2 });

                Point[] t3 = { new Point(50, 50), new Point(50, 0), new Point(100, 50) };
                oddVertexes.Add(new Vertex { Name = $"{rowName}{3}", Points = t3, Pen = pen2 });

                Point[] t5 = { new Point(100, 50), new Point(100, 0), new Point(150, 50) };
                oddVertexes.Add(new Vertex { Name = $"{rowName}{5}", Points = t5, Pen = pen2 });

                Point[] t7 = { new Point(150, 50), new Point(150, 0), new Point(200, 50) };
                oddVertexes.Add(new Vertex { Name = $"{rowName}{7}", Points = t7, Pen = pen2 });

                Point[] t9 = { new Point(200, 50), new Point(200, 0), new Point(250, 50) };
                oddVertexes.Add(new Vertex { Name = $"{rowName}{9}", Points = t9, Pen = pen2 });

                Point[] t11 = { new Point(250, 50), new Point(250, 0), new Point(300, 50) };
                oddVertexes.Add(new Vertex { Name = $"{rowName}{11}", Points = t11, Pen = pen2 });

                col++;
            }

            // Populate results and return.

            return new VertexesResult(evenVertexes, oddVertexes);
        }
    }
}
