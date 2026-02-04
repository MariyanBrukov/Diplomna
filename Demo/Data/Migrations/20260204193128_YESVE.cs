using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class YESVE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 31, 27, 203, DateTimeKind.Utc).AddTicks(9276));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
