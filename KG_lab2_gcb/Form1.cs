using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KG_lab2_gcb
{
    public partial class Form1 : Form
    {
        private Color brush = Color.Coral;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DrawBtn_Click(object sender, EventArgs e)
        {
            Viewport vp = new Viewport(pictureBox1.Height, pictureBox1.Width);
            vp.brush = brush;
            vp.addPartShar(Double.Parse(textBox1.Text));
            vp.addCamera(new Camera(new Vector(textBoxCamPosition.Text), new Vector(textBoxCamDir.Text).minus(new Vector(textBoxCamPosition.Text)), (double)angleCam.Value));
            vp.lightDir = new Vector(textBox2.Text);
            vp.Render();
            pictureBox1.Image = vp.pic;
        }
    }
}
