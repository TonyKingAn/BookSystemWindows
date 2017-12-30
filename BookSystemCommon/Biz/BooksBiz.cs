using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSystemCommon.Models.Biz
{
    public class BooksBiz
    {
        public Dictionary<string, string> GetBookTypes()
        {

            using (var db = Heart.CreateBookDbContext())
            {
                var bookTypes = db.BookTypes.ToList();
                Dictionary<string, string> bookType = new Dictionary<string, string>();
                if (bookTypes.Any())
                {
                    foreach (var type in bookTypes)
                    {
                        bookType.Add(type.TypeName, type.TypeName);
                    }
                }
                else
                {
                    bookType.Add("Default", "没有图书类型请创建新类型");
                }

                return bookType;
            }
        }

        public void CreateBookType(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                throw new Exception("创建书籍类型出错");
            }
            using (var db = Heart.CreateBookDbContext())
            {
                if (db.BookTypes.Any(bt => bt.TypeName == typeName))
                {
                    MessageBox.Show("请勿重复创建书籍类型");
                    return;
                }

                BookType type = new BookType()
                {
                    Id = Guid.NewGuid(),
                    CreatedTime = DateTime.Now,
                    TypeName = typeName
                };
                db.BookTypes.Add(type);
                db.SaveChanges();
            }
        }

        public void DeleteBookType(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                MessageBox.Show("删除书籍类型出错");
                return;
            }
            using (var db = Heart.CreateBookDbContext())
            {
                var existed = db.BookTypes.FirstOrDefault(bt => bt.TypeName == typeName);
                if (existed == null)
                {
                    MessageBox.Show("未找到可以删除的书籍类型");
                    return;
                }

                db.BookTypes.Remove(existed);
                db.SaveChanges();
            }
        }

        public List<string> GetBookTypeList()
        {
            using (var db = Heart.CreateBookDbContext())
            {
                return db.BookTypes.OrderByDescending(b => b.CreatedTime).Select(b => b.TypeName).ToList();
            }
        }

        public Book GetBookByBookNumber(string bookNumber)
        {
            using (var db = Heart.CreateBookDbContext())
            {
                return db.Books.FirstOrDefault(b => b.BookNumber == bookNumber);
            }
        }

        public Book GetBookByBookId(Guid bookId)
        {
            using (var db = Heart.CreateBookDbContext())
            {
                return db.Books.FirstOrDefault(b => b.Id == bookId);
            }
        }

        public bool CreateBook(Book source)
        {
            var result = false;
            using (var db = Heart.CreateBookDbContext())
            {
                var existedBook = db.Books.FirstOrDefault(b => b.BookNumber == source.BookNumber);
                if (existedBook != null)
                {
                    MessageBox.Show("书籍编码已存在");
                    return false;
                }
                var createBook = new Book()
                {
                    Id = Guid.NewGuid(),
                    BookNumber = source.BookNumber,
                    Name = source.Name,
                    Type = source.Type,
                    CreatedTime = DateTime.Now
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
                MessageBox.Show("无法找到更新的图书");
                return;
            }

            using (var db = Heart.CreateBookDbContext())
            {
                var source = db.Books.FirstOrDefault(b => b.BookNumber == updateSource.BookNumber);

                if (source != null)
                {
                    db.Books.Attach(source);
                    source.Name = updateSource.Name;
                    source.Type = updateSource.Type;

                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("未找到当前图书");
                    return;
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
