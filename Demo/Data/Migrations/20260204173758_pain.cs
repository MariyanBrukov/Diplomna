using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class pain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 17, 37, 56, 846, DateTimeKind.Utc).AddTicks(4378));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
