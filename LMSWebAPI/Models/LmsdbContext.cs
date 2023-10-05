using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LMSWebAPI.Models;

public partial class LmsdbContext : DbContext
{
    public LmsdbContext()
    {
    }

    public LmsdbContext(DbContextOptions<LmsdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblCourse> TblCourses { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    public virtual DbSet<TblcourseCategory> TblcourseCategories { get; set; }

    public virtual DbSet<TblcourseDetail> TblcourseDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            //    => optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS;Database=LMSDB;User Id=eldrin;Password=focus;TrustServerCertificate=True;");
        }
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblCourse>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_course");

            entity.Property(e => e.CourseDate).HasColumnType("date");
            entity.Property(e => e.CourseImageUrl)
                .HasMaxLength(255)
                .HasColumnName("CourseImageURL");
            entity.Property(e => e.CourseName).HasMaxLength(255);
            entity.Property(e => e.CourseNo)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CourseStatus).HasDefaultValueSql("((0))");
            entity.Property(e => e.Edate)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("edate");
            entity.Property(e => e.Euser)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("euser");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Sdate)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("sdate");
            entity.Property(e => e.Suser)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("suser");
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_user");

            entity.Property(e => e.A)
                .HasDefaultValueSql("((1))")
                .HasColumnName("a");
            entity.Property(e => e.AccountType)
                .HasDefaultValueSql("((0))")
                .HasColumnName("accountType");
            entity.Property(e => e.B)
                .HasDefaultValueSql("((1))")
                .HasColumnName("b");
            entity.Property(e => e.EInactive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("eInactive");
            entity.Property(e => e.EStatus)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("eStatus");
            entity.Property(e => e.Ename)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<TblcourseCategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblcourse_category");

            entity.Property(e => e.CategoryName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Edate)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("edate");
            entity.Property(e => e.Euser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("euser");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Sdate)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("sdate");
            entity.Property(e => e.Status)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Suser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("suser");
        });

        modelBuilder.Entity<TblcourseDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblcourse_details");

            entity.Property(e => e.Caccess)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CAccess");
            entity.Property(e => e.Categoryid)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ChapterImageUrl)
                .HasMaxLength(255)
                .HasColumnName("ChapterImageURL");
            entity.Property(e => e.CourseCode)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CourseNo).HasMaxLength(250);
            entity.Property(e => e.Cpublish)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CPublish");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Tid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("tid");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
