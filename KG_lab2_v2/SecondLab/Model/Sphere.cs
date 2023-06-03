using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
    public class Sphere : IPolyhedron
    {
        private readonly List<Polygon3D> polygons;

        public IEnumerable<Polygon3D> Polygons => polygons;


        public Sphere(IEnumerable<Polygon3D> polygons)
        {
            this.polygons = polygons.ToList();
        }

        //трансформация матрици в соответствии с растяжением по вводимому радиусу
        public IPolyhedron Transform(TransformationH3D transformation)
        {
            IEnumerable<Polygon3D> newPolygons = polygons.Select(p => transformation.Apply(p));
            return new Sphere(newPolygons);
        }
    }
}
