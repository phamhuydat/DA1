using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class inti113 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Inch",
                table: "AppProductDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "AppDiscountCode",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(9350), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "AppDiscountCode",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(9350), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6583), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6583) });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6583), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6583) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 160, 18, 213, 28, 216, 65, 235, 121, 190, 208, 231, 0, 119, 167, 77, 143, 5, 55, 156, 212, 244, 165, 91, 55, 133, 247, 15, 51, 243, 13, 251, 6, 10, 92, 153, 125, 106, 182, 42, 22, 8, 129, 148, 80, 220, 60, 54, 242, 129, 228, 236, 169, 210, 159, 174, 78, 200, 115, 35, 64, 21, 63, 236, 84 }, new byte[] { 126, 242, 176, 139, 160, 173, 48, 237, 67, 142, 84, 9, 132, 234, 15, 114, 52, 115, 146, 29, 218, 116, 207, 96, 136, 88, 109, 146, 39, 179, 99, 203, 124, 127, 211, 48, 234, 55, 94, 44, 195, 21, 136, 239, 207, 133, 25, 46, 149, 196, 96, 130, 176, 74, 7, 106, 32, 32, 161, 120, 86, 171, 140, 206, 159, 245, 171, 230, 134, 164, 191, 124, 215, 248, 224, 160, 13, 240, 64, 57, 161, 94, 219, 52, 72, 124, 167, 3, 198, 250, 255, 91, 10, 90, 90, 43, 43, 168, 159, 51, 216, 254, 47, 202, 111, 25, 171, 211, 117, 65, 68, 13, 62, 108, 11, 188, 103, 200, 61, 248, 221, 134, 12, 171, 0, 167, 91, 177 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1101,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1102,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1103,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1104,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1105,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1205,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1303,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1304,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1401,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1402,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1403,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1404,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1501,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1502,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1503,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1504,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1701,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1702,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1703,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1704,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1901,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1902,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1903,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1904,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2101,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2102,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2103,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2104,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2201,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2202,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2203,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2204,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2205,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2206,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2207,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2208,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2401,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2402,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2403,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2404,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2501,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2502,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2503,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2504,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2506,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2507,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2508,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2601,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2602,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2603,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2604,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 21, 43, 4, 890, DateTimeKind.Local).AddTicks(9136));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Inch",
                table: "AppProductDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "AppDiscountCode",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(9814), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "AppDiscountCode",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(9814), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7084), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7084), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 16, 238, 243, 58, 88, 137, 11, 7, 164, 53, 185, 117, 147, 47, 87, 213, 70, 117, 210, 198, 226, 204, 203, 226, 172, 7, 148, 131, 233, 189, 88, 170, 18, 125, 181, 4, 91, 234, 89, 237, 124, 37, 152, 141, 74, 231, 4, 8, 128, 24, 225, 146, 50, 91, 45, 161, 6, 138, 14, 181, 168, 35, 240, 244 }, new byte[] { 206, 198, 78, 33, 169, 37, 222, 58, 40, 123, 62, 216, 211, 209, 255, 242, 126, 4, 229, 204, 56, 205, 133, 233, 111, 166, 238, 50, 233, 238, 253, 238, 238, 53, 53, 66, 134, 224, 43, 162, 9, 177, 13, 229, 143, 220, 249, 183, 228, 66, 144, 231, 105, 57, 230, 76, 21, 0, 106, 179, 95, 179, 115, 81, 100, 57, 148, 94, 153, 248, 17, 112, 194, 17, 149, 51, 5, 6, 134, 108, 10, 104, 59, 65, 1, 32, 242, 144, 38, 188, 182, 193, 10, 90, 28, 56, 31, 170, 74, 183, 224, 114, 48, 236, 155, 252, 135, 166, 43, 128, 50, 140, 246, 85, 227, 252, 199, 37, 208, 152, 94, 181, 167, 169, 102, 106, 168, 45 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1101,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1102,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1103,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1104,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1105,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1205,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1303,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1304,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1401,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1402,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1403,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1404,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1501,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1502,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1503,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1504,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1701,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1702,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1703,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1704,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1901,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1902,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1903,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1904,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2101,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2102,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2103,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2104,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2201,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2202,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2203,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2204,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2205,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2206,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2207,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2208,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2401,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2402,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2403,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2404,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2501,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2502,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2503,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2504,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2506,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2507,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2508,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2601,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2602,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2603,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2604,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 23, 17, 25, 899, DateTimeKind.Local).AddTicks(9571));
        }
    }
}
