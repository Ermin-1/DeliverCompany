using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeliverCompany.Migrations
{
    /// <inheritdoc />
    public partial class AloowNullNote : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NoteDescription",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 10, 1, 10, 19, 26, 297, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 9, 30, 10, 19, 26, 297, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 9, 29, 10, 19, 26, 297, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 4,
                column: "NoteDate",
                value: new DateTime(2024, 9, 28, 10, 19, 26, 297, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 5,
                column: "NoteDate",
                value: new DateTime(2024, 9, 27, 10, 19, 26, 297, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 6,
                column: "NoteDate",
                value: new DateTime(2024, 9, 26, 10, 19, 26, 297, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 7,
                column: "NoteDate",
                value: new DateTime(2024, 9, 25, 10, 19, 26, 297, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 10, 1, 10, 19, 26, 297, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 9, 30, 10, 19, 26, 297, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 9, 29, 10, 19, 26, 297, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 4,
                column: "NoteDate",
                value: new DateTime(2024, 9, 28, 10, 19, 26, 297, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 5,
                column: "NoteDate",
                value: new DateTime(2024, 9, 27, 10, 19, 26, 297, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 6,
                column: "NoteDate",
                value: new DateTime(2024, 9, 26, 10, 19, 26, 297, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 7,
                column: "NoteDate",
                value: new DateTime(2024, 9, 25, 10, 19, 26, 297, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 8,
                column: "NoteDate",
                value: new DateTime(2024, 9, 24, 10, 19, 26, 297, DateTimeKind.Local).AddTicks(4759));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NoteDescription",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 9, 30, 14, 0, 1, 175, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 9, 29, 14, 0, 1, 175, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 9, 28, 14, 0, 1, 175, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 4,
                column: "NoteDate",
                value: new DateTime(2024, 9, 27, 14, 0, 1, 175, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 5,
                column: "NoteDate",
                value: new DateTime(2024, 9, 26, 14, 0, 1, 175, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 6,
                column: "NoteDate",
                value: new DateTime(2024, 9, 25, 14, 0, 1, 175, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 7,
                column: "NoteDate",
                value: new DateTime(2024, 9, 24, 14, 0, 1, 175, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 9, 30, 14, 0, 1, 175, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 9, 29, 14, 0, 1, 175, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 9, 28, 14, 0, 1, 175, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 4,
                column: "NoteDate",
                value: new DateTime(2024, 9, 27, 14, 0, 1, 175, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 5,
                column: "NoteDate",
                value: new DateTime(2024, 9, 26, 14, 0, 1, 175, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 6,
                column: "NoteDate",
                value: new DateTime(2024, 9, 25, 14, 0, 1, 175, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 7,
                column: "NoteDate",
                value: new DateTime(2024, 9, 24, 14, 0, 1, 175, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 8,
                column: "NoteDate",
                value: new DateTime(2024, 9, 23, 14, 0, 1, 175, DateTimeKind.Local).AddTicks(1162));
        }
    }
}
