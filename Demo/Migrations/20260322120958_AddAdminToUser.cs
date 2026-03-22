using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 9, 57, 391, DateTimeKind.Utc).AddTicks(1758));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5219));
        }
    }
}
