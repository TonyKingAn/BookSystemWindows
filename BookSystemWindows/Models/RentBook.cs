﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystemWindows.Models
{
    public class RentBook
    {
        public Guid Id { get; set; }

        public Guid BookId { get; set; }

        public Guid UserId { get; set; }

        public DateTime RentDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public string Comments { get; set; }

        public bool IsReturn { get; set; }
    }
}