using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkAndEF04.Models
{
    internal class Customer
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public List<Order> Orders { get; set; }
    }
}
