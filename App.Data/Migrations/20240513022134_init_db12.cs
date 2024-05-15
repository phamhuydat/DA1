using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class init_db12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductCode",
                table: "AppProduct",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductCode",
                table: "AppProduct");

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
    }
}
