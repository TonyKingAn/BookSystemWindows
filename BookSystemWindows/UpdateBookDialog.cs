using BookSystemCommon.Models;
using BookSystemCommon.Models.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookSystemWindows
{
    public partial class UpdateBookDialog : Form
    {
        private string orignialBookNumber = string.Empty;
        private delegate void SuccessEventHandler();
        SuccessEventHandler successCallBack;

        public UpdateBookDialog(string bookNumber, Action action)
        {
            InitializeComponent();
            orignialBookNumber = bookNumber;
            if (action != null)
            {
                successCallBack = new SuccessEventHandler(action);
            }
            InitlizationBook(bookNumber);
        }

        private void InitlizationBook(string bookNumber)
        {
            using (var db = Heart.CreateBookDbContext())
            {
                var book = db.Books.FirstOrDefault(b => b.BookNumber == bookNumber);

                if (book != null)
                {
                    this.bookName_txt.Text = book.Name;
                    var bookType = BizManager.BooksBiz.GetBookTypes();
                    BindingSource bs = new BindingSource();
                    bs.DataSource = bookType;
                    this.bookType_cb.DataSource = bs;
                    bookType_cb.ValueMember = "Key";
                    bookType_cb.DisplayMember = "Value";
                    bookType_cb.Text = bookType[book.Type];
                    this.bookNumber_txt.Text = book.BookNumber;
                }
            }
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            using (var db = Heart.CreateBookDbContext())
            {
                var existedBook = db.Books.FirstOrDefault(b => b.BookNumber == orignialBookNumber);
                if (existedBook == null)
                {
                    MessageBox.Show("未找到可更改的书籍");
                }

                var message = string.Empty;
                var rendtDetail = db.RentBooks.Where(rb => rb.BookId == existedBook.Id);
                if (rendtDetail.Any())
                {
                    message = "当前书籍具有历史数据，更改会造成历史错误，确认强制修改吗？";
                }
                else
                {
                    message = "确定修改当前书籍吗？";
                }

                DialogResult result = MessageBox.Show(message, "书籍修改", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    var type = (BookType)Enum.Parse(typeof(BookType), this.bookType_cb.SelectedValue.ToString());
                    var createBook = new Book()
                    {
                        BookNumber = this.bookNumber_txt.Text,
                        Name = this.bookName_txt.Text,
                        Type = type
                    };
                    BizManager.BooksBiz.UpdateBook(createBook);
                }
                this.Hide();
                successCallBack();
            }
        }
    }
}
