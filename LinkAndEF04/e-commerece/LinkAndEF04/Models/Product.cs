using System;
using System.Collections.Generic;
using System.Text;

namespace LinkAndEF04.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
