﻿using System;

namespace YourJarvis.ApplicationCore.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }
        public DateTime ContactDate { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactBody { get; set; }
        public string ContactPhone { get; set; }
    }
}