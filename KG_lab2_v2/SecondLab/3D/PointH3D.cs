using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SecondLab
{
    public class PointH3D : VectorH3D
    {
        public PointH3D(float x, float y, float z) : base(x, y, z, 1f) 
        {

        }


        public static PointAtInfH3D operator -(PointH3D left, PointH3D right)
        {
            return new PointAtInfH3D(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
        }

        // Преобразует вектор по заданной матрице 4х4.
        public static PointH3D Transform(PointH3D position, Matrix4x4 matrix)
        {
            return new PointH3D((matrix.M11 * position.X + matrix.M21 * position.Y + matrix.M31 * position.Z + matrix.M41 * 1),
                (matrix.M12 * position.X + matrix.M22 * position.Y + matrix.M32 * position.Z + matrix.M42 * 1),
                (matrix.M13 * position.X + matrix.M23 * position.Y + matrix.M33 * position.Z + matrix.M43 * 1));
        }
    }
}
