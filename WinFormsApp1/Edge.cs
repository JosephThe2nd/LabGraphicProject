using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Edge
    {
        int idxVertexStart;
        int idxVertexEnd;

        public Edge(int idxVertexStart, int idxVertexEnd)
        {
            this.idxVertexStart = idxVertexStart;
            this.idxVertexEnd = idxVertexEnd;
        }
    }
}
