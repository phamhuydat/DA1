using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class edit3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppProductCategory_AppProductCategory_ParentCateId",
                table: "AppProductCategory");

            migrationBuilder.DropTable(
                name: "SystemEnv");

            migrationBuilder.DropIndex(
                name: "IX_AppProductCategory_ParentCateId",
                table: "AppProductCategory");

            migrationBuilder.DropColumn(
                name: "CateLevel",
                table: "AppProductCategory");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "AppProductCategory");

            migrationBuilder.DropColumn(
                name: "GroupName",
                table: "AppProductCategory");

            migrationBuilder.DropColumn(
                name: "HasChild",
                table: "AppProductCategory");

            migrationBuilder.DropColumn(
                name: "ParentCateId",
                table: "AppProductCategory");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "AppProductCategory");

            migrationBuilder.DropColumn(
                name: "StampPath",
                table: "AppProductCategory");

            migrationBuilder.AlterColumn<string>(
                name: "CoverImgPath",
                table: "AppProductCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CoverImgPath",
                table: "AppProductCategory",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CateLevel",
                table: "AppProductCategory",
                type: "int",
                maxLength: 5,
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "AppProductCategory",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GroupName",
                table: "AppProductCategory",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "HasChild",
                table: "AppProductCategory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ParentCateId",
                table: "AppProductCategory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "AppProductCategory",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StampPath",
                table: "AppProductCategory",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "SystemEnv",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemEnv", x => x.Key);
                });

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

            migrationBuilder.InsertData(
                table: "SystemEnv",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "AdminReciverMail", "" },
                    { "BrandAddress", "" },
                    { "BrandName", "" },
                    { "CompanyIntroduce", "" },
                    { "CompanyIntroduceContent", "" },
                    { "CompanyIntroduceImage1", "" },
                    { "CompanyIntroduceImage2", "" },
                    { "CompanyIntroduceImage3", "" },
                    { "CompanyIntroduceImage4", "" },
                    { "CompanyIntroduceTitle", "" },
                    { "DefaultImage", "" },
                    { "EmailForOrderInformation", "" },
                    { "Facebook", "" },
                    { "IconImagePath", "" },
                    { "Logo", "" },
                    { "MessengerEmbeddedCode", "" },
                    { "PrimaryMail", "" },
                    { "PrimaryPhone", "" },
                    { "SecondaryMail", "" },
                    { "SecondaryPhone", "" },
                    { "SEODescription", "" },
                    { "SEOImagePath", "" },
                    { "SEOKeyword", "" },
                    { "SEOTitle", "" },
                    { "TaxCode", "" },
                    { "Youtube", "" },
                    { "Zalo", "" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppProductCategory_ParentCateId",
                table: "AppProductCategory",
                column: "ParentCateId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppProductCategory_AppProductCategory_ParentCateId",
                table: "AppProductCategory",
                column: "ParentCateId",
                principalTable: "AppProductCategory",
                principalColumn: "Id");
        }
    }
}
