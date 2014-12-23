using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasiControlInheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstBox.Items.Add("Sven");
            lstBox.Items[0].SubItems.Add("1");
            lstBox.Items[0].SubItems.Add(new DateTime(2007, 11, 27).ToShortDateString());

            lstBox.Items.Add("Milica");
            lstBox.Items[1].SubItems.Add("2");
            lstBox.Items[1].SubItems.Add(new DateTime(1990, 4, 28).ToShortDateString());
        }
    }
}
