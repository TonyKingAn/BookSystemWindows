using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystemCommon.Models
{
    public class BookDbContext : DbContext
    {

        public DbSet<Book> Books { get; set; }

        public DbSet<RentBook> RentBooks { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<BookType> BookTypes { get; set; }

        public BookDbContext(string connectionString) : base(connectionString)
        {

        }

    }
}
