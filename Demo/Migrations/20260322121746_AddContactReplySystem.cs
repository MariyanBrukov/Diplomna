using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class AddContactReplySystem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdminReply",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsAnswered",
                table: "Contacts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReplyDate",
                table: "Contacts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 17, 45, 721, DateTimeKind.Utc).AddTicks(8529));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminReply",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "IsAnswered",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "ReplyDate",
                table: "Contacts");

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
    }
}
