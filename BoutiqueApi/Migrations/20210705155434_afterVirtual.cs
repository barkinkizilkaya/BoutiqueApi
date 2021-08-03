using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BoutiqueApi.Migrations
{
    public partial class afterVirtual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                column: "RecordDate",
                value: new DateTime(2021, 7, 5, 18, 54, 33, 546, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                column: "RecordDate",
                value: new DateTime(2021, 7, 5, 18, 54, 33, 550, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "RecordDate",
                value: new DateTime(2021, 7, 5, 18, 54, 33, 550, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "RecordDate",
                value: new DateTime(2021, 7, 5, 18, 54, 33, 550, DateTimeKind.Local).AddTicks(3900));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                column: "RecordDate",
                value: new DateTime(2021, 7, 3, 21, 22, 34, 287, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                column: "RecordDate",
                value: new DateTime(2021, 7, 3, 21, 22, 34, 291, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "RecordDate",
                value: new DateTime(2021, 7, 3, 21, 22, 34, 291, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "RecordDate",
                value: new DateTime(2021, 7, 3, 21, 22, 34, 291, DateTimeKind.Local).AddTicks(3460));
        }
    }
}
