using SigmaSchoolManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SigmaSchoolManager.Infrastructure.Data.Context
{
    public class SigmaSchoolManagerContext : DbContext
    {
        public SigmaSchoolManagerContext(DbContextOptions options) : base(options){}

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().ToTable("Student").Property(p => p.UpdatedAt).IsConcurrencyToken();
        }

    }
}
