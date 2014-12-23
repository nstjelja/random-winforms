using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharedLibrary
{
    public class ListViewSorter : IComparer  
    {

        private int Column { get; set; }
        private SortOrder SortOrder { get; set; }

        public ListViewSorter(int column, SortOrder sortOrder) {
            Column = column;
            SortOrder = sortOrder;
        }

        public int Compare(object x, object y)
        {
            var a = x as ListViewItem;
            var b = y as ListViewItem;

            if (a == null || b == null)
                return 0;
            var result = 0;
            switch (Column) { 
                case 0:
                    result = a.SubItems[0].Text.CompareTo(b.SubItems[0].Text);
                    break;
                case 1:
                    result = Convert.ToInt32(a.SubItems[1].Text).CompareTo(Convert.ToInt32(b.SubItems[1].Text));
                    break;
                case 2:
                    result = Convert.ToDateTime(a.SubItems[2].Text).CompareTo(Convert.ToDateTime(b.SubItems[2].Text));
                    break;
            }

            if (SortOrder == System.Windows.Forms.SortOrder.Ascending)
                return result;
            

            return result * -1;

                   
        }
    }
}
