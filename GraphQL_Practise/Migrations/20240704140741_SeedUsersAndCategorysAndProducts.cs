using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GraphQLPractise.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsersAndCategorysAndProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryKey", "CategoryName", "CreatedOn", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "Bags", new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9137), new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9137) },
                    { 2, "Shoes", new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9140), new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9141) },
                    { 3, "Clothing", new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9142), new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9143) },
                    { 4, "Accessories", new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9144), new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9145) },
                    { 5, "Electronics", new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9146), new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9147) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CategoryKey", "CreatedOn", "Description", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9171), null, "School Bag", new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9172) },
                    { 2, 2, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9176), null, "Running Shoes", new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9177) },
                    { 3, 3, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9179), null, "T-Shirt", new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9179) },
                    { 4, 4, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9181), null, "Leather Belt", new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9182) },
                    { 5, 5, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9183), null, "Smartphone", new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9184) },
                    { 6, 1, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9186), null, "Laptop Bag", new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9186) },
                    { 7, 2, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9188), null, "Sandals", new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9188) },
                    { 8, 3, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9189), null, "Jacket", new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9190) },
                    { 9, 4, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9191), null, "Watch", new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9192) },
                    { 10, 5, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9194), null, "Tablet", new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9195) },
                    { 11, 1, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9196), null, "Travel Bag", new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9197) },
                    { 12, 2, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9198), null, "Formal Shoes", new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9198) },
                    { 13, 3, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9200), null, "Jeans", new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9200) },
                    { 14, 4, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9202), null, "Necklace", new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9202) },
                    { 15, 5, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9204), null, "Headphones", new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9204) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserKey", "CreatedOn", "UpdatedOn", "UserEmail", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9059), new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9075), "shehrozmalik665@gmail.com", "Shehroz Ali" },
                    { 2, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9084), new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9085), "ali@gmail.com", "Ali" },
                    { 3, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9086), new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9087), "jawad@gmail.com", "Jawad" },
                    { 4, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9088), new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9089), "wahab@gmail.com", "Wahab" },
                    { 5, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9090), new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9090), "waqas@gmail.com", "Waqas" },
                    { 6, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9093), new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9094), "hassan@gmail.com", "Hassan" },
                    { 7, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9095), new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9096), "usman@gmail.com", "Usman" },
                    { 8, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9097), new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9097), "ahmad@gmail.com", "Ahmad" },
                    { 9, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9099), new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9099), "bilal@gmail.com", "Bilal" },
                    { 10, new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9101), new DateTime(2024, 7, 4, 19, 7, 41, 574, DateTimeKind.Local).AddTicks(9101), "noman@gmail.com", "Noman" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryKey",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryKey",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryKey",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryKey",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryKey",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserKey",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserKey",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserKey",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserKey",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserKey",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserKey",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserKey",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserKey",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserKey",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserKey",
                keyValue: 10);
        }
    }
}
