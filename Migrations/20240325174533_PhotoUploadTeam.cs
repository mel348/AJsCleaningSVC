using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AJsCleaning.Migrations
{
    /// <inheritdoc />
    public partial class PhotoUploadTeam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Description", "Name", "PhotoPath", "Title" },
                values: new object[,]
                {
                    { 1, "Janelle is the co owner of AJ's Cleaning", "Janelle Fineout", "/images/teams/Team-Janelle.jpg", "Owner" },
                    { 2, "Alyssah is the co owner of AJ's Cleaning.", "Alyssah Fearnow", "/images/teams/Team-Alyssah.jpg", "Owner" },
                    { 3, "I like long walks through the park, and the smell of rotisserie chicken. My cleaning specialty is licking plates clean.", "MeatLoaf", "/images/teams/Team-Meatloaf.jpg", "The Goodest Boy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
