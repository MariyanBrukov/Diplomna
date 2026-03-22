using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 33, 23, 288, DateTimeKind.Utc).AddTicks(799));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateCreated", "Email", "IsAdmin", "Password", "Username" },
                values: new object[] { 999, new DateTime(2026, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@pcjunkie.com", true, "admin123", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8786));
        }
    }
}
