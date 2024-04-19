using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class edit4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "AppProduct");

            migrationBuilder.RenameColumn(
                name: "inch",
                table: "AppProduct",
                newName: "Inch");

            migrationBuilder.AlterColumn<double>(
                name: "Inch",
                table: "AppProduct",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsMain",
                table: "AppProduct",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 44, 31, 707, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 44, 31, 707, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 44, 31, 707, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 44, 31, 707, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 44, 31, 707, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 68, 6, 176, 9, 217, 133, 158, 38, 224, 163, 4, 85, 34, 79, 115, 248, 182, 118, 77, 220, 35, 99, 134, 183, 69, 156, 88, 254, 29, 79, 134, 168, 185, 180, 234, 145, 181, 28, 144, 138, 113, 117, 138, 154, 189, 146, 144, 114, 72, 175, 141, 35, 216, 46, 6, 13, 30, 212, 60, 92, 13, 208, 184, 178 }, new byte[] { 154, 171, 14, 150, 39, 102, 143, 126, 154, 231, 141, 113, 132, 65, 54, 124, 8, 202, 78, 174, 198, 31, 72, 103, 163, 217, 191, 66, 148, 9, 59, 55, 60, 84, 89, 229, 173, 94, 129, 114, 213, 68, 125, 210, 214, 193, 85, 202, 194, 43, 79, 127, 16, 152, 134, 45, 91, 158, 153, 101, 242, 14, 39, 95, 196, 36, 168, 117, 51, 139, 156, 76, 245, 36, 181, 243, 68, 34, 186, 66, 14, 253, 38, 142, 156, 118, 40, 243, 146, 168, 169, 208, 25, 53, 178, 127, 175, 161, 41, 166, 64, 55, 21, 148, 153, 222, 29, 43, 160, 50, 108, 100, 117, 13, 37, 210, 44, 153, 163, 148, 136, 177, 49, 67, 52, 151, 205, 163 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 44, 31, 707, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 44, 31, 707, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 44, 31, 707, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 44, 31, 707, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 44, 31, 707, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 44, 31, 707, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 44, 31, 707, DateTimeKind.Local).AddTicks(9576));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Inch",
                table: "AppProduct",
                newName: "inch");

            migrationBuilder.AlterColumn<int>(
                name: "IsMain",
                table: "AppProduct",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "inch",
                table: "AppProduct",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "AppProduct",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 16, 8, 42, 278, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 16, 8, 42, 278, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 16, 8, 42, 278, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 16, 8, 42, 278, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 16, 8, 42, 278, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 62, 75, 30, 21, 5, 35, 44, 185, 176, 122, 210, 126, 216, 194, 164, 211, 128, 92, 242, 141, 79, 183, 183, 181, 114, 193, 215, 19, 124, 20, 181, 195, 140, 69, 97, 70, 249, 249, 3, 227, 235, 221, 10, 11, 82, 173, 39, 193, 27, 176, 96, 184, 184, 220, 25, 211, 175, 194, 220, 88, 73, 208, 89, 106 }, new byte[] { 136, 37, 156, 64, 123, 43, 150, 52, 58, 116, 222, 138, 215, 149, 138, 220, 231, 141, 205, 120, 186, 239, 143, 145, 13, 31, 79, 236, 196, 139, 237, 75, 115, 99, 140, 143, 19, 53, 60, 70, 143, 136, 150, 162, 112, 144, 217, 56, 167, 189, 215, 135, 206, 195, 98, 94, 4, 177, 20, 250, 150, 57, 221, 157, 15, 218, 135, 124, 7, 51, 128, 168, 230, 7, 172, 98, 208, 47, 125, 197, 7, 231, 54, 43, 55, 109, 119, 106, 147, 73, 21, 150, 51, 30, 8, 3, 59, 187, 35, 214, 199, 123, 127, 82, 36, 223, 20, 27, 27, 173, 117, 3, 29, 22, 33, 31, 40, 33, 108, 49, 64, 95, 104, 111, 166, 118, 89, 15 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 16, 8, 42, 278, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 16, 8, 42, 278, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 16, 8, 42, 278, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 16, 8, 42, 278, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 16, 8, 42, 278, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 16, 8, 42, 278, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 16, 8, 42, 278, DateTimeKind.Local).AddTicks(7182));
        }
    }
}
