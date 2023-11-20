using CareProLearning.Models;
using Microsoft.EntityFrameworkCore;

namespace CareProLearning.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Module> Modules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data
            modelBuilder.Entity<Module>().HasData(
            new Module
            {
                ModuleId = 1,
                Title = "Labs",
                Description = "How to access labs",
                VideoUrl = "/videos/LabOrder.mp4",
                ThumbnailImagePath = "/images/Labs1.jpg",
                Category = "Labs"
            });

            modelBuilder.Entity<Module>().HasData(
            new Module
            {
                ModuleId = 2,
                Title = "Math Basics",
                Description = "How to access labs 2",
                VideoUrl = "/videos/Drugs.mp4",
                ThumbnailImagePath = "/images/Lab2.jpg",
                Category = "Labs"
            });

            modelBuilder.Entity<Module>().HasData(
            new Module
            {
                ModuleId = 3,
                Title = "Registration",
                Description = "How to register a patient",
                VideoUrl = "/videos/Register.mp4",
                ThumbnailImagePath = "/images/register1.jpg",
                Category = "Registration"
            });

            modelBuilder.Entity<Module>().HasData(
            new Module
            {
                ModuleId = 4,
                Title = "Registration Video Two",
                Description = "How to register a patient 2",
                VideoUrl = "/videos/Starting.mp4",
                ThumbnailImagePath = "/images/register2.jpg",
                Category = "Registration"
            });

            modelBuilder.Entity<Module>().HasData(
            new Module
            {
                ModuleId = 5,
                Title = "Vitals Video One",
                Description = "Vitals Vid",
                VideoUrl = "/videos/Vitals.mp4",
                ThumbnailImagePath = "/images/Vitals1.jpg",
                Category = "Vitals"
            });

            modelBuilder.Entity<Module>().HasData(
            new Module
            {
                ModuleId = 6,
                Title = "Vitals Video Two",
                Description = "Vitals Vid Two",
                VideoUrl = "/videos/Visit.mp4",
                ThumbnailImagePath = "/images/Vitals2.jpg",
                Category = "Vitals"
            });

            modelBuilder.Entity<Module>().HasData(
            new Module
            {
                ModuleId = 7,
                Title = "Reports",
                Description = "MER Reports",
                VideoUrl = "/videos/ARTClient.mp4",
                ThumbnailImagePath = "/images/report1.jpeg",
                Category = "Reports"
            });

            modelBuilder.Entity<Module>().HasData(
            new Module
            {
                ModuleId = 8,
                Title = "Reports",
                Description = "MER Reports Video Two",
                VideoUrl = "/videos/Reports.mp4",
                ThumbnailImagePath = "/images/report2.jpg",
                Category = "Reports"
            });
        }
    }
}
