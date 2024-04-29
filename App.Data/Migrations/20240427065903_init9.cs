using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class init9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPU",
                table: "AppProductDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GPU",
                table: "AppProductDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ram",
                table: "AppProductDetail",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rom",
                table: "AppProductDetail",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 27, 13, 59, 0, 753, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 27, 13, 59, 0, 753, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 27, 13, 59, 0, 753, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 27, 13, 59, 0, 753, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 27, 13, 59, 0, 753, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 103, 207, 116, 46, 104, 73, 30, 231, 190, 246, 125, 124, 96, 85, 132, 203, 125, 136, 67, 147, 114, 124, 150, 87, 253, 206, 53, 8, 248, 117, 38, 164, 99, 4, 75, 105, 90, 216, 43, 22, 114, 114, 97, 14, 142, 11, 68, 225, 246, 48, 237, 71, 87, 254, 48, 83, 14, 180, 55, 255, 73, 215, 60, 28 }, new byte[] { 89, 172, 119, 226, 184, 64, 67, 97, 239, 160, 139, 108, 7, 157, 103, 106, 175, 47, 30, 220, 135, 213, 220, 4, 18, 226, 239, 223, 244, 0, 243, 37, 5, 73, 173, 79, 196, 57, 61, 178, 17, 87, 19, 249, 198, 20, 152, 98, 37, 22, 76, 147, 128, 98, 75, 181, 86, 148, 207, 90, 160, 240, 57, 126, 96, 149, 103, 33, 22, 213, 171, 137, 255, 18, 2, 243, 94, 105, 100, 32, 62, 93, 87, 215, 214, 112, 114, 64, 96, 123, 220, 105, 119, 122, 92, 127, 101, 130, 118, 170, 165, 177, 176, 162, 95, 119, 111, 9, 28, 74, 57, 101, 128, 33, 159, 46, 131, 223, 249, 201, 219, 23, 61, 235, 21, 60, 45, 26 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 27, 13, 59, 0, 753, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 27, 13, 59, 0, 753, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 27, 13, 59, 0, 753, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 27, 13, 59, 0, 753, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 27, 13, 59, 0, 753, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 27, 13, 59, 0, 753, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 27, 13, 59, 0, 753, DateTimeKind.Local).AddTicks(7806));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPU",
                table: "AppProductDetail");

            migrationBuilder.DropColumn(
                name: "GPU",
                table: "AppProductDetail");

            migrationBuilder.DropColumn(
                name: "Ram",
                table: "AppProductDetail");

            migrationBuilder.DropColumn(
                name: "Rom",
                table: "AppProductDetail");

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
    }
}
