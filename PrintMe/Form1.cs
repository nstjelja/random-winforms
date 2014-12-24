using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrintMe_Click(object sender, EventArgs e)
        {
            var doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += doc_PrintPage;
            doc.Print();
        }

        void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black), new Point(0, 0), new Point(500, 500));
            e.Graphics.DrawString("My name is Sam", new Font(FontFamily.GenericMonospace, 10),Brushes.Aquamarine, new PointF(300, 300));
        }
    }
}
