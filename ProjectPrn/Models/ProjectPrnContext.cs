using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProjectPrn.Models
{
    public partial class ProjectPrnContext : DbContext
    {
        public ProjectPrnContext()
        {
        }

        public ProjectPrnContext(DbContextOptions<ProjectPrnContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-69JNVK0\\QUOCBAO; database=ProjectPrn; uid=sa;password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("Customer");

                entity.Property(e => e.Cid)
                    .HasMaxLength(10)
                    .HasColumnName("cid");

                entity.Property(e => e.Caddress)
                    .HasMaxLength(50)
                    .HasColumnName("caddress");

                entity.Property(e => e.Cmobile)
                    .HasMaxLength(50)
                    .HasColumnName("cmobile");

                entity.Property(e => e.Cname)
                    .HasMaxLength(50)
                    .HasColumnName("cname");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.Cccd)
                    .HasMaxLength(50)
                    .HasColumnName("cccd");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("code");

                entity.Property(e => e.Dob)
                    .HasMaxLength(50)
                    .HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(50)
                    .HasColumnName("fullname");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .HasColumnName("mobile");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.Verify).HasColumnName("verify");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
