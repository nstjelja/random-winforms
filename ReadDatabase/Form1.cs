using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.ValueMember = "TestTableID";
            comboBox1.DisplayMember = "Field3";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var db = new  DatabaseTable.TestTableAdapters.TestTableTableAdapter();
            var table = db.GetData();

            var items = table.Where(x => x.Field1 > 50).ToList();


            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(items.ToArray());
            
        }
    }
}
