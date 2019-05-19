using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Project.Data
{
    public partial class HITProjectDataEntities : DbContext
    {
        public HITProjectDataEntities()
        {
        }

        public HITProjectDataEntities(DbContextOptions<HITProjectDataEntities> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Attendant> Attendant { get; set; }
        public virtual DbSet<BirthRecord> BirthRecord { get; set; }
        public virtual DbSet<Certifier> Certifier { get; set; }
        public virtual DbSet<EducationEarned> EducationEarned { get; set; }
        public virtual DbSet<Facility> Facility { get; set; }
        public virtual DbSet<FacilityType> FacilityType { get; set; }
        public virtual DbSet<NewBorn> NewBorn { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PaymentType> PaymentType { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Prenatal> Prenatal { get; set; }
        public virtual DbSet<Race> Race { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name=DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.DateUpdated).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("FK__AspNetUse__Facil__01142BA1");
            });

            modelBuilder.Entity<Attendant>(entity =>
            {
                entity.Property(e => e.JobTitle).IsUnicode(false);

                entity.Property(e => e.Npi).IsUnicode(false);
            });

            modelBuilder.Entity<BirthRecord>(entity =>
            {
                entity.Property(e => e.OtherBirthLocation).IsUnicode(false);

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.BirthRecordFacility)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.FacilityTransferIdmomNavigation)
                    .WithMany(p => p.BirthRecordFacilityTransferIdmomNavigation)
                    .HasForeignKey(d => d.FacilityTransferIdmom)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.FatherPerson)
                    .WithMany(p => p.BirthRecord)
                    .HasForeignKey(d => d.FatherPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BirthRecord_Person_FatherPersonlID");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.BirthRecord)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Certifier>(entity =>
            {
                entity.Property(e => e.CertifierName).IsUnicode(false);
            });

            modelBuilder.Entity<EducationEarned>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Facility>(entity =>
            {
                entity.Property(e => e.FacilityName).IsUnicode(false);

                entity.Property(e => e.FacilityNumber).IsUnicode(false);

                entity.HasOne(d => d.FacilityType)
                    .WithMany(p => p.Facility)
                    .HasForeignKey(d => d.FacilityTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<FacilityType>(entity =>
            {
                entity.Property(e => e.TypeDescription).IsUnicode(false);
            });

            modelBuilder.Entity<NewBorn>(entity =>
            {
                entity.Property(e => e.BirthOrder).IsUnicode(false);

                entity.Property(e => e.FiveMinApgarScore).IsUnicode(false);

                entity.Property(e => e.InfantLiving).IsUnicode(false);

                entity.Property(e => e.TenMinApgarScore).IsUnicode(false);

                entity.HasOne(d => d.BirthRecord)
                    .WithMany(p => p.NewBorn)
                    .HasForeignKey(d => d.BirthRecordId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.FacilityTransferIdbabyNavigation)
                    .WithMany(p => p.NewBorn)
                    .HasForeignKey(d => d.FacilityTransferIdbaby)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.NewBorn)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_NewBorn_Patient_PersonID");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(e => e.MedicalRecordNumber).IsUnicode(false);
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.Property(e => e.PaymentSource).IsUnicode(false);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.BirthCounty).IsUnicode(false);

                entity.Property(e => e.BirthPlace).IsUnicode(false);

                entity.Property(e => e.FatherSsn).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.Gender).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.MailingAptNo).IsUnicode(false);

                entity.Property(e => e.MailingCity).IsUnicode(false);

                entity.Property(e => e.MailingStreetAddress).IsUnicode(false);

                entity.Property(e => e.MailingZip).IsUnicode(false);

                entity.Property(e => e.MiddleName).IsUnicode(false);

                entity.Property(e => e.MotherSsn).IsUnicode(false);

                entity.Property(e => e.PriorFirstName).IsUnicode(false);

                entity.Property(e => e.PriorLastName).IsUnicode(false);

                entity.Property(e => e.PriorMiddleName).IsUnicode(false);

                entity.Property(e => e.PriorSuffix).IsUnicode(false);

                entity.Property(e => e.ResidenceAptNo).IsUnicode(false);

                entity.Property(e => e.ResidenceCity).IsUnicode(false);

                entity.Property(e => e.ResidenceCountry).IsUnicode(false);

                entity.Property(e => e.ResidenceState).IsUnicode(false);

                entity.Property(e => e.ResidenceZip).IsUnicode(false);

                entity.Property(e => e.ResidentStreetAddress).IsUnicode(false);

                entity.Property(e => e.Ssn).IsUnicode(false);

                entity.Property(e => e.Suffix).IsUnicode(false);

                entity.HasOne(d => d.EducationEarned)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.EducationEarnedId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Prenatal>(entity =>
            {
                entity.Property(e => e.CigFirstThreeMonthsPregnancy).IsUnicode(false);

                entity.Property(e => e.CigSecondThreeMonthsPregnancy).IsUnicode(false);

                entity.Property(e => e.CigThirdTrimesterPregnancy).IsUnicode(false);

                entity.Property(e => e.EstimateGestation).IsUnicode(false);

                entity.Property(e => e.TotalPrenatal).IsUnicode(false);
            });

            modelBuilder.Entity<Race>(entity =>
            {
                entity.Property(e => e.Hispanic).IsUnicode(false);

                entity.Property(e => e.Other).IsUnicode(false);

                entity.Property(e => e.OtherAsian).IsUnicode(false);

                entity.Property(e => e.PacificIslander).IsUnicode(false);

                entity.Property(e => e.Tribe).IsUnicode(false);
            });
        }
    }
}
