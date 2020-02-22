using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HandsOnEFcodefirst.Models;
namespace HandsOnEFcodefirst.context
{
    class mycontext:DbContext
    {
        //define entities
        public DbSet<student> students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = DESKTOP-A63MUHA\SQLEXPRESS;
                               Initial Catalog = StudentDb; User ID = sa;Password=pass@word1");
        }
    }
}
