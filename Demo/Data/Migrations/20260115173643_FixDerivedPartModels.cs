using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class FixDerivedPartModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Storages",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Storages",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedUtc",
                table: "Storages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Storages",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Storages",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Storages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "RAMs",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "RAMs",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedUtc",
                table: "RAMs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "RAMs",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "RAMs",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "RAMs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PowerSupplies",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "PowerSupplies",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedUtc",
                table: "PowerSupplies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PowerSupplies",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "PowerSupplies",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "PowerSupplies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Motherboards",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Motherboards",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedUtc",
                table: "Motherboards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Motherboards",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Motherboards",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Motherboards",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "GPUs",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "GPUs",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedUtc",
                table: "GPUs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "GPUs",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "GPUs",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "GPUs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CPUs",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "CPUs",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedUtc",
                table: "CPUs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CPUs",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "CPUs",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "CPUs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cases",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Cases",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedUtc",
                table: "Cases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Cases",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Cases",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Cases",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3577), null, null, true });

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3582), null, null, true });

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3583), null, null, true });

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3584), null, null, true });

            migrationBuilder.UpdateData(
                table: "CPUs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3585), null, null, true });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3822), null, null, true });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3824), null, null, true });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3825), null, null, true });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3826), null, null, true });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3827), null, null, true });

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3706), null, null, true });

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3709), null, null, true });

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3710), null, null, true });

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3711), null, null, true });

            migrationBuilder.UpdateData(
                table: "GPUs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3712), null, null, true });

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3733), null, null, true });

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3734), null, null, true });

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3735), null, null, true });

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3737), null, null, true });

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3738), null, null, true });

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3801), null, null, true });

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3802), null, null, true });

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3803), null, null, true });

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3804), null, null, true });

            migrationBuilder.UpdateData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3805), null, null, true });

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3757), null, null, true });

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3760), null, null, true });

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3761), null, null, true });

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3762), null, null, true });

            migrationBuilder.UpdateData(
                table: "RAMs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3763), null, null, true });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3780), null, null, true });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3781), null, null, true });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3782), null, null, true });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3783), null, null, true });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brand", "CreatedUtc", "Description", "ImageUrl", "IsActive" },
                values: new object[] { "", new DateTime(2026, 1, 15, 17, 36, 42, 455, DateTimeKind.Utc).AddTicks(3784), null, null, true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Storages");

            migrationBuilder.DropColumn(
                name: "CreatedUtc",
                table: "Storages");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Storages");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Storages");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Storages");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "RAMs");

            migrationBuilder.DropColumn(
                name: "CreatedUtc",
                table: "RAMs");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "RAMs");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "RAMs");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "RAMs");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "PowerSupplies");

            migrationBuilder.DropColumn(
                name: "CreatedUtc",
                table: "PowerSupplies");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "PowerSupplies");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "PowerSupplies");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "PowerSupplies");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Motherboards");

            migrationBuilder.DropColumn(
                name: "CreatedUtc",
                table: "Motherboards");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Motherboards");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Motherboards");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Motherboards");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "GPUs");

            migrationBuilder.DropColumn(
                name: "CreatedUtc",
                table: "GPUs");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "GPUs");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "GPUs");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "GPUs");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "CPUs");

            migrationBuilder.DropColumn(
                name: "CreatedUtc",
                table: "CPUs");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CPUs");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "CPUs");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "CPUs");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "CreatedUtc",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Cases");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Storages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "RAMs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PowerSupplies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Motherboards",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "GPUs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CPUs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cases",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);
        }
    }
}
