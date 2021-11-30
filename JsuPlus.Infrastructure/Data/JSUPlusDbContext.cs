using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace JsuPlus.Infrastructure
{
    public partial class JSUPlusDbContext : DbContext
    {
        public JSUPlusDbContext()
        {
        }

        public JSUPlusDbContext(DbContextOptions<JSUPlusDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tblaccount> Tblaccounts { get; set; }
        public virtual DbSet<Tbladdress> Tbladdresses { get; set; }
        public virtual DbSet<Tblorganization> Tblorganizations { get; set; }
        public virtual DbSet<JsuPlus.Core.Entities.Participant> Tblparticipants { get; set; }
        public virtual DbSet<Tbluniversity> Tbluniversities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("Server=(address=us-cdbr-east-04.cleardb.com:3306);uid=b06d5d4e606035;pwd=8bdddad9;Database=heroku_30ebef2574eacbe;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tblaccount>(entity =>
            {
                entity.ToTable("tblaccount");

                entity.HasIndex(e => e.Id, "id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AccountType)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Tbladdress>(entity =>
            {
                entity.ToTable("tbladdress");

                entity.HasIndex(e => e.Id, "id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.StreetName)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.StreetNumber)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Tblorganization>(entity =>
            {
                entity.ToTable("tblorganization");

                entity.HasIndex(e => e.Id, "Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.SubscriptionNumber, "SubscriptionNumber_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Tblorganizationcol, "tblorganizationcol_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.SubscriptionNumber)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Tblorganizationcol)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("tblorganizationcol");
            });

            modelBuilder.Entity<JsuPlus.Core.Entities.Participant>(entity =>
            {
                entity.ToTable("tblparticipant");

                //entity.HasIndex(e => e.AddressId, "AddressId_idx");

                entity.HasIndex(e => e.Id, "Id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("char(38)");

                //entity.Property(e => e.AddressId)
                //    .HasColumnType("int(11)")
                //    .HasColumnName("Address_Id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Tbluniversity>(entity =>
            {
                entity.ToTable("tbluniversity");

                entity.HasIndex(e => e.Id, "Id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "Name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
