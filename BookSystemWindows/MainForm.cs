using BookSystemCommon.Models;
using BookSystemCommon.Models.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
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

        // 修改header会影响删除，修改的问题
        private List<string> bookDetailHeaders = new List<string>() {
            "书号",
            "书名",
            "类型",
            "是否可借",
            "借阅人",
            "租借日期",
            "租借天数",
            "间隔时间",
            "状态"
        };

        private void InitializeBookDetails()
        {
            ClearListView();

            // prepare column hearder
            foreach (var headerName in bookDetailHeaders)
            {
                ColumnHeader clh = new ColumnHeader();
                clh.Text = headerName;
                BookDetailList.Columns.Add(clh);
            }

            using (var db = Heart.CreateBookDbContext())
            {
                //  var user = db.Users.ToList();
                var books = db.Books.OrderBy(b => b.BookNumber).ToList();

                foreach (var book in books)
                {
                    ListViewItem item = new ListViewItem(book.BookNumber);
                    //item.SubItems.Add(book.BookNumber);
                    var bookType = BizManager.BooksBiz.GetBookTypes();
                    item.SubItems.Add(book.Name);
                    item.SubItems.Add(bookType[book.Type]);
                    item.SubItems.Add(db.RentBooks.Any(rb => rb.BookId == book.Id && rb.IsReturn == false) ? "不可借阅" : "可借阅");
                    // user's properties
                    var rentBook = BizManager.UserRentBiz.GetRentInfoByBookId(book.Id);
                    if (rentBook != null)
                    {
                        var user = BizManager.UsersBiz.GetUserById(rentBook.UserId);
                        item.SubItems.Add(user.Name);
                        item.SubItems.Add(rentBook.RentDate.ToString("yyyy年MM月dd日"));
                        var rentDays = rentBook.ReturnDate - rentBook.RentDate;
                        item.SubItems.Add(Math.Ceiling(rentDays.TotalDays).ToString());
                        var day = rentBook.ReturnDate - DateTime.Now;
                        item.SubItems.Add(Math.Ceiling(day.TotalDays).ToString());
                        item.SubItems.Add(rentBook.ReturnDate < DateTime.Now ? "已超期" : "正常");     //状态 [8]
                        item.SubItems.Add(rentBook.Id.ToString());// rent id [9]
                    }

                    this.BookDetailList.Items.Add(item);
                }
            }
            dynamicSizeChange();
        }

        private void UpdateBookDetails(string keyword)
        {
            ClearListView();

            // prepare column hearder
            foreach (var headerName in bookDetailHeaders)
            {
                ColumnHeader clh = new ColumnHeader();
                clh.Text = headerName;
                BookDetailList.Columns.Add(clh);
            }

            using (var db = Heart.CreateBookDbContext())
            {
                List<Book> books = new List<Book>();
                if (string.IsNullOrEmpty(keyword))
                {
                    books = db.Books.OrderBy(b => b.BookNumber).ToList();
                }
                else
                {
                    books = db.Books.Where(b => b.BookNumber.Contains(keyword) || b.Name.Contains(keyword)).OrderBy(b => b.BookNumber).ToList();
                }

                foreach (var book in books)
                {
                    ListViewItem item = new ListViewItem(book.BookNumber);
                    //item.SubItems.Add(book.BookNumber);
                    var bookType = BizManager.BooksBiz.GetBookTypes();
                    item.SubItems.Add(book.Name);
                    item.SubItems.Add(bookType[book.Type]);
                    item.SubItems.Add(db.RentBooks.Any(rb => rb.BookId == book.Id && rb.IsReturn == false) ? "不可借阅" : "可借阅");
                    // user's properties
                    var rentBook = BizManager.UserRentBiz.GetRentInfoByBookId(book.Id);
                    if (rentBook != null)
                    {
                        var user = BizManager.UsersBiz.GetUserById(rentBook.UserId);
                        item.SubItems.Add(user.Name);
                        item.SubItems.Add(rentBook.RentDate.ToString("yyyy年MM月dd日"));
                        var rentDays = rentBook.ReturnDate - rentBook.RentDate;
                        item.SubItems.Add(Math.Ceiling(rentDays.TotalDays).ToString());
                        var day = rentBook.ReturnDate - DateTime.Now;
                        item.SubItems.Add(Math.Ceiling(day.TotalDays).ToString());
                        item.SubItems.Add(rentBook.ReturnDate < DateTime.Now ? "已超期" : "正常");     //状态 [8]
                        item.SubItems.Add(rentBook.Id.ToString());// rent id [9]
                    }

                    this.BookDetailList.Items.Add(item);
                }
            }
            dynamicSizeChange();
        }

        private void ClearListView()
        {
            this.BookDetailList.Clear();
        }

        private void CreateBooks(object sender, EventArgs e)
        {
            var createBookDialog = new CreateBookDialog(() => { InitializeBookDetails(); });
            createBookDialog.ShowDialog();
        }

        private void listview_SizeChanged(object sender, EventArgs e)
        {
            dynamicSizeChange();
        }

        private void dynamicSizeChange()
        {
            int _Count = BookDetailList.Columns.Count;
            int _Width = BookDetailList.Width;
            foreach (ColumnHeader ch in BookDetailList.Columns)
            {
                ch.Width = _Width / _Count;
            }
        }

        private void UpdateBook_Click(object sender, EventArgs e)
        {
            if (this.BookDetailList.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要修改的书籍");
                return;
            }

            if (this.BookDetailList.SelectedItems.Count > 1)
            {
                MessageBox.Show("只能修改一本书，请勿多选");
                return;
            }

            var bookNumber = this.BookDetailList.SelectedItems[0].SubItems[0].Text;

            var updateBookDialog = new UpdateBookDialog(bookNumber, () => { InitializeBookDetails(); });
            updateBookDialog.ShowDialog();
        }

        private void DeleteBooks_Click(object sender, EventArgs e)
        {
            if (this.BookDetailList.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要删除的书籍");
                return;
            }

            using (var db = Heart.CreateBookDbContext())
            {
                List<Book> deleteBook = new List<Book>();
                string message = string.Empty;
                for (int i = 0; i < this.BookDetailList.SelectedItems.Count; i++)
                {
                    var bookNumber = this.BookDetailList.SelectedItems[i].SubItems[0].Text;
                    deleteBook.Add(db.Books.FirstOrDefault(b => b.BookNumber == bookNumber)); // 书号
                    if (BizManager.UserRentBiz.RelatedRent(bookNumber))
                    {
                        message += $"{bookNumber}";
                    }
                }

                if (!string.IsNullOrEmpty(message))
                {
                    message = message.TrimEnd(',') + "这些书籍有历史借阅记录，删除会影响数据统计，是否确认修改？";
                }
                else
                {
                    message = "是否要修改当前数据？";
                }

                var result = MessageBox.Show(message, "删除提示", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    db.Books.RemoveRange(deleteBook);
                    db.SaveChanges();
                    InitializeBookDetails();
                }
            }
        }

        private void RentBooks_Click(object sender, EventArgs e)
        {
            if (this.BookDetailList.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要借的书籍");
                return;
            }

            if (this.BookDetailList.SelectedItems.Count > 1)
            {
                MessageBox.Show("只能选择一本书");
                return;
            }

            var bookNumber = this.BookDetailList.SelectedItems[0].SubItems[0].Text;

            if (BizManager.UserRentBiz.IsBookRented(bookNumber))
            {
                MessageBox.Show("该书已借出，无法再借");
                return;
            }
            var rentBooksDialog = new RentBooksDialog(bookNumber, () => { InitializeBookDetails(); });
            rentBooksDialog.ShowDialog();
        }

        private void ReturnBooks_Click(object sender, EventArgs e)
        {
            if (this.BookDetailList.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要还的书籍");
                return;
            }

            if (this.BookDetailList.SelectedItems.Count > 1)
            {
                MessageBox.Show("一次只能返还一本书");
                return;
            }

            var bookNumber = this.BookDetailList.SelectedItems[0].SubItems[0].Text;
            var rentId = this.BookDetailList.SelectedItems[0].SubItems[9].Text;
            if (!BizManager.UserRentBiz.IsBookRented(bookNumber))
            {
                MessageBox.Show("该书未借出，不需要还书");
                return;
            }
            var rentBooksDialog = new ReturnBookDialog(Guid.Parse(rentId), () => { InitializeBookDetails(); });
            rentBooksDialog.ShowDialog();
        }

        private void userDetailTip_Click(object sender, EventArgs e)
        {
            UserDetailPage uPage = new UserDetailPage();
            uPage.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateBookDetails(this.keyword_txt.Text);
        }

        private void createBookType_btn_Click(object sender, EventArgs e)
        {
            CreateBookTypeDialog cbtDialog = new CreateBookTypeDialog();
            cbtDialog.ShowDialog();
        }
    }
}
