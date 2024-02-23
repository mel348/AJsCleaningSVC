using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AJsCleaning.Migrations
{
    /// <inheritdoc />
    public partial class Ititial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Service = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "Service", "Type" },
                values: new object[,]
                {
                    { 1, "- Cleaning floors furniture, windows, walls, restrooms, and other common area surfaces.- Disposing of waste- Vacuuming carpets- Scrubbing toilets- Dusting ceilings, light fixtures, countertops, loose furniture (high and low dusting as well as wet dusting)- Washing and drying windows (including window sills and frames)- Carrying out heavy cleansing tasks and special projects (deep cleaning fridges, washers, dishwashers, etc.)- Notifying clients of occurring deficiencies or needs for repairs.", "Deep Cleaning", 0 },
                    { 2, "Providing organizational services to help clients declutter and optimize their spaces.", "Organization", 0 },
                    { 3, "Regular cleaning services, including dusting, vacuuming, mopping, and general maintenance of spaces.", "Normal Cleaning", 0 },
                    { 4, "Cleaning services specifically designed for moving in or out of a residence or commercial space.", "Move-in/Move-out", 0 },
                    { 5, "Cleaning services before or after construction projects, including dust and debris removal.", "New & Post Construction Clean-Up", 0 },
                    { 6, "Cleaning and arranging spaces to enhance their appeal for potential buyers or tenants.", "Real Estate Staging", 0 },
                    { 7, "Specialized cleaning for households expecting or with a new baby, focusing on a hygienic and safe environment.", "Newborn Arrival Cleaning", 0 },
                    { 8, "Cleaning services tailored for short-term rental properties, ensuring cleanliness for incoming guests.", "AirBnb's & Vacation Rentals", 1 },
                    { 9, "Cleaning services for commercial office spaces, including desks, common areas, and janitorial tasks.", "Office Cleaning", 1 },
                    { 10, "Cleaning services for commercial office spaces, including desks, common areas, and janitorial tasks.", "Gardening", 2 },
                    { 11, "Basic pet care services, including feeding, walking, and other routine tasks for pet owners.", "Pet Care", 2 },
                    { 12, "Assisting clients with grocery shopping services.", "Grocery Shopping", 2 },
                    { 13, "Providing laundry services for clients, including washing, drying, and folding clothes.", "Laundry Services", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
