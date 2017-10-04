using System.Collections.Generic;

namespace ImageCalculator.Service.Models
{
    public class VertexesResult
    {
        public List<Vertex> OddVertexes { get; private set; }
        public List<Vertex> EvenVertexes { get; private set; }

        public VertexesResult(List<Vertex> oddVertexes, List<Vertex> evenVertexes)
        {
            this.OddVertexes = oddVertexes;
            this.EvenVertexes = evenVertexes;
        }
    }
}

