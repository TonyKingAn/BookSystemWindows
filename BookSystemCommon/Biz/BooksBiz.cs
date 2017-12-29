using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystemCommon.Models.Biz
{
    public class BooksBiz
    {
        public Dictionary<BookType, string> GetBookTypes()
        {
            Dictionary<BookType, string> bookType = new Dictionary<BookType, string>();
            bookType.Add(BookType.Adult, "成人");
            bookType.Add(BookType.Childern, "儿童");

            return bookType;
        }

        public bool CreateBook(Book source)
        {
            var result = false;
            using (var db = Heart.CreateBookDbContext())
            {
                var existedBook = db.Books.FirstOrDefault(b => b.BookNumber == source.BookNumber);
                if (existedBook != null)
                {
                    throw new Exception("书籍编码已存在");
                }
                var createBook = new Book()
                {
                    Id = Guid.NewGuid(),
                    BookNumber = source.BookNumber,
                    Name = source.Name,
                    Type = source.Type
                };

                db.Books.Add(createBook);
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        public void UpdateBook(Book updateSource)
        {
            if (updateSource == null)
            {
                throw new Exception("无法找到更新的图书");
            }

            using (var db = Heart.CreateBookDbContext())
            {
                var source = db.Books.FirstOrDefault(b => b.BookNumber == updateSource.BookNumber);

                if (source != null)
                {
                    var createBook = new Book()
                    {
                        Id = Guid.NewGuid(),
                        BookNumber = source.BookNumber,
                        Name = source.Name,
                        Type = source.Type
                    };

                    db.Books.Add(createBook);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("未找到当前图书");
                }
            }
        }

        public void DeleteBook(List<string> bookNumbers)
        {
            if (!bookNumbers.Any())
            {
                return;
            }
            using (var db = Heart.CreateBookDbContext())
            {
                var deleteBooks = new List<Book>();

                foreach (var bookNumber in bookNumbers)
                {
                    var existedBook = db.Books.FirstOrDefault(b => b.BookNumber == bookNumber);
                    deleteBooks.Add(existedBook);
                }

                db.Books.RemoveRange(deleteBooks);
                db.SaveChanges();
            }
        }


    }
}
