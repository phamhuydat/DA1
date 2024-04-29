using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsMobile",
                table: "AppProductImage",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 41, 14, 258, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 41, 14, 258, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 41, 14, 258, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 41, 14, 258, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 41, 14, 258, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 123, 204, 205, 202, 117, 154, 49, 152, 14, 41, 218, 24, 141, 122, 118, 73, 43, 1, 145, 160, 78, 22, 252, 78, 194, 250, 122, 28, 161, 40, 36, 103, 145, 230, 97, 2, 71, 57, 255, 212, 143, 84, 1, 118, 147, 197, 63, 245, 126, 152, 230, 141, 149, 161, 46, 38, 163, 220, 34, 50, 42, 71, 245, 134 }, new byte[] { 229, 56, 149, 189, 62, 35, 58, 242, 144, 178, 94, 196, 199, 112, 36, 126, 107, 111, 230, 155, 43, 251, 8, 81, 18, 161, 162, 42, 86, 70, 67, 68, 52, 153, 186, 76, 204, 75, 69, 136, 124, 84, 166, 84, 210, 29, 93, 139, 41, 151, 46, 143, 179, 137, 59, 200, 147, 90, 29, 180, 189, 110, 43, 181, 32, 66, 58, 223, 85, 241, 156, 20, 112, 209, 112, 65, 90, 2, 185, 15, 175, 201, 29, 143, 38, 32, 227, 60, 219, 18, 48, 90, 223, 7, 101, 115, 123, 17, 244, 53, 181, 38, 24, 111, 76, 149, 143, 242, 93, 96, 65, 227, 123, 83, 29, 23, 83, 13, 13, 198, 224, 33, 119, 71, 53, 229, 124, 120 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 41, 14, 258, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 41, 14, 258, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 41, 14, 258, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 41, 14, 258, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 41, 14, 258, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 41, 14, 258, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 41, 14, 258, DateTimeKind.Local).AddTicks(5864));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsMobile",
                table: "AppProductImage",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 39, 35, 158, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 39, 35, 158, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 39, 35, 158, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 39, 35, 158, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 39, 35, 158, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 56, 43, 77, 206, 48, 246, 70, 74, 56, 11, 131, 100, 95, 149, 140, 139, 37, 98, 163, 229, 169, 252, 117, 160, 216, 249, 176, 39, 210, 11, 12, 71, 98, 144, 51, 38, 98, 56, 43, 10, 138, 40, 110, 39, 11, 48, 126, 34, 73, 20, 217, 152, 26, 13, 148, 216, 69, 135, 117, 71, 88, 114, 38, 149 }, new byte[] { 27, 224, 79, 23, 209, 244, 92, 50, 170, 141, 122, 189, 202, 131, 156, 215, 95, 76, 50, 228, 30, 218, 4, 224, 146, 62, 163, 200, 92, 31, 3, 174, 37, 114, 131, 254, 103, 161, 58, 254, 140, 219, 140, 20, 112, 197, 246, 218, 192, 200, 227, 92, 215, 153, 201, 99, 129, 203, 181, 98, 214, 255, 223, 103, 39, 36, 41, 71, 81, 80, 167, 177, 246, 77, 17, 24, 55, 200, 127, 63, 14, 132, 10, 43, 246, 188, 137, 161, 253, 207, 23, 212, 254, 12, 213, 134, 167, 138, 120, 242, 193, 68, 131, 173, 50, 200, 222, 62, 51, 103, 206, 247, 9, 213, 29, 143, 27, 136, 214, 153, 4, 204, 140, 250, 241, 194, 2, 7 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 39, 35, 158, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 39, 35, 158, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 39, 35, 158, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 39, 35, 158, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 39, 35, 158, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 39, 35, 158, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 39, 35, 158, DateTimeKind.Local).AddTicks(8431));
        }
    }
}
