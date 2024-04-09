using Microsoft.EntityFrameworkCore;
using AJsCleaning.Models;
using Microsoft.Identity.Client;
using System.Diagnostics;
namespace AJsCleaning.Data
{
    public class AJContext : DbContext
    {


        public AJContext(DbContextOptions<AJContext> options)
            : base(options)
        {
        }

        public DbSet<AJsCleaning.Models.Services> Services { get; set; } = null!;
        public DbSet<AJsCleaning.Models.Team> Teams { get; set; } = null!;

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

            modelBuilder.Entity<Team>().HasData(
                new Team { 
                    Id = 1, 
                    Name = "Janelle Fineout", 
                    Title = "Owner", 
                    Description = "Hi, I'm Janelle Fineout, busy mother of four, who needed more flexibility for my children when COVID hit back in 2020. With many years of cleaning experience already, I decided to open up a cleaning business with a coworker I had taught children with for 7 years. At the time some thought we were crazy, opening a business during covid, but as I saw it, sanitation was booming and took it as a business opportunity. Within 6 months, we were working full-time, expanding, providing dependable, top quality cleaning services for residential and commercial clients in the Grand Traverse County area. Our Team loves to organize and clean your space, giving customers their time back, while we handle the details.",
                    PhotoPath = "/images/teams/Team-Janelle.jpg" 
                },
                new Team { 
                    Id = 2, 
                    Name = "Alyssah Fearnow", 
                    Title = "Owner", 
                    Description = "Hey there! I’m so loudly and proudly the A in AJ’s, Alyssah Fearnow! Commonly known as Lys. \r\n\r\nI am a wife to my amazing and supportive husband OB and momma to our spunky fur son, Meatloaf who brings endless joy, an abundance of snuggles, so much hair and tons of mud to our household. He is reputable for nose boop marks on all of our windows! \r\n\r\nI possess a strong drive, unwavering determination, and a firm self-assurance as a determined and driven female professional. I also possess a strong drive to have way too many plants, pet every dog I meet (after asking), eating all of the good food, and watching all of the junk tv. I found someone who shares some loves of mine, side by side with the J to my A for the past 7 years we became known as the dynamic duo! \r\n\r\nLetting A&J's have your back with all of your cleaning, sanitizing, disinfecting, organizational requirements, and dog petting, whether for residential or commercial settings, will prove to be the “BEST” choice! Big or small, we clean them all!", 
                    PhotoPath = "/images/teams/Team-Alyssah.jpg" 
                },
                new Team {
                    Id = 3,
                    Name = "Danielle Franks",
                    Title = "Employee",
                    Description = "Hi, my name is Danielle Franks and i am a loving mother to 3 beautiful children. At the age of 14, my first job was working in hotels, and I've had almost 10 years of cleaning experience . I took some time off during covid to raise my youngest and have since been with A.J.s for almost two years. It is so important to me to have a good relationship with the people that I work with and have found that with this company. I also enjoy getting to know our clients and their families, and I love pets of all kinds. It is a joy to come to work every day, and I find great satisfaction in a job well done.",
                    PhotoPath = "/images/teams/teams_danielle.jpg"
                    }
   );



        }
    }
}
