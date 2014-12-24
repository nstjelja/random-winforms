using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawALine
{
    public partial class Form1 : Form
    {
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Blue, 2F);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

        private void btnDraw_Click(object sender, EventArgs e)
        {

          
            var graphics = canvas.CreateGraphics();
            graphics.Clear(Color.White);
            graphics.DrawLine(pen1, new Point((int)x1.Value, (int)x2x2.Value), new Point((int)y1.Value, (int)y2.Value));
        }
    }
}
