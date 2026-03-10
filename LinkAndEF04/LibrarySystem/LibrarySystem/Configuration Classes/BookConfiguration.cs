using LibrarySystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Configuration_Classes
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Book> builder)
        {
            builder.HasOne((b) => b.Author)
                .WithMany((A) => A.Books)
                .HasForeignKey((b) => b.AuthorID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany((b)=>b.Loans)
                .WithOne((l) => l.Book)
                .HasForeignKey((l)=>l.BookId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
