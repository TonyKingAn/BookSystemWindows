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
    public partial class UserDetailPage : Form
    {
        public Action<Tuple<Guid, string>> successCallback;
        private string operationType = string.Empty;

        public UserDetailPage()
        {
            InitializeComponent();
            InitializeUserDetails();
            this.submit_btn.Visible = false;
        }

        public UserDetailPage(string type, Action<Tuple<Guid, string>> action)
        {
            InitializeComponent();
            InitializeUserDetails();
            operationType = type;
            if (action != null)
            {
                successCallback = action;
            }

            this.submit_btn.Visible = true;
        }

        private List<string> userDetailHeaders = new List<string>() {
            "姓名",
            "电话",
            "生日",
            "过期时间",
            "备注",
            "状态"
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
                var users = db.Users.OrderBy(u => u.Name).ToList();

                foreach (var user in users)
                {
                    ListViewItem item = new ListViewItem(user.Name);
                    item.SubItems.Add(user.Mobile);
                    item.SubItems.Add(user.Birthday.ToString("yyyy年MM月dd日"));
                    item.SubItems.Add(user.ExpireTime.ToString("yyyy年MM月dd日"));
                    item.SubItems.Add(user.Comments.ToString());

                    item.SubItems.Add(user.ExpireTime > DateTime.Now ? "未过期" : "已过期");

                    item.SubItems.Add(user.Id.ToString());
                    this.userDetailList.Items.Add(item);
                    this.userDetailList.Columns[0].Width = 0;
                }
            }
            dynamicSizeChange();
        }

        private void UpdateUserDetail(string keyword)
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
                List<User> users = new List<User>();
                if (string.IsNullOrEmpty(keyword))
                {
                    users = db.Users.OrderBy(u => u.Name).ToList();
                }
                else
                {
                    users = db.Users.Where(u => u.Name.Contains(keyword) || u.Mobile.Contains(keyword)).OrderBy(u => u.Name).ToList();
                }

                foreach (var user in users)
                {
                    ListViewItem item = new ListViewItem(user.Name);
                    item.SubItems.Add(user.Mobile);
                    item.SubItems.Add(user.Birthday.ToString("yyyy年MM月dd日"));
                    item.SubItems.Add(user.ExpireTime.ToString("yyyy年MM月dd日"));
                    item.SubItems.Add(user.Comments.ToString());

                    item.SubItems.Add(user.ExpireTime > DateTime.Now ? "未过期" : "已过期");

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
            if (this.userDetailList.SelectedItems.Count == 0)
            {
                MessageBox.Show("未选择需修改的用户");
                return;
            }

            if (this.userDetailList.SelectedItems.Count > 1)
            {
                MessageBox.Show("只能修改一个用户，请勿多选");
                return;
            }

            var userId = this.userDetailList.SelectedItems[0].SubItems[6].Text; //userId

            var updateUserDialog = new UpdateUserDialog(() => { InitializeUserDetails(); }, Guid.Parse(userId));
            updateUserDialog.ShowDialog();
        }

        private void deleteUser_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.userDetailList.SelectedItems.Count == 0)
                {
                    MessageBox.Show("请选择要删除的用户");
                    return;
                }

                List<Guid> deleteUserIds = new List<Guid>();
                string message = string.Empty;
                foreach (var user in this.userDetailList.SelectedItems)
                {
                    var userId = this.userDetailList.SelectedItems[0].SubItems[6].Text; //userId
                    var userName = this.userDetailList.SelectedItems[0].SubItems[0].Text;
                    deleteUserIds.Add(Guid.Parse(userId));
                    if (BizManager.UserRentBiz.RelatedRent(userId))
                    {
                        message += $"{userName},";
                    }
                }

                if (!string.IsNullOrEmpty(message))
                {
                    message = message.TrimEnd(',') + "这些用户有关联的借书信息，删除会造成数据统计错误，是否删除？";
                }
                else
                {
                    message = "确定要删除这些用户吗？";
                }

                var result = MessageBox.Show(message, "删除提示", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    BizManager.UsersBiz.DeleteUser(deleteUserIds);
                }
                InitializeUserDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (this.userDetailList.SelectedItems.Count == 0)
            {
                MessageBox.Show("未选择用户");
                return;
            }

            if (this.userDetailList.SelectedItems.Count > 1)
            {
                MessageBox.Show("只能选择一个用户");
                return;
            }

            var userId = this.userDetailList.SelectedItems[0].SubItems[6].Text;//userId
            Tuple<Guid, string> user = new Tuple<Guid, string>(Guid.Parse(userId), this.userDetailList.SelectedItems[0].SubItems[0].Text);
            successCallback(user);
            this.Hide();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            UpdateUserDetail(this.keyword_txt.Text);
        }

        private void ImportUser_MenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.ShowDialog();
                var msg = BizManager.UsersBiz.ImportUser(file.FileName);
                MessageBox.Show(msg);
                InitializeUserDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
