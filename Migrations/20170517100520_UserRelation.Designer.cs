using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using forummvc.Models;

namespace forummvc.Migrations
{
    [DbContext(typeof(ForummvcContext))]
    [Migration("20170517100520_UserRelation")]
    partial class UserRelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("forummvc.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayName");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("forummvc.Models.Post", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<int>("ThreadID");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("ThreadID");

                    b.HasIndex("UserID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("forummvc.Models.Thread", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryID");

                    b.Property<string>("DisplayName");

                    b.Property<int>("Status");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("UserID");

                    b.ToTable("Threads");
                });

            modelBuilder.Entity("forummvc.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<int>("Status");

                    b.Property<string>("Username");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("forummvc.Models.UserData", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayName");

                    b.Property<DateTime>("RegistrationDate");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("UserData");
                });

            modelBuilder.Entity("forummvc.Models.Post", b =>
                {
                    b.HasOne("forummvc.Models.Thread", "Thread")
                        .WithMany("Posts")
                        .HasForeignKey("ThreadID")
                        .HasConstraintName("FK_Post_Thread")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("forummvc.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .HasConstraintName("FK_Post_User");
                });

            modelBuilder.Entity("forummvc.Models.Thread", b =>
                {
                    b.HasOne("forummvc.Models.Category", "Category")
                        .WithMany("Threads")
                        .HasForeignKey("CategoryID")
                        .HasConstraintName("FK_Thread_Category")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("forummvc.Models.User", "Starter")
                        .WithMany("Threads")
                        .HasForeignKey("UserID")
                        .HasConstraintName("FK_Thread_User")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("forummvc.Models.UserData", b =>
                {
                    b.HasOne("forummvc.Models.User", "User")
                        .WithOne("UserData")
                        .HasForeignKey("forummvc.Models.UserData", "UserID")
                        .HasConstraintName("FK_UserData_User")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
