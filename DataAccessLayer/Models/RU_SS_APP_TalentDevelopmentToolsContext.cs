using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer.Models
{
    public partial class RU_SS_APP_TalentDevelopmentToolsContext : DbContext
    {
        public RU_SS_APP_TalentDevelopmentToolsContext()
        {
        }

        public RU_SS_APP_TalentDevelopmentToolsContext(DbContextOptions<RU_SS_APP_TalentDevelopmentToolsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TempBoss> TempBoss { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json");
            var config = builder.Build();
            var connectionString = config.GetConnectionString("DBConnectionString");

            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //        optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog=RU_SS_APP_TalentDevelopmentTools;Integrated Security=true");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TempBoss>(entity =>
            {
                entity.ToTable("TempBOSS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BusinessMobile)
                    .HasColumnName("Business_Mobile")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessPhone)
                    .HasColumnName("Business_Phone")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Employeetype)
                    .HasColumnName("EMPLOYEETYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("FIRST_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FirstNameRu)
                    .HasColumnName("First_Name_RU")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("LAST_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastNameRu)
                    .HasColumnName("Last_Name_RU")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleNameRu)
                    .HasColumnName("Middle_Name_RU")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NetworkAccount)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PositionName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Positionnameru)
                    .HasColumnName("POSITIONNAMERU")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Wwid)
                    .HasColumnName("WWID")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
