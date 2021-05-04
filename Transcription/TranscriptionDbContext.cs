using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace Transcription
{

    public class TranscriptionDbContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public DbSet<TransccriptionProgram> TransccriptionPrograms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Transcription.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
            .HasOne<TransccriptionProgram>()
            .WithMany()
            .HasForeignKey(e => e.ProgramId);

        }
    }
}