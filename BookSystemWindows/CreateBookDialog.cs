using BookSystemWindows.Models;
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

            Dictionary<BookType, string> bookType = new Dictionary<BookType, string>();
            bookType.Add(BookType.Adult, "成人");
            bookType.Add(BookType.Childern, "儿童");
            BindingSource bs = new BindingSource();
            bs.DataSource = bookType;
            this.bookType_cb.DataSource = bs;
            bookType_cb.ValueMember = "Key";
            bookType_cb.DisplayMember = "Value";
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

            using (var db = Heart.CreateBookDbContext())
            {
                if (db.Books.Any(b => b.BookNumber == this.bookNumber_txt.Text))
                {
                    MessageBox.Show("已存在相同书籍编号的书");
                    return;
                }

                var type = (BookType)Enum.Parse(typeof(BookType), this.bookType_cb.SelectedValue.ToString());
                var createBook = new Book()
                {
                    Id = Guid.NewGuid(),
                    BookNumber = this.bookNumber_txt.Text,
                    Name = this.bookName_txt.Text,
                    Type = type
                };

                db.Books.Add(createBook);
                db.SaveChanges();
                this.Hide();
                callback();
            }
        }
    }
}
