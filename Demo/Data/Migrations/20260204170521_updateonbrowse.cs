using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class updateonbrowse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 5, 19, 394, DateTimeKind.Utc).AddTicks(8775));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 51, 51, 47, DateTimeKind.Utc).AddTicks(8173));
        }
    }
}
