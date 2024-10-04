using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeliverCompany.Migrations
{
    /// <inheritdoc />
    public partial class Updatess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 10, 2, 13, 38, 11, 446, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 10, 1, 13, 38, 11, 446, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 9, 30, 13, 38, 11, 446, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 4,
                column: "NoteDate",
                value: new DateTime(2024, 9, 29, 13, 38, 11, 446, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 5,
                column: "NoteDate",
                value: new DateTime(2024, 9, 28, 13, 38, 11, 446, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 6,
                column: "NoteDate",
                value: new DateTime(2024, 9, 27, 13, 38, 11, 446, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 7,
                column: "NoteDate",
                value: new DateTime(2024, 9, 26, 13, 38, 11, 446, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 10, 2, 13, 38, 11, 446, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 10, 1, 13, 38, 11, 446, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 9, 30, 13, 38, 11, 446, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 4,
                column: "NoteDate",
                value: new DateTime(2024, 9, 29, 13, 38, 11, 446, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 5,
                column: "NoteDate",
                value: new DateTime(2024, 9, 28, 13, 38, 11, 446, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 6,
                column: "NoteDate",
                value: new DateTime(2024, 9, 27, 13, 38, 11, 446, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 7,
                column: "NoteDate",
                value: new DateTime(2024, 9, 26, 13, 38, 11, 446, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 8,
                column: "NoteDate",
                value: new DateTime(2024, 9, 25, 13, 38, 11, 446, DateTimeKind.Local).AddTicks(5700));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
