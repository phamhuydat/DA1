using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppProduct_MstProductColor_ProductColorId",
                table: "AppProduct");

            migrationBuilder.DropIndex(
                name: "IX_AppProduct_ProductColorId",
                table: "AppProduct");

            migrationBuilder.DeleteData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1801);

            migrationBuilder.DeleteData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1802);

            migrationBuilder.DeleteData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1803);

            migrationBuilder.DeleteData(
                table: "MstPermission",
                keyColumn: "Id",
                keyValue: 1804);

            migrationBuilder.DropColumn(
                name: "ProductColorId",
                table: "AppProduct");

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "AppProduct",
                type: "int",
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

            migrationBuilder.CreateIndex(
                name: "IX_AppProduct_ColorId",
                table: "AppProduct",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppProduct_MstProductColor_ColorId",
                table: "AppProduct",
                column: "ColorId",
                principalTable: "MstProductColor",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppProduct_MstProductColor_ColorId",
                table: "AppProduct");

            migrationBuilder.DropIndex(
                name: "IX_AppProduct_ColorId",
                table: "AppProduct");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "AppProduct");

            migrationBuilder.AddColumn<int>(
                name: "ProductColorId",
                table: "AppProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.InsertData(
                table: "MstPermission",
                columns: new[] { "Id", "Code", "CreatedDate", "DeletedDate", "Desc", "DisplayOrder", "GroupName", "Table" },
                values: new object[,]
                {
                    { 1801, "VIEW_LIST", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xem danh sách size", null, "Quản lý size sản phẩm", "MstProductSize" },
                    { 1802, "CREATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Thêm size", null, "Quản lý size sản phẩm", "MstProductSize" },
                    { 1803, "UPDATE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sửa size", null, "Quản lý size sản phẩm", "MstProductSize" },
                    { 1804, "DELETE", new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Xóa size", null, "Quản lý size sản phẩm", "MstProductSize" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AppProduct_ProductColorId",
                table: "AppProduct",
                column: "ProductColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppProduct_MstProductColor_ProductColorId",
                table: "AppProduct",
                column: "ProductColorId",
                principalTable: "MstProductColor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
