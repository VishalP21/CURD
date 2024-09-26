using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Employee.Database;

public partial class EmployeemanagesystemContext : DbContext
{
    public EmployeemanagesystemContext()
    {
    }

    public EmployeemanagesystemContext(DbContextOptions<EmployeemanagesystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employe> Employes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=VISAL\\MSSQLSERVER02;Database=employeemanagesystem;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employe>(entity =>
        {
            entity.ToTable("employes");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
