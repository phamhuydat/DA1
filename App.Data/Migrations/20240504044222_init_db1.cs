using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class init_db1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(9050), new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(9050), new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.InsertData(
                table: "AppRolePermission",
                columns: new[] { "Id", "AppRoleId", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "MstPermissionId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1101, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 2, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1102, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 3, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1103, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 4, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1104, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 5, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1105, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 6, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1001, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 7, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1002, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 8, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1003, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 9, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1004, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 10, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1005, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 11, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1006, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 12, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1007, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 13, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1008, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 14, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1205, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 15, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1301, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 16, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1302, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 17, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1303, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 18, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1304, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 19, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1401, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 20, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1402, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 21, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1403, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 22, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1404, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 23, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1501, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 24, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1502, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 25, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1503, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 26, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1504, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 27, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1701, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 28, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1702, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 29, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1703, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 30, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1704, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 31, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1901, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 32, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1902, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 33, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1903, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 34, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 1904, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 35, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2001, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 36, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2002, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 37, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2003, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 38, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2004, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 39, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2005, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 40, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2101, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 41, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2102, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 42, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2103, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 43, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2104, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 44, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2201, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 45, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2202, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 46, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2203, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 47, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2204, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 48, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2205, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 49, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2206, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 50, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2207, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 51, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2208, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 52, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2301, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 53, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2302, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 54, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2401, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 55, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2402, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 56, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2403, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 57, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2404, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 58, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2501, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 59, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2502, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 60, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2503, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 61, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2504, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 62, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2506, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 63, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2507, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 64, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2508, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 65, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2601, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 66, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2602, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 67, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2603, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) },
                    { 68, 2, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), null, null, 2604, null, new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) }
                });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 188, 26, 128, 51, 98, 218, 76, 98, 234, 101, 146, 135, 186, 29, 28, 133, 48, 70, 150, 220, 7, 249, 80, 111, 201, 201, 150, 128, 67, 19, 119, 57, 22, 219, 57, 128, 106, 255, 46, 101, 236, 195, 117, 104, 155, 244, 186, 90, 219, 57, 216, 142, 16, 137, 133, 140, 246, 99, 224, 174, 195, 203, 205, 24 }, new byte[] { 191, 19, 163, 20, 178, 191, 196, 142, 51, 44, 69, 165, 81, 157, 38, 85, 222, 47, 92, 234, 144, 68, 49, 33, 238, 8, 149, 230, 149, 56, 33, 63, 155, 148, 104, 150, 235, 58, 107, 44, 64, 99, 204, 29, 225, 23, 128, 231, 103, 116, 21, 35, 118, 140, 211, 32, 189, 221, 106, 36, 147, 15, 147, 254, 114, 129, 112, 196, 76, 17, 221, 243, 203, 76, 142, 40, 188, 121, 192, 187, 146, 201, 219, 116, 165, 53, 224, 41, 155, 134, 195, 172, 1, 93, 123, 6, 135, 123, 44, 149, 180, 41, 85, 49, 193, 250, 207, 140, 187, 76, 144, 84, 2, 138, 251, 200, 52, 139, 62, 155, 16, 205, 128, 98, 20, 214, 36, 124 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1101,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1102,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1103,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1104,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1105,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1205,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1303,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1304,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1401,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1402,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1403,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1404,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1501,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1502,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1503,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1504,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1701,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1702,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1703,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1704,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1901,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1902,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1903,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1904,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2101,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2102,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2103,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2104,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2201,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2202,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2203,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2204,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2205,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2206,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2207,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2208,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2401,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2402,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2403,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2404,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2501,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2502,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2503,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2504,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2506,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2507,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2508,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2601,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2602,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2603,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2604,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 33, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(1957));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4377), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4377), new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 137, 25, 119, 216, 60, 187, 90, 119, 54, 163, 100, 173, 95, 59, 227, 219, 81, 130, 118, 197, 19, 77, 182, 110, 58, 206, 3, 149, 13, 211, 23, 177, 85, 148, 179, 107, 9, 181, 200, 89, 205, 60, 85, 90, 185, 214, 196, 151, 127, 199, 3, 155, 154, 124, 95, 44, 247, 174, 160, 178, 245, 175, 75, 131 }, new byte[] { 114, 236, 14, 76, 94, 31, 112, 225, 183, 188, 207, 105, 86, 206, 201, 104, 164, 12, 188, 145, 179, 52, 126, 0, 119, 51, 250, 22, 121, 125, 250, 165, 133, 206, 76, 207, 238, 112, 113, 214, 42, 221, 213, 126, 49, 233, 106, 205, 197, 121, 248, 60, 149, 175, 100, 171, 133, 248, 72, 67, 170, 69, 102, 188, 92, 96, 203, 73, 116, 39, 63, 99, 98, 200, 243, 195, 204, 175, 69, 165, 8, 167, 107, 57, 173, 155, 78, 16, 140, 152, 207, 126, 81, 126, 3, 66, 161, 220, 66, 48, 50, 9, 206, 55, 30, 28, 90, 242, 2, 97, 160, 179, 187, 188, 1, 97, 30, 22, 11, 153, 87, 34, 29, 119, 117, 179, 103, 228 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1101,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1102,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1103,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1104,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1105,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1205,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1303,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1304,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1401,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1402,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1403,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1404,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1501,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1502,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1503,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1504,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1701,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1702,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1703,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1704,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1901,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1902,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1903,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1904,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2101,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2102,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2103,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2104,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2201,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2202,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2203,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2204,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2205,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2206,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2207,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2208,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2401,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2402,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2403,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2404,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2501,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2502,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2503,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2504,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2506,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2507,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2508,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2601,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2602,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2603,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2604,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6509));
        }
    }
}
