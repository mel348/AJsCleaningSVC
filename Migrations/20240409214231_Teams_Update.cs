using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AJsCleaning.Migrations
{
    /// <inheritdoc />
    public partial class Teams_Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Hi, I'm Janelle Fineout, busy mother of four, who needed more flexibility for my children when COVID hit back in 2020. With many years of cleaning experience already, I decided to open up a cleaning business with a coworker I had taught children with for 7 years. At the time some thought we were crazy, opening a business during covid, but as I saw it, sanitation was booming and took it as a business opportunity. Within 6 months, we were working full-time, expanding, providing dependable, top quality cleaning services for residential and commercial clients in the Grand Traverse County area. Our Team loves to organize and clean your space, giving customers their time back, while we handle the details.");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Hey there! I’m so loudly and proudly the A in AJ’s, Alyssah Fearnow! Commonly known as Lys. \r\n\r\nI am a wife to my amazing and supportive husband OB and momma to our spunky fur son, Meatloaf who brings endless joy, an abundance of snuggles, so much hair and tons of mud to our household. He is reputable for nose boop marks on all of our windows! \r\n\r\nI possess a strong drive, unwavering determination, and a firm self-assurance as a determined and driven female professional. I also possess a strong drive to have way too many plants, pet every dog I meet (after asking), eating all of the good food, and watching all of the junk tv. I found someone who shares some loves of mine, side by side with the J to my A for the past 7 years we became known as the dynamic duo! \r\n\r\nLetting A&J's have your back with all of your cleaning, sanitizing, disinfecting, organizational requirements, and dog petting, whether for residential or commercial settings, will prove to be the “BEST” choice! Big or small, we clean them all!");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name", "PhotoPath", "Title" },
                values: new object[] { "Hi, my name is Danielle Franks and i am a loving mother to 3 beautiful children. At the age of 14, my first job was working in hotels, and I've had almost 10 years of cleaning experience . I took some time off during covid to raise my youngest and have since been with A.J.s for almost two years. It is so important to me to have a good relationship with the people that I work with and have found that with this company. I also enjoy getting to know our clients and their families, and I love pets of all kinds. It is a joy to come to work every day, and I find great satisfaction in a job well done.", "Danielle Franks", "/images/teams/teams_danielle.jpg", "Employee" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Janelle is the co owner of AJ's Cleaning");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Alyssah is the co owner of AJ's Cleaning.");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name", "PhotoPath", "Title" },
                values: new object[] { "I like long walks through the park, and the smell of rotisserie chicken. My cleaning specialty is licking plates clean.", "MeatLoaf", "/images/teams/Team-Meatloaf.jpg", "The Goodest Boy" });
        }
    }
}
