using System;
using System.Collections.Generic;
using System.Linq;

namespace proiectPaw.Entities
{
    class Product
    {
        public Guid Id { get;  set; }
        public Guid BatchId { get;  set; }
        public string Name { get;  set; }
        public string Category { get;  set; }
        public decimal Price { get;  set; }
    }
}
