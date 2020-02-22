using EFDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDAL.context
{
   public class MyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-A63MUHA\SQLEXPRESS;Initial Catalog=EMSDB;User ID=sa;Password=pass@word1");
        }
        public DbSet<project> projects { get; set; }
        public DbSet<employee> employees { get; set; }
    }
}
