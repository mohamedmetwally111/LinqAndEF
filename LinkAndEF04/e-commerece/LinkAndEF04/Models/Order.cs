using System;
using System.Collections.Generic;
using System.Text;

namespace LinkAndEF04.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        public List<OrderDetail> orderDetails { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
