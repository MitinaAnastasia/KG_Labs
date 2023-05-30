using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KG_lab2_gcb
{
    class Camera
    {
        Vector fpos;
        Vector fdirection;
        double fangle;
        public Matrix toRotate;

        public Camera(Vector _pos, Vector _direction, double _angle)
        {
            fpos = _pos;
            fdirection = _direction;
            if (direction.length == 0)
            {
                direction.applyMatrix(Matrix.getShiftMatr(0, 0, 1));
            }
            fangle = _angle * Math.PI / 180; 
            calcMatrixToRotate();
        }

        public double angle
        {
            get { return fangle; }
        }

        public Vector pos
        {
            get { return fpos; }
        }

        public Vector direction
        {
            get { return fdirection; }
        }

        void calcMatrixToRotate() //ось Z в направлении камеры
        {
            Matrix shift = Matrix.getShiftMatr(-pos.getX(), -pos.getY(), -pos.getZ()); //перенос в точку камеры
            Vector proj = new Vector(direction.getX(), direction.getY(), 0); 
            double ang = proj.findAngle(new Vector(0, 1, 0)); 
            if (proj.getX() < 0)
                ang = -ang;
            Matrix rotZ = Matrix.getRorateZMatr(ang);
            Matrix rotX = Matrix.getRorateXMatr(direction.findAngle(new Vector(0, 0, 1))); 
            toRotate = shift.mulMatrs(rotZ.mulMatrs(rotX));
        }
    }
}
