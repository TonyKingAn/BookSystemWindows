using BookSystemCommon.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystemWindows
{
    public static class Heart
    {

        public static BookDbContext CreateBookDbContext()
        {
            return new BookDbContext(ConfigurationManager.AppSettings["connectionString"]);
        }
    }
}
