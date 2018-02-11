using BookSystemCommon.Models;
using System;
using System.Windows.Forms;
using System.Linq;
using BookSystemCommon.Models.Biz;

namespace BookSystemWindows
{
    public partial class UpdateUserDialog : Form
    {
        private delegate void CallBackEventHandler();
        CallBackEventHandler succcessCallBack;
        private Guid userId = Guid.Empty;

        public UpdateUserDialog(Action action, Guid userId)
        {
            InitializeComponent();

            if (action != null)
            {
                succcessCallBack = new CallBackEventHandler(action);
            }
            this.userId = userId;
            InitializeUpdateUserInfo(userId);
        }

        private void InitializeUpdateUserInfo(Guid userId)
        {
            var existedUser = BizManager.UsersBiz.GetUserById(userId);
            if (existedUser == null)
            {
                throw new Exception("未找到当前用户");
            }

            this.userName_txt.Text = existedUser.Name;
            this.userMobile_txt.Text = existedUser.Mobile;
            this.userComments_txt.Text = existedUser.Comments;
            this.userBirthday_dp.Text = existedUser.Birthday.ToString("yyyy年MM月dd日");
            this.userExpire_dp.Text = existedUser.ExpireTime.ToString("yyyy年MM月dd日");

            if (existedUser.Sex == "男")
            {
                this.checkBox1.Checked = true;    //男
            }
            else if (existedUser.Sex == "女")
            {
                this.checkBox2.Checked = true; //女
            }
        }

        private void resetBtn_Click(object sender, System.EventArgs e)
        {

        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var existedUser = BizManager.UsersBiz.GetUserById(userId);
                if (existedUser == null)
                {
                    throw new Exception("未找到当前可修改用户");
                }

                if (string.IsNullOrEmpty(this.userName_txt.Text))
                {
                    MessageBox.Show("用户姓名不能为空");
                    return;
                }

                if (DateTime.Parse(this.userExpire_dp.Text) < DateTime.Now)
                {
                    MessageBox.Show("会员过期时间不能小于或等于当前时间");
                    return;
                }

                User createUser = new User()
                {
                    Id = userId,
                    Birthday = DateTime.Parse(this.userBirthday_dp.Text),
                    ExpireTime = DateTime.Parse(this.userExpire_dp.Text),
                    Comments = this.userComments_txt.Text,
                    Mobile = this.userMobile_txt.Text,
                    Name = this.userName_txt.Text,
                    Sex = this.checkBox1.Checked ? this.checkBox1.Text : this.checkBox2.Text
                };
                BizManager.UsersBiz.UpdateUser(createUser);
                this.Hide();
                succcessCallBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
