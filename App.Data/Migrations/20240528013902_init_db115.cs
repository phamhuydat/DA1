﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
	/// <inheritdoc />
	public partial class init_db115 : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<decimal>(
				name: "Percent",
				table: "AppDiscountCode",
				type: "decimal(18,2)",
				nullable: true,
				oldClrType: typeof(int),
				oldType: "int",
				oldNullable: true);

			migrationBuilder.UpdateData(
				table: "AppBranch",
				keyColumn: "Id",
				keyValue: 1,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6818));

			migrationBuilder.UpdateData(
				table: "AppDiscountCode",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "CreatedDate", "Percent", "StartDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(8685), 10m, new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(8685) });

			migrationBuilder.UpdateData(
				table: "AppDiscountCode",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "CreatedDate", "Percent", "StartDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(8685), null, new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(8685) });

			migrationBuilder.UpdateData(
				table: "AppNewsCategory",
				keyColumn: "Id",
				keyValue: 1,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(8405));

			migrationBuilder.UpdateData(
				table: "AppNewsCategory",
				keyColumn: "Id",
				keyValue: 2,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(8405));

			migrationBuilder.UpdateData(
				table: "AppNewsCategory",
				keyColumn: "Id",
				keyValue: 3,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(8405));

			migrationBuilder.UpdateData(
				table: "AppNewsCategory",
				keyColumn: "Id",
				keyValue: 4,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(8405));

			migrationBuilder.UpdateData(
				table: "AppNewsCategory",
				keyColumn: "Id",
				keyValue: 5,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(8405));

			migrationBuilder.UpdateData(
				table: "AppNewsCategory",
				keyColumn: "Id",
				keyValue: 6,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(8405));

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 3,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 4,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 5,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 6,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 7,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 8,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 9,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 10,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 11,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 12,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 13,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 14,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 15,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 16,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 17,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 18,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 19,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 20,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 21,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 22,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 23,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 24,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 25,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 26,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 27,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6904) });

			migrationBuilder.UpdateData(
				table: "AppRole",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5402), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5402) });

			migrationBuilder.UpdateData(
				table: "AppRole",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5402), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5402) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 3,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 4,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 5,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 6,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 7,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 8,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 9,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 10,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 11,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 12,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 13,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 14,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 15,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 16,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 17,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 18,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 19,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 20,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 21,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 22,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 23,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 24,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 25,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 26,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 27,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 28,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 29,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 30,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 31,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 32,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 33,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 34,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 35,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 36,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 37,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 38,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 39,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 40,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 41,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 42,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 43,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 44,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 45,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 46,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 47,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 48,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 49,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 50,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 51,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 52,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 53,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 54,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 55,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 56,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 57,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 58,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 59,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 60,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 61,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 62,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 63,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 64,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 65,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 66,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 67,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 68,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(6366) });

			migrationBuilder.UpdateData(
				table: "AppUser",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "PasswordHash", "PasswordSalt" },
				values: new object[] { new byte[] { 29, 135, 111, 134, 149, 16, 104, 224, 13, 106, 230, 167, 89, 117, 122, 76, 140, 150, 36, 161, 161, 63, 243, 118, 163, 185, 224, 191, 20, 234, 149, 103, 35, 21, 126, 181, 116, 227, 29, 93, 192, 10, 228, 229, 169, 208, 254, 220, 12, 21, 129, 59, 236, 121, 28, 84, 231, 208, 115, 22, 64, 133, 47, 80 }, new byte[] { 95, 248, 74, 192, 224, 86, 104, 115, 3, 217, 129, 175, 16, 122, 29, 192, 53, 249, 219, 117, 191, 124, 205, 153, 32, 177, 26, 0, 71, 168, 125, 214, 54, 28, 145, 224, 193, 153, 204, 187, 215, 121, 51, 28, 124, 42, 193, 115, 67, 85, 77, 200, 244, 159, 251, 102, 24, 189, 247, 202, 69, 26, 147, 181, 87, 170, 39, 176, 69, 34, 238, 84, 31, 237, 107, 221, 109, 151, 188, 167, 206, 242, 187, 47, 205, 57, 226, 197, 9, 129, 91, 0, 42, 190, 220, 238, 18, 187, 87, 11, 149, 17, 132, 237, 139, 88, 232, 218, 161, 85, 245, 141, 129, 124, 59, 192, 217, 82, 155, 66, 68, 53, 9, 60, 86, 207, 46, 131 } });

			migrationBuilder.UpdateData(
				table: "MstOrderStatus",
				keyColumn: "Id",
				keyValue: 1,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(8337));

			migrationBuilder.UpdateData(
				table: "MstOrderStatus",
				keyColumn: "Id",
				keyValue: 2,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(8337));

			migrationBuilder.UpdateData(
				table: "MstOrderStatus",
				keyColumn: "Id",
				keyValue: 3,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(8337));

			migrationBuilder.UpdateData(
				table: "MstOrderStatus",
				keyColumn: "Id",
				keyValue: 4,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(8337));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1001,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1002,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1003,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1004,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1005,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1006,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1007,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1008,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1101,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1102,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1103,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1104,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1105,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1205,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1301,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1302,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1303,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1304,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1401,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1402,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1403,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1404,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1501,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1502,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1503,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1504,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1701,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1702,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1703,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1704,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1901,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1902,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1903,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1904,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2001,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2002,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2003,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2004,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2005,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2101,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2102,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2103,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2104,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2201,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2202,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2203,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2204,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2205,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2206,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2207,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2208,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2301,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2302,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2401,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2402,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2403,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2404,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2501,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2502,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2503,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2504,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2506,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2507,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2508,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2601,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2602,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2603,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2604,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(5103));

			migrationBuilder.UpdateData(
				table: "MstProductColor",
				keyColumn: "Id",
				keyValue: 1,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(8373));

			migrationBuilder.UpdateData(
				table: "MstProductColor",
				keyColumn: "Id",
				keyValue: 2,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(8373));

			migrationBuilder.UpdateData(
				table: "MstProductColor",
				keyColumn: "Id",
				keyValue: 3,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 28, 8, 38, 59, 561, DateTimeKind.Local).AddTicks(8373));
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<int>(
				name: "Percent",
				table: "AppDiscountCode",
				type: "int",
				nullable: true,
				oldClrType: typeof(decimal),
				oldType: "decimal(18,2)",
				oldNullable: true);

			migrationBuilder.UpdateData(
				table: "AppBranch",
				keyColumn: "Id",
				keyValue: 1,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9148));

			migrationBuilder.UpdateData(
				table: "AppDiscountCode",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "CreatedDate", "Percent", "StartDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 53, DateTimeKind.Local).AddTicks(686), 10, new DateTime(2024, 5, 24, 23, 1, 43, 53, DateTimeKind.Local).AddTicks(686) });

			migrationBuilder.UpdateData(
				table: "AppDiscountCode",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "CreatedDate", "Percent", "StartDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 53, DateTimeKind.Local).AddTicks(686), null, new DateTime(2024, 5, 24, 23, 1, 43, 53, DateTimeKind.Local).AddTicks(686) });

			migrationBuilder.UpdateData(
				table: "AppNewsCategory",
				keyColumn: "Id",
				keyValue: 1,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 53, DateTimeKind.Local).AddTicks(464));

			migrationBuilder.UpdateData(
				table: "AppNewsCategory",
				keyColumn: "Id",
				keyValue: 2,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 53, DateTimeKind.Local).AddTicks(464));

			migrationBuilder.UpdateData(
				table: "AppNewsCategory",
				keyColumn: "Id",
				keyValue: 3,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 53, DateTimeKind.Local).AddTicks(464));

			migrationBuilder.UpdateData(
				table: "AppNewsCategory",
				keyColumn: "Id",
				keyValue: 4,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 53, DateTimeKind.Local).AddTicks(464));

			migrationBuilder.UpdateData(
				table: "AppNewsCategory",
				keyColumn: "Id",
				keyValue: 5,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 53, DateTimeKind.Local).AddTicks(464));

			migrationBuilder.UpdateData(
				table: "AppNewsCategory",
				keyColumn: "Id",
				keyValue: 6,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 53, DateTimeKind.Local).AddTicks(464));

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 3,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 4,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 5,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 6,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 7,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 8,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 9,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 10,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 11,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 12,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 13,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 14,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 15,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 16,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 17,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 18,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 19,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 20,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 21,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 22,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 23,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 24,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 25,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 26,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppProductCategory",
				keyColumn: "Id",
				keyValue: 27,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(9227) });

			migrationBuilder.UpdateData(
				table: "AppRole",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7859), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7859) });

			migrationBuilder.UpdateData(
				table: "AppRole",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7859), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7859) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 3,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 4,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 5,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 6,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 7,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 8,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 9,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 10,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 11,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 12,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 13,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 14,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 15,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 16,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 17,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 18,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 19,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 20,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 21,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 22,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 23,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 24,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 25,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 26,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 27,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 28,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 29,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 30,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 31,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 32,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 33,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 34,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 35,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 36,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 37,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 38,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 39,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 40,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 41,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 42,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 43,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 44,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 45,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 46,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 47,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 48,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 49,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 50,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 51,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 52,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 53,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 54,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 55,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 56,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 57,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 58,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 59,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 60,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 61,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 62,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 63,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 64,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 65,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 66,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 67,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppRolePermission",
				keyColumn: "Id",
				keyValue: 68,
				columns: new[] { "CreatedDate", "UpdatedDate" },
				values: new object[] { new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(8767) });

			migrationBuilder.UpdateData(
				table: "AppUser",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "PasswordHash", "PasswordSalt" },
				values: new object[] { new byte[] { 35, 70, 220, 143, 242, 88, 49, 169, 12, 27, 69, 149, 121, 160, 84, 152, 102, 219, 244, 191, 111, 166, 198, 88, 26, 200, 58, 76, 92, 148, 101, 233, 238, 242, 148, 5, 164, 186, 87, 110, 112, 21, 161, 234, 30, 60, 23, 30, 210, 44, 245, 173, 53, 129, 98, 29, 221, 56, 127, 15, 63, 192, 20, 17 }, new byte[] { 167, 252, 167, 222, 89, 247, 208, 200, 176, 241, 204, 120, 66, 13, 80, 238, 204, 218, 39, 197, 77, 187, 145, 134, 119, 104, 193, 159, 87, 194, 126, 55, 31, 30, 1, 120, 165, 172, 45, 246, 60, 222, 207, 12, 26, 175, 155, 0, 109, 250, 165, 16, 121, 90, 1, 81, 108, 178, 215, 173, 162, 143, 239, 32, 113, 28, 173, 45, 135, 8, 30, 122, 72, 35, 248, 69, 168, 241, 240, 187, 31, 106, 58, 232, 37, 89, 46, 215, 177, 161, 18, 116, 227, 8, 241, 86, 189, 173, 182, 205, 46, 85, 14, 50, 105, 73, 77, 10, 101, 43, 85, 176, 199, 3, 178, 113, 101, 239, 8, 199, 201, 171, 162, 85, 105, 152, 141, 139 } });

			migrationBuilder.UpdateData(
				table: "MstOrderStatus",
				keyColumn: "Id",
				keyValue: 1,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 53, DateTimeKind.Local).AddTicks(414));

			migrationBuilder.UpdateData(
				table: "MstOrderStatus",
				keyColumn: "Id",
				keyValue: 2,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 53, DateTimeKind.Local).AddTicks(414));

			migrationBuilder.UpdateData(
				table: "MstOrderStatus",
				keyColumn: "Id",
				keyValue: 3,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 53, DateTimeKind.Local).AddTicks(414));

			migrationBuilder.UpdateData(
				table: "MstOrderStatus",
				keyColumn: "Id",
				keyValue: 4,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 53, DateTimeKind.Local).AddTicks(414));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1001,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1002,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1003,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1004,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1005,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1006,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1007,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1008,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1101,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1102,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1103,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1104,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1105,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1205,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1301,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1302,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1303,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1304,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1401,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1402,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1403,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1404,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1501,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1502,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1503,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1504,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1701,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1702,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1703,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1704,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1901,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1902,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1903,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 1904,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2001,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2002,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2003,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2004,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2005,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2101,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2102,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2103,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2104,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2201,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2202,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2203,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2204,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2205,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2206,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2207,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2208,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2301,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2302,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2401,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2402,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2403,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2404,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2501,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2502,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2503,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2504,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2506,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2507,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2508,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2601,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2602,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2603,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstPermission",
				keyColumn: "Id",
				keyValue: 2604,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 52, DateTimeKind.Local).AddTicks(7579));

			migrationBuilder.UpdateData(
				table: "MstProductColor",
				keyColumn: "Id",
				keyValue: 1,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 53, DateTimeKind.Local).AddTicks(438));

			migrationBuilder.UpdateData(
				table: "MstProductColor",
				keyColumn: "Id",
				keyValue: 2,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 53, DateTimeKind.Local).AddTicks(438));

			migrationBuilder.UpdateData(
				table: "MstProductColor",
				keyColumn: "Id",
				keyValue: 3,
				column: "CreatedDate",
				value: new DateTime(2024, 5, 24, 23, 1, 43, 53, DateTimeKind.Local).AddTicks(438));
		}
	}
}