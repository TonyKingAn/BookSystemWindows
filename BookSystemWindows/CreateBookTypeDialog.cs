using BookSystemCommon.Models;
using BookSystemCommon.Models.Biz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSystemWindows
{
    public partial class CreateBookTypeDialog : Form
    {
        public CreateBookTypeDialog()
        {
            InitializeComponent();
            InitlizeBookType();
        }

        private void InitlizeBookType()
        {
            ClearListView();

            // prepare column hearder

            ColumnHeader clh = new ColumnHeader();
            clh.Text = "类型";
            bookType_List.Columns.Add(clh);

            using (var db = Heart.CreateBookDbContext())
            {
                var bookTypes = BizManager.BooksBiz.GetBookTypeList();

                foreach (var type in bookTypes)
                {
                    ListViewItem item = new ListViewItem(type);
                    this.bookType_List.Items.Add(item);
                }
            }
            dynamicSizeChange();
        }
        private void ClearListView()
        {
            this.bookType_List.Clear();
        }

        private void listview_SizeChanged(object sender, EventArgs e)
        {
            dynamicSizeChange();
        }

        private void dynamicSizeChange()
        {
            int _Count = bookType_List.Columns.Count;
            int _Width = bookType_List.Width;
            foreach (ColumnHeader ch in bookType_List.Columns)
            {
                ch.Width = _Width / _Count;
            }
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            BizManager.BooksBiz.CreateBookType(this.bookType_txt.Text);
            InitlizeBookType();
            this.bookType_txt.Text = string.Empty;
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (this.bookType_List.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要修改的书籍");
                return;
            }

            var bookType = this.bookType_List.SelectedItems[0].SubItems[0].Text;
            BizManager.BooksBiz.DeleteBookType(bookType);
            InitlizeBookType();
        }
    }
}
