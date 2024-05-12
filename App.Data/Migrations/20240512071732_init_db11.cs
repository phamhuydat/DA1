using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class init_db11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductCode",
                table: "AppProduct");

            migrationBuilder.AddColumn<string>(
                name: "ProductCode",
                table: "AppProductDetail",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "AppDiscountCode",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 237, DateTimeKind.Local).AddTicks(1378), new DateTime(2024, 5, 12, 14, 17, 31, 237, DateTimeKind.Local).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "AppDiscountCode",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 237, DateTimeKind.Local).AddTicks(1378), new DateTime(2024, 5, 12, 14, 17, 31, 237, DateTimeKind.Local).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 237, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 237, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 237, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 237, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 237, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 237, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8384), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8384), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 44, 91, 246, 96, 1, 169, 151, 150, 72, 197, 222, 20, 82, 46, 92, 180, 128, 43, 29, 186, 177, 150, 210, 236, 96, 181, 112, 49, 207, 144, 101, 79, 211, 154, 206, 74, 100, 76, 231, 179, 220, 255, 128, 147, 190, 241, 65, 198, 145, 194, 234, 225, 220, 229, 146, 157, 90, 6, 207, 89, 224, 202, 168, 203 }, new byte[] { 80, 125, 138, 22, 63, 203, 144, 159, 88, 110, 195, 148, 49, 205, 226, 156, 205, 210, 233, 250, 14, 170, 217, 117, 14, 225, 82, 138, 164, 199, 173, 221, 18, 43, 29, 225, 248, 64, 28, 126, 199, 204, 227, 225, 65, 104, 196, 159, 26, 105, 148, 120, 208, 138, 20, 23, 212, 131, 198, 65, 198, 35, 109, 40, 203, 60, 142, 59, 206, 127, 208, 121, 220, 157, 244, 187, 149, 137, 162, 109, 75, 156, 191, 19, 50, 159, 142, 42, 228, 40, 175, 124, 46, 35, 96, 45, 130, 188, 70, 127, 167, 144, 95, 181, 178, 197, 64, 9, 29, 240, 196, 239, 72, 122, 67, 1, 237, 96, 72, 42, 251, 138, 141, 255, 93, 171, 213, 244 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 237, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 237, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 237, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 237, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1101,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1102,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1103,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1104,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1105,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1205,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1303,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1304,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1401,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1402,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1403,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1404,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1501,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1502,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1503,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1504,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1701,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1702,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1703,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1704,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1901,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1902,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1903,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1904,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2101,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2102,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2103,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2104,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2201,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2202,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2203,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2204,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2205,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2206,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2207,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2208,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2401,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2402,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2403,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2404,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2501,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2502,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2503,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2504,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2506,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2507,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2508,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2601,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2602,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2603,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2604,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 236, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 237, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 237, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 12, 14, 17, 31, 237, DateTimeKind.Local).AddTicks(1144));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductCode",
                table: "AppProductDetail");

            migrationBuilder.AddColumn<string>(
                name: "ProductCode",
                table: "AppProduct",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "AppDiscountCode",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(2314), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "AppDiscountCode",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(2314), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(9227) });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(9227) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213), new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 158, 117, 27, 89, 32, 17, 38, 34, 83, 162, 6, 148, 211, 209, 221, 5, 60, 223, 252, 170, 215, 74, 240, 62, 63, 252, 189, 55, 169, 152, 168, 130, 24, 18, 243, 157, 85, 99, 193, 18, 63, 222, 232, 214, 58, 40, 3, 159, 205, 200, 54, 6, 32, 158, 90, 223, 42, 194, 123, 221, 52, 133, 71, 253 }, new byte[] { 96, 38, 199, 108, 181, 75, 17, 226, 98, 13, 131, 213, 16, 149, 74, 221, 49, 17, 251, 70, 206, 40, 55, 38, 63, 252, 185, 136, 144, 85, 167, 189, 113, 3, 248, 85, 105, 187, 40, 3, 97, 249, 199, 64, 227, 175, 95, 238, 131, 135, 143, 156, 124, 92, 84, 66, 38, 175, 55, 224, 63, 128, 174, 149, 143, 57, 66, 97, 202, 163, 142, 27, 5, 41, 109, 249, 36, 103, 183, 227, 169, 127, 43, 175, 116, 18, 186, 177, 35, 14, 191, 150, 94, 239, 206, 245, 193, 168, 66, 69, 148, 39, 44, 125, 167, 141, 63, 220, 122, 52, 225, 214, 132, 71, 247, 85, 89, 240, 51, 48, 209, 84, 169, 136, 184, 164, 153, 67 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1101,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1102,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1103,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1104,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1105,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1205,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1303,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1304,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1401,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1402,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1403,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1404,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1501,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1502,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1503,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1504,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1701,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1702,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1703,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1704,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1901,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1902,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1903,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1904,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2101,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2102,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2103,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2104,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2201,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2202,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2203,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2204,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2205,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2206,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2207,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2208,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2401,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2402,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2403,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2404,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2501,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2502,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2503,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2504,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2506,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2507,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2508,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2601,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2602,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2603,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2604,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 899, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 18, 51, 42, 900, DateTimeKind.Local).AddTicks(2037));
        }
    }
}
