using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndEF03.Models
{
    //internal class Author
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string? Country { get; set; }
    //}

    //Data Annotations
    [Table("Writers")]
    internal class Author
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string? Country { get; set; }
    }
}
