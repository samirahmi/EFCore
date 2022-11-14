using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_EFCore.DataBase
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<StudentCourses> StudentCourses { get; set; } //Table Conjuction
        public DbSet<Parent> Parents { get; set; }
        public DbSet<vw_StudentAddress> vw_StudentAddresses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=localhost;Username=postgres;Password=sami;Database=SchoolDB; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourses>().HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<Teacher>().HasData(
                new { TeacherId = 1, FirstName = "Andik", LastName = "Rain" },
                new { TeacherId = 2, FirstName = "Hinata", LastName = "Shoyo" },
                new { TeacherId = 3, FirstName = "Sami", LastName = "Rahmi" },
                new { TeacherId = 4, FirstName = "Uzumaki", LastName = "Naruto" },
                new { TeacherId = 5, FirstName = "Tobio", LastName = "Kageyama" }
                );

            modelBuilder.Entity<Parent>().Property(p => p.ParentId).HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<Parent>().HasData(
                new Parent() { ParentId = Guid.NewGuid(), ParentName = "Fugaku", Address = "Konoha" },
                new Parent() { ParentId = Guid.NewGuid(), ParentName = "Hatake", Address = "Miyagi" }
                );

            modelBuilder.Entity<vw_StudentAddress>(
                vsa =>
                {
                    vsa.HasNoKey();
                    vsa.ToView("view_studentadress");
                });

            modelBuilder.Entity<Student>().Property(lu => lu.LastUpdate).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Student>().Property(lu => lu.LastUpdate).HasDefaultValueSql("Now()");

            modelBuilder.Entity<Student>().Property(g => g.Gender)
                .HasConversion(
                eg => eg.ToString(),
                eg => (Gender)Enum.Parse(typeof(Gender), eg)
                );
        }

    }
}
