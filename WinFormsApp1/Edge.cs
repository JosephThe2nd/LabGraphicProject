using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinFormsApp1
{
    public class Edge
    {
        public int idxVertexStart;
        public int idxVertexEnd;

        public Edge(int idxVertexStart, int idxVertexEnd)
        {
            this.idxVertexStart = idxVertexStart;
            this.idxVertexEnd = idxVertexEnd;
        }
        public void Draw(Graphic handler, List<Vertex> v)
        {
            PointF start = v[idxVertexStart].mapLocation;
            PointF end = v[idxVertexEnd].mapLocation;
            handler.grp.DrawLine(Pens.Black, start, end);
        }
    }
}
