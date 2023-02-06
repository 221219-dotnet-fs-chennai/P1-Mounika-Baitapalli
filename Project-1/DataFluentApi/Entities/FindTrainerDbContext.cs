using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataFluentApi.Entities;


public partial class FindTrainerDbContext : DbContext
{
    //internal TrainerDetail TrainerDetail;
    //string path = File.ReadAllText("../../../TrainerProject/connectionstring.txt");
    public FindTrainerDbContext()
    {
    }

    public FindTrainerDbContext(DbContextOptions<FindTrainerDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CompanyDetail> CompanyDetails { get; set; }

    public virtual DbSet<EducationDetail> EducationDetails { get; set; }

    public virtual DbSet<SkillSet> SkillSets { get; set; }

    public virtual DbSet<TrainerDetail> TrainerDetails { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

     //   => optionsBuilder.UseSqlServer(path);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CompanyDetail>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Company___206D9170550C2BE7");

            entity.ToTable("Company_Details");

            entity.Property(e => e.UserId)
                .ValueGeneratedOnAdd()
                .HasColumnName("User_Id");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Company_Name");
            entity.Property(e => e.ExperienceInYears)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Experience_In_Years");
            entity.Property(e => e.Position)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithOne(p => p.CompanyDetail)
                .HasForeignKey<CompanyDetail>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_CompanyDetails");
        });

        modelBuilder.Entity<EducationDetail>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Educatio__206D91703E65A47A");

            entity.ToTable("Education_Details");

            entity.Property(e => e.UserId)
                .ValueGeneratedOnAdd()
                .HasColumnName("User_Id");
            entity.Property(e => e.Degree)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Institution)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Specialization)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.YearOfPassing)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Year_Of_Passing");

            entity.HasOne(d => d.User).WithOne(p => p.EducationDetail)
                .HasForeignKey<EducationDetail>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK-Education_details");
        });

        modelBuilder.Entity<SkillSet>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Skill_Se__206D9170E8B05FB9");

            entity.ToTable("Skill_Set");

            entity.Property(e => e.UserId)
                .ValueGeneratedOnAdd()
                .HasColumnName("User_Id");
            entity.Property(e => e.Skill1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Skill_1");
            entity.Property(e => e.Skill2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Skill_2");
            entity.Property(e => e.Skill3)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Skill_3");

            entity.HasOne(d => d.User).WithOne(p => p.SkillSet)
                .HasForeignKey<SkillSet>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK-Skill_Set");
        });

        modelBuilder.Entity<TrainerDetail>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Trainer___206D9170AB5A4059");

            entity.ToTable("Trainer_Details");

            entity.Property(e => e.UserId).HasColumnName("User_Id");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Contact_Number");
            entity.Property(e => e.EmailId)
                .IsUnicode(false)
                .HasColumnName("EmailID");
            entity.Property(e => e.Gender).IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SocialMediaProfile)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SocialMedia_Profile");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    internal void Delete(DbSet<TrainerDetail> trainerDetails)
    {
        throw new NotImplementedException();
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
