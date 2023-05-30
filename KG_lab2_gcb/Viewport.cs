using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KG_lab2_gcb
{
    class Viewport
    {
        public Color brush = Color.RoyalBlue;
        public Bitmap pic;
        public int height, width;
        public Camera cam;
        double del;
        public List<Vector> verts;
        public List<Triangle> polys;
        public Vector lightDir;
        double[,] Zbuffer;

        public Viewport(int aheight, int awidth)
        {
            height = aheight;
            width = awidth;
            pic = new Bitmap(width, height);
            verts = new List<Vector>();
            polys = new List<Triangle>();
        }
        public void addPartShar(double diam)
        {
            double r = diam / 2;
            int h = 1;
            List<List<Vector>> list_krug = new List<List<Vector>>();
            list_krug.Add(new List<Vector>());
            for (int i = 90; i < 270; i += h)
            {
                double rad = i * Math.PI / 180;
                list_krug[0].Add(new Vector(r * Math.Cos(rad), r * Math.Sin(rad), 0));
            }
            for (int i = 0; i < r; i += h)
            {
                double rad = 270 * Math.PI / 180;
                list_krug[0].Add(new Vector(r * Math.Cos(rad) - i, r * Math.Sin(rad), 0));
            }
            for (int i = 0; i < r; i += h)
            {
                double rad = 270 * Math.PI / 180;
                list_krug[0].Add(new Vector(r * Math.Cos(rad), r * Math.Sin(rad) - i, 0));
            }


            double r_new = r / Math.Sqrt(2);
            list_krug.Add(new List<Vector>());
            for (int i = 90; i < 270; i += h)
            {
                double rad = i * Math.PI / 180;
                list_krug[1].Add(new Vector(r_new * Math.Cos(rad), r_new * Math.Sin(rad), r / 2));
            }
            for (int i = 0; i < r_new; i += h)
            {
                double rad = 270 * Math.PI / 180;
                list_krug[1].Add(new Vector(r_new * Math.Cos(rad) - i, r_new * Math.Sin(rad), 0));
            }
            for (int i = 0; i < r_new; i += h)
            {
                double rad = 270 * Math.PI / 180;
                list_krug[1].Add(new Vector(r_new * Math.Cos(rad), r_new * Math.Sin(rad) - i, 0));
            }

            List<Vector> krug = new List<Vector>();
            List<Vector> krugUp = new List<Vector>();
            for (int curcle = 0; curcle < list_krug.Count - 1; curcle++)
            {
                krug = list_krug[curcle];
                krugUp = list_krug[curcle + 1];
                for (int i = 0; i < krugUp.Count - 1; i++) 
                {
                    polys.Add(new Triangle(krug[i], krug[i + 1], krugUp[i], brush));
                    polys.Add(new Triangle(krug[i + 1], krugUp[i + 1], krugUp[i], brush));
                }
                polys.Add(new Triangle(krug[krug.Count - 1], krug[0], krugUp[krugUp.Count - 1], brush));
                polys.Add(new Triangle(krug[0], krugUp[0], krugUp[krugUp.Count - 1], brush));

            }
            krugUp = list_krug[list_krug.Count - 1];
            verts.Add(new Vector(0, 0, r));
            for (int i = 0; i < krugUp.Count - 1; i++) polys.Add(new Triangle(krugUp[i], krugUp[i + 1], verts[0], brush)); 
            polys.Add(new Triangle(krugUp[krugUp.Count - 1], krugUp[0], verts[0], brush));                       

            for (int curcle = 0; curcle <= list_krug.Count - 1; curcle++)
            {
                verts.AddRange(list_krug[curcle]);
            }
        }

        public void addCamera(Camera acam)
        {
            cam = acam;
            del = 1 / Math.Tan(cam.angle / 2);
        }

        public Point convertToScreenPoint(Vector v)
        {
            Point result = new Point();
            result.X = (int)Math.Round(v.Vcam.getX() / v.Vcam.getZ() * del * (double)width / 2 + (double)width / 2);
            result.Y = (int)Math.Round(v.Vcam.getY() / v.Vcam.getZ() * del * (double)width / 2 + (double)height / 2);
            return result;
        }

        public bool CheckPoint(Point pnt, List<Point> pnts)
        {
            Vector v0, v1, v2;
            v0 = new Vector(pnt).minus(new Vector(pnts[0]));
            v1 = new Vector(pnts[1]).minus(new Vector(pnts[0]));
            v2 = new Vector(pnts[2]).minus(new Vector(pnts[0]));
            if (Math.Abs(v2.findAngle(v1) - v2.findAngle(v0) - v1.findAngle(v0)) > 1e-3)
                return false;

            v0 = new Vector(pnt).minus(new Vector(pnts[1]));
            v1 = new Vector(pnts[0]).minus(new Vector(pnts[1]));
            v2 = new Vector(pnts[2]).minus(new Vector(pnts[1]));
            if (Math.Abs(v2.findAngle(v1) - v2.findAngle(v0) - v1.findAngle(v0)) > 1e-3)
                return false;

            return true;
        }

        public Vector findVertex(Point pnt, Triangle poly)
        {
            Vector onScreen = new Vector((pnt.X - (double)width / 2) / (del * (double)width / 2), (pnt.Y - (double)height / 2) / (del * (double)width / 2), 1);
            Vector norm = poly.normalCam;
            double A = norm.X,
                B = norm.Y,
                C = norm.Z,
                D = -(A * poly.v0.Vcam.getX() + B * poly.v0.Vcam.getY() + C * poly.v0.Vcam.getZ());
            double t = -D / (A * onScreen.getX() + B * onScreen.getY() + C * onScreen.getZ());
            return onScreen.scale(t);
        }

        public Color colorWithLight(Triangle poly)
        {
            double R = 20, G = 20, B = 20;

            Vector norm = poly.normalCam;
            Vector ray = lightDir; //направление освещения
            if (ray.findAngle(norm) < Math.PI / 2)
            {
                double cos = Math.Pow(Math.Cos(ray.findAngle(norm)), 0.5);
                R = cos * poly.color.R;
                G = cos * poly.color.G;
                B = cos * poly.color.B;
            }
            return Color.FromArgb(Math.Min((int)R, 255), Math.Min((int)G, 255), Math.Min((int)B, 255));
        }

        public void DrawPolygon(Triangle poly)
        {
            List<Point> pnts = new List<Point>();
            pnts.Add(convertToScreenPoint(poly.v0));
            pnts.Add(convertToScreenPoint(poly.v1));
            pnts.Add(convertToScreenPoint(poly.v2));

            int minX, minY, maxX, maxY;
            minX = maxX = pnts[0].X;
            minY = maxY = pnts[0].Y;
            foreach (Point pnt in pnts)
            {
                minX = Math.Min(minX, pnt.X);
                maxX = Math.Max(maxX, pnt.X);
                minY = Math.Min(minY, pnt.Y);
                maxY = Math.Max(maxY, pnt.Y);
            }
            minX = Math.Max(minX, 0);
            minY = Math.Max(minY, 0);
            maxX = Math.Min(maxX, width - 1);
            maxY = Math.Min(maxY, height - 1);
            for (int X = minX; X <= maxX; X++)
                for (int Y = minY; Y <= maxY; Y++)
                {
                    Point curp = new Point(X, Y);
                    if (CheckPoint(curp, pnts))
                    {
                        Vector curV = findVertex(curp, poly);
                        if (curV.getZ() < Zbuffer[X, Y])
                        {
                            Zbuffer[X, Y] = curV.getZ();
                            pic.SetPixel(X, Y, colorWithLight(poly));
                        }
                    }
                }
        }

        public void Render()
        {
            if (cam != null)
            {
                foreach (Vector vr in verts)
                    vr.rotateForCam(cam);
                lightDir.rotateForCam(cam);
                Graphics gr = Graphics.FromImage(pic);
                gr.Clear(Color.White);
                Zbuffer = new double[width, height];
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                        Zbuffer[i, j] = 10000;

                foreach (Triangle pl in polys)
                    if (pl.v0.minus(cam.pos).findAngle(pl.normal) > Math.PI / 2) 
                        if (pl.v0.Vcam.getZ() > 0.2 && pl.v1.Vcam.getZ() > 0.2 && pl.v2.Vcam.getZ() > 0.2)
                            DrawPolygon(pl);
            }
        }
    }
}
