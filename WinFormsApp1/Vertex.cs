using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinFormsApp1
{
    
    public class Vertex
    {
        int idx;
        public PointF mapLocation;

        public Vertex(int idx, PointF mapLocation)
        {
            this.idx = idx; 
            this.mapLocation = mapLocation; 
        }
        public Vertex(int idx)
        {
            this.idx = idx;
            this.mapLocation = new PointF(0,0);
        }
        public void Draw(Graphic handler)
        {
            handler.grp.DrawEllipse(Pens.Red, mapLocation.X - 7, mapLocation.Y - 7, 15, 15);
        }

    }
}
