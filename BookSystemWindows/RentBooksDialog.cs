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
    public partial class RentBooksDialog : Form
    {
        private string bookNumber = string.Empty;
        private delegate void SuccessCallBackEventHandler();
        SuccessCallBackEventHandler successCallback;
        private Guid rentUserId = Guid.Empty;


        public RentBooksDialog(string bookNumber, Action action)
        {
            InitializeComponent();
            this.bookNumber = bookNumber;
            if (action != null)
            {
                successCallback = new SuccessCallBackEventHandler(action);
            }
            initlizationBookInfo(bookNumber);
            this.userId_txt.Visible = false;
        }

        private void initlizationBookInfo(string bookNumber)
        {
            var bookInfo = BizManager.BooksBiz.GetBookByBookNumber(bookNumber);
            if (bookInfo == null)
            {
                MessageBox.Show("借书信息出错");
                return;
            }

            this.bookName_txt.Text = bookInfo.Name;
            this.bookNumber_txt.Text = bookInfo.BookNumber;
            var bookTypes = BizManager.BooksBiz.GetBookTypes();
            this.bookType_txt.Text = bookTypes[bookInfo.Type];
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            successCallback();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var book = BizManager.BooksBiz.GetBookByBookNumber(this.bookNumber_txt.Text);

                if (book == null)
                {
                    MessageBox.Show("未找到可借阅的书籍");
                    return;
                }

                if (DateTime.Parse(this.bookRentDate_dp.Text) >= DateTime.Parse(this.bookReturn_dp.Text))
                {
                    MessageBox.Show("借书日期不能小于或等于还书日期");
                    return;
                }

                if (string.IsNullOrEmpty(this.userId_txt.Text))
                {
                    MessageBox.Show("用户信息不能为空");
                    return;
                }

                var rentDate = DateTime.Parse(this.bookRentDate_dp.Text);
                var returnDate = DateTime.Parse(this.bookReturn_dp.Text);
                var actualReturnDate = new DateTime(1900, 1, 1);

                RentBook rb = new RentBook()
                {
                    Id = Guid.NewGuid(),
                    BookId = book.Id,
                    UserId = Guid.Parse(this.userId_txt.Text),
                    IsReturn = false,
                    RentDate = rentDate,
                    ReturnDate = returnDate,
                    ActualReturnDate = actualReturnDate,
                    Comments = string.Empty
                };

                BizManager.UserRentBiz.RentBook(rb);
                this.Hide();
                successCallback();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectUser_btn_Click(object sender, EventArgs e)
        {
            UserDetailPage userPage = new UserDetailPage("RentBook", (data) =>
            {
                this.userInfo_txt.Text = data.Item2;
                this.userId_txt.Text = data.Item1.ToString();
            });
            userPage.ShowDialog();
        }
    }
}
