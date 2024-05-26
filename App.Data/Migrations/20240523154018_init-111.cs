using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class init111 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Inch",
                table: "AppProductDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "AppDiscountCode",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 110, DateTimeKind.Local).AddTicks(540), new DateTime(2024, 5, 23, 22, 40, 16, 110, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "AppDiscountCode",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 110, DateTimeKind.Local).AddTicks(540), new DateTime(2024, 5, 23, 22, 40, 16, 110, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 110, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 110, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 110, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 110, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 110, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 110, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6823), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6823), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 201, 62, 5, 71, 162, 64, 112, 43, 203, 175, 33, 185, 222, 130, 25, 254, 110, 135, 91, 165, 209, 142, 241, 73, 150, 26, 57, 13, 240, 72, 94, 170, 193, 169, 180, 212, 81, 47, 75, 228, 126, 118, 218, 198, 145, 90, 56, 140, 183, 104, 186, 171, 236, 101, 248, 130, 124, 141, 168, 103, 10, 171, 17, 207 }, new byte[] { 233, 83, 66, 220, 255, 208, 223, 209, 147, 189, 86, 145, 139, 12, 202, 143, 57, 116, 147, 143, 18, 232, 69, 130, 101, 187, 156, 32, 34, 76, 59, 103, 245, 116, 241, 36, 204, 236, 30, 222, 81, 35, 114, 96, 41, 153, 162, 24, 131, 7, 212, 11, 83, 24, 5, 79, 205, 192, 77, 69, 154, 34, 139, 140, 25, 232, 146, 9, 179, 195, 6, 117, 13, 91, 240, 129, 96, 92, 237, 124, 1, 216, 244, 177, 69, 230, 41, 71, 139, 69, 11, 133, 22, 147, 38, 12, 75, 184, 96, 154, 92, 255, 188, 78, 210, 201, 62, 0, 13, 255, 75, 11, 241, 26, 77, 73, 129, 3, 147, 42, 186, 108, 220, 40, 15, 30, 55, 159 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 110, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 110, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 110, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 110, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1101,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1102,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1103,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1104,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1105,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1205,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1303,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1304,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1401,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1402,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1403,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1404,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1501,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1502,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1503,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1504,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1701,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1702,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1703,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1704,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1901,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1902,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1903,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1904,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2101,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2102,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2103,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2104,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2201,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2202,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2203,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2204,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2205,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2206,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2207,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2208,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2401,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2402,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2403,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2404,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2501,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2502,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2503,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2504,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2506,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2507,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2508,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2601,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2602,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2603,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2604,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 110, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 110, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 22, 40, 16, 110, DateTimeKind.Local).AddTicks(288));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Inch",
                table: "AppProductDetail");

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "AppDiscountCode",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 147, DateTimeKind.Local).AddTicks(1057), new DateTime(2024, 5, 13, 9, 21, 32, 147, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "AppDiscountCode",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 147, DateTimeKind.Local).AddTicks(1057), new DateTime(2024, 5, 13, 9, 21, 32, 147, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 147, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 147, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 147, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 147, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 147, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 147, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7881), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7881), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 150, 174, 71, 142, 142, 81, 97, 167, 162, 252, 1, 30, 61, 89, 61, 252, 37, 82, 18, 98, 184, 193, 147, 185, 96, 196, 135, 190, 46, 120, 4, 111, 222, 100, 147, 234, 212, 161, 176, 250, 86, 163, 196, 246, 165, 90, 250, 247, 199, 7, 62, 113, 74, 61, 125, 143, 41, 84, 37, 201, 201, 73, 202, 144 }, new byte[] { 98, 120, 191, 201, 29, 40, 160, 62, 95, 199, 168, 236, 62, 155, 187, 16, 61, 241, 218, 86, 247, 235, 91, 180, 24, 72, 195, 195, 168, 53, 144, 129, 207, 112, 159, 147, 124, 70, 250, 40, 185, 254, 108, 244, 231, 58, 70, 105, 118, 63, 57, 40, 199, 198, 251, 240, 229, 94, 181, 131, 225, 194, 73, 220, 2, 125, 209, 202, 186, 190, 235, 83, 15, 57, 80, 252, 153, 219, 153, 77, 10, 41, 19, 88, 129, 190, 219, 124, 145, 129, 94, 42, 84, 100, 244, 233, 69, 104, 110, 157, 167, 167, 8, 212, 156, 112, 161, 26, 129, 193, 230, 1, 224, 191, 254, 172, 118, 173, 231, 110, 199, 86, 244, 58, 199, 198, 9, 48 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 147, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 147, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 147, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 147, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1101,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1102,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1103,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1104,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1105,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1205,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1303,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1304,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1401,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1402,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1403,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1404,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1501,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1502,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1503,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1504,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1701,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1702,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1703,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1704,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1901,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1902,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1903,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1904,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2101,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2102,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2103,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2104,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2201,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2202,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2203,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2204,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2205,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2206,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2207,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2208,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2401,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2402,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2403,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2404,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2501,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2502,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2503,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2504,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2506,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2507,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2508,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2601,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2602,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2603,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2604,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 146, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 147, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 147, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 13, 9, 21, 32, 147, DateTimeKind.Local).AddTicks(823));
        }
    }
}
