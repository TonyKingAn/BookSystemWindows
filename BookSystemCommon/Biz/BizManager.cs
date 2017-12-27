using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystemCommon.Models.Biz
{
    public class BizManager
    {
        private static Lazy<BooksBiz> booksBiz = new Lazy<BooksBiz>();
        private static Lazy<UsersBiz> usersBiz = new Lazy<UsersBiz>();
        private static Lazy<UserRentBiz> userRentBiz = new Lazy<UserRentBiz>();

        public BizManager() { }

        public static BooksBiz BooksBiz { get { return booksBiz.Value; } }

        public static UsersBiz UsersBiz { get { return usersBiz.Value; } }

        public static UserRentBiz UserRentBiz { get { return userRentBiz.Value; } }
    }
}
