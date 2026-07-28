using Microsoft.EntityFrameworkCore;
using TTAK_BLZRV2.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Text;
using TTAK_BLZRV2.Core.Models;

namespace TTAK_BLZRV2.Data
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> dbContext) : base(dbContext) { }

        public DbSet<AlbumE> Albums { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Alert> Alerts { get; set; }
        public DbSet<Gender> Genders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }
    }
}
