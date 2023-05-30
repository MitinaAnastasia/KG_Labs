
namespace KG_lab2_gcb
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCamPosition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCamDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.angleCam = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DrawBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleCam)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(287, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 499);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Положение камеры";
            // 
            // textBoxCamPosition
            // 
            this.textBoxCamPosition.Location = new System.Drawing.Point(23, 35);
            this.textBoxCamPosition.Name = "textBoxCamPosition";
            this.textBoxCamPosition.Size = new System.Drawing.Size(125, 27);
            this.textBoxCamPosition.TabIndex = 2;
            this.textBoxCamPosition.Text = "7 11 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Направление камеры";
            // 
            // textBoxCamDir
            // 
            this.textBoxCamDir.Location = new System.Drawing.Point(23, 97);
            this.textBoxCamDir.Name = "textBoxCamDir";
            this.textBoxCamDir.Size = new System.Drawing.Size(125, 27);
            this.textBoxCamDir.TabIndex = 4;
            this.textBoxCamDir.Text = "0 0 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Угол обзора камеры";
            // 
            // angleCam
            // 
            this.angleCam.Location = new System.Drawing.Point(23, 165);
            this.angleCam.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.angleCam.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.angleCam.Name = "angleCam";
            this.angleCam.Size = new System.Drawing.Size(150, 27);
            this.angleCam.TabIndex = 6;
            this.angleCam.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Диаметр полушара";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Освещение";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 305);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "15 15 3";
            // 
            // DrawBtn
            // 
            this.DrawBtn.Location = new System.Drawing.Point(39, 360);
            this.DrawBtn.Name = "DrawBtn";
            this.DrawBtn.Size = new System.Drawing.Size(94, 29);
            this.DrawBtn.TabIndex = 11;
            this.DrawBtn.Text = "Рисовать";
            this.DrawBtn.UseVisualStyleBackColor = true;
            this.DrawBtn.Click += new System.EventHandler(this.DrawBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 524);
            this.Controls.Add(this.DrawBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.angleCam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCamDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCamPosition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCamPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCamDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown angleCam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button DrawBtn;
    }
}

