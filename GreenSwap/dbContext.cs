using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;
using GreenSwap.Models;
using System.IO;

namespace GreenSwap
{
    public class GreenSwapDbContext : DbContext
    {
        // DbSets for each entity
        public DbSet<User> Users { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Trade> Trades { get; set; }
        public DbSet<PlantCareInfo> PlantCareInfo { get; set; }

        // The database file path
        private string DbPath { get; }

        public GreenSwapDbContext()
        {
            // Create database in the app's folder
            var folder = System.Environment.CurrentDirectory;
            DbPath = Path.Join(folder, "greenswap.db");
        }

        // Configure the SQLite connection
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        // Configure entity relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure User entity
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            // Configure Plant entity
            modelBuilder.Entity<Plant>()
                .HasOne(p => p.Owner)
                .WithMany(u => u.Plants)
                .HasForeignKey(p => p.UserID)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure Trade entity
            modelBuilder.Entity<Trade>()
                .HasOne(t => t.Requestor)
                .WithMany(u => u.RequestedTrades)
                .HasForeignKey(t => t.RequestorID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Trade>()
                .HasOne(t => t.Provider)
                .WithMany(u => u.ProvidedTrades)
                .HasForeignKey(t => t.ProviderID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Trade>()
                .HasOne(t => t.Plant)
                .WithMany(p => p.Trades)
                .HasForeignKey(t => t.PlantID)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure PlantCareInfo entity
            modelBuilder.Entity<PlantCareInfo>()
                .HasIndex(p => p.PlantTypeName)
                .IsUnique();
        }
    }
}