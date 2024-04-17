using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class edit1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Avatar",
                table: "AppUser",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AppUser",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 48, 51, 535, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 48, 51, 535, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 48, 51, 535, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 48, 51, 535, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 48, 51, 535, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 58, 57, 230, 38, 90, 149, 20, 172, 57, 208, 242, 18, 161, 198, 16, 211, 52, 114, 98, 145, 237, 162, 252, 97, 79, 49, 11, 184, 150, 49, 136, 251, 237, 105, 56, 82, 84, 172, 41, 58, 238, 150, 227, 80, 85, 183, 59, 212, 15, 212, 148, 24, 209, 48, 131, 39, 233, 133, 182, 106, 230, 188, 204, 83 }, new byte[] { 205, 161, 186, 254, 98, 180, 197, 155, 36, 146, 128, 50, 64, 77, 242, 122, 250, 178, 209, 30, 187, 160, 104, 178, 76, 175, 233, 217, 218, 164, 155, 57, 5, 162, 41, 139, 239, 44, 176, 154, 14, 134, 249, 115, 52, 194, 53, 56, 199, 64, 148, 230, 216, 87, 177, 77, 6, 183, 20, 158, 149, 106, 234, 89, 143, 68, 19, 35, 170, 87, 33, 164, 24, 235, 194, 96, 44, 118, 160, 216, 217, 27, 74, 4, 18, 62, 82, 27, 87, 155, 251, 52, 111, 60, 177, 70, 227, 179, 52, 60, 38, 37, 118, 54, 160, 112, 83, 126, 108, 82, 87, 38, 157, 109, 176, 232, 5, 79, 87, 199, 122, 11, 190, 251, 60, 27, 229, 113 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 48, 51, 535, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 48, 51, 535, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 48, 51, 535, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 48, 51, 535, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 48, 51, 535, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 48, 51, 535, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 48, 51, 535, DateTimeKind.Local).AddTicks(7426));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Avatar",
                table: "AppUser",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AppUser",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 36, 51, 532, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 36, 51, 532, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 36, 51, 532, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 36, 51, 532, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 36, 51, 532, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 18, 10, 215, 152, 30, 127, 10, 49, 6, 12, 230, 83, 1, 231, 116, 95, 193, 236, 142, 150, 123, 34, 86, 178, 1, 28, 70, 156, 130, 62, 113, 141, 51, 9, 121, 127, 164, 203, 107, 60, 209, 76, 246, 115, 63, 161, 88, 162, 35, 185, 74, 157, 13, 17, 132, 55, 7, 252, 249, 61, 183, 53, 1, 55 }, new byte[] { 77, 205, 166, 30, 246, 38, 203, 131, 213, 183, 41, 138, 111, 171, 235, 182, 210, 75, 94, 64, 202, 104, 207, 10, 67, 29, 151, 89, 6, 45, 30, 222, 165, 124, 146, 205, 54, 62, 199, 180, 229, 47, 239, 36, 20, 145, 217, 22, 246, 85, 48, 141, 79, 6, 41, 19, 60, 248, 200, 54, 168, 137, 67, 188, 98, 234, 109, 15, 157, 189, 119, 121, 192, 105, 116, 76, 190, 193, 225, 108, 180, 25, 125, 20, 47, 152, 238, 62, 47, 225, 176, 128, 90, 27, 155, 157, 114, 74, 177, 229, 17, 221, 107, 60, 118, 8, 78, 212, 174, 131, 27, 80, 252, 244, 223, 66, 245, 3, 230, 191, 3, 237, 59, 191, 140, 236, 25, 91 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 36, 51, 532, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 36, 51, 532, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 36, 51, 532, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 36, 51, 532, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 36, 51, 532, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 36, 51, 532, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 36, 51, 532, DateTimeKind.Local).AddTicks(5257));
        }
    }
}
