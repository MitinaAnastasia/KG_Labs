
namespace KG_lab1_19
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
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.ClusterButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBox
            // 
            this.PicBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PicBox.Location = new System.Drawing.Point(317, 22);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(620, 550);
            this.PicBox.TabIndex = 0;
            this.PicBox.TabStop = false;
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(21, 22);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(110, 50);
            this.ImportButton.TabIndex = 1;
            this.ImportButton.Text = "Load Image";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(168, 22);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(110, 50);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clusters count (1 - 30)";
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(21, 215);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(125, 27);
            this.CountTextBox.TabIndex = 4;
            // 
            // ClusterButton
            // 
            this.ClusterButton.Location = new System.Drawing.Point(21, 523);
            this.ClusterButton.Name = "ClusterButton";
            this.ClusterButton.Size = new System.Drawing.Size(221, 49);
            this.ClusterButton.TabIndex = 5;
            this.ClusterButton.Text = "Start clusterization";
            this.ClusterButton.UseVisualStyleBackColor = true;
            this.ClusterButton.Click += new System.EventHandler(this.ClusterButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(93, 89);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(110, 50);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save Image";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 584);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ClusterButton);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.PicBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.Button ClusterButton;
        private System.Windows.Forms.Button SaveButton;
    }
}

