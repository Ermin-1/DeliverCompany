using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DeliverCompany.Migrations
{
    /// <inheritdoc />
    public partial class initialcreation : Migration
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

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "DriverID", "BeloppIn", "BeloppUt", "CarReg", "DriverName", "NoteDate", "NoteDescription", "ResponsibleEmployee", "TotalBeloppIn", "TotalBeloppUt" },
                values: new object[,]
                {
                    { 1, 500.00m, 200.00m, "ABC123", "Alice Smith", new DateTime(2024, 9, 19, 9, 27, 8, 981, DateTimeKind.Local).AddTicks(9684), "Completed delivery route", "John Doe", 500.00m, 200.00m },
                    { 2, 0.00m, 100.00m, "XYZ789", "Bob Johnson", new DateTime(2024, 9, 18, 9, 27, 8, 981, DateTimeKind.Local).AddTicks(9729), "Vehicle maintenance", "Admin User", 0.00m, 100.00m }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Email", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { 1, "admin@example.com", "Admin User", "admin123", "Admin" },
                    { 2, "john@example.com", "John Doe", "password123", "Employee" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
