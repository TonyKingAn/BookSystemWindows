using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystemWindows.Models
{
    public class BookDbContext : DbContext
    {

        public BookDbContext(string connectionString) : base(connectionString)
        {

        }

    }
}
