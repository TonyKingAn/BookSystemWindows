using BookSystemCommon.Models;
using BookSystemCommon.Models.Biz;
using System;
using System.Windows.Forms;

namespace BookSystemWindows
{
    public partial class CreateUserDialog : Form
    {
        private delegate void SuccessCallBackEventHandler();

        SuccessCallBackEventHandler successCallback;
        public CreateUserDialog(Action callback)
        {
            InitializeComponent();
            if (callback != null)
            {
                successCallback = new SuccessCallBackEventHandler(callback);
            }
        }

        private void resetBtn_Click(object sender, System.EventArgs e)
        {
            this.userBirthday_dp.Text = DateTime.Now.ToString();
            this.expireDate_dp.Text = DateTime.Now.ToString();
            this.userComments_txt.Text = string.Empty;
            this.userMobile_txt.Text = string.Empty;
            this.userName_txt.Text = string.Empty;
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.userName_txt.Text))
                {
                    MessageBox.Show("用户姓名不能为空");
                }

                if (DateTime.Parse(this.expireDate_dp.Text) < DateTime.Now)
                {
                    MessageBox.Show("会员过期时间不能小于或等于当前时间");
                    return;
                }

                User createUser = new User()
                {
                    Id = Guid.NewGuid(),
                    Birthday = DateTime.Parse(this.userBirthday_dp.Text),
                    ExpireTime = DateTime.Parse(this.expireDate_dp.Text),
                    Comments = this.userComments_txt.Text,
                    Mobile = this.userMobile_txt.Text,
                    Name = this.userName_txt.Text
                };
                BizManager.UsersBiz.CreateUser(createUser);
                this.Hide();
                successCallback();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
