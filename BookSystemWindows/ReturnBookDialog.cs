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
    public partial class ReturnBookDialog : Form
    {
        private Action successCallback;
        private Guid orignalRentId = Guid.Empty;

        public ReturnBookDialog(Guid rentId, Action action)
        {
            InitializeComponent();
            if (action != null)
            {
                successCallback = action;
            }
            orignalRentId = rentId;
            initlizationBookInfo(rentId);
        }
        private void initlizationBookInfo(Guid rentId)
        {
            var rentInfo = BizManager.UserRentBiz.GetRentInfoById(rentId);
            if (rentInfo == null)
            {
                MessageBox.Show("该书租借信息出错");
                return;
            }

            var bookInfo = BizManager.BooksBiz.GetBookByBookId(rentInfo.BookId);
            if (bookInfo == null)
            {
                MessageBox.Show("借书信息出错");
                return;
            }

            var user = BizManager.UsersBiz.GetUserById(rentInfo.UserId);

            this.bookName_txt.Text = bookInfo.Name;
            this.bookNumber_txt.Text = bookInfo.BookNumber;
            var bookTypes = BizManager.BooksBiz.GetBookTypes();
            this.bookType_txt.Text = bookTypes[bookInfo.Type];
            this.userInfo_txt.Text = user.Name;
        }


        private void submit_btn_Click(object sender, EventArgs e)
        {
            var actualReturnDate = DateTime.Parse(this.bookReturn_dp.Text);

            using (var db = Heart.CreateBookDbContext())
            {
                var rentInfo = db.RentBooks.FirstOrDefault(rb => rb.Id == orignalRentId);
                if (rentInfo == null)
                {
                    MessageBox.Show("未找到还书信息");
                    return;
                }

                if (actualReturnDate < rentInfo.RentDate)
                {
                    MessageBox.Show("还书时间不能小于借书时间");
                }

                if (actualReturnDate > DateTime.Now)
                {
                    MessageBox.Show("还书时间不能大于当前时间");
                }

                db.RentBooks.Attach(rentInfo);
                rentInfo.ActualReturnDate = actualReturnDate;
                rentInfo.IsReturn = true;
                db.SaveChanges();
            }

            this.Hide();
            successCallback();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            successCallback();
        }
    }
}
