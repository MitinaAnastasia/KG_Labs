using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
    public class PointH2D : VectorH2D
    {
        public PointH2D(float x, float y) : base(x, y, 1f)
        {

        }

        public static PointAtInfH2D operator +(PointH2D left, PointH2D right)
        {
            return new PointAtInfH2D(left.X + right.X, left.Y + right.Y);
        }

    }
}
