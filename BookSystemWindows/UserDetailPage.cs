using BookSystemCommon.Models;
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
    public partial class UserDetailPage : Form
    {
        public UserDetailPage()
        {
            InitializeComponent();
            InitializeUserDetails();
        }

        private List<string> userDetailHeaders = new List<string>() {
            "姓名",
            "电话",
            "生日",
            "过期时间",
            "备注",
        };

        private void InitializeUserDetails()
        {
            ClearListView();

            // prepare column hearder
            foreach (var headerName in userDetailHeaders)
            {
                ColumnHeader clh = new ColumnHeader();
                clh.Text = headerName;
                userDetailList.Columns.Add(clh);
            }

            using (var db = Heart.CreateBookDbContext())
            {
                var users = db.Users.ToList();

                foreach (var user in users)
                {
                    ListViewItem item = new ListViewItem(user.Name);
                    item.SubItems.Add(user.Mobile);
                    item.SubItems.Add(user.Birthday.ToString());
                    item.SubItems.Add(user.ExpireTime.ToString());
                    item.SubItems.Add(user.Comments.ToString());
                    item.SubItems.Add(user.Id.ToString());
                    this.userDetailList.Items.Add(item);
                    this.userDetailList.Columns[0].Width = 0;
                }
            }
            dynamicSizeChange();
        }

        private void ClearListView()
        {
            this.userDetailList.Clear();
        }

        private void listview_SizeChanged(object sender, EventArgs e)
        {
            dynamicSizeChange();
        }

        // 动态调整尺寸
        private void dynamicSizeChange()
        {
            int _Count = this.userDetailList.Columns.Count;
            int _Width = this.userDetailList.Width;
            foreach (ColumnHeader ch in this.userDetailList.Columns)
            {
                ch.Width = _Width / _Count;
            }
        }

        private void createUser_btn_Click(object sender, EventArgs e)
        {
            var createUserDialog = new CreateUserDialog(() => { InitializeUserDetails(); });
            createUserDialog.ShowDialog();
        }

        private void updateUser_btn_Click(object sender, EventArgs e)
        {
            var updateUserDialog = new UpdateUserDialog();
            updateUserDialog.ShowDialog();
        }
    }
}
