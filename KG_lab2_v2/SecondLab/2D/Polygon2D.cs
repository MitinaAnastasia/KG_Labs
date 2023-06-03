using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
    public class Polygon2D
    {
        private readonly PointH2D[] points;

        public IEnumerable<PointH2D> Points => points;

        public float LightingLevel { get; }


        public Polygon2D(PointH2D[] points, float lightingLevel)
        {
            if (points.Length != 3)
            {
                throw new ArgumentException();
            }
            this.points = points;
            LightingLevel = lightingLevel;
        }

    }
}
