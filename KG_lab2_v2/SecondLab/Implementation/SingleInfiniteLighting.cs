using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
    public class SingleInfiniteLighting : ILighting 
    {
        public PointAtInfH3D Direction { get; } 


        public SingleInfiniteLighting(PointAtInfH3D direction)
        {
            Direction = direction.GetUnit();
        }


        public float GetLevel(Polygon3D polygon)
        {
            float product = Direction * polygon.Normal;
            return (float) Math.Max(-product, 0.0);
        }

    }
}
