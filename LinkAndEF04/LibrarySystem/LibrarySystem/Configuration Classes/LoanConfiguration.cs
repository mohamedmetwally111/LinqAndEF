using LibrarySystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Configuration_Classes
{
    internal class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.HasKey((l) => new { l.BorrowerId, l.BookId });

            builder.HasOne((l) => l.Book)
                .WithMany((b) => b.Loans)
                .HasForeignKey((l) => l.BookId);

            builder.HasOne((l) => l.Borrower)
                .WithMany((b) => b.Loans)
                .HasForeignKey((l) => l.BorrowerId);


        }
    }
}
