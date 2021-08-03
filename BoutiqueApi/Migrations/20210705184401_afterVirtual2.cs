using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BoutiqueApi.Migrations
{
    public partial class afterVirtual2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                column: "RecordDate",
                value: new DateTime(2021, 7, 5, 21, 44, 1, 33, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                column: "RecordDate",
                value: new DateTime(2021, 7, 5, 21, 44, 1, 37, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "RecordDate",
                value: new DateTime(2021, 7, 5, 21, 44, 1, 38, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "RecordDate",
                value: new DateTime(2021, 7, 5, 21, 44, 1, 38, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 13, "M", 1, 5 },
                    { 14, "Xl", 1, 5 },
                    { 15, "XS", 1, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 15);

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
    }
}
