using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class init_db9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CusNote",
                table: "AppOrder");

            migrationBuilder.AddColumn<string>(
                name: "Voucher",
                table: "AppOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "AppDiscountCode",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(8886), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "AppDiscountCode",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(8886), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5975), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5975), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 254, 189, 122, 14, 76, 29, 161, 23, 132, 250, 94, 141, 57, 67, 51, 11, 91, 143, 209, 166, 145, 210, 176, 88, 12, 34, 99, 159, 75, 105, 178, 61, 167, 183, 110, 168, 96, 45, 117, 116, 171, 108, 121, 228, 140, 141, 17, 81, 239, 140, 78, 137, 48, 247, 10, 35, 250, 42, 103, 224, 124, 224, 165, 207 }, new byte[] { 244, 203, 198, 106, 71, 234, 71, 235, 95, 78, 157, 92, 102, 236, 55, 20, 86, 66, 196, 68, 111, 247, 16, 109, 231, 31, 170, 177, 99, 202, 139, 122, 181, 59, 60, 170, 253, 110, 207, 234, 249, 117, 18, 177, 194, 153, 207, 229, 44, 26, 154, 198, 31, 35, 145, 200, 173, 161, 55, 245, 255, 164, 135, 163, 161, 217, 59, 153, 123, 113, 143, 126, 37, 33, 206, 129, 11, 229, 119, 128, 213, 54, 97, 6, 137, 252, 76, 133, 130, 20, 50, 214, 22, 8, 94, 233, 125, 19, 73, 122, 158, 84, 19, 194, 240, 123, 27, 16, 127, 173, 47, 55, 112, 200, 183, 145, 138, 14, 24, 214, 228, 62, 112, 195, 63, 142, 226, 225 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1101,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1102,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1103,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1104,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1105,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1205,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1303,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1304,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1401,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1402,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1403,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1404,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1501,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1502,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1503,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1504,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1701,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1702,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1703,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1704,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1901,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1902,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1903,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1904,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2101,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2102,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2103,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2104,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2201,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2202,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2203,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2204,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2205,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2206,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2207,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2208,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2401,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2402,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2403,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2404,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2501,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2502,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2503,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2504,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2506,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2507,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2508,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2601,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2602,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2603,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2604,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 16, 29, 16, 387, DateTimeKind.Local).AddTicks(8679));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Voucher",
                table: "AppOrder");

            migrationBuilder.AddColumn<string>(
                name: "CusNote",
                table: "AppOrder",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "AppDiscountCode",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(6588), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "AppDiscountCode",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(6588), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(3146), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(3146), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 14, 33, 33, 174, 19, 116, 46, 159, 63, 251, 168, 3, 1, 71, 84, 45, 133, 250, 148, 205, 135, 91, 209, 8, 120, 90, 130, 64, 26, 162, 178, 89, 87, 59, 137, 58, 238, 195, 112, 214, 42, 150, 144, 84, 216, 125, 83, 149, 211, 98, 195, 123, 44, 130, 254, 87, 134, 91, 189, 160, 23, 103, 232, 212 }, new byte[] { 110, 242, 244, 236, 84, 119, 38, 170, 244, 237, 160, 28, 8, 151, 229, 252, 124, 115, 200, 204, 194, 5, 45, 255, 150, 136, 211, 180, 102, 45, 244, 100, 226, 11, 104, 42, 19, 238, 14, 69, 129, 181, 28, 33, 243, 204, 89, 25, 82, 233, 179, 164, 90, 41, 59, 192, 33, 100, 86, 193, 117, 111, 125, 58, 180, 228, 31, 155, 59, 198, 168, 117, 226, 182, 141, 112, 46, 60, 195, 59, 254, 44, 187, 49, 54, 205, 18, 159, 162, 9, 77, 145, 228, 167, 73, 244, 251, 185, 214, 55, 0, 166, 135, 146, 66, 205, 65, 70, 81, 59, 211, 45, 180, 93, 52, 26, 239, 81, 141, 230, 16, 174, 154, 155, 86, 108, 123, 156 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1101,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1102,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1103,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1104,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1105,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1205,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1303,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1304,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1401,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1402,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1403,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1404,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1501,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1502,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1503,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1504,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1701,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1702,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1703,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1704,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1901,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1902,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1903,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1904,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2101,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2102,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2103,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2104,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2201,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2202,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2203,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2204,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2205,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2206,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2207,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2208,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2401,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2402,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2403,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2404,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2501,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2502,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2503,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2504,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2506,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2507,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2508,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2601,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2602,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2603,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2604,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 34, 3, 349, DateTimeKind.Local).AddTicks(6286));
        }
    }
}
