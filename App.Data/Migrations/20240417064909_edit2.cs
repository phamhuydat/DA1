using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class edit2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 13, 49, 7, 772, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 13, 49, 7, 772, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 13, 49, 7, 772, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 13, 49, 7, 772, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 13, 49, 7, 772, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 247, 56, 71, 154, 194, 7, 194, 156, 247, 48, 131, 200, 7, 51, 105, 101, 76, 26, 117, 98, 32, 173, 145, 232, 23, 130, 40, 22, 201, 108, 1, 213, 160, 65, 248, 52, 16, 195, 139, 254, 175, 96, 215, 26, 149, 164, 212, 114, 238, 24, 139, 172, 93, 230, 216, 229, 123, 72, 205, 125, 170, 54, 131, 61 }, new byte[] { 207, 114, 228, 216, 133, 3, 12, 168, 150, 85, 180, 95, 188, 66, 222, 193, 94, 143, 173, 35, 52, 11, 51, 154, 32, 222, 148, 114, 184, 166, 122, 255, 222, 93, 20, 233, 94, 51, 63, 42, 193, 166, 125, 231, 112, 117, 202, 82, 215, 27, 244, 76, 54, 224, 246, 127, 89, 193, 20, 118, 30, 185, 241, 166, 154, 37, 53, 137, 197, 3, 255, 1, 182, 145, 93, 33, 27, 113, 232, 129, 53, 244, 1, 136, 140, 148, 14, 248, 114, 89, 248, 110, 103, 191, 202, 89, 18, 40, 217, 179, 238, 112, 238, 231, 213, 139, 108, 17, 119, 0, 185, 212, 64, 156, 1, 47, 207, 222, 70, 0, 80, 60, 121, 216, 9, 3, 137, 141 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 13, 49, 7, 772, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 13, 49, 7, 772, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 13, 49, 7, 772, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 13, 49, 7, 772, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 13, 49, 7, 772, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 13, 49, 7, 772, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 13, 49, 7, 772, DateTimeKind.Local).AddTicks(5884));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
