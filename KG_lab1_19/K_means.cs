using System;
using System.Drawing;


namespace KG_lab1_19
{
    class K_means
    {
        public Bitmap Segmentation(Bitmap bitmap, int count)
        {
            Random rand = new Random();
            Point[] center = new Point[count];
            for(int i = 0; i < count; i++)
            {
                center[i] = new Point(rand.Next(bitmap.Width), rand.Next(bitmap.Height));
            }
            int[] dist = new int[count];
            for(int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Height; x++)
                {
                    for (int i = 0; i < count; i++)
                    {
                        var r = Math.Abs(bitmap.GetPixel(x, y).R - bitmap.GetPixel(center[i].X, center[i].Y).R);
                        var g = Math.Abs(bitmap.GetPixel(x, y).G - bitmap.GetPixel(center[i].X, center[i].Y).G);
                        var b = Math.Abs(bitmap.GetPixel(x, y).B - bitmap.GetPixel(center[i].X, center[i].Y).B);
                        dist[i] = (int)(Math.Sqrt(r * r + g * g + b * b));
                    }
                    int nearInd = MinDistance(dist, count);
                    var cnrColor = bitmap.GetPixel(center[nearInd].X, center[nearInd].Y);
                    bitmap.SetPixel(x, y, cnrColor);
                }
            }
            return bitmap;
        }

        public int MinDistance(int[] dist, int count)
        {
            int min = dist[0];
            int minInd = 0;
            for(int i = 0; i < count; i++)
            {
                if(dist[i] < min)
                {
                    min = dist[i];
                    minInd = i;
                }
            }
            return minInd;
        }
    }
}
