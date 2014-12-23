using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharedLibrary
{
    public class MyListBox : ListView
    {
        public MyListBox() {
            Columns.Add("String");
            Columns.Add("Integer");
            Columns.Add("DateTime");

            this.ColumnClick += MyListBox_ColumnClick;
            this.View = System.Windows.Forms.View.Details;
        }

        void MyListBox_ColumnClick(object sender, ColumnClickEventArgs e)
        {
          

            if (Sorting == SortOrder.None)
            {
                Sorting = SortOrder.Ascending;
                this.ListViewItemSorter = new ListViewSorter(e.Column, Sorting);
                Sort();
                return;
            }

            if (Sorting == SortOrder.Ascending) {
                Sorting = SortOrder.Descending;
                this.ListViewItemSorter = new ListViewSorter(e.Column, Sorting);
                Sort();
                return;
            }

         
            Sorting = SortOrder.Ascending;
            this.ListViewItemSorter = new ListViewSorter(e.Column, Sorting);
            Sort();
            return;
           
          
        }
    }
}
