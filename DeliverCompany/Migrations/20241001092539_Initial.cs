using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DeliverCompany.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarReg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoteDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponsibleEmployee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BeloppUt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BeloppIn = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalBeloppUt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalBeloppIn = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoteDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BeloppIn = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BeloppUt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DriverID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventID);
                    table.ForeignKey(
                        name: "FK_Events_Drivers_DriverID",
                        column: x => x.DriverID,
                        principalTable: "Drivers",
                        principalColumn: "DriverID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "DriverID", "BeloppIn", "BeloppUt", "CarReg", "DriverName", "NoteDate", "NoteDescription", "ResponsibleEmployee", "TotalBeloppIn", "TotalBeloppUt" },
                values: new object[,]
                {
                    { 1, 500.00m, 200.00m, "ABC123", "Alice Smith", new DateTime(2024, 9, 30, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9055), "Completed delivery route", "John Doe", 500.00m, 200.00m },
                    { 2, 0.00m, 100.00m, "XYZ789", "Bob Johnson", new DateTime(2024, 9, 29, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9098), "Vehicle maintenance", "Admin User", 0.00m, 100.00m },
                    { 3, 400.00m, 150.00m, "LMN456", "Michael Brown", new DateTime(2024, 9, 28, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9101), "Delivered groceries", "Jane Doe", 400.00m, 150.00m },
                    { 4, 600.00m, 200.00m, "JKL789", "Emma Wilson", new DateTime(2024, 9, 27, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9104), "Completed overnight delivery", "Tom Hardy", 600.00m, 200.00m },
                    { 5, 700.00m, 300.00m, "OPQ123", "Oliver Martinez", new DateTime(2024, 9, 26, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9107), "Completed furniture delivery", "Emily Davis", 700.00m, 300.00m },
                    { 6, 1000.00m, 400.00m, "RST456", "Lucas Green", new DateTime(2024, 9, 25, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9110), "Delivered medical supplies", "Sophia Turner", 1000.00m, 400.00m },
                    { 7, 1200.00m, 500.00m, "UVW789", "Liam White", new DateTime(2024, 9, 24, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9112), "Delivered electronics", "Luke Perry", 1200.00m, 500.00m }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Email", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { 1, "admin@example.com", "Admin User", "admin123", "Admin" },
                    { 2, "john@example.com", "John Doe", "password123", "Employee" },
                    { 3, "jane@example.com", "Jane Doe", "password123", "Employee" },
                    { 4, "tom@example.com", "Tom Hardy", "hardy123", "Employee" },
                    { 5, "emily@example.com", "Emily Davis", "davis123", "Employee" },
                    { 6, "sophia@example.com", "Sophia Turner", "turner123", "Employee" },
                    { 7, "luke@example.com", "Luke Perry", "perry123", "Employee" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventID", "BeloppIn", "BeloppUt", "DriverID", "NoteDate", "NoteDescription" },
                values: new object[,]
                {
                    { 1, 400.00m, 50.00m, 1, new DateTime(2024, 9, 30, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9230), "Delivered goods to customer" },
                    { 2, 0.00m, 300.00m, 2, new DateTime(2024, 9, 29, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9233), "Vehicle repaired" },
                    { 3, 0.00m, 100.00m, 1, new DateTime(2024, 9, 28, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9235), "Picked up supplies" },
                    { 4, 400.00m, 50.00m, 3, new DateTime(2024, 9, 27, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9238), "Delivered groceries" },
                    { 5, 600.00m, 100.00m, 4, new DateTime(2024, 9, 26, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9240), "Completed overnight delivery" },
                    { 6, 700.00m, 150.00m, 5, new DateTime(2024, 9, 25, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9242), "Furniture delivered" },
                    { 7, 1000.00m, 200.00m, 6, new DateTime(2024, 9, 24, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9244), "Delivered medical supplies" },
                    { 8, 1200.00m, 300.00m, 7, new DateTime(2024, 9, 23, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9246), "Delivered electronics" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_DriverID",
                table: "Events",
                column: "DriverID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
