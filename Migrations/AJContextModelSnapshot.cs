﻿// <auto-generated />
using AJsCleaning.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AJsCleaning.Migrations
{
    [DbContext(typeof(AJContext))]
    partial class AJContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AJsCleaning.Models.Services", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Service")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "- Cleaning floors furniture, windows, walls, restrooms, and other common area surfaces.- Disposing of waste- Vacuuming carpets- Scrubbing toilets- Dusting ceilings, light fixtures, countertops, loose furniture (high and low dusting as well as wet dusting)- Washing and drying windows (including window sills and frames)- Carrying out heavy cleansing tasks and special projects (deep cleaning fridges, washers, dishwashers, etc.)- Notifying clients of occurring deficiencies or needs for repairs.",
                            Service = "Deep Cleaning",
                            Type = 0
                        },
                        new
                        {
                            Id = 2,
                            Description = "Providing organizational services to help clients declutter and optimize their spaces.",
                            Service = "Organization",
                            Type = 0
                        },
                        new
                        {
                            Id = 3,
                            Description = "Regular cleaning services, including dusting, vacuuming, mopping, and general maintenance of spaces.",
                            Service = "Normal Cleaning",
                            Type = 0
                        },
                        new
                        {
                            Id = 4,
                            Description = "Cleaning services specifically designed for moving in or out of a residence or commercial space.",
                            Service = "Move-in/Move-out",
                            Type = 0
                        },
                        new
                        {
                            Id = 5,
                            Description = "Cleaning services before or after construction projects, including dust and debris removal.",
                            Service = "New & Post Construction Clean-Up",
                            Type = 0
                        },
                        new
                        {
                            Id = 6,
                            Description = "Cleaning and arranging spaces to enhance their appeal for potential buyers or tenants.",
                            Service = "Real Estate Staging",
                            Type = 0
                        },
                        new
                        {
                            Id = 7,
                            Description = "Specialized cleaning for households expecting or with a new baby, focusing on a hygienic and safe environment.",
                            Service = "Newborn Arrival Cleaning",
                            Type = 0
                        },
                        new
                        {
                            Id = 8,
                            Description = "Cleaning services tailored for short-term rental properties, ensuring cleanliness for incoming guests.",
                            Service = "AirBnb's & Vacation Rentals",
                            Type = 1
                        },
                        new
                        {
                            Id = 9,
                            Description = "Cleaning services for commercial office spaces, including desks, common areas, and janitorial tasks.",
                            Service = "Office Cleaning",
                            Type = 1
                        },
                        new
                        {
                            Id = 10,
                            Description = "Cleaning services for commercial office spaces, including desks, common areas, and janitorial tasks.",
                            Service = "Gardening",
                            Type = 2
                        },
                        new
                        {
                            Id = 11,
                            Description = "Basic pet care services, including feeding, walking, and other routine tasks for pet owners.",
                            Service = "Pet Care",
                            Type = 2
                        },
                        new
                        {
                            Id = 12,
                            Description = "Assisting clients with grocery shopping services.",
                            Service = "Grocery Shopping",
                            Type = 2
                        },
                        new
                        {
                            Id = 13,
                            Description = "Providing laundry services for clients, including washing, drying, and folding clothes.",
                            Service = "Laundry Services",
                            Type = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
