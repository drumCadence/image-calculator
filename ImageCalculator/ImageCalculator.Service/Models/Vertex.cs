using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageCalculator.Service.Models
{
    public class Vertex
    {
        public string Name { get; set; }
        public Point[] Points { get; set; }
        public Pen Pen { get; set; }
    }
}

