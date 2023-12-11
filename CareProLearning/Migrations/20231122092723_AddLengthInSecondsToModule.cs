using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CareProLearning.Migrations
{
    /// <inheritdoc />
    public partial class AddLengthInSecondsToModule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Modules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "LengthInSeconds",
                table: "Modules",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ProgressInSeconds",
                table: "Modules",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 1,
                columns: new[] { "IsCompleted", "LengthInSeconds", "ProgressInSeconds" },
                values: new object[] { false, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 2,
                columns: new[] { "IsCompleted", "LengthInSeconds", "ProgressInSeconds" },
                values: new object[] { false, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 3,
                columns: new[] { "IsCompleted", "LengthInSeconds", "ProgressInSeconds" },
                values: new object[] { false, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 4,
                columns: new[] { "IsCompleted", "LengthInSeconds", "ProgressInSeconds" },
                values: new object[] { false, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 5,
                columns: new[] { "IsCompleted", "LengthInSeconds", "ProgressInSeconds" },
                values: new object[] { false, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 6,
                columns: new[] { "IsCompleted", "LengthInSeconds", "ProgressInSeconds" },
                values: new object[] { false, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 7,
                columns: new[] { "IsCompleted", "LengthInSeconds", "ProgressInSeconds" },
                values: new object[] { false, 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 8,
                columns: new[] { "IsCompleted", "LengthInSeconds", "ProgressInSeconds" },
                values: new object[] { false, 0.0, 0.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "LengthInSeconds",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "ProgressInSeconds",
                table: "Modules");
        }
    }
}
