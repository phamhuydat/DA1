using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class edit5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SEODescription",
                table: "AppProduct");

            migrationBuilder.DropColumn(
                name: "SEOImagePath",
                table: "AppProduct");

            migrationBuilder.DropColumn(
                name: "SEOKeyword",
                table: "AppProduct");

            migrationBuilder.DropColumn(
                name: "SEOTitle",
                table: "AppProduct");

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 52, 41, 646, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 52, 41, 646, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 52, 41, 646, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 52, 41, 646, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 52, 41, 646, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 140, 40, 135, 220, 188, 254, 120, 23, 49, 131, 104, 92, 53, 230, 218, 0, 151, 82, 22, 202, 75, 81, 88, 172, 154, 231, 117, 10, 223, 126, 17, 131, 226, 104, 237, 26, 84, 165, 109, 250, 125, 75, 155, 162, 42, 233, 82, 101, 90, 86, 157, 175, 2, 198, 249, 23, 107, 67, 254, 242, 33, 140, 137, 219 }, new byte[] { 147, 195, 7, 246, 196, 53, 26, 106, 87, 230, 160, 13, 129, 80, 45, 178, 14, 28, 242, 255, 179, 140, 215, 71, 49, 20, 164, 2, 132, 44, 250, 92, 155, 60, 168, 200, 151, 190, 226, 86, 204, 44, 7, 23, 30, 16, 103, 121, 8, 248, 116, 61, 143, 140, 119, 113, 181, 76, 1, 131, 168, 123, 25, 216, 27, 3, 137, 234, 218, 104, 235, 6, 196, 191, 254, 79, 17, 228, 82, 134, 100, 205, 58, 215, 206, 14, 116, 107, 215, 2, 158, 76, 202, 179, 88, 253, 68, 18, 229, 116, 108, 165, 75, 15, 191, 193, 235, 37, 250, 147, 255, 88, 75, 82, 76, 2, 20, 78, 197, 98, 181, 70, 64, 164, 23, 64, 233, 250 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 52, 41, 646, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 52, 41, 646, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 52, 41, 646, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 52, 41, 646, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 52, 41, 646, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 52, 41, 646, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 17, 52, 41, 646, DateTimeKind.Local).AddTicks(2147));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SEODescription",
                table: "AppProduct",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SEOImagePath",
                table: "AppProduct",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SEOKeyword",
                table: "AppProduct",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SEOTitle",
                table: "AppProduct",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

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
    }
}
