using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 28, 53, 775, DateTimeKind.Utc).AddTicks(1765));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
