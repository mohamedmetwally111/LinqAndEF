using LinqAndEF03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndEF03.Configration_Classes
{
    internal class BookConfiguratio : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> b)
        {
            b.Property((c) => c.Title)
                .IsRequired()
                .HasMaxLength(150);

            b.Property((c) => c.Price)
                .HasColumnType("decimal(8,2)");

            b.Property((c) => c.PublishedDate);
                
        }
    }
}
