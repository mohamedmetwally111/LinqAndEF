using LibrarySystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Configuration_Classes
{
    internal class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasMany((A) => A.Books)
                .WithOne((b) => b.Author)
                .HasForeignKey((b)=>b.AuthorID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
