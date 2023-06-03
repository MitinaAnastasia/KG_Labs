using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
    public abstract class VectorH2D
    {
        private readonly float[] coordinates;

        public float X => coordinates[0];

        public float Y => coordinates[1];

        public float W => coordinates[3];

        public float this[int i] => coordinates[i];


        public VectorH2D(float[] coordinates)
        {
            if (coordinates.Length != 3)
            {
                throw new ArgumentException();
            }
            this.coordinates = coordinates;
        }

        public VectorH2D(float x, float y, float w) : this(new float[] { x, y, w })
        {

        }

    }
}
