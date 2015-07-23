namespace GameOfLife
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGridSize = new System.Windows.Forms.Label();
            this.numGridSize = new System.Windows.Forms.NumericUpDown();
            this.numCellSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTesting = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCellSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(239, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(541, 437);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grid size:";
            // 
            // lblGridSize
            // 
            this.lblGridSize.AutoSize = true;
            this.lblGridSize.Location = new System.Drawing.Point(174, 15);
            this.lblGridSize.Name = "lblGridSize";
            this.lblGridSize.Size = new System.Drawing.Size(42, 13);
            this.lblGridSize.TabIndex = 4;
            this.lblGridSize.Text = "10 x 10";
            // 
            // numGridSize
            // 
            this.numGridSize.Location = new System.Drawing.Point(68, 12);
            this.numGridSize.Name = "numGridSize";
            this.numGridSize.Size = new System.Drawing.Size(100, 20);
            this.numGridSize.TabIndex = 5;
            this.numGridSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numGridSize.ValueChanged += new System.EventHandler(this.numGridSize_ValueChanged);
            // 
            // numCellSize
            // 
            this.numCellSize.Enabled = false;
            this.numCellSize.Location = new System.Drawing.Point(68, 38);
            this.numCellSize.Name = "numCellSize";
            this.numCellSize.Size = new System.Drawing.Size(100, 20);
            this.numCellSize.TabIndex = 7;
            this.numCellSize.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numCellSize.ValueChanged += new System.EventHandler(this.numCellSize_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cell size:";
            // 
            // txtTesting
            // 
            this.txtTesting.Location = new System.Drawing.Point(15, 175);
            this.txtTesting.Multiline = true;
            this.txtTesting.Name = "txtTesting";
            this.txtTesting.Size = new System.Drawing.Size(201, 238);
            this.txtTesting.TabIndex = 8;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(12, 64);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtTesting);
            this.Controls.Add(this.numCellSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numGridSize);
            this.Controls.Add(this.lblGridSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCellSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGridSize;
        private System.Windows.Forms.NumericUpDown numGridSize;
        private System.Windows.Forms.NumericUpDown numCellSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTesting;
        private System.Windows.Forms.Button btnRun;
    }
}

