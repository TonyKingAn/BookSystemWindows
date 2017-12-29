﻿using BookSystemCommon.Models;
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
            "剩余时间",
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
                var books = db.Books.ToList();

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
                        item.SubItems.Add((rentBook.ReturnDate.Day - rentBook.RentDate.Day).ToString());
                        item.SubItems.Add((rentBook.ReturnDate.Day - DateTime.Now.Day).ToString());
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
            var bookNumber = this.BookDetailList.SelectedItems[0].SubItems[0].Text;

            if (BizManager.UserRentBiz.IsBookRented(bookNumber))
            {

            }
            var rentBooksDialog = new RentBooksDialog(bookNumber, () => { InitializeBookDetails(); });
            rentBooksDialog.ShowDialog();
        }

        private void ReturnBooks_Click(object sender, EventArgs e)
        {

        }

        private void userDetailTip_Click(object sender, EventArgs e)
        {
            UserDetailPage uPage = new UserDetailPage();
            uPage.ShowDialog();
        }
    }
}
