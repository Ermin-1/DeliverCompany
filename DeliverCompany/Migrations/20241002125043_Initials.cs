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
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 10, 1, 14, 46, 57, 949, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 9, 30, 14, 46, 57, 949, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 9, 29, 14, 46, 57, 949, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 4,
                column: "NoteDate",
                value: new DateTime(2024, 9, 28, 14, 46, 57, 949, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 5,
                column: "NoteDate",
                value: new DateTime(2024, 9, 27, 14, 46, 57, 949, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 6,
                column: "NoteDate",
                value: new DateTime(2024, 9, 26, 14, 46, 57, 949, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 7,
                column: "NoteDate",
                value: new DateTime(2024, 9, 25, 14, 46, 57, 949, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 10, 1, 14, 46, 57, 949, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 9, 30, 14, 46, 57, 949, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 9, 29, 14, 46, 57, 949, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 4,
                column: "NoteDate",
                value: new DateTime(2024, 9, 28, 14, 46, 57, 949, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 5,
                column: "NoteDate",
                value: new DateTime(2024, 9, 27, 14, 46, 57, 949, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 6,
                column: "NoteDate",
                value: new DateTime(2024, 9, 26, 14, 46, 57, 949, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 7,
                column: "NoteDate",
                value: new DateTime(2024, 9, 25, 14, 46, 57, 949, DateTimeKind.Local).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 8,
                column: "NoteDate",
                value: new DateTime(2024, 9, 24, 14, 46, 57, 949, DateTimeKind.Local).AddTicks(9994));
        }
    }
}
