﻿using BookSystemCommon.Models;
using BookSystemCommon.Models.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookSystemWindows
{
    public partial class CreateBookDialog : Form
    {

        public delegate void CreateBookEventHandler();
        CreateBookEventHandler callback;
        public CreateBookDialog(Action action)
        {
            if (action != null)
            {
                callback = new CreateBookEventHandler(action);
            }

            InitializeComponent();

            var bookType = BizManager.BooksBiz.GetBookTypes();
            if(bookType != null)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = bookType;
                this.bookType_cb.DataSource = bs;
                bookType_cb.ValueMember = "Key";
                bookType_cb.DisplayMember = "Value";
            }
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.bookName_txt.Text))
            {
                MessageBox.Show("书名不能为空");
                return;
            }
            else if (string.IsNullOrEmpty(this.bookNumber_txt.Text))
            {
                MessageBox.Show("书籍编号不能为空");
                return;
            }

            if(this.bookType_cb.SelectedValue.ToString() == "没有图书类型请创建新类型")
            {
                MessageBox.Show("没有图书类型无法创建图书");
                return;
            }

            using (var db = Heart.CreateBookDbContext())
            {
                if (db.Books.Any(b => b.BookNumber == this.bookNumber_txt.Text))
                {
                    MessageBox.Show("已存在相同书籍编号的书");
                    return;
                }

                var type = this.bookType_cb.SelectedValue.ToString();
                var createBook = new Book()
                {
                    Id = Guid.NewGuid(),
                    BookNumber = this.bookNumber_txt.Text,
                    Name = this.bookName_txt.Text,
                    Type = type
                };

                BizManager.BooksBiz.CreateBook(createBook);
                this.Hide();
                callback();
            }
        }
    }
}
