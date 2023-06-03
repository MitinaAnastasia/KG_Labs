using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
    public class Polygon3D
    {
        public readonly PointH3D[] points;

        public IEnumerable<PointH3D> Points => points;

        public PointAtInfH3D Normal { get; }


        public Polygon3D(PointH3D[] points)
        {
            if (points.Length != 3)
            {
                throw new ArgumentException();
            }
            this.points = points;
            Normal = GetNormal();
        }

        public Polygon3D(PointH3D first, PointH3D second, PointH3D third) 
            : this(new PointH3D[] { first, second, third })
        {

        }


        private PointAtInfH3D GetNormal()
        {
            PointAtInfH3D a = points[2] - points[0];
            PointAtInfH3D b = points[1] - points[0];
            PointAtInfH3D normal = a ^ b;
            return normal.GetUnit();
        }

    }
}
