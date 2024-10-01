using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 30, 17, 48, 20, 643, DateTimeKind.Utc).AddTicks(2827), new DateTime(2024, 9, 30, 17, 48, 20, 643, DateTimeKind.Utc).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 30, 17, 48, 20, 643, DateTimeKind.Utc).AddTicks(2830), new DateTime(2024, 9, 30, 17, 48, 20, 643, DateTimeKind.Utc).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 30, 17, 48, 20, 643, DateTimeKind.Utc).AddTicks(2832), new DateTime(2024, 9, 30, 17, 48, 20, 643, DateTimeKind.Utc).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 30, 17, 48, 20, 643, DateTimeKind.Utc).AddTicks(2910), new DateTime(2024, 9, 30, 17, 48, 20, 643, DateTimeKind.Utc).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 30, 17, 48, 20, 643, DateTimeKind.Utc).AddTicks(2911), new DateTime(2024, 9, 30, 17, 48, 20, 643, DateTimeKind.Utc).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 30, 17, 48, 20, 643, DateTimeKind.Utc).AddTicks(2912), new DateTime(2024, 9, 30, 17, 48, 20, 643, DateTimeKind.Utc).AddTicks(2913) });
        }
    }
}
