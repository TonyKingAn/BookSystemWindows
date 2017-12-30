using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystemCommon.Models
{
    [Table("BookType")]
    public class BookType
    {
        public Guid Id { get; set; }

        public string TypeName { get; set; }

        public DateTime CreatedTime { get; set; }

    }
}
