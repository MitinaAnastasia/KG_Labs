using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
    public class PointAtInfH3D : VectorH3D
    {
        public float Norm { get; }


        public PointAtInfH3D(float x, float y, float z) : base(x, y, z, 0f)
        {
            Norm = GetNorm();
        }


        private float GetNorm()
        {
            float sum = this * this;
            return (float) Math.Sqrt(sum);
        }

        public PointAtInfH3D GetUnit()
        {
            return new PointAtInfH3D(X / Norm, Y / Norm, Z / Norm);
        }


        public static float operator *(PointAtInfH3D left, PointAtInfH3D right)
        {
            return left.X * right.X + left.Y * right.Y + left.Z * right.Z;
        }

        public static PointAtInfH3D operator ^(PointAtInfH3D left, PointAtInfH3D right)
        {
            float x = left.Y * right.Z - left.Z * right.Y;
            float y = left.Z * right.X - left.X * right.Z;
            float z = left.X * right.Y - left.Y * right.X;
            return new PointAtInfH3D(x, y, z);
        }

    }
}
