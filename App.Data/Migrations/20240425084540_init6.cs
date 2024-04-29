using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class init6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppOrderDetail_AppProdcutDetail_AppProdcutDetailId",
                table: "AppOrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_AppProdcutDetail_AppProduct_AppProductId",
                table: "AppProdcutDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_AppProdcutDetail_MstProductColor_MstProductColorId",
                table: "AppProdcutDetail");

            migrationBuilder.DropIndex(
                name: "IX_AppOrderDetail_AppProdcutDetailId",
                table: "AppOrderDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppProdcutDetail",
                table: "AppProdcutDetail");

            migrationBuilder.DropIndex(
                name: "IX_AppProdcutDetail_AppProductId",
                table: "AppProdcutDetail");

            migrationBuilder.DropIndex(
                name: "IX_AppProdcutDetail_MstProductColorId",
                table: "AppProdcutDetail");

            migrationBuilder.DropColumn(
                name: "AppProdcutDetailId",
                table: "AppOrderDetail");

            migrationBuilder.DropColumn(
                name: "AppProductId",
                table: "AppProdcutDetail");

            migrationBuilder.DropColumn(
                name: "MstProductColorId",
                table: "AppProdcutDetail");

            migrationBuilder.RenameTable(
                name: "AppProdcutDetail",
                newName: "AppProductDetail");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppProductDetail",
                table: "AppProductDetail",
                column: "Id");

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

            migrationBuilder.CreateIndex(
                name: "IX_AppOrderDetail_ProductId",
                table: "AppOrderDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AppProductDetail_ColorId",
                table: "AppProductDetail",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_AppProductDetail_ProductId",
                table: "AppProductDetail",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppOrderDetail_AppProductDetail_ProductId",
                table: "AppOrderDetail",
                column: "ProductId",
                principalTable: "AppProductDetail",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppProductDetail_AppProduct_ProductId",
                table: "AppProductDetail",
                column: "ProductId",
                principalTable: "AppProduct",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppProductDetail_MstProductColor_ColorId",
                table: "AppProductDetail",
                column: "ColorId",
                principalTable: "MstProductColor",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppOrderDetail_AppProductDetail_ProductId",
                table: "AppOrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_AppProductDetail_AppProduct_ProductId",
                table: "AppProductDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_AppProductDetail_MstProductColor_ColorId",
                table: "AppProductDetail");

            migrationBuilder.DropIndex(
                name: "IX_AppOrderDetail_ProductId",
                table: "AppOrderDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppProductDetail",
                table: "AppProductDetail");

            migrationBuilder.DropIndex(
                name: "IX_AppProductDetail_ColorId",
                table: "AppProductDetail");

            migrationBuilder.DropIndex(
                name: "IX_AppProductDetail_ProductId",
                table: "AppProductDetail");

            migrationBuilder.RenameTable(
                name: "AppProductDetail",
                newName: "AppProdcutDetail");

            migrationBuilder.AddColumn<int>(
                name: "AppProdcutDetailId",
                table: "AppOrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppProductId",
                table: "AppProdcutDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MstProductColorId",
                table: "AppProdcutDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppProdcutDetail",
                table: "AppProdcutDetail",
                column: "Id");

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

            migrationBuilder.CreateIndex(
                name: "IX_AppOrderDetail_AppProdcutDetailId",
                table: "AppOrderDetail",
                column: "AppProdcutDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_AppProdcutDetail_AppProductId",
                table: "AppProdcutDetail",
                column: "AppProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AppProdcutDetail_MstProductColorId",
                table: "AppProdcutDetail",
                column: "MstProductColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppOrderDetail_AppProdcutDetail_AppProdcutDetailId",
                table: "AppOrderDetail",
                column: "AppProdcutDetailId",
                principalTable: "AppProdcutDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppProdcutDetail_AppProduct_AppProductId",
                table: "AppProdcutDetail",
                column: "AppProductId",
                principalTable: "AppProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppProdcutDetail_MstProductColor_MstProductColorId",
                table: "AppProdcutDetail",
                column: "MstProductColorId",
                principalTable: "MstProductColor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
