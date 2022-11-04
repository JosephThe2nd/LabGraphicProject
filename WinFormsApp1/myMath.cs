using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public static class myMath
    {
        public static PointF Inters(PointF A, PointF B, PointF C, PointF D )
        {
            
            float a = B.X - A.X;
            float b = B.Y - A.Y;
            float c = D.X - C.X;
            float d = D.Y - C.Y;
            float t1 = b * A.X - a * A.Y;
            float t2 = d * C.X - c * C.Y;
            float ds = a * d - b * c;
            float dx = a * t2 - c * t1;
            float dy = b * t2 - d * t1;
            float x = dx / ds;
            float y = dy / ds;
            if (ds == 0) return PointF.Empty;
            else return new PointF(dx / ds, dy / ds);

        }
    }
}
