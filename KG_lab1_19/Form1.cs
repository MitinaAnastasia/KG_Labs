using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace KG_lab1_19
{
    public partial class Form1 : Form
    {
        Graphics graphic;
        K_means kmeans = new K_means();
        public int count;

        public Form1()
        {
            InitializeComponent();
            graphic = PicBox.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        PicBox.SizeMode = PictureBoxSizeMode.Zoom;
                        PicBox.Image = new Bitmap(dialog.FileName);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Load correct file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            graphic.Clear(BackColor);
            PicBox.Image = null;
            CountTextBox.Text = "";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PicBox.Image == null)
                {
                    throw new NullReferenceException();
                }

                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        PicBox.Image.Save(dialog.FileName);
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Load image to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClusterButton_Click(object sender, EventArgs e)
        {
            try
            {
                count = int.Parse(CountTextBox.Text);
                if (count <= 0 || count > 30)
                {
                    throw new OverflowException();
                }
                if (PicBox.Image == null)
                {
                    throw new NullReferenceException();
                }
                PicBox.Image = kmeans.Segmentation(new Bitmap(PicBox.Image), count);
            }
            catch (FormatException)
            {
                MessageBox.Show("Uncorrect count", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Count is out of range (1-30)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Load image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Сегментация завершена!");
            }
        }
    }
}
