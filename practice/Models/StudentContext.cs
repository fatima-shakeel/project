using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace practice.Models
{
    public partial class StudentContext : DbContext
    {
        public StudentContext()
        {
        }

        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<StudentInfo> StudentInfo { get; set; }

       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=FATIMA-SHAKEEL;Database=Student;Trusted_Connection=True;User ID=sa; Password=fatima;");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.City).HasMaxLength(10);

                entity.Property(e => e.Cv)
                    .HasColumnName("CV")
                    .HasMaxLength(250);

                entity.Property(e => e.Department).HasMaxLength(10);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FatherName)
                    .HasColumnName("Father_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.MotherName)
                    .HasColumnName("Mother_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(10);

                entity.Property(e => e.ProfilePicture)
                    .HasColumnName("Profile_Picture")
                    .HasMaxLength(250);

                entity.Property(e => e.RollNo)
                    .HasColumnName("Roll_No")
                    .HasMaxLength(10);

                entity.Property(e => e.Section).HasMaxLength(10);

                entity.Property(e => e.Subject).HasMaxLength(50);
            });
        }
    }
}
