﻿using System.Collections.Generic;

namespace BookCluster.API.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Book[] Books { get; set; }
    }
}