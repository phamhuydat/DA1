using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class init10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Rom",
                table: "AppProductDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ram",
                table: "AppProductDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 11, 17, 33, 896, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 11, 17, 33, 896, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 11, 17, 33, 896, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 11, 17, 33, 896, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 11, 17, 33, 896, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 202, 170, 50, 175, 116, 34, 93, 150, 64, 48, 127, 59, 221, 192, 79, 79, 78, 73, 91, 168, 127, 124, 29, 245, 57, 17, 0, 63, 37, 18, 215, 167, 186, 137, 34, 20, 185, 142, 202, 60, 195, 147, 66, 47, 119, 227, 156, 38, 113, 186, 251, 239, 11, 219, 146, 229, 117, 59, 145, 113, 119, 46, 197, 118 }, new byte[] { 229, 230, 1, 108, 23, 134, 145, 12, 200, 55, 189, 56, 47, 169, 189, 179, 123, 35, 67, 45, 183, 28, 225, 97, 111, 112, 44, 83, 199, 69, 165, 103, 14, 118, 99, 70, 243, 28, 15, 37, 67, 3, 87, 40, 137, 229, 35, 47, 247, 204, 193, 158, 235, 150, 85, 172, 215, 152, 57, 161, 36, 189, 254, 220, 7, 170, 132, 80, 217, 134, 134, 76, 239, 35, 230, 107, 187, 60, 31, 98, 5, 106, 95, 81, 63, 254, 206, 120, 137, 70, 180, 46, 229, 25, 181, 12, 73, 225, 202, 51, 79, 37, 199, 123, 135, 69, 153, 192, 138, 35, 25, 146, 71, 51, 249, 30, 104, 233, 193, 184, 90, 254, 246, 49, 155, 137, 106, 134 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 11, 17, 33, 896, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 11, 17, 33, 896, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 11, 17, 33, 896, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 11, 17, 33, 896, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 11, 17, 33, 896, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 11, 17, 33, 896, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 11, 17, 33, 896, DateTimeKind.Local).AddTicks(9682));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Rom",
                table: "AppProductDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Ram",
                table: "AppProductDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
