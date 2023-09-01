using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ICDWebApi.Models;

public partial class IcdContext : DbContext
{
    public IcdContext()
    {
    }

    public IcdContext(DbContextOptions<IcdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aec> Aecs { get; set; }

    public virtual DbSet<AttachmentCode> AttachmentCodes { get; set; }

    public virtual DbSet<Note> Notes { get; set; }

    public virtual DbSet<ProviderSpecialty> ProviderSpecialties { get; set; }

    public virtual DbSet<Spc> Spcs { get; set; }

    public virtual DbSet<SurgicalCode> SurgicalCodes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-1PBH5TU;Database=ICD;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AEC");

            entity.Property(e => e.AutoErrorCd).HasColumnName("Auto_error_cd ");
            entity.Property(e => e.AutoErrorEffDt).HasColumnName("Auto_error_eff_dt");
            entity.Property(e => e.AutoErrorEndDt).HasColumnName("Auto_error_end_dt");
            entity.Property(e => e.CreateTs).HasColumnName("Create_ts");
            entity.Property(e => e.CreateUserId).HasColumnName("Create_userId");
            entity.Property(e => e.IcdVersion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ICD_version");
            entity.Property(e => e.RecordType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Record_type");
            entity.Property(e => e.StatusInd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Status_ind");
            entity.Property(e => e.SurgicalProcCode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Surgical_proc_code");
            entity.Property(e => e.UpdateTs).HasColumnName("Update_ts");
            entity.Property(e => e.UpdateUserId).HasColumnName("Update_userId");

            entity.HasOne(d => d.SurgicalCode).WithMany()
                .HasForeignKey(d => new { d.IcdVersion, d.SurgicalProcCode })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurgicalCode_AEC");
        });

        modelBuilder.Entity<AttachmentCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AttachmentCode");

            entity.Property(e => e.AttachmentCode1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Attachment_code");
            entity.Property(e => e.CreateTs).HasColumnName("Create_ts");
            entity.Property(e => e.CreateUserId).HasColumnName("Create_userId");
            entity.Property(e => e.EffectiveDate).HasColumnName("Effective_date");
            entity.Property(e => e.EndDate).HasColumnName("End_date ");
            entity.Property(e => e.IcdVersion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ICD_version");
            entity.Property(e => e.RecordType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Record_type");
            entity.Property(e => e.StatusInd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Status_ind");
            entity.Property(e => e.SurgicalProcCode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Surgical_proc_code");
            entity.Property(e => e.UpdateTs).HasColumnName("Update_ts");
            entity.Property(e => e.UpdateUserId).HasColumnName("Update_userId");

            entity.HasOne(d => d.SurgicalCode).WithMany()
                .HasForeignKey(d => new { d.IcdVersion, d.SurgicalProcCode })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurgicalCode_AttachmentCode");
        });

        modelBuilder.Entity<Note>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.IcdVersion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ICD_version");
            entity.Property(e => e.Notes)
                .HasMaxLength(79)
                .IsUnicode(false);
            entity.Property(e => e.RecordType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Record_type");
            entity.Property(e => e.SurgicalProcCode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Surgical_proc_code");

            entity.HasOne(d => d.SurgicalCode).WithMany()
                .HasForeignKey(d => new { d.IcdVersion, d.SurgicalProcCode })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurgicalCode_Notes");
        });

        modelBuilder.Entity<ProviderSpecialty>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProviderSpecialty");

            entity.Property(e => e.CreateTs).HasColumnName("Create_ts");
            entity.Property(e => e.CreateUserId).HasColumnName("Create_userId");
            entity.Property(e => e.EffectiveDate).HasColumnName("Effective_date");
            entity.Property(e => e.EndDate).HasColumnName("End_date");
            entity.Property(e => e.IcdVersion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ICD_version");
            entity.Property(e => e.ProviderSpecialtyCd).HasColumnName("Provider_Specialty__cd");
            entity.Property(e => e.RecordType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Record_type");
            entity.Property(e => e.SpecInclExcl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SPEC_INCL_EXCL");
            entity.Property(e => e.StatusInd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Status_ind");
            entity.Property(e => e.SurgicalProcCode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Surgical_proc_code");
            entity.Property(e => e.UpdateTs).HasColumnName("Update_ts");
            entity.Property(e => e.UpdateUserId).HasColumnName("Update_userId");

            entity.HasOne(d => d.SurgicalCode).WithMany()
                .HasForeignKey(d => new { d.IcdVersion, d.SurgicalProcCode })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurgicalCode_ProviderSpecialty");
        });

        modelBuilder.Entity<Spc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SPC");

            entity.Property(e => e.CreateTs).HasColumnName("Create_ts");
            entity.Property(e => e.CreateUserId).HasColumnName("Create_userId");
            entity.Property(e => e.EffectiveDate).HasColumnName("Effective_date");
            entity.Property(e => e.EndDate).HasColumnName("End_date");
            entity.Property(e => e.IcdVersion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ICD_version");
            entity.Property(e => e.RecordType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Record_type");
            entity.Property(e => e.SpcCd).HasColumnName("SPC_cd");
            entity.Property(e => e.SpcInclExcl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SPC_INCL_EXCL");
            entity.Property(e => e.StatusInd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Status_ind");
            entity.Property(e => e.SurgicalProcCode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Surgical_proc_code");
            entity.Property(e => e.UpdateTs).HasColumnName("Update_ts");
            entity.Property(e => e.UpdateUserId).HasColumnName("Update_userId");

            entity.HasOne(d => d.SurgicalCode).WithMany()
                .HasForeignKey(d => new { d.IcdVersion, d.SurgicalProcCode })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurgicalCode_SPC");
        });

        modelBuilder.Entity<SurgicalCode>(entity =>
        {
            entity.HasKey(e => new { e.IcdVersion, e.SurgicalProcCode }).HasName("PK_ICD_SurgicalCode");

            entity.ToTable("SurgicalCode");

            entity.Property(e => e.IcdVersion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ICD_version");
            entity.Property(e => e.SurgicalProcCode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Surgical_proc_code");
            entity.Property(e => e.AhsfInd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AHSF_ind");
            entity.Property(e => e.CosmeticSurgInd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Cosmetic_surg_ind");
            entity.Property(e => e.CreateTs).HasColumnName("Create_ts");
            entity.Property(e => e.CreateUserId).HasColumnName("Create_userId");
            entity.Property(e => e.EffectiveDate).HasColumnName("Effective_date");
            entity.Property(e => e.EndDate).HasColumnName("End_date");
            entity.Property(e => e.MaxAge).HasColumnName("Max_age");
            entity.Property(e => e.MaxAgeInd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Max_age_ind");
            entity.Property(e => e.MinAge).HasColumnName("Min_age");
            entity.Property(e => e.MinAgeInd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Min_age_ind");
            entity.Property(e => e.RecordType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Record_type");
            entity.Property(e => e.SecondOpinionInd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Second_opinion_ind");
            entity.Property(e => e.Sex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StatusInd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Status_ind");
            entity.Property(e => e.SurgLaymanDesc)
                .HasMaxLength(60)
                .HasColumnName("Surg_layman_desc");
            entity.Property(e => e.SurgName)
                .HasMaxLength(200)
                .HasColumnName("Surg_name");
            entity.Property(e => e.SurgeryInd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Surgery_ind");
            entity.Property(e => e.UpdateTs).HasColumnName("Update_ts");
            entity.Property(e => e.UpdateUserId).HasColumnName("Update_userId");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.Email)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(50)
                .HasColumnName("EmployeeID");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(200);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.SupervisorEmail).HasMaxLength(50);
            entity.Property(e => e.UserType)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
