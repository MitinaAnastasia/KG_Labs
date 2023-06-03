using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
    public class TransformationH3D
    {
        private readonly float[,] components;

        public float this[int i, int j] => components[i, j]; 

        public int Size => 4; 


        private TransformationH3D(float[,] components)
        {
            this.components = components;
        }

        public Polygon3D Apply(Polygon3D polygon)
        {
            PointH3D[] resultPoints = new PointH3D[3];
            int p = 0;
            foreach (PointH3D polygonPoint in polygon.Points)
            {
                float[] coordinates = new float[3];
                for (int i = 0; i < 3; i++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        coordinates[i] += components[i, k] * polygonPoint[k];
                    }
                }
                resultPoints[p++] = new PointH3D(coordinates[0], coordinates[1], coordinates[2]);
            }
            return new Polygon3D(resultPoints);
        }

        public static TransformationH3D CreateScaling(float a, float b, float c)
        {
            return new TransformationH3D(new float[,]
            {
                { a,  0f, 0f, 0f },
                { 0f, b,  0f, 0f },
                { 0f, 0f, c,  0f },
                { 0f, 0f, 0f, 1f }
            });
        }

    }
}
