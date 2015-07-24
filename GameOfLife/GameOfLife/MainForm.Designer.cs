namespace GameOfLife
{
    partial class MainForm
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
            this.btnRun = new System.Windows.Forms.Button();
            this.txtTesting = new System.Windows.Forms.TextBox();
            this.numCellSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numGridSize = new System.Windows.Forms.NumericUpDown();
            this.lblGridSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCellSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(21, 64);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 17;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtTesting
            // 
            this.txtTesting.Location = new System.Drawing.Point(24, 175);
            this.txtTesting.Multiline = true;
            this.txtTesting.Name = "txtTesting";
            this.txtTesting.Size = new System.Drawing.Size(201, 238);
            this.txtTesting.TabIndex = 16;
            // 
            // numCellSize
            // 
            this.numCellSize.Enabled = false;
            this.numCellSize.Location = new System.Drawing.Point(77, 38);
            this.numCellSize.Name = "numCellSize";
            this.numCellSize.Size = new System.Drawing.Size(100, 20);
            this.numCellSize.TabIndex = 15;
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
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cell size:";
            // 
            // numGridSize
            // 
            this.numGridSize.Location = new System.Drawing.Point(77, 12);
            this.numGridSize.Name = "numGridSize";
            this.numGridSize.Size = new System.Drawing.Size(100, 20);
            this.numGridSize.TabIndex = 13;
            this.numGridSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numGridSize.ValueChanged += new System.EventHandler(this.numGridSize_ValueChanged);
            // 
            // lblGridSize
            // 
            this.lblGridSize.AutoSize = true;
            this.lblGridSize.Location = new System.Drawing.Point(183, 15);
            this.lblGridSize.Name = "lblGridSize";
            this.lblGridSize.Size = new System.Drawing.Size(42, 13);
            this.lblGridSize.TabIndex = 12;
            this.lblGridSize.Text = "10 x 10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Grid size:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(248, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 569);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(102, 64);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 18;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 609);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtTesting);
            this.Controls.Add(this.numCellSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numGridSize);
            this.Controls.Add(this.lblGridSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.numCellSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtTesting;
        private System.Windows.Forms.NumericUpDown numCellSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numGridSize;
        private System.Windows.Forms.Label lblGridSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStop;
    }
}