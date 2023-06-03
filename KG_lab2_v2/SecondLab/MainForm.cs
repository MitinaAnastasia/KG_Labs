using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondLab
{
    public partial class MainForm : Form
    {
        private readonly World world;
        
        private Graphics graphics;

        public MainForm()
        {
            InitializeComponent();
            world = new World();
            graphics = Graphics.FromHwnd(pictureBox.Handle);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            SetParameters();
            IEnumerable<Polygon2D> polygons = world.GetCameraProjection();
            graphics.Clear(Color.White);
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            foreach (Polygon2D polygon in polygons)
            {
                int red = Math.Min(Math.Max(55 + (int)(200 * polygon.LightingLevel), 0),254);
                Color color = Color.FromArgb(255, red, 0, 0);
                SolidBrush brush = new SolidBrush(color);
                Pen pen = new Pen(Color.FromArgb(255, red, 0, 0));
                PointH2D[] points = polygon.Points.ToArray();
                PointF[] screenPoints = new PointF[3];
                for (int i = 0; i < screenPoints.Length; i++) 
                {
                    screenPoints[i] = new PointF(points[i].X, points[i].Y);

                }
                graphics.DrawPolygon(pen, screenPoints);
                graphics.FillPolygon(brush, screenPoints);
            }
        }

        private void SetParameters()
        {
            float radius = (float)radiusNUD.Value;
            int angle = (int)angleNUD.Value;
            world.SetAngilShpere(angle);
            world.TransformPolyhedron(radius/ 100, radius/100);
            world.SetPointCamera(new Vector3((float)alphaAngleNUD.Value, (float)bettaAngleNUD.Value, (float)gammaAngleNUD.Value),
                10, (float)(Math.PI / 2), 800, 600);

            world.SetLighting((float) xLightNUD.Value, (float) yLightNUD.Value, (float) zLightNUD.Value);
        }

    }
}
