using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace ImageCalculator.Printer
{
    public class Vertex
    {
        public string Name { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }


    }

    class Program
    {
        static void Main(string[] args)
        {
            //var V = new List<int[]>(new int[] { 0, 5 }, new int[] { 0, 6 }, new int[] { 1, 5 );             

            //char c = (char)(65);
            var oddDictRow = new Dictionary<string, List<Vertex>>();
            //var oddDictRow = new List<Vertex>();

            for (var t = 0; t < 6; t++)
            {
                //if (t % 2 == 0) // get odds F1, F3, ...
                //{
                    var oddVs = new List<Vertex>();
                // F1
                //V1, 0,0
                //V2, 0,1
                //V3, 1,0

                // F3
                //V1, 1,0
                //V2, 1,1
                //V3, 2,0

                // F5
                //V1, 2,0
                //V2, 2,1
                //V3, 3,0

                var vertexes = new List<Vertex>
                    {
                        new Vertex { Name = $"V{1}", XCoordinate = t, YCoordinate = (t==0) ? t : t-1 },
                        new Vertex { Name = $"V{2}", XCoordinate = t, YCoordinate = (t==0) ? t+1 : t },
                        new Vertex { Name = $"V{3}", XCoordinate = t+1, YCoordinate = (t==0) ? t : t-1 }
                    };
                    foreach (var v in vertexes)
                    {
                        Debug.WriteLine(v.Name + ", " + v.XCoordinate + "," + v.YCoordinate);
                    }

                    //for (int i = 0; i < 2; i++)
                    //{
                    //    oddVs.Add(new Vertex { Name = $"V{i + 1}", XCoordinate = i, YCoordinate = i });
                    //    Debug.WriteLine(oddVs[i].Name + ", " + oddVs[i].XCoordinate + "," + oddVs[i].YCoordinate);
                    //}
                //}
            }
            

            //switch (i+1)
            //{
            //    case 1:
            //        oddVs.Add(new Vertex { Name = $"V{i+1}", XCoordinate = i+t, YCoordinate = i+t });
            //        Debug.WriteLine(oddVs[0].Name + ", " + oddVs[0].XCoordinate + "," + oddVs[0].YCoordinate);
            //        break;
            //    case 2:
            //        oddVs.Add(new Vertex { Name = $"V{i+1}", XCoordinate = i-1, YCoordinate = i });
            //        Debug.WriteLine(oddVs[1].Name + ", " + oddVs[1].XCoordinate + "," + oddVs[1].YCoordinate);
            //        break;
            //      case 3:
            //        oddVs.Add(new Vertex { Name = $"V{i+1}", XCoordinate = i-1 , YCoordinate = i-2 });
            //          Debug.WriteLine(oddVs[2].Name + ", " + oddVs[2].XCoordinate + "," + oddVs[2].YCoordinate);
            //          break;
            //}

            //foreach (var vertex in vertexes)
            //{
            //    Debug.WriteLine(vertex.Name + ", " + vertex.XCoordinate + "," + vertex.YCoordinate);
            //}


            //var vertexes = new List<Vertex>
            //{
            //    new Vertex { Name = $"V{i+1}", XCoordinate = i, YCoordinate = i },
            //    new Vertex { Name = $"V{i+2}", XCoordinate = i, YCoordinate = i+1 },
            //    new Vertex { Name = $"V{i+3}", XCoordinate = i+1, YCoordinate = i }
            //};

            //oddDictRow.Add($"F{i + v}", vertexes);

            //for (int x = 1; x <= 6; x++)
            //{
            //    var triName = $"F{x}";
            //    Debug.WriteLine(triName);
            //}



        }


    }
}

