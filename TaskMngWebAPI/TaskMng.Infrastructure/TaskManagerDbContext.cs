using TaskMng.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace TaskMng.Infrastructure
{
    public class TaskManagerDbContext : DbContext
    {
        public TaskManagerDbContext(DbContextOptions<TaskManagerDbContext> options)
            : base(options)
        {
        }

        public DbSet<ToDoTask> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Project>()
                .HasOne(p => p.ProjectOwner)
                .WithMany(u => u.Projects)
                .HasForeignKey(p => p.ProjectOwnerId);

            modelBuilder.Entity<ToDoTask>()
                .HasOne(t => t.User)
                .WithMany(u => u.Tasks)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ToDoTask>()
                .HasOne(t => t.Project)
                .WithMany(p => p.Tasks)
                .HasForeignKey(t => t.ProjectId)
                .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<TasK>(entity =>
            //{
            //    entity.Property(e => e.Status)
            //        .IsRequired();
            //});

            //modelBuilder.Entity<TasK>()
            //     .ToTable(b => b.HasCheckConstraint("CK_Status", "Status IN ('Started', 'In progress', 'Done')"));
        }
    }
}