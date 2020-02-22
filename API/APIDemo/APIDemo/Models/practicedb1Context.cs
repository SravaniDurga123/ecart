using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace APIDemo.Models
{
    public partial class practicedb1Context : DbContext
    {
        public practicedb1Context()
        {
        }

        public practicedb1Context(DbContextOptions<practicedb1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<WorksOn> WorksOn { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-A63MUHA\\SQLEXPRESS;Database=practicedb1;Trusted_Connection=True;User ID=sa;Password=pass@word1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("customers");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Companyname)
                    .IsRequired()
                    .HasColumnName("companyname")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasColumnName("contact")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Customerid)
                    .IsRequired()
                    .HasColumnName("customerid")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Town)
                    .HasColumnName("town")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("departments");

                entity.Property(e => e.DeptName)
                    .HasColumnName("dept_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DeptNo)
                    .HasColumnName("dept_no")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employee");

                entity.Property(e => e.DeptNo)
                    .HasColumnName("dept_no")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EmpFname)
                    .HasColumnName("emp_fname")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmpLname)
                    .HasColumnName("emp_lname")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNo).HasColumnName("emp_no");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("orders");

                entity.Property(e => e.Customerid)
                    .IsRequired()
                    .HasColumnName("customerid")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Freight)
                    .HasColumnName("freight")
                    .HasColumnType("money");

                entity.Property(e => e.Orderdate)
                    .HasColumnName("orderdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Shipaddress)
                    .HasColumnName("shipaddress")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Shipname)
                    .HasColumnName("shipname")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Shippeddate)
                    .HasColumnName("shippeddate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("project");

                entity.Property(e => e.Budget).HasColumnName("budget");

                entity.Property(e => e.ProjectName)
                    .HasColumnName("project_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("project_no")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorksOn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("works_on");

                entity.Property(e => e.EmpNo).HasColumnName("emp_no");

                entity.Property(e => e.EnterDate)
                    .HasColumnName("enter_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Job)
                    .HasColumnName("job")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectNo)
                    .HasColumnName("project_no")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
