using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RemovedYearsFromWorkExperiece : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YearsOfExperience",
                table: "WorkExperiences");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 28, 21, 620, DateTimeKind.Utc).AddTicks(7923), new DateTime(2024, 10, 1, 17, 28, 21, 620, DateTimeKind.Utc).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 28, 21, 620, DateTimeKind.Utc).AddTicks(7927), new DateTime(2024, 10, 1, 17, 28, 21, 620, DateTimeKind.Utc).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 28, 21, 620, DateTimeKind.Utc).AddTicks(7928), new DateTime(2024, 10, 1, 17, 28, 21, 620, DateTimeKind.Utc).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 28, 21, 620, DateTimeKind.Utc).AddTicks(7990), new DateTime(2024, 10, 1, 17, 28, 21, 620, DateTimeKind.Utc).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 28, 21, 620, DateTimeKind.Utc).AddTicks(7991), new DateTime(2024, 10, 1, 17, 28, 21, 620, DateTimeKind.Utc).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 28, 21, 620, DateTimeKind.Utc).AddTicks(7992), new DateTime(2024, 10, 1, 17, 28, 21, 620, DateTimeKind.Utc).AddTicks(7992) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YearsOfExperience",
                table: "WorkExperiences",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 12, 26, 1, 35, DateTimeKind.Utc).AddTicks(7845), new DateTime(2024, 10, 1, 12, 26, 1, 35, DateTimeKind.Utc).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 12, 26, 1, 35, DateTimeKind.Utc).AddTicks(7848), new DateTime(2024, 10, 1, 12, 26, 1, 35, DateTimeKind.Utc).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 12, 26, 1, 35, DateTimeKind.Utc).AddTicks(7849), new DateTime(2024, 10, 1, 12, 26, 1, 35, DateTimeKind.Utc).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 12, 26, 1, 35, DateTimeKind.Utc).AddTicks(7942), new DateTime(2024, 10, 1, 12, 26, 1, 35, DateTimeKind.Utc).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 12, 26, 1, 35, DateTimeKind.Utc).AddTicks(7944), new DateTime(2024, 10, 1, 12, 26, 1, 35, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 12, 26, 1, 35, DateTimeKind.Utc).AddTicks(7945), new DateTime(2024, 10, 1, 12, 26, 1, 35, DateTimeKind.Utc).AddTicks(7945) });
        }
    }
}
