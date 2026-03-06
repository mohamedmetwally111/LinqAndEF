using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LinqAndEF03.Models
{
    
//  Q1: Why did the property "Id" become a Primary Key without any explicit configuration?
//  Answer: By EF Core convention, any property named Id or ClassNameId 
//          is automatically configured as the Primary Key.

//  Q2: Why is "Country" nullable in the database while "Price" is not?
//  Answer: Country is a string  which is nullable by default in C#. 
//          Price is likely a decimal or double which is non-nullable
//          unless explicitly defined as nullable
//
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime? PublishedDate { get; set; }
    }
}
