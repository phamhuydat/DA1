using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class init7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "AppProduct");

            migrationBuilder.AddColumn<int>(
                name: "InStock",
                table: "AppProductDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "AppProductDetail",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sold",
                table: "AppProductDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 16, 51, 4, 156, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 16, 51, 4, 156, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 16, 51, 4, 156, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 16, 51, 4, 156, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 16, 51, 4, 156, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 33, 238, 64, 230, 19, 159, 9, 75, 16, 201, 166, 17, 213, 31, 255, 68, 151, 199, 210, 46, 238, 128, 222, 167, 184, 254, 82, 113, 113, 94, 100, 171, 52, 153, 231, 65, 133, 181, 68, 46, 13, 250, 136, 103, 42, 101, 215, 115, 115, 191, 110, 171, 20, 161, 47, 147, 188, 229, 1, 62, 20, 220, 184, 66 }, new byte[] { 233, 8, 6, 129, 63, 142, 37, 93, 125, 205, 119, 62, 65, 15, 197, 243, 201, 107, 190, 101, 49, 156, 77, 141, 206, 13, 229, 68, 70, 8, 207, 198, 220, 27, 227, 157, 215, 239, 63, 15, 163, 94, 131, 159, 198, 233, 177, 82, 153, 119, 87, 237, 212, 51, 152, 88, 178, 6, 53, 86, 75, 249, 62, 9, 22, 28, 172, 133, 133, 223, 209, 230, 237, 39, 15, 11, 65, 129, 121, 82, 75, 10, 198, 181, 138, 216, 48, 136, 110, 142, 242, 23, 85, 234, 141, 105, 181, 66, 143, 247, 131, 78, 18, 1, 207, 31, 252, 26, 94, 105, 58, 241, 96, 9, 185, 210, 106, 234, 82, 229, 73, 40, 124, 163, 11, 50, 58, 121 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 16, 51, 4, 156, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 16, 51, 4, 156, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 16, 51, 4, 156, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 16, 51, 4, 156, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 16, 51, 4, 156, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 16, 51, 4, 156, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 16, 51, 4, 156, DateTimeKind.Local).AddTicks(8865));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InStock",
                table: "AppProductDetail");

            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "AppProductDetail");

            migrationBuilder.DropColumn(
                name: "Sold",
                table: "AppProductDetail");

            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "AppProduct",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 45, 39, 668, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 45, 39, 668, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 45, 39, 668, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 45, 39, 668, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 45, 39, 668, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 140, 149, 65, 27, 93, 122, 8, 140, 96, 18, 199, 6, 187, 175, 19, 99, 117, 117, 109, 104, 79, 244, 78, 48, 238, 11, 194, 118, 216, 142, 251, 14, 99, 118, 174, 232, 54, 27, 134, 83, 176, 181, 80, 255, 128, 85, 71, 65, 68, 112, 32, 125, 113, 77, 111, 59, 170, 180, 228, 241, 99, 252, 130, 178 }, new byte[] { 38, 62, 214, 31, 171, 14, 174, 131, 125, 101, 199, 24, 179, 5, 157, 215, 223, 254, 105, 132, 145, 167, 47, 148, 32, 15, 187, 208, 138, 34, 117, 142, 237, 83, 171, 150, 66, 155, 234, 145, 235, 82, 203, 24, 32, 12, 109, 142, 83, 138, 48, 185, 163, 118, 0, 75, 24, 181, 34, 41, 4, 4, 126, 10, 154, 180, 61, 56, 70, 235, 93, 82, 236, 38, 216, 232, 206, 176, 172, 173, 24, 171, 150, 204, 172, 159, 117, 45, 59, 27, 236, 119, 132, 182, 28, 223, 124, 122, 117, 135, 58, 106, 0, 55, 159, 123, 201, 133, 201, 96, 117, 131, 211, 143, 83, 233, 233, 85, 171, 161, 139, 107, 24, 193, 215, 27, 238, 156 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 45, 39, 668, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 45, 39, 668, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 45, 39, 668, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 45, 39, 668, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 45, 39, 668, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 45, 39, 668, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 45, 39, 668, DateTimeKind.Local).AddTicks(8864));
        }
    }
}
