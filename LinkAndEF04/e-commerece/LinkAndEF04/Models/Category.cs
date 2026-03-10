using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace LinkAndEF04.Models
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set; }

    }
}
