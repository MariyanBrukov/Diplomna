using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class secondtest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 35, 22, 360, DateTimeKind.Utc).AddTicks(4334));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
