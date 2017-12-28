using System.Configuration;

namespace BookSystemCommon.Models
{
    public static class Heart
    {

        public static BookDbContext CreateBookDbContext()
        {
            return new BookDbContext(ConfigurationManager.AppSettings["connectionString"]);
        }
    }
}
