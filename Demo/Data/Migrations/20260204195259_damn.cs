using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class damn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 2, 4, 19, 52, 58, 70, DateTimeKind.Utc).AddTicks(5394));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
