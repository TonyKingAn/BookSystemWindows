using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystemCommon.Models
{
    public class Book
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string BookNumber { get; set; }

        public DateTime CreatedTime { get; set; }
    }
}
