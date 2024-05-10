using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class init_db5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AppDiscountCode",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "AppDiscountCode",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "AppDiscountCode",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "AppDiscountCode",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 523, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 523, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 523, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 523, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 523, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 523, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppProductCategory",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7922), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7922), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 167, 186, 217, 149, 182, 13, 112, 110, 52, 146, 107, 26, 205, 254, 197, 209, 163, 234, 177, 205, 241, 244, 116, 56, 197, 86, 117, 52, 70, 229, 234, 115, 27, 116, 182, 234, 107, 248, 235, 165, 34, 42, 98, 49, 86, 67, 110, 131, 21, 16, 182, 156, 62, 234, 246, 216, 47, 208, 37, 204, 11, 236, 135, 202 }, new byte[] { 249, 215, 199, 37, 210, 44, 194, 232, 30, 116, 48, 233, 99, 108, 217, 215, 196, 126, 56, 57, 7, 151, 78, 0, 60, 35, 34, 43, 163, 70, 11, 217, 119, 174, 182, 92, 68, 72, 232, 51, 12, 7, 234, 211, 5, 132, 136, 216, 217, 248, 158, 12, 51, 239, 89, 5, 106, 2, 57, 168, 122, 132, 171, 93, 181, 14, 246, 72, 89, 195, 173, 20, 145, 108, 66, 137, 36, 131, 167, 122, 48, 98, 100, 210, 34, 143, 217, 28, 209, 235, 119, 185, 12, 99, 162, 18, 103, 89, 192, 230, 127, 116, 112, 111, 42, 20, 7, 148, 91, 249, 140, 70, 7, 109, 200, 196, 124, 246, 146, 83, 232, 115, 48, 227, 238, 222, 192, 235 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 523, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 523, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 523, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 523, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1101,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1102,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1103,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1104,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1105,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1205,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1303,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1304,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1401,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1402,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1403,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1404,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1501,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1502,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1503,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1504,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1701,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1702,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1703,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1704,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1901,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1902,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1903,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1904,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2101,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2102,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2103,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2104,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2201,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2202,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2203,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2204,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2205,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2206,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2207,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2208,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2301,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2302,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2401,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2402,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2403,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2404,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2501,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2502,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2503,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2504,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2506,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2507,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2508,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2601,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2602,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2603,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 2604,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 522, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 523, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 523, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 10, 11, 13, 523, DateTimeKind.Local).AddTicks(2228));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "AppDiscountCode");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "AppDiscountCode");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "AppDiscountCode");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AppDiscountCode",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "AppRolePermission",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 5, 4, 11, 42, 21, 34, DateTimeKind.Local).AddTicks(178) });

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
    }
}
