using System;
using System.Collections.Generic;
using System.Data;
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

        public string ImportBooks(string filePath)
        {
            var msg = new StringBuilder();
            var data = new DataTable();

            try
            {
                data = ExcelHelpers.ImportExcelToDataTable(filePath);
            }
            catch (Exception ex)
            {
                msg.AppendLine("导入失败！");
                msg.AppendLine("1.请确认模板是否正确，或者下载最新模板");
                msg.AppendLine("2.请确认Excel中没有空的行");
                msg.AppendLine("3.请勿对行进行增删操作");

                return msg.ToString();
            }

            if (data.Rows.Count == 0)
            {
                return "无法导入，图书信息为空";
            }

            var addBookList = new List<Book>();
            var bookTypeList = new List<BookType>();
            foreach (DataRow row in data.Rows)
            {
                var bookNumber = row["图书编号"].ToString();
                var name = row["图书名称"].ToString();
                var type = row["图书类型"].ToString();

                // validate requirement property
                //1. first to validate required property
                if (string.IsNullOrEmpty(bookNumber)
                    || string.IsNullOrEmpty(name)
                    || string.IsNullOrEmpty(type))
                {
                    msg.AppendLine($"必要字段缺失请检查图书编号，图书名称和图书类型.,行号：{data.Rows.IndexOf(row) + 1}");
                    continue;
                }

                // validate repetition book
                if (IsRepitionBook(bookNumber))
                {
                    msg.AppendLine($"该书已经存在，书名：{name},书籍编码：{bookNumber},行号：{data.Rows.IndexOf(row) + 1}");
                    continue;
                }

                // validate repetition book type
                if (!IsRepitionBookType(type))
                {
                    // add book type
                    var bookType = new BookType()
                    {
                        Id = Guid.NewGuid(),
                        TypeName = type,
                        CreatedTime = DateTime.Now
                    };

                    bookTypeList.Add(bookType);
                }

                // add book
                var book = new Book()
                {
                    Id = Guid.NewGuid(),
                    BookNumber = bookNumber,
                    CreatedTime = DateTime.Now,
                    Name = name,
                    Type = type
                };

                addBookList.Add(book);
            }

            using (var db = Heart.CreateBookDbContext())
            {
                db.Books.AddRange(addBookList);
                db.BookTypes.AddRange(bookTypeList);
                db.SaveChanges();
            }

            if (string.IsNullOrEmpty(msg.ToString()))
            {
                return "书籍导入成功";
            }
            return msg.ToString();
        }

        private bool IsRepitionBook(string bookNumber)
        {
            using (var db = Heart.CreateBookDbContext())
            {
                return db.Books.Any(b => b.BookNumber == bookNumber);
            }
        }

        private bool IsRepitionBookType(string bookTypeName)
        {
            using (var db = Heart.CreateBookDbContext())
            {
                return db.BookTypes.Any(b => b.TypeName == bookTypeName);
            }
        }
    }
}
