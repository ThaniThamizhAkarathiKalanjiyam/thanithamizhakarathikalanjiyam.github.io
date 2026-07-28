using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TTAK_BLZRV2.Core.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace TTAK_BLZRV2.Data.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(m => m.Id);
            //builder.Property(m => m.Id).UseIdentityColumn();
            builder.Property(m => m.Id).ValueGeneratedOnAdd();               
            builder.ToTable("Employees");
        }
    }
}
