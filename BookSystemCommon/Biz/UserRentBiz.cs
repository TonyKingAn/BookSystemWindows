using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystemCommon.Models.Biz
{
    public class UserRentBiz
    {

        public void RentBook(RentBook source)
        {
            using (var db = Heart.CreateBookDbContext())
            {
                var result = new RentBook()
                {
                    BookId = source.BookId,
                    Id = Guid.NewGuid(),
                    RentDate = source.RentDate,
                    Comments = source.Comments,
                    IsReturn = false,
                    ReturnDate = new DateTime(1900, 0, 0),
                    UserId = source.UserId
                };


            }

        }

    }
}
