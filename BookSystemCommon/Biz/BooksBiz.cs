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

    }
}
