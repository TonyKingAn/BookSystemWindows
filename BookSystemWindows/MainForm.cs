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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeBookDetails();
        }

        private List<string> bookDetailHeaders = new List<string>() {
            "书号",
            "书名",
            "是否可借",
            "借阅人",
            "租借日期",
            "租借天数",
            "剩余时间"
        };


        private void InitializeBookDetails()
        {
            // prepare column hearder
            foreach (var headerName in bookDetailHeaders)
            {
                ColumnHeader clh = new ColumnHeader();
                clh.Text = headerName;
                BookDetailList.Columns.Add(clh);
            }

            ListViewItem lit = new ListViewItem("1");
            ListViewItem lit2 = new ListViewItem("1");
            ListViewItem lit3 = new ListViewItem("1");
            BookDetailList.Items.Add(lit);
            BookDetailList.Items.Add(lit2);
            BookDetailList.Items.Add(lit3);
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void CreateBooks(object sender, EventArgs e)
        {

        }

        private void CreateUserTip_Click(object sender, EventArgs e)
        {

        }

        private void UpdateUserTip_Click(object sender, EventArgs e)
        {

        }
    }
}
