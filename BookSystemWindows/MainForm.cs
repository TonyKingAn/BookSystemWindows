﻿using BookSystemCommon.Models;
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
            "是否可借",
            "借阅人",
            "租借日期",
            "租借天数",
            "剩余时间",
            "操作"
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
                    item.SubItems.Add(book.Name);
                    item.SubItems.Add(db.RentBooks.Any(rb => rb.BookId == book.Id && rb.IsReturn == false) ? "不可借阅" : "可借阅");
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

        private void CreateUserTip_Click(object sender, EventArgs e)
        {
            var createUserDialog = new CreateUserDialog(() => { InitializeBookDetails(); });
            createUserDialog.ShowDialog();

        }

        private void UpdateUserTip_Click(object sender, EventArgs e)
        {
            var updateUserDialog = new UpdateUserDialog();
            updateUserDialog.ShowDialog();
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
            if (this.BookDetailList.SelectedItems.Count > 1)
            {
                MessageBox.Show("只能修改一本书，请勿多选");
            }

            var bookNumber = this.BookDetailList.SelectedItems[0].SubItems[0].Text;

            var updateBookDialog = new UpdateBookDialog(bookNumber);
            updateBookDialog.ShowDialog();
        }

        private void DeleteBooks_Click(object sender, EventArgs e)
        {
            using (var db = Heart.CreateBookDbContext())
            {
                List<Book> deleteBook = new List<Book>();
                string message = string.Empty;
                for (int i = 0; i < this.BookDetailList.SelectedItems.Count; i++)
                {
                    var bookNumber = this.BookDetailList.SelectedItems[i].SubItems[0].Text;
                    deleteBook.Add(db.Books.FirstOrDefault(b => b.BookNumber == bookNumber)); // 书号
                }

                db.Books.RemoveRange(deleteBook);
                db.SaveChanges();
                InitializeBookDetails();
            }
        }

        private void RentBooks_Click(object sender, EventArgs e)
        {
            var rentBooksDialog = new RentBooksDialog();
            rentBooksDialog.ShowDialog();
        }

        private void ReturnBooks_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userDetailTip_Click(object sender, EventArgs e)
        {
            UserDetailPage uPage = new UserDetailPage();
            uPage.ShowDialog();
        }
    }
}
