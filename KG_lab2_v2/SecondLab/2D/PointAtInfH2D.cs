using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
    public class PointAtInfH2D : VectorH2D
    {
        public float Norm { get; }


        public PointAtInfH2D(float x, float y) : base(x, y, 0f)
        {
            Norm = GetNorm();
        }


        private float GetNorm()
        {
            float sum = this * this;
            return (float) Math.Sqrt(sum);
        }

        public static float operator *(PointAtInfH2D left, PointAtInfH2D right)
        {
            return left.X * right.X + left.Y * right.Y;
        }

    }
}
