using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxesAhoy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstLeft.Items.Add("Sven");
            lstLeft.Items.Add("Milica");
            lstLeft.Items.Add("Nikola");
        }

        private void AfterMove() {
            if (lstLeft.Items.Count == 0) {
                btnMoveAllToRight.Enabled = false;
                btnMoveOneToRight.Enabled = false;
                btnMoveAllToLeft.Enabled = true;
                btnMoveOneToLeft.Enabled = true;
                return;
            }

            if (lstRight.Items.Count == 0)
            {
                btnMoveAllToRight.Enabled = true;
                btnMoveOneToRight.Enabled = true;
                btnMoveAllToLeft.Enabled = false;
                btnMoveOneToLeft.Enabled = false;
            }
        }

        private void btnMoveOneToRight_Click(object sender, EventArgs e)
        {
            MoveOne(lstLeft, lstRight);
        }

        private void btnMoveAllToRight_Click(object sender, EventArgs e)
        {
            MoveAll(lstLeft, lstRight);
        }

        private void btnMoveAllToLeft_Click(object sender, EventArgs e)
        {
            MoveAll(lstRight, lstLeft);
        }

        private void btnMoveOneToLeft_Click(object sender, EventArgs e)
        {
           
            MoveOne(lstRight, lstLeft);
        }

        private void MoveOne(ListBox source, ListBox destination) {
            if (source.Items.Count == 0)
                return;

            var item = source.Items[0];
            source.Items.RemoveAt(0);
            destination.Items.Add(item);
            AfterMove();
        }

        private void MoveAll(ListBox source, ListBox destination) {
            foreach (var item in source.Items)
            {
                destination.Items.Add(item);
            }

            source.Items.Clear();
            AfterMove();
        }
    }
}
