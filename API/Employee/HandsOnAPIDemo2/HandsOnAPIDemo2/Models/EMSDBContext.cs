using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HandsOnAPIDemo2.Models
{
    public partial class EMSDBContext : DbContext
    {
        public EMSDBContext()
        {
        }

        public EMSDBContext(DbContextOptions<EMSDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Project> Project { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-A63MUHA\\SQLEXPRESS;Initial Catalog=EMSDB;User ID=sa;Password=pass@word1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Eid);

                entity.HasIndex(e => e.Pid);

                entity.Property(e => e.Eid)
                    .HasColumnName("eid")
                    .HasMaxLength(5);

                entity.Property(e => e.Designation)
                    .HasColumnName("designation")
                    .HasMaxLength(20);

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasColumnName("ename")
                    .HasMaxLength(30);

                entity.Property(e => e.Joindate)
                    .HasColumnName("joindate")
                    .HasColumnType("date");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Salary)
                    .HasColumnName("salary")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.Pid);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.Pid);

                entity.ToTable("project");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("date");

                entity.Property(e => e.Pname)
                    .IsRequired()
                    .HasColumnName("pname")
                    .HasMaxLength(30);

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
