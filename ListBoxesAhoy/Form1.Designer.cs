namespace ListBoxesAhoy
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
            this.lstLeft = new System.Windows.Forms.ListBox();
            this.lstRight = new System.Windows.Forms.ListBox();
            this.btnMoveOneToRight = new System.Windows.Forms.Button();
            this.btnMoveAllToRight = new System.Windows.Forms.Button();
            this.btnMoveAllToLeft = new System.Windows.Forms.Button();
            this.btnMoveOneToLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLeft
            // 
            this.lstLeft.FormattingEnabled = true;
            this.lstLeft.Location = new System.Drawing.Point(52, 61);
            this.lstLeft.Name = "lstLeft";
            this.lstLeft.Size = new System.Drawing.Size(187, 225);
            this.lstLeft.TabIndex = 0;
            // 
            // lstRight
            // 
            this.lstRight.FormattingEnabled = true;
            this.lstRight.Location = new System.Drawing.Point(351, 61);
            this.lstRight.Name = "lstRight";
            this.lstRight.Size = new System.Drawing.Size(219, 225);
            this.lstRight.TabIndex = 1;
            // 
            // btnMoveOneToRight
            // 
            this.btnMoveOneToRight.Location = new System.Drawing.Point(259, 61);
            this.btnMoveOneToRight.Name = "btnMoveOneToRight";
            this.btnMoveOneToRight.Size = new System.Drawing.Size(75, 23);
            this.btnMoveOneToRight.TabIndex = 2;
            this.btnMoveOneToRight.Text = ">";
            this.btnMoveOneToRight.UseVisualStyleBackColor = true;
            this.btnMoveOneToRight.Click += new System.EventHandler(this.btnMoveOneToRight_Click);
            // 
            // btnMoveAllToRight
            // 
            this.btnMoveAllToRight.Location = new System.Drawing.Point(259, 102);
            this.btnMoveAllToRight.Name = "btnMoveAllToRight";
            this.btnMoveAllToRight.Size = new System.Drawing.Size(75, 23);
            this.btnMoveAllToRight.TabIndex = 3;
            this.btnMoveAllToRight.Text = ">>";
            this.btnMoveAllToRight.UseVisualStyleBackColor = true;
            this.btnMoveAllToRight.Click += new System.EventHandler(this.btnMoveAllToRight_Click);
            // 
            // btnMoveAllToLeft
            // 
            this.btnMoveAllToLeft.Location = new System.Drawing.Point(259, 144);
            this.btnMoveAllToLeft.Name = "btnMoveAllToLeft";
            this.btnMoveAllToLeft.Size = new System.Drawing.Size(75, 23);
            this.btnMoveAllToLeft.TabIndex = 4;
            this.btnMoveAllToLeft.Text = "<<";
            this.btnMoveAllToLeft.UseVisualStyleBackColor = true;
            this.btnMoveAllToLeft.Click += new System.EventHandler(this.btnMoveAllToLeft_Click);
            // 
            // btnMoveOneToLeft
            // 
            this.btnMoveOneToLeft.Location = new System.Drawing.Point(259, 184);
            this.btnMoveOneToLeft.Name = "btnMoveOneToLeft";
            this.btnMoveOneToLeft.Size = new System.Drawing.Size(75, 23);
            this.btnMoveOneToLeft.TabIndex = 5;
            this.btnMoveOneToLeft.Text = "<";
            this.btnMoveOneToLeft.UseVisualStyleBackColor = true;
            this.btnMoveOneToLeft.Click += new System.EventHandler(this.btnMoveOneToLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 384);
            this.Controls.Add(this.btnMoveOneToLeft);
            this.Controls.Add(this.btnMoveAllToLeft);
            this.Controls.Add(this.btnMoveAllToRight);
            this.Controls.Add(this.btnMoveOneToRight);
            this.Controls.Add(this.lstRight);
            this.Controls.Add(this.lstLeft);
            this.Name = "Form1";
            this.Text = "List boy ahoy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstLeft;
        private System.Windows.Forms.ListBox lstRight;
        private System.Windows.Forms.Button btnMoveOneToRight;
        private System.Windows.Forms.Button btnMoveAllToRight;
        private System.Windows.Forms.Button btnMoveAllToLeft;
        private System.Windows.Forms.Button btnMoveOneToLeft;
    }
}

