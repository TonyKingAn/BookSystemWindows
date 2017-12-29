﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSystemCommon.Models.Biz
{
    public class UserRentBiz
    {

        public void RentBook(RentBook source)
        {
            if (source == null)
            {
                throw new Exception("借用书籍出错");
            }

            using (var db = Heart.CreateBookDbContext())
            {
                var result = new RentBook()
                {
                    BookId = source.BookId,
                    Id = Guid.NewGuid(),
                    RentDate = source.RentDate,
                    Comments = source.Comments,
                    IsReturn = false,
                    ReturnDate = source.ReturnDate,
                    UserId = source.UserId,
                    ActualReturnDate = new DateTime(1900, 0, 0)
                };

                db.RentBooks.Add(result);
                db.SaveChanges();
            }
        }

        public void ReturnBook(RentBook source)
        {
            if (source == null)
            {
                throw new Exception("借用书籍出错");
            }

            using (var db = Heart.CreateBookDbContext())
            {
                var existed = db.RentBooks.FirstOrDefault(rb => rb.Id == source.Id);

                if (existed == null)
                {
                    throw new Exception("未找到可还书籍");
                }

                db.RentBooks.Attach(existed);
                existed.ActualReturnDate = source.ActualReturnDate;
                existed.Comments = source.Comments;
                db.SaveChanges();
            }
        }

        // we support keyword could be book number or userId
        public bool RelatedRent(string keyWord)
        {
            using (var db = Heart.CreateBookDbContext())
            {
                var book = db.Books.FirstOrDefault(b => b.BookNumber == keyWord);
                if (book != null)
                {
                    return db.RentBooks.Any(rb => rb.BookId == book.Id);
                }

                var userId = Guid.Parse(keyWord);

                return db.RentBooks.Any(rb => rb.UserId == userId);
            }
        }

        public bool IsBookRented(string bookNumber)
        {
            using (var db = Heart.CreateBookDbContext())
            {

                var book = db.Books.FirstOrDefault(b => b.BookNumber == bookNumber);
                if (book == null)
                {
                    MessageBox.Show("未找到当前书籍");
                }

                return db.RentBooks.Any(rb => rb.BookId == book.Id && rb.IsReturn == false);
            }
        }

        public RentBook GetRentInfoByBookId(Guid bookId)
        {
            using (var db = Heart.CreateBookDbContext())
            {
                return db.RentBooks.FirstOrDefault(rb => rb.BookId == bookId && rb.IsReturn == false);
            }
        }

    }
}
