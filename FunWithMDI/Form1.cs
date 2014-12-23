using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunWithMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MdiChildActivate += Form1_MdiChildActivate;
        }

        void Form1_MdiChildActivate(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = ActiveMdiChild.Text;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var childe = new ChildMidi();
            var next =MdiChildren.Count()+1;
            childe.Text = String.Format("Form {0}", next);

            childe.MdiParent = this;
            childe.Show();

           
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
    }
}
