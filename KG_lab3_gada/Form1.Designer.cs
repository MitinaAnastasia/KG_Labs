
namespace KG_lab3_gada
{
    partial class Form1
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
            this.pan = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Light = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.size = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.AccumBits = ((byte)(0));
            this.pan.AutoCheckErrors = false;
            this.pan.AutoFinish = false;
            this.pan.AutoMakeCurrent = true;
            this.pan.AutoSwapBuffers = true;
            this.pan.BackColor = System.Drawing.Color.Black;
            this.pan.ColorBits = ((byte)(32));
            this.pan.DepthBits = ((byte)(16));
            this.pan.Location = new System.Drawing.Point(12, 12);
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(528, 519);
            this.pan.StencilBits = ((byte)(0));
            this.pan.TabIndex = 0;
            this.pan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pan_MouseMove);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y,
            this.Z,
            this.Color});
            this.dataGridView1.Location = new System.Drawing.Point(546, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(383, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 80;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 80;
            // 
            // Z
            // 
            this.Z.HeaderText = "Z";
            this.Z.MinimumWidth = 6;
            this.Z.Name = "Z";
            this.Z.Width = 80;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            this.Color.Width = 80;
            // 
            // Light
            // 
            this.Light.Location = new System.Drawing.Point(677, 179);
            this.Light.Name = "Light";
            this.Light.Size = new System.Drawing.Size(125, 49);
            this.Light.TabIndex = 2;
            this.Light.Text = "Освещение";
            this.Light.UseVisualStyleBackColor = true;
            this.Light.Click += new System.EventHandler(this.Light_Click);
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(549, 288);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(100, 22);
            this.size.TabIndex = 3;
            this.size.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Размер:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.size);
            this.Controls.Add(this.Light);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl pan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z;
        private System.Windows.Forms.DataGridViewButtonColumn Color;
        private System.Windows.Forms.Button Light;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.Label label1;
    }
}

