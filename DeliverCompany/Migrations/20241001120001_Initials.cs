using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeliverCompany.Migrations
{
    /// <inheritdoc />
    public partial class Initials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 9, 30, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 9, 29, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 9, 28, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 4,
                column: "NoteDate",
                value: new DateTime(2024, 9, 27, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 5,
                column: "NoteDate",
                value: new DateTime(2024, 9, 26, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 6,
                column: "NoteDate",
                value: new DateTime(2024, 9, 25, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 7,
                column: "NoteDate",
                value: new DateTime(2024, 9, 24, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 9, 30, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 9, 29, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 9, 28, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 4,
                column: "NoteDate",
                value: new DateTime(2024, 9, 27, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 5,
                column: "NoteDate",
                value: new DateTime(2024, 9, 26, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 6,
                column: "NoteDate",
                value: new DateTime(2024, 9, 25, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 7,
                column: "NoteDate",
                value: new DateTime(2024, 9, 24, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 8,
                column: "NoteDate",
                value: new DateTime(2024, 9, 23, 11, 25, 38, 514, DateTimeKind.Local).AddTicks(9246));
        }
    }
}
