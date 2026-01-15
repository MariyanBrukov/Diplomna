using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class fixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3784));
        }
    }
}
