using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlazorCareer.Models;

public partial class CareerContext : DbContext
{
    public CareerContext()
    {
    }

    public CareerContext(DbContextOptions<CareerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Education> Educations { get; set; }

    public virtual DbSet<EducationPersonalDatum> EducationPersonalData { get; set; }

    public virtual DbSet<PersonalDatum> PersonalData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=192.168.73.25;Database=Career;User Id=syteline;Password=planetcomm@123;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Education>(entity =>
        {
            entity.ToTable("Education");

            entity.Property(e => e.EducationEnd).HasColumnType("date");
            entity.Property(e => e.EducationLevel).HasMaxLength(50);
            entity.Property(e => e.EducationStart).HasColumnType("date");
            entity.Property(e => e.Gpa).HasColumnName("GPA");
            entity.Property(e => e.Major).HasMaxLength(150);
            entity.Property(e => e.NameOfInstitute).HasMaxLength(150);
        });

        modelBuilder.Entity<EducationPersonalDatum>(entity =>
        {
            entity.HasKey(e => e.EducationPersonal);

            entity.ToTable("Education_PersonalData");

            entity.Property(e => e.EducationPersonal).HasColumnName("Education_Personal");

            entity.HasOne(d => d.Education).WithMany(p => p.EducationPersonalData)
                .HasForeignKey(d => d.EducationId)
                .HasConstraintName("FK_Education_PersonalData_Education");

            entity.HasOne(d => d.PersonalData).WithMany(p => p.EducationPersonalData)
                .HasForeignKey(d => d.PersonalDataId)
                .HasConstraintName("FK_Education_PersonalData_PersonalData");
        });

        modelBuilder.Entity<PersonalDatum>(entity =>
        {
            entity.HasKey(e => e.PersonalDataId);

            entity.Property(e => e.AddressPresent).HasMaxLength(150);
            entity.Property(e => e.AddressRegistration).HasMaxLength(150);
            entity.Property(e => e.ContactNumber).HasMaxLength(50);
            entity.Property(e => e.ContractNumber).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.DistrictPresent).HasMaxLength(150);
            entity.Property(e => e.DistrictRegistration).HasMaxLength(150);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmergencyContact).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.IdCardNumber).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MaritalStatus).HasMaxLength(50);
            entity.Property(e => e.MilitaryStatus).HasMaxLength(50);
            entity.Property(e => e.NickName).HasMaxLength(50);
            entity.Property(e => e.Position).HasMaxLength(100);
            entity.Property(e => e.Prefix).HasMaxLength(50);
            entity.Property(e => e.ProvincePresent).HasMaxLength(150);
            entity.Property(e => e.ProvinceRegistration).HasMaxLength(150);
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.StreetPresent).HasMaxLength(150);
            entity.Property(e => e.StreetRegistration).HasMaxLength(150);
            entity.Property(e => e.SubDistrictPresent).HasMaxLength(150);
            entity.Property(e => e.SubDistrictRegistration).HasMaxLength(150);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
