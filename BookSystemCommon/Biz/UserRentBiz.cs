using System;
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
                    CreatedTime = DateTime.Now,
                    ActualReturnDate = new DateTime(1900, 1, 1)
                };

                db.RentBooks.Add(result);
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

        // one person just can rent 5 books
        public bool CanRentBook(Guid userId)
        {
            using (var db = Heart.CreateBookDbContext())
            {
                var books = db.RentBooks.Where(rb => rb.UserId == userId && rb.IsReturn == false);
                if (books.Count() > 5)
                {
                    throw new Exception("用户借阅超过五本，无法再借");
                }
            }
            return true;
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

        public RentBook GetRentInfoById(Guid rentId)
        {
            using (var db = Heart.CreateBookDbContext())
            {
                return db.RentBooks.FirstOrDefault(rb => rb.Id == rentId);
            }
        }

    }
}
