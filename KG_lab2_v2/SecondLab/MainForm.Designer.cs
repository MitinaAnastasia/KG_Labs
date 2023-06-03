namespace SecondLab
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.showButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radiusNUD = new System.Windows.Forms.NumericUpDown();
            this.angleNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.yLightNUD = new System.Windows.Forms.NumericUpDown();
            this.xLightNUD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.zLightNUD = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gammaAngleNUD = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.bettaAngleNUD = new System.Windows.Forms.NumericUpDown();
            this.alphaAngleNUD = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yLightNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xLightNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zLightNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaAngleNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bettaAngleNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaAngleNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(11, 10);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 600);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(889, 475);
            this.showButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(246, 47);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Отобразить";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(885, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Радиус полусферы(px)";
            // 
            // radiusNUD
            // 
            this.radiusNUD.Location = new System.Drawing.Point(1050, 31);
            this.radiusNUD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiusNUD.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.radiusNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radiusNUD.Name = "radiusNUD";
            this.radiusNUD.Size = new System.Drawing.Size(85, 22);
            this.radiusNUD.TabIndex = 3;
            this.radiusNUD.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // angleNUD
            // 
            this.angleNUD.Location = new System.Drawing.Point(1050, 57);
            this.angleNUD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.angleNUD.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.angleNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.angleNUD.Name = "angleNUD";
            this.angleNUD.Size = new System.Drawing.Size(85, 22);
            this.angleNUD.TabIndex = 5;
            this.angleNUD.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(885, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Угол отсечения";
            // 
            // yLightNUD
            // 
            this.yLightNUD.Location = new System.Drawing.Point(1050, 336);
            this.yLightNUD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yLightNUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.yLightNUD.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.yLightNUD.Name = "yLightNUD";
            this.yLightNUD.Size = new System.Drawing.Size(85, 22);
            this.yLightNUD.TabIndex = 9;
            this.yLightNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // xLightNUD
            // 
            this.xLightNUD.Location = new System.Drawing.Point(1050, 287);
            this.xLightNUD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xLightNUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.xLightNUD.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.xLightNUD.Name = "xLightNUD";
            this.xLightNUD.Size = new System.Drawing.Size(85, 22);
            this.xLightNUD.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(885, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Направление освещения по X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(885, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Направление освещения по Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(885, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Направление освещения по Z:";
            // 
            // zLightNUD
            // 
            this.zLightNUD.Location = new System.Drawing.Point(1050, 385);
            this.zLightNUD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zLightNUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.zLightNUD.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.zLightNUD.Name = "zLightNUD";
            this.zLightNUD.Size = new System.Drawing.Size(85, 22);
            this.zLightNUD.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(885, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Параметры полусферы";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(885, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Освещение";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(885, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 17);
            this.label10.TabIndex = 48;
            this.label10.Text = "Движение камеры";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(885, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 17);
            this.label6.TabIndex = 47;
            this.label6.Text = "ОсьZ(Вперёд/назад)";
            // 
            // gammaAngleNUD
            // 
            this.gammaAngleNUD.Location = new System.Drawing.Point(1050, 191);
            this.gammaAngleNUD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gammaAngleNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.gammaAngleNUD.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.gammaAngleNUD.Name = "gammaAngleNUD";
            this.gammaAngleNUD.Size = new System.Drawing.Size(85, 22);
            this.gammaAngleNUD.TabIndex = 46;
            this.gammaAngleNUD.Value = new decimal(new int[] {
            7,
            0,
            0,
            -2147483648});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(885, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "ОсьY(Вверх/вниз)";
            // 
            // bettaAngleNUD
            // 
            this.bettaAngleNUD.Location = new System.Drawing.Point(1050, 162);
            this.bettaAngleNUD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bettaAngleNUD.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.bettaAngleNUD.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.bettaAngleNUD.Name = "bettaAngleNUD";
            this.bettaAngleNUD.Size = new System.Drawing.Size(85, 22);
            this.bettaAngleNUD.TabIndex = 44;
            this.bettaAngleNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // alphaAngleNUD
            // 
            this.alphaAngleNUD.Location = new System.Drawing.Point(1050, 134);
            this.alphaAngleNUD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alphaAngleNUD.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.alphaAngleNUD.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.alphaAngleNUD.Name = "alphaAngleNUD";
            this.alphaAngleNUD.Size = new System.Drawing.Size(85, 22);
            this.alphaAngleNUD.TabIndex = 43;
            this.alphaAngleNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(885, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "ОсьX(Велво/вправо)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gammaAngleNUD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bettaAngleNUD);
            this.Controls.Add(this.alphaAngleNUD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zLightNUD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yLightNUD);
            this.Controls.Add(this.xLightNUD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.angleNUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radiusNUD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.pictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yLightNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xLightNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zLightNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaAngleNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bettaAngleNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaAngleNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown radiusNUD;
        private System.Windows.Forms.NumericUpDown angleNUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown yLightNUD;
        private System.Windows.Forms.NumericUpDown xLightNUD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown zLightNUD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown gammaAngleNUD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown bettaAngleNUD;
        private System.Windows.Forms.NumericUpDown alphaAngleNUD;
        private System.Windows.Forms.Label label8;
    }
}

