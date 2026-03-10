using System;
using System.Collections.Generic;
using System.Text;

namespace LinkAndEF04.Models
{
    internal class OrderDetail
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
    }
}
