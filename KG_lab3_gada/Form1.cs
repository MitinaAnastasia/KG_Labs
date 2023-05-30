using System;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;
using System.Drawing;

namespace KG_lab3_gada
{
    public partial class Form1 : Form
    {
        double _size = 10.0;
        public Form1()
        {
            InitializeComponent();
            pan.InitializeContexts();
        }

        float func(float x, float y)
        {
            return (float)(x*x - y*y);
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            Gl.glClearColor(0, 0, 0, 1);
            Gl.glViewport(0, 0, pan.Width, pan.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            const double W = 10;
            double H = W * pan.Height / pan.Width;
            Gl.glOrtho(-W, W, -H, H, -300, 300);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
        }

        private void Render(double x, double y)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glLoadIdentity();
            Gl.glColor3f(1, 1, 1);

            Gl.glPushMatrix();
            Gl.glTranslated(0, -1, -6);
            Gl.glRotated((x - pan.Height) * 180 / pan.Height, 0, 1, 0);
            Gl.glRotated((y - pan.Width) * 180 / pan.Width, 1, 0, 0);
            Glut.glutSolidTeapot(_size);
            Gl.glPopMatrix();
            Gl.glFlush();
            pan.Invalidate();
        }

        private void Light_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                if (dgvr.Index + 1 != dataGridView1.Rows.Count)
                {
                    Gl.glEnable(Gl.GL_LIGHT0 + dgvr.Index);
                    float[] light_direction =
                    {
                            (float)Convert.ToDecimal(dgvr.Cells[0].Value),
                            (float)Convert.ToDecimal(dgvr.Cells[1].Value),
                            (float)Convert.ToDecimal(dgvr.Cells[2].Value),
                            0
                        };
                    Gl.glLightfv(Gl.GL_LIGHT0 + dgvr.Index, Gl.GL_POSITION, light_direction);
                    float[] diffuse_light =
                    {
                            ((Color)dgvr.Cells[3].Value).R / (float)255,
                            ((Color)dgvr.Cells[3].Value).G / (float)255,
                            ((Color)dgvr.Cells[3].Value).B / (float)255
                        };
                    Gl.glLightfv(Gl.GL_LIGHT0 + dgvr.Index, Gl.GL_DIFFUSE, diffuse_light);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (DialogResult.OK == colorDialog1.ShowDialog())
                {
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value = colorDialog1.Color;
                }
            }
        }

        private void pan_MouseMove(object sender, MouseEventArgs e)
        {
            Render(e.X, e.Y);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _size = Convert.ToDouble(size.Text);
        }
    }
}
