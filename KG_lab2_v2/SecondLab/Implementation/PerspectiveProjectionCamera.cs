using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using SecondLab._3D;

namespace SecondLab
{
    public class PerspectiveProjectionCamera : IPointCamera
    {
        public int ScreenWidth { get; set; }

        public int ScreenHeight { get; set; }
        //локальные координаты камеры
        public Basis Basis { get; private set; }
        //расстояние до проекционной плоскости
        public float ScreenDist { get; private set; }

        public float ObserveRange { get; private set; }

        //размеры сферы отностельно камеры (коэффициент растяжения)
        public float Scale => ScreenWidth / (float)(2 * ScreenDist * Math.Tan(ObserveRange / 2));

        public PerspectiveProjectionCamera(Vector3 center, float screenDist, float observeRange, int screenWidth, int screenHeight)
        {
            Basis = Basis.BaseBasis(center);
            ScreenDist = screenDist;
            ObserveRange = observeRange;
            ScreenWidth = screenWidth;
            ScreenHeight = screenHeight;
        }
        public void Move(Vector3 v)
        {
            Basis.Move(v);
        }

        public PointH2D ScreenProection(Vector3 v)
        {
            var local = Basis.ToLocalCoords(v);
            if (local.Z > ScreenDist)
            {
                return new PointH2D(float.NaN, float.NaN);
            }
            //через подобные треугольники находим проекцию и умножаем ее на коэффициент растяжения
            var delta = ScreenDist / local.Z * Scale;
            var proection = new PointH2D(local.X * delta, local.Y * delta);
            //этот код нужен для перевода проекции в экранные координаты
            var screen = proection + new PointH2D(-ScreenWidth / 2, -ScreenHeight / 2);
            var screenCoords = new PointH2D(-screen.X, -screen.Y);
            //если точка принадлежит экранной области - вернем ее
            if (screenCoords.X >= 0 && screenCoords.X < ScreenWidth && screenCoords.Y >= 0 && screenCoords.Y < ScreenHeight)
            {
                return screenCoords;
            }
            return new PointH2D(float.NaN, float.NaN);
        }

        public IEnumerable<Polygon2D> GetProjection(IPolyhedron polyhedron, ILighting lighting)
        {
            List<Polygon2D> polygons2D = new List<Polygon2D>();
            foreach (Polygon3D polygon3D in polyhedron.Polygons)
            {
                PointH3D[] points3D = polygon3D.Points.ToArray();
                PointH2D[] points2D = new PointH2D[3];
                bool flag = true;
                for (int i = 0; i < points2D.Length; i++)
                {
                    points2D[i] = ScreenProection(new Vector3(points3D[i].X, points3D[i].Y, points3D[i].Z));
                    if (float.IsNaN(points2D[i].X) || float.IsNaN(points2D[i].Y))
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    float lightingLevel = lighting.GetLevel(polygon3D);
                    Polygon2D polygon2D = new Polygon2D(points2D, lightingLevel);
                    polygons2D.Add(polygon2D);
                }
            }
            return polygons2D;
        }
    }
}
