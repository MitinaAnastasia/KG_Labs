using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SecondLab._3D
{
    public enum Axis
    {
        X, Y, Z
    }
    static class VectorMath
    {
        public static float Cross(Vector3 v1, Vector3 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }
        public static PointH3D Transform(this PointH3D Vector3D, Matrix4x4 matrix4X4)
        {
            var v = new Vector4(Vector3D.X, Vector3D.Y, Vector3D.Z, 1);
            var newVector = Vector4.Transform(v, matrix4X4);
            return new PointH3D(newVector.X / newVector.W, newVector.Y / newVector.W, newVector.Z / newVector.W);
        }
    }
}
