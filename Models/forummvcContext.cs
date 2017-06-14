using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace forummvc.Models
{
    public class ForummvcContext : DbContext
    {
        public ForummvcContext(DbContextOptions<ForummvcContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Thread>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Threads)
                .HasForeignKey(k => k.CategoryId)
                .HasConstraintName("FK_Thread_Category")
                .IsRequired(false);

            modelBuilder.Entity<Thread>()
                .HasOne(t => t.Starter)
                .WithMany(u => u.Threads)
                .HasForeignKey(t => t.UserId)
                .HasConstraintName("FK_Thread_User");

            modelBuilder.Entity<User>()
                .HasOne(u => u.UserData)
                .WithOne(ud => ud.User)
                .HasForeignKey<UserData>(ud => ud.UserId)
                .HasConstraintName("FK_UserData_User");
                
            modelBuilder.Entity<Post>()
                .HasOne(p => p.Thread)
                .WithMany(t => t.Posts)
                .HasForeignKey(p => p.ThreadId)
                .HasConstraintName("FK_Post_Thread");
            
            modelBuilder.Entity<Post>()
                .HasOne(p => p.User)
                .WithMany()
                .HasForeignKey(p => p.UserId)
                .HasConstraintName("FK_Post_User")
                .OnDelete(DeleteBehavior.Restrict);
        }
        public DbSet<Category> Categories {get; set;}
        public DbSet<Thread> Threads {get; set;}
        public DbSet<User> Users {get;set;}
        public DbSet<UserData> UserData {get; set;}
        public DbSet<Post> Posts {get; set;}
    }
}