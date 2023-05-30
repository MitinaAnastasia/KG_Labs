using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KG_lab2_gcb
{
    class Triangle
    {
        Vector fv0, fv1, fv2;
        public Color color;

        public Triangle(Vector av0, Vector av1, Vector av2, Color aColor)
        {
            fv0 = av0;
            fv1 = av1;
            fv2 = av2;
            color = aColor;
        }

        public Vector v0
        {
            get { return fv0; }
        }

        public Vector v1
        {
            get { return fv1; }
        }

        public Vector v2
        {
            get { return fv2; }
        }

        public Vector normal
        {
            get { return v1.minus(v0).getVectorMult(v2.minus(v0)); }
        }

        public Vector normalCam
        {
            get { return v1.Vcam.minus(v0.Vcam).getVectorMult(v2.Vcam.minus(v0.Vcam)); }
        }
    }
}
