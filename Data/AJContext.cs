using Microsoft.EntityFrameworkCore;
using AJsCleaning.Models;
namespace AJsCleaning.Data
{
    public class AJContext : DbContext
    {
        public AJContext(DbContextOptions<AJContext> options)
            : base(options)
        {
        }

        public DbSet<AJsCleaning.Models.Services> Services { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Services>().HasData(
                new Services {
                    Id = 1,
                    Type = PropertyType.Residential,
                    Service = "Deep Cleaning",
                    Description = "- Cleaning floors furniture, windows, walls, restrooms, and other common area surfaces." +
                                                 "- Disposing of waste" +
                                                 "- Vacuuming carpets" +
                                                 "- Scrubbing toilets" +
                                                 "- Dusting ceilings, light fixtures, countertops, loose furniture (high and low dusting as well as wet dusting)" +
                                                 "- Washing and drying windows (including window sills and frames)" +
                                                 "- Carrying out heavy cleansing tasks and special projects (deep cleaning fridges, washers, dishwashers, etc.)" +
                                                 "- Notifying clients of occurring deficiencies or needs for repairs."
                },
                new Services {
                    Id = 2,
                    Type = PropertyType.Residential,
                    Service = "Organization",
                    Description = "Providing organizational services to help clients declutter and optimize their spaces."
                },
                new Services {
                    Id = 3,
                    Type = PropertyType.Residential,
                    Service = "Normal Cleaning",
                    Description = "Regular cleaning services, including dusting, vacuuming, mopping, and general maintenance of spaces."
                },
                new Services {
                    Id = 4,
                    Type = PropertyType.Residential,
                    Service = "Move-in/Move-out",
                    Description = "Cleaning services specifically designed for moving in or out of a residence or commercial space."
                },
                new Services {
                    Id = 5,
                    Type = PropertyType.Residential,
                    Service = "New & Post Construction Clean-Up",
                    Description = "Cleaning services before or after construction projects, including dust and debris removal."
                },
                new Services {
                    Id = 6,
                    Type = PropertyType.Residential,
                    Service = "Real Estate Staging",
                    Description = "Cleaning and arranging spaces to enhance their appeal for potential buyers or tenants."
                },
                new Services {
                    Id = 7,
                    Type = PropertyType.Residential,
                    Service = "Newborn Arrival Cleaning",
                    Description = "Specialized cleaning for households expecting or with a new baby, focusing on a hygienic and safe environment."
                },
                new Services {
                    Id = 8,
                    Type = PropertyType.Commercial,
                    Service = "AirBnb's & Vacation Rentals",
                    Description = "Cleaning services tailored for short-term rental properties, ensuring cleanliness for incoming guests."
                },
                new Services {
                    Id = 9,
                    Type = PropertyType.Commercial,
                    Service = "Office Cleaning",
                    Description = "Cleaning services for commercial office spaces, including desks, common areas, and janitorial tasks."
                },
                new Services {
                    Id = 10,
                    Type = PropertyType.Other,
                    Service = "Gardening",
                    Description = "Cleaning services for commercial office spaces, including desks, common areas, and janitorial tasks."
                },
                new Services {
                    Id = 11,
                    Type = PropertyType.Other,
                    Service = "Pet Care",
                    Description = "Basic pet care services, including feeding, walking, and other routine tasks for pet owners."
                },
                new Services {
                    Id = 12,
                    Type = PropertyType.Other,
                    Service = "Grocery Shopping",
                    Description = "Assisting clients with grocery shopping services."
                },
                new Services {
                    Id = 13,
                    Type = PropertyType.Other,
                    Service = "Laundry Services",
                    Description = "Providing laundry services for clients, including washing, drying, and folding clothes."

                }
            );
        }
    }
}
