using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SecondLab
{
    public class World
    {
        private ISphereBuilder SpherePolygonsBuilder = new SphereBuilder(180);

        private Sphere SphereModel;

        public IPointCamera PointCamera { get; private set; }

        public IPolyhedron Polyhedron { get; private set; }

        public ILighting Lighting { get; private set; }

        public World()
        {
            SphereModel = SpherePolygonsBuilder.Build();
            Polyhedron = SphereModel;
            PointCamera = null;
            Lighting = null;
        }

        public void SetAngilShpere(int angle)
        {
            SphereModel = SpherePolygonsBuilder.Build(angle);
        }

        public void SetPointCamera(Vector3 center, float screenDist, float observeRange, int screenWidth, int screenHeight)
        {
            PointCamera = new PerspectiveProjectionCamera(
                center,
                screenDist,
                observeRange,
                screenWidth,
                screenHeight);
        }

        public void SetLighting(float x, float y, float z)
        {
            PointAtInfH3D direction = new PointAtInfH3D(x, y, z);
            Lighting = new SingleInfiniteLighting(direction);
        }

        public void TransformPolyhedron(float height, float baseRadius)
        {
            TransformationH3D scaling = TransformationH3D.CreateScaling(baseRadius, height, baseRadius);
            Polyhedron = SphereModel.Transform(scaling);

        }

        public IEnumerable<Polygon2D> GetCameraProjection()
        {
            return PointCamera.GetProjection(Polyhedron, Lighting);
        }

    }
}
