using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeliverCompany.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 10, 2, 9, 30, 7, 555, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 10, 1, 9, 30, 7, 555, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 9, 30, 9, 30, 7, 555, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 4,
                column: "NoteDate",
                value: new DateTime(2024, 9, 29, 9, 30, 7, 555, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 5,
                column: "NoteDate",
                value: new DateTime(2024, 9, 28, 9, 30, 7, 555, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 6,
                column: "NoteDate",
                value: new DateTime(2024, 9, 27, 9, 30, 7, 555, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 7,
                column: "NoteDate",
                value: new DateTime(2024, 9, 26, 9, 30, 7, 555, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 10, 2, 9, 30, 7, 555, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 10, 1, 9, 30, 7, 555, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 9, 30, 9, 30, 7, 555, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 4,
                column: "NoteDate",
                value: new DateTime(2024, 9, 29, 9, 30, 7, 555, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 5,
                column: "NoteDate",
                value: new DateTime(2024, 9, 28, 9, 30, 7, 555, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 6,
                column: "NoteDate",
                value: new DateTime(2024, 9, 27, 9, 30, 7, 555, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 7,
                column: "NoteDate",
                value: new DateTime(2024, 9, 26, 9, 30, 7, 555, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 8,
                column: "NoteDate",
                value: new DateTime(2024, 9, 25, 9, 30, 7, 555, DateTimeKind.Local).AddTicks(4478));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 10, 1, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 9, 30, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 9, 29, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 4,
                column: "NoteDate",
                value: new DateTime(2024, 9, 28, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 5,
                column: "NoteDate",
                value: new DateTime(2024, 9, 27, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 6,
                column: "NoteDate",
                value: new DateTime(2024, 9, 26, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 7,
                column: "NoteDate",
                value: new DateTime(2024, 9, 25, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 10, 1, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 9, 30, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 9, 29, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 4,
                column: "NoteDate",
                value: new DateTime(2024, 9, 28, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 5,
                column: "NoteDate",
                value: new DateTime(2024, 9, 27, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 6,
                column: "NoteDate",
                value: new DateTime(2024, 9, 26, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 7,
                column: "NoteDate",
                value: new DateTime(2024, 9, 25, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 8,
                column: "NoteDate",
                value: new DateTime(2024, 9, 24, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(4118));
        }
    }
}
