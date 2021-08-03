using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BoutiqueApi.Migrations
{
    public partial class afterVirtual3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                column: "RecordDate",
                value: new DateTime(2021, 7, 5, 22, 35, 7, 0, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                column: "RecordDate",
                value: new DateTime(2021, 7, 5, 22, 35, 7, 4, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "RecordDate",
                value: new DateTime(2021, 7, 5, 22, 35, 7, 4, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "RecordDate",
                value: new DateTime(2021, 7, 5, 22, 35, 7, 4, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Adress", "City", "CreatedBy", "Email", "FullName", "OrderDate", "OrderStatus", "PaymentDate", "PaymentStatus", "PhoneNumber", "ShipmentDate", "TotalPrice", "TransactionId" },
                values: new object[,]
                {
                    { 1, "TestAdress", "TestCity", "test@testmail.com", "test@testmail.com", "Test Name Test Surname", new DateTime(2021, 7, 5, 22, 35, 7, 5, DateTimeKind.Local).AddTicks(8090), "TestStatus", new DateTime(2021, 7, 5, 22, 35, 7, 5, DateTimeKind.Local).AddTicks(8770), "TestStatus", "12345678", new DateTime(2021, 7, 5, 22, 35, 7, 5, DateTimeKind.Local).AddTicks(9830), 20m, 1 },
                    { 2, "TestAdress", "TestCity", "test@testmail.com", "test@testmail.com", "Test Name Test Surname", new DateTime(2021, 7, 5, 22, 35, 7, 6, DateTimeKind.Local).AddTicks(950), "TestStatus", new DateTime(2021, 7, 5, 22, 35, 7, 6, DateTimeKind.Local).AddTicks(950), "TestStatus", "12345678", new DateTime(2021, 7, 5, 22, 35, 7, 6, DateTimeKind.Local).AddTicks(960), 20m, 1 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "OrderId", "ProductId", "Quantity", "Size" },
                values: new object[] { 1, 1, 2, 5, null });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "OrderId", "ProductId", "Quantity", "Size" },
                values: new object[] { 2, 1, 2, 5, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

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
        }
    }
}
