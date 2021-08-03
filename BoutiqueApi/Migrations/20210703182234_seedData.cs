using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BoutiqueApi.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RecordDate",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RecordDate",
                table: "Devices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "TestBrand1" },
                    { 2, "TestBrand2" },
                    { 3, "TestBrand3" },
                    { 4, "TestBrand4" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "TestCategory1" },
                    { 2, "TestCategory2" },
                    { 3, "TestCategory3" },
                    { 4, "TestCategory4" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Key", "Platform", "RecordDate" },
                values: new object[,]
                {
                    { 2, "TestKey2", "TestPlatform", new DateTime(2021, 7, 3, 21, 22, 34, 291, DateTimeKind.Local).AddTicks(1480) },
                    { 1, "TestKey1", "TestPlatform", new DateTime(2021, 7, 3, 21, 22, 34, 287, DateTimeKind.Local).AddTicks(6250) }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Message", "RecordDate", "Title" },
                values: new object[,]
                {
                    { 1, "Test Message", new DateTime(2021, 7, 3, 21, 22, 34, 291, DateTimeKind.Local).AddTicks(2780), "Test Title" },
                    { 2, "Test Message2", new DateTime(2021, 7, 3, 21, 22, 34, 291, DateTimeKind.Local).AddTicks(3460), "Test Title" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CampaignPrice", "CampaignStatus", "Category", "MostSalesProduct", "Name", "Price" },
                values: new object[,]
                {
                    { 11, "TestBrand4", 10m, true, "TestCategory4", true, "TestProduct11", 20m },
                    { 10, "TestBrand3", 10m, true, "TestCategory2", true, "TestProduct10", 20m },
                    { 9, "TestBrand3", 10m, true, "TestCategory2", true, "TestProduct9", 20m },
                    { 8, "TestBrand4", 10m, true, "TestCategory4", true, "TestProduct8", 20m },
                    { 7, "TestBrand", 10m, true, "TestCategory2", true, "TestProduct7", 20m },
                    { 1, "TestBrand1", 0m, false, "TestCategory1", true, "TestProduct1", 20m },
                    { 5, "TestBrand2", 0m, false, "TestCategory3", true, "TestProduct5", 20m },
                    { 4, "TestBrand3", 0m, false, "TestCategory3", true, "TestProduct4", 20m },
                    { 3, "TestBrand", 0m, false, "TestCategory2", true, "TestProduct3", 20m },
                    { 2, "TestBrand2", 0m, false, "TestCategory1", true, "TestProduct2", 20m },
                    { 12, "TestBrand2", 10m, true, "TestCategory1", true, "TestProduct12", 20m },
                    { 6, "TestBrand3", 10m, true, "TestCategory3", true, "TestProduct6", 20m },
                    { 13, "TestBrand1", 10m, true, "TestCategory1", true, "TestProduct13", 20m }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "ProductId", "Url" },
                values: new object[,]
                {
                    { 2, "TestImage2", 1, "TestLink" },
                    { 3, "TestImage3", 2, "TestLink" },
                    { 13, "TestImage2", 11, "TestLink" },
                    { 4, "TestImage2", 3, "TestLink" },
                    { 5, "TestImage3", 4, "TestLink" },
                    { 6, "TestImage2", 4, "TestLink" },
                    { 12, "TestImage3", 10, "TestLink" },
                    { 7, "TestImage3", 5, "TestLink" },
                    { 8, "TestImage3", 6, "TestLink" },
                    { 14, "TestImage3", 12, "TestLink" },
                    { 9, "TestImage2", 7, "TestLink" },
                    { 11, "TestImage2", 9, "TestLink" },
                    { 10, "TestImage3", 8, "TestLink" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 11, "S", 11, 5 },
                    { 10, "S", 10, 5 },
                    { 9, "S", 9, 5 },
                    { 6, "S", 6, 5 },
                    { 7, "S", 7, 5 },
                    { 5, "S", 5, 5 },
                    { 4, "S", 4, 5 },
                    { 3, "S", 3, 5 },
                    { 2, "S", 2, 5 },
                    { 1, "S", 1, 5 },
                    { 8, "S", 8, 5 },
                    { 12, "S", 12, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.AlterColumn<string>(
                name: "RecordDate",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "RecordDate",
                table: "Devices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
