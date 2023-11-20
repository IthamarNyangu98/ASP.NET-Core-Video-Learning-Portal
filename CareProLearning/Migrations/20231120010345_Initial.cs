using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CareProLearning.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    ModuleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbnailImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.ModuleId);
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "ModuleId", "Category", "Description", "ThumbnailImagePath", "Title", "VideoUrl" },
                values: new object[,]
                {
                    { 1, "Labs", "How to access labs", "/images/Labs1.jpg", "Labs", "/videos/LabOrder.mp4" },
                    { 2, "Labs", "How to access labs 2", "/images/Lab2.jpg", "Math Basics", "/videos/Drugs.mp4" },
                    { 3, "Registration", "How to register a patient", "/images/register1.jpg", "Registration", "/videos/Register.mp4" },
                    { 4, "Registration", "How to register a patient 2", "/images/register2.jpg", "Registration Video Two", "/videos/Starting.mp4" },
                    { 5, "Vitals", "Vitals Vid", "/images/Vitals1.jpg", "Vitals Video One", "/videos/Vitals.mp4" },
                    { 6, "Vitals", "Vitals Vid Two", "/images/Vitals2.jpg", "Vitals Video Two", "/videos/Visit.mp4" },
                    { 7, "Reports", "MER Reports", "/images/report1.jpeg", "Reports", "/videos/ARTClient.mp4" },
                    { 8, "Reports", "MER Reports Video Two", "/images/report2.jpg", "Reports", "/videos/Reports.mp4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Modules");
        }
    }
}
