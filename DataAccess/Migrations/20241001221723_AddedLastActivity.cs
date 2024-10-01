using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedLastActivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastActivity",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 17, 21, 342, DateTimeKind.Utc).AddTicks(5176), new DateTime(2024, 10, 1, 22, 17, 21, 342, DateTimeKind.Utc).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 17, 21, 342, DateTimeKind.Utc).AddTicks(5180), new DateTime(2024, 10, 1, 22, 17, 21, 342, DateTimeKind.Utc).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 17, 21, 342, DateTimeKind.Utc).AddTicks(5181), new DateTime(2024, 10, 1, 22, 17, 21, 342, DateTimeKind.Utc).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 17, 21, 342, DateTimeKind.Utc).AddTicks(5239), new DateTime(2024, 10, 1, 22, 17, 21, 342, DateTimeKind.Utc).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 17, 21, 342, DateTimeKind.Utc).AddTicks(5241), new DateTime(2024, 10, 1, 22, 17, 21, 342, DateTimeKind.Utc).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 17, 21, 342, DateTimeKind.Utc).AddTicks(5242), new DateTime(2024, 10, 1, 22, 17, 21, 342, DateTimeKind.Utc).AddTicks(5242) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastActivity",
                table: "Users");

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
    }
}
