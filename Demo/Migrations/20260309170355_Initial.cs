using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormFactor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CPUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Socket = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cores = table.Column<int>(type: "int", nullable: false),
                    ClockSpeedGHz = table.Column<float>(type: "real", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GPUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemoryGB = table.Column<int>(type: "int", nullable: false),
                    Chipset = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motherboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Socket = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormFactor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PowerSupplies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Wattage = table.Column<int>(type: "int", nullable: false),
                    Efficiency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerSupplies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RAMs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CapacityGB = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpeedMHz = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapacityGB = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Builds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CPUId = table.Column<int>(type: "int", nullable: false),
                    GPUId = table.Column<int>(type: "int", nullable: false),
                    MotherboardId = table.Column<int>(type: "int", nullable: false),
                    RAMId = table.Column<int>(type: "int", nullable: false),
                    StorageId = table.Column<int>(type: "int", nullable: false),
                    PowerSupplyId = table.Column<int>(type: "int", nullable: false),
                    CaseId = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Builds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Builds_CPUs_CPUId",
                        column: x => x.CPUId,
                        principalTable: "CPUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Builds_Cases_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Cases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Builds_GPUs_GPUId",
                        column: x => x.GPUId,
                        principalTable: "GPUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Builds_Motherboards_MotherboardId",
                        column: x => x.MotherboardId,
                        principalTable: "Motherboards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Builds_PowerSupplies_PowerSupplyId",
                        column: x => x.PowerSupplyId,
                        principalTable: "PowerSupplies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Builds_RAMs_RAMId",
                        column: x => x.RAMId,
                        principalTable: "RAMs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Builds_Storages_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Builds_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CPUs",
                columns: new[] { "Id", "Brand", "ClockSpeedGHz", "Cores", "CreatedUtc", "Description", "ImageUrl", "IsActive", "Name", "Price", "Socket" },
                values: new object[,]
                {
                    { 1, "", 2.5f, 6, new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4649), null, null, true, "Intel Core i5-12400F", 160m, "LGA1700" },
                    { 2, "", 3.4f, 16, new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4655), null, null, true, "Intel Core i7-13700K", 420m, "LGA1700" },
                    { 3, "", 3.5f, 6, new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4657), null, null, true, "AMD Ryzen 5 5600", 140m, "AM4" },
                    { 4, "", 4.2f, 8, new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4658), null, null, true, "AMD Ryzen 7 7800X3D", 400m, "AM5" },
                    { 5, "", 3.2f, 24, new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4659), null, null, true, "Intel Core i9-14900K", 600m, "LGA1700" }
                });

            migrationBuilder.InsertData(
                table: "Cases",
                columns: new[] { "Id", "Brand", "Color", "CreatedUtc", "Description", "FormFactor", "ImageUrl", "IsActive", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "", "White", new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5266), null, "ATX", null, true, "NZXT H510", 80m },
                    { 2, "", "Black", new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5268), null, "ATX", null, true, "Lian Li Lancool II Mesh", 100m },
                    { 3, "", "Black", new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5269), null, "Mini-ITX", null, true, "Cooler Master NR200", 90m },
                    { 4, "", "Black", new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5270), null, "ATX", null, true, "Fractal Design Meshify 2", 140m },
                    { 5, "", "White", new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5271), null, "ATX", null, true, "Corsair 4000D Airflow", 120m }
                });

            migrationBuilder.InsertData(
                table: "GPUs",
                columns: new[] { "Id", "Brand", "Chipset", "CreatedUtc", "Description", "ImageUrl", "IsActive", "MemoryGB", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "", "Ada Lovelace", new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4799), null, null, true, 8, "NVIDIA RTX 4060", 300m },
                    { 2, "", "Ada Lovelace", new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4801), null, null, true, 12, "NVIDIA RTX 4070", 550m },
                    { 3, "", "RDNA 3", new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4802), null, null, true, 8, "AMD Radeon RX 7600", 270m },
                    { 4, "", "RDNA 3", new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4803), null, null, true, 20, "AMD Radeon RX 7900 XT", 750m },
                    { 5, "", "Ada Lovelace", new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4804), null, null, true, 24, "NVIDIA RTX 4090", 1600m }
                });

            migrationBuilder.InsertData(
                table: "Motherboards",
                columns: new[] { "Id", "Brand", "CreatedUtc", "Description", "FormFactor", "ImageUrl", "IsActive", "Name", "Price", "Socket" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4827), null, "Micro-ATX", null, true, "ASUS TUF Gaming B660M-PLUS", 150m, "LGA1700" },
                    { 2, "", new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4829), null, "ATX", null, true, "MSI MAG B550 TOMAHAWK", 180m, "AM4" },
                    { 3, "", new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4830), null, "ATX", null, true, "Gigabyte X670 AORUS ELITE", 230m, "AM5" },
                    { 4, "", new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4831), null, "ATX", null, true, "ASRock Z790 Steel Legend", 220m, "LGA1700" },
                    { 5, "", new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4832), null, "ATX", null, true, "MSI PRO B650-P", 200m, "AM5" }
                });

            migrationBuilder.InsertData(
                table: "PowerSupplies",
                columns: new[] { "Id", "Brand", "CreatedUtc", "Description", "Efficiency", "ImageUrl", "IsActive", "Name", "Price", "Wattage" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5239), null, "80+ Gold", null, true, "Corsair RM750e", 100m, 750 },
                    { 2, "", new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5240), null, "80+ Bronze", null, true, "EVGA 600 BR", 50m, 600 },
                    { 3, "", new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5242), null, "80+ Gold", null, true, "Seasonic Focus GX-850", 120m, 850 },
                    { 4, "", new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5243), null, "80+ Bronze", null, true, "Cooler Master MWE 650", 70m, 650 },
                    { 5, "", new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5244), null, "80+ Platinum", null, true, "ASUS ROG Loki 1000W", 250m, 1000 }
                });

            migrationBuilder.InsertData(
                table: "RAMs",
                columns: new[] { "Id", "Brand", "CapacityGB", "CreatedUtc", "Description", "ImageUrl", "IsActive", "Name", "Price", "SpeedMHz", "Type" },
                values: new object[,]
                {
                    { 1, "", 16, new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4852), null, null, true, "Corsair Vengeance LPX 16GB", 50m, 3200, "DDR4" },
                    { 2, "", 32, new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4853), null, null, true, "G.Skill Trident Z5 32GB", 160m, 6000, "DDR5" },
                    { 3, "", 16, new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4855), null, null, true, "Kingston Fury Beast 16GB", 55m, 3600, "DDR4" },
                    { 4, "", 32, new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4856), null, null, true, "Crucial DDR5 32GB", 140m, 5600, "DDR5" },
                    { 5, "", 16, new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(4857), null, null, true, "TeamGroup T-Force Delta RGB 16GB", 60m, 3200, "DDR4" }
                });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Brand", "CapacityGB", "CreatedUtc", "Description", "ImageUrl", "IsActive", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 1, "", 1000, new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5214), null, null, true, "Samsung 970 EVO Plus", 90m, "NVMe SSD" },
                    { 2, "", 1000, new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5216), null, null, true, "Crucial MX500", 70m, "SSD" },
                    { 3, "", 500, new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5217), null, null, true, "WD Blue SN570", 40m, "NVMe SSD" },
                    { 4, "", 2000, new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5218), null, null, true, "Seagate Barracuda", 60m, "HDD" },
                    { 5, "", 2000, new DateTime(2026, 3, 9, 17, 3, 54, 718, DateTimeKind.Utc).AddTicks(5219), null, null, true, "Kingston KC3000", 160m, "NVMe SSD" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Builds_CaseId",
                table: "Builds",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_CPUId",
                table: "Builds",
                column: "CPUId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_GPUId",
                table: "Builds",
                column: "GPUId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_MotherboardId",
                table: "Builds",
                column: "MotherboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_PowerSupplyId",
                table: "Builds",
                column: "PowerSupplyId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_RAMId",
                table: "Builds",
                column: "RAMId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_StorageId",
                table: "Builds",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_UserId",
                table: "Builds",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Builds");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "CPUs");

            migrationBuilder.DropTable(
                name: "Cases");

            migrationBuilder.DropTable(
                name: "GPUs");

            migrationBuilder.DropTable(
                name: "Motherboards");

            migrationBuilder.DropTable(
                name: "PowerSupplies");

            migrationBuilder.DropTable(
                name: "RAMs");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
