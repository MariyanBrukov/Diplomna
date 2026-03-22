using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminAndContactReply : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedUtc",
                value: new DateTime(2026, 3, 22, 12, 27, 2, 905, DateTimeKind.Utc).AddTicks(8786));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
