using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class sumtin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 4, 10, 20, 57, 14, 864, DateTimeKind.Utc).AddTicks(811));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
