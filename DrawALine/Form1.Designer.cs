namespace DrawALine
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
            this.lblX1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.NumericUpDown();
            this.x2x2 = new System.Windows.Forms.NumericUpDown();
            this.y1 = new System.Windows.Forms.NumericUpDown();
            this.y2 = new System.Windows.Forms.NumericUpDown();
            this.btnDraw = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2x2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(13, 13);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(20, 13);
            this.lblX1.TabIndex = 4;
            this.lblX1.Text = "X1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y2";
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(16, 43);
            this.x1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(66, 20);
            this.x1.TabIndex = 8;
            // 
            // x2x2
            // 
            this.x2x2.Location = new System.Drawing.Point(118, 43);
            this.x2x2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.x2x2.Name = "x2x2";
            this.x2x2.Size = new System.Drawing.Size(66, 20);
            this.x2x2.TabIndex = 9;
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(239, 43);
            this.y1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(66, 20);
            this.y1.TabIndex = 10;
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(345, 43);
            this.y2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(66, 20);
            this.y2.TabIndex = 11;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(424, 40);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 12;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(16, 84);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(483, 291);
            this.canvas.TabIndex = 13;
            this.canvas.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 426);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x2x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblX1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2x2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown x1;
        private System.Windows.Forms.NumericUpDown x2x2;
        private System.Windows.Forms.NumericUpDown y1;
        private System.Windows.Forms.NumericUpDown y2;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.PictureBox canvas;
    }
}

