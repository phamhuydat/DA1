using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppOrderDetail_AppProduct_ProductId",
                table: "AppOrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_AppProduct_MstProductColor_ColorId",
                table: "AppProduct");

            migrationBuilder.DropIndex(
                name: "IX_AppProduct_ColorId",
                table: "AppProduct");

            migrationBuilder.DropIndex(
                name: "IX_AppOrderDetail_ProductId",
                table: "AppOrderDetail");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "AppProduct");

            migrationBuilder.DropColumn(
                name: "DiscountFrom",
                table: "AppProduct");

            migrationBuilder.DropColumn(
                name: "DiscountPrice",
                table: "AppProduct");

            migrationBuilder.DropColumn(
                name: "DiscountTo",
                table: "AppProduct");

            migrationBuilder.DropColumn(
                name: "Inch",
                table: "AppProduct");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "AppProduct");

            migrationBuilder.DropColumn(
                name: "Ram",
                table: "AppProduct");

            migrationBuilder.DropColumn(
                name: "Rom",
                table: "AppProduct");

            migrationBuilder.AddColumn<bool>(
                name: "IsMobile",
                table: "AppProductImage",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "AppProdcutDetailId",
                table: "AppOrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AppProdcutDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DiscountFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DiscountTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    ColorId = table.Column<int>(type: "int", nullable: true),
                    AppProductId = table.Column<int>(type: "int", nullable: false),
                    MstProductColorId = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppProdcutDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppProdcutDetail_AppProduct_AppProductId",
                        column: x => x.AppProductId,
                        principalTable: "AppProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppProdcutDetail_MstProductColor_MstProductColorId",
                        column: x => x.MstProductColorId,
                        principalTable: "MstProductColor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppOrderDetail_AppProdcutDetail_AppProdcutDetailId",
                table: "AppOrderDetail");

            migrationBuilder.DropTable(
                name: "AppProdcutDetail");

            migrationBuilder.DropIndex(
                name: "IX_AppOrderDetail_AppProdcutDetailId",
                table: "AppOrderDetail");

            migrationBuilder.DropColumn(
                name: "IsMobile",
                table: "AppProductImage");

            migrationBuilder.DropColumn(
                name: "AppProdcutDetailId",
                table: "AppOrderDetail");

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "AppProduct",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DiscountFrom",
                table: "AppProduct",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountPrice",
                table: "AppProduct",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DiscountTo",
                table: "AppProduct",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Inch",
                table: "AppProduct",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "AppProduct",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Ram",
                table: "AppProduct",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rom",
                table: "AppProduct",
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
                name: "IX_AppProduct_ColorId",
                table: "AppProduct",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_AppOrderDetail_ProductId",
                table: "AppOrderDetail",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppOrderDetail_AppProduct_ProductId",
                table: "AppOrderDetail",
                column: "ProductId",
                principalTable: "AppProduct",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppProduct_MstProductColor_ColorId",
                table: "AppProduct",
                column: "ColorId",
                principalTable: "MstProductColor",
                principalColumn: "Id");
        }
    }
}
