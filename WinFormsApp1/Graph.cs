using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace WinFormsApp1
{
    public class Graph
    {
        public List<Edge> edges;
        public List<Vertex> vertices;

        public Graph()
        {
            edges = new List<Edge>();
            vertices = new List<Vertex>();
        }

        public void Load(string fileName)
        {
            TextReader load = new StreamReader(fileName);
            int n = int.Parse(load.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Vertex localV = new Vertex(i+1);
                vertices.Add(localV);
            }
            string buffer;
            while((buffer = load.ReadLine()) != null)
            {
                string[] localS = buffer.Split(' ');
                Edge localE = new Edge(int.Parse(localS[0]), int.Parse(localS[1]));
                edges.Add(localE);
            }

        }
        public void Dispersion(PointF center,float radius)
        {
            float fi = (float)(Math.PI * 2) / vertices.Count;
            for(int i = 0; i < vertices.Count; i++)
            {
                float x = center.X + radius * (float)Math.Cos(i * fi);
                float y = center.Y + radius * (float)Math.Sin(i * fi);
                vertices[i].mapLocation = new PointF(x, y);
            }
        }
        public void NrI(Graphic handler)
        {
            int nr = 0;
            for(int i = 0; i< edges.Count - 1; i++)
                for(int j = i + 1; j< edges.Count; j++)
                {
                    PointF S = myMath.Inters(vertices[edges[i].idxVertexStart].mapLocation, vertices[edges[i].idxVertexEnd].mapLocation, vertices[edges[j].idxVertexStart].mapLocation, vertices[edges[j].idxVertexEnd].mapLocation);            
                        try
                        {
                            handler.grp.DrawEllipse(Pens.Red, S.X - 5, S.Y - 5, 11, 11); }
                        catch
                        { };
                }
        }
        public void Draw(Graphic handler)
        {
            foreach(Vertex vertex in vertices)
            {
                vertex.Draw(handler);

                
            }
            foreach(Edge edge in edges)
            {
                edge.Draw(handler, vertices);
            }
        }
    }
}
