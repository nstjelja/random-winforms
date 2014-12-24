namespace ThreadingFactorialCalculation
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
            this.numSeed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblFactorial = new System.Windows.Forms.Label();
            this.btnCacluclateFactorial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSeed)).BeginInit();
            this.SuspendLayout();
            // 
            // numSeed
            // 
            this.numSeed.Location = new System.Drawing.Point(22, 29);
            this.numSeed.Name = "numSeed";
            this.numSeed.Size = new System.Drawing.Size(222, 20);
            this.numSeed.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter seed";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(115, 160);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 2;
            // 
            // lblFactorial
            // 
            this.lblFactorial.AutoSize = true;
            this.lblFactorial.Location = new System.Drawing.Point(22, 98);
            this.lblFactorial.Name = "lblFactorial";
            this.lblFactorial.Size = new System.Drawing.Size(0, 13);
            this.lblFactorial.TabIndex = 3;
            // 
            // btnCacluclateFactorial
            // 
            this.btnCacluclateFactorial.Location = new System.Drawing.Point(309, 26);
            this.btnCacluclateFactorial.Name = "btnCacluclateFactorial";
            this.btnCacluclateFactorial.Size = new System.Drawing.Size(75, 23);
            this.btnCacluclateFactorial.TabIndex = 4;
            this.btnCacluclateFactorial.Text = "GetMeThatFactorial";
            this.btnCacluclateFactorial.UseVisualStyleBackColor = true;
            this.btnCacluclateFactorial.Click += new System.EventHandler(this.btnCacluclateFactorial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 327);
            this.Controls.Add(this.btnCacluclateFactorial);
            this.Controls.Add(this.lblFactorial);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numSeed);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numSeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numSeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblFactorial;
        private System.Windows.Forms.Button btnCacluclateFactorial;
    }
}

