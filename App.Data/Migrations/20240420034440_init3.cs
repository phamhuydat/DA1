using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverImgPath",
                table: "AppProductCategory");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "AppSlider",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 44, 39, 885, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 44, 39, 885, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 44, 39, 885, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 44, 39, 885, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 44, 39, 885, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 196, 68, 185, 158, 146, 128, 225, 173, 60, 25, 161, 20, 123, 212, 187, 175, 12, 31, 18, 2, 146, 98, 65, 217, 160, 41, 190, 189, 41, 107, 201, 227, 201, 213, 200, 164, 163, 232, 156, 86, 11, 145, 133, 13, 182, 224, 115, 217, 67, 157, 64, 109, 92, 181, 168, 195, 154, 83, 162, 15, 164, 135, 209, 25 }, new byte[] { 125, 104, 138, 51, 214, 90, 50, 170, 47, 143, 76, 255, 198, 23, 44, 253, 91, 170, 119, 92, 235, 190, 75, 3, 135, 228, 158, 197, 98, 101, 125, 244, 137, 188, 206, 130, 217, 138, 86, 246, 113, 161, 19, 111, 229, 152, 109, 39, 50, 186, 111, 44, 65, 212, 41, 178, 4, 48, 133, 98, 221, 156, 46, 76, 201, 106, 8, 80, 159, 192, 37, 242, 120, 182, 49, 222, 159, 67, 227, 223, 92, 91, 220, 206, 112, 155, 250, 131, 62, 238, 122, 64, 139, 138, 121, 228, 185, 80, 138, 176, 18, 177, 219, 199, 253, 124, 91, 250, 235, 54, 227, 150, 185, 20, 96, 121, 49, 177, 120, 128, 43, 159, 86, 147, 94, 176, 215, 241 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 44, 39, 885, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 44, 39, 885, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 44, 39, 885, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 44, 39, 885, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 44, 39, 885, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 44, 39, 885, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 44, 39, 885, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.CreateIndex(
                name: "IX_AppSlider_CategoryId",
                table: "AppSlider",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppSlider_AppProductCategory_CategoryId",
                table: "AppSlider",
                column: "CategoryId",
                principalTable: "AppProductCategory",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppSlider_AppProductCategory_CategoryId",
                table: "AppSlider");

            migrationBuilder.DropIndex(
                name: "IX_AppSlider_CategoryId",
                table: "AppSlider");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "AppSlider");

            migrationBuilder.AddColumn<string>(
                name: "CoverImgPath",
                table: "AppProductCategory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppBranch",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 29, 49, 869, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 29, 49, 869, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 29, 49, 869, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 29, 49, 869, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "AppNewsCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 29, 49, 869, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 111, 37, 93, 65, 244, 81, 127, 122, 60, 194, 75, 130, 182, 171, 246, 64, 212, 5, 220, 117, 127, 74, 216, 84, 151, 214, 195, 230, 26, 111, 203, 40, 99, 173, 59, 119, 217, 206, 105, 162, 177, 109, 27, 40, 131, 97, 148, 14, 240, 158, 196, 218, 239, 105, 195, 91, 136, 236, 241, 209, 46, 29, 68, 131 }, new byte[] { 58, 40, 37, 36, 56, 66, 83, 149, 129, 89, 0, 130, 38, 248, 109, 225, 87, 158, 107, 206, 33, 65, 89, 15, 82, 62, 81, 238, 156, 195, 59, 106, 177, 115, 186, 240, 14, 109, 77, 30, 58, 229, 63, 25, 169, 147, 251, 233, 65, 179, 239, 68, 79, 104, 52, 41, 241, 82, 229, 183, 39, 167, 117, 42, 233, 144, 35, 120, 31, 229, 52, 160, 67, 227, 42, 44, 13, 12, 26, 106, 183, 60, 28, 181, 26, 119, 190, 25, 70, 129, 99, 186, 90, 121, 10, 195, 0, 13, 161, 135, 98, 130, 128, 144, 174, 142, 190, 156, 189, 108, 92, 75, 217, 95, 17, 125, 29, 230, 137, 101, 244, 31, 202, 128, 241, 37, 22, 193 } });

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 29, 49, 869, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 29, 49, 869, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 29, 49, 869, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "MstOrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 29, 49, 869, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 29, 49, 869, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 29, 49, 869, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "MstProductColor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 10, 29, 49, 869, DateTimeKind.Local).AddTicks(6604));
        }
    }
}
