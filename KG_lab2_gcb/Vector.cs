using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KG_lab2_gcb
{
    class Vector
    {
        public double X, Y, Z;
        public double W;
        public Vector Vcam;

        public Vector(double aX, double aY, double aZ, double aW = 1)
        {
            X = aX;
            Y = aY;
            Z = aZ;
            W = aW;
            Vcam = null;
        }

        public Vector(String str)
        {
            string[] coords = str.Split(' ');
            X = Double.Parse(coords[0]);
            Y = Double.Parse(coords[1]);
            Z = Double.Parse(coords[2]);
            W = 1;
            Vcam = null;
        }

        public Vector(Point pnt)
        {
            X = pnt.X;
            Y = pnt.Y;
            Z = 0;
            W = 1;
            Vcam = null;
        }

        public double getX()
        {
            return X / W;
        }

        public double getY()
        {
            return Y / W;
        }

        public double getZ()
        {
            return Z / W;
        }

        public double getW()
        {
            return W;
        }

        public double length
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y + Z * Z);
            }
        }

        public void Normalize()
        {
            double len = length;
            X /= len;
            Y /= len;
            Z /= len;
        }

        public Vector getVectorMult(Vector src)
        {
            double ax, ay, az;
            ax = getY() * src.getZ() - getZ() * src.getY();
            ay = getZ() * src.getX() - getX() * src.getZ();
            az = getX() * src.getY() - getY() * src.getX();
            return new Vector(ax, ay, az);
        }

        public Vector applyMatrix(Matrix matr)
        {
            Vector result = new Vector(0, 0, 0, 0);
            double[] input = { X, Y, Z, W };
            for (int i = 0; i < 4; i++)
            {
                result.X += input[i] * matr.fields[i, 0];
                result.Y += input[i] * matr.fields[i, 1];
                result.Z += input[i] * matr.fields[i, 2];
                result.W += input[i] * matr.fields[i, 3];
            }
            return result;
        }

        public double findAngle(Vector src)
        {
            if (length == 0 || src.length == 0)
                return 0;
            double cos = (getX() * src.getX() + getY() * src.getY() + getZ() * src.getZ()) / (length * src.length);
            return Math.Acos(cos);
        }

        public void rotateForCam(Camera cam)
        {
            Vcam = applyMatrix(cam.toRotate);
        }

        public static Vector operator *(double scalar, Vector vector)
        {
            double x = scalar * vector.X;
            double y = scalar * vector.Y;
            double z = scalar * vector.Z;

            return new Vector(x, y, z);
        }

        public static Vector operator *(Vector vector, double scalar)
        {
            return scalar * vector;
        }

        public static Vector operator -(Vector vector1, Vector vector2)
        {
            double x = vector1.X - vector2.X;
            double y = vector1.Y - vector2.Y;
            double z = vector1.Z - vector2.Z;

            return new Vector(x, y, z);
        }

        public Vector minus(Vector src)
        {
            return new Vector(getX() - src.getX(), getY() - src.getY(), getZ() - src.getZ());
        }

        public Vector plus(Vector src)
        {
            return new Vector(getX() + src.getX(), getY() + src.getY(), getZ() + src.getZ());
        }

        public Vector scale(double mnozh)
        {
            return new Vector(getX() * mnozh, getY() * mnozh, getZ() * mnozh);
        }
    }
}
