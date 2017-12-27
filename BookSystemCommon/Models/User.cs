﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystemCommon.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Mobile { get; set; }

        public DateTime Birthday { get; set; }

        public DateTime ExpireTime { get; set; }

        public string Comments { get; set; }
    }
}
