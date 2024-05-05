using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class init_db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppBranch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IdMap = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBranch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppDiscountCode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MinDiscountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    UnApplyCategoryId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppDiscountCode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppNewsCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppNewsCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppProductCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CateLevel = table.Column<int>(type: "int", maxLength: 5, nullable: false, defaultValue: 1),
                    HasChild = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Content = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CoverImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StampPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentCateId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppProductCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppProductCategory_AppProductCategory_ParentCateId",
                        column: x => x.ParentCateId,
                        principalTable: "AppProductCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CanDelete = table.Column<bool>(type: "bit", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MstOrderStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MstOrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MstPermission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Table = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MstPermission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MstProductColor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CssColor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MstProductColor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppProduct_AppProductCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "AppProductCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppSlider",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSlider", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppSlider_AppProductCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "AppProductCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(200)", maxLength: 200, nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(200)", maxLength: 200, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BlockedTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BlockedBy = table.Column<int>(type: "int", nullable: true),
                    AppRoleId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUser_AppRole_AppRoleId",
                        column: x => x.AppRoleId,
                        principalTable: "AppRole",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppRolePermission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppRoleId = table.Column<int>(type: "int", nullable: false),
                    MstPermissionId = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRolePermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppRolePermission_AppRole_AppRoleId",
                        column: x => x.AppRoleId,
                        principalTable: "AppRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppRolePermission_MstPermission_MstPermissionId",
                        column: x => x.MstPermissionId,
                        principalTable: "MstPermission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppProductDetail",
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
                    Ram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GPU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMain = table.Column<bool>(type: "bit", nullable: true),
                    InStock = table.Column<int>(type: "int", nullable: false),
                    Sold = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppProductDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppProductDetail_AppProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "AppProduct",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppProductDetail_MstProductColor_ColorId",
                        column: x => x.ColorId,
                        principalTable: "MstProductColor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppProductImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    IsMobile = table.Column<bool>(type: "bit", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppProductImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppProductImage_AppProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "AppProduct",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppNews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Views = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    Votes = table.Column<float>(type: "real", nullable: false, defaultValue: 0f),
                    Published = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    PublishedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CoverImgPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoverImgThumbnailPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StampPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SEOTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SEODescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    SEOKeyword = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SEOImagePath = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppNews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppNews_AppNewsCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "AppNewsCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppNews_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CusName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CusPhone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CusEmail = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CusNote = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    DiscountCodeId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppOrder_AppDiscountCode_DiscountCodeId",
                        column: x => x.DiscountCodeId,
                        principalTable: "AppDiscountCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppOrder_AppUser_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AppUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppOrder_AppUser_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppOrder_MstOrderStatus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "MstOrderStatus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppPolicy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CoverImgPath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CoverImgThumbnailPath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Like = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPolicy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppPolicy_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppVerifyCode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TokenString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expired = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppVerifyCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppVerifyCode_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppOrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppOrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppOrderDetail_AppOrder_OrderId",
                        column: x => x.OrderId,
                        principalTable: "AppOrder",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppOrderDetail_AppProductDetail_ProductId",
                        column: x => x.ProductId,
                        principalTable: "AppProductDetail",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AppBranch",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "GroupName", "IdMap", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "91 Trần Văn Khéo, Cái Khế, Ninh Kiều, Cần Thơ", null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5277), null, null, "Thành Phố Cần Thơ", "113.188.249.73", null, null });

            migrationBuilder.InsertData(
                table: "AppNewsCategory",
                columns: new[] { "Id", "Content", "CoverImgPath", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "Slug", "Title", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6531), null, null, "tin-tuc-apple", "Tin tức Apple", null, null },
                    { 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6531), null, null, "bai-viet-review", "Bài viết Review", null, null },
                    { 3, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6531), null, null, "kham-pha", "Khám phá", null, null },
                    { 4, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6531), null, null, "thu-thuat", "Thủ thuật", null, null },
                    { 5, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6531), null, null, "khuyen-mai", "Khuyến mãi", null, null },
                    { 6, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6531), null, null, "tin-khac", "Tin khác", null, null }
                });

            migrationBuilder.InsertData(
                table: "AppProductCategory",
                columns: new[] { "Id", "CateLevel", "Content", "CoverImgPath", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "HasChild", "Name", "ParentCateId", "Slug", "StampPath", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, true, "Iphone", null, "iphone", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 2, 1, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, true, "IPad", null, "ipad", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 3, 1, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, true, "Mac", null, "mac", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 4, 1, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, true, "Watch", null, "watch", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 5, 1, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, true, "Phụ kiện", null, "phu-kien", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) }
                });

            migrationBuilder.InsertData(
                table: "AppRole",
                columns: new[] { "Id", "CanDelete", "CreatedBy", "CreatedDate", "DeletedDate", "Desc", "DisplayOrder", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, false, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4377), null, "Khách hàng", null, "Khách hàng", null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4377) },
                    { 2, true, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4377), null, "Quản trị toàn bộ hệ thống", null, "Quản trị hệ thống", null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4377) }
                });

            migrationBuilder.InsertData(
                table: "MstOrderStatus",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6483), null, null, "Đang xử lý" },
                    { 2, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6483), null, null, "Đang giao hàng" },
                    { 3, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6483), null, null, "Đã giao hàng" },
                    { 4, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6483), null, null, "Đã từ chối" }
                });

            migrationBuilder.InsertData(
                table: "MstPermission",
                columns: new[] { "Id", "Code", "CreatedDate", "DeletedDate", "Desc", "DisplayOrder", "GroupName", "Table" },
                values: new object[,]
                {
                    { 1001, "VIEW_LIST", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xem danh sách người dùng", null, "Quản lý người dùng", "AppUser" },
                    { 1002, "VIEW_DETAIL", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xem chi tiết người dùng", null, "Quản lý người dùng", "AppUser" },
                    { 1003, "CREATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Thêm người dùng", null, "Quản lý người dùng", "AppUser" },
                    { 1004, "UPDATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Cập nhật người dùng", null, "Quản lý người dùng", "AppUser" },
                    { 1005, "UPDATE_PWD", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Đổi mật khẩu", null, "Quản lý người dùng", "AppUser" },
                    { 1006, "BLOCK", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Khóa người dùng", null, "Quản lý người dùng", "AppUser" },
                    { 1007, "UNBLOCK", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Mở khóa người dùng", null, "Quản lý người dùng", "AppUser" },
                    { 1008, "DELETE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xóa người dùng", null, "Quản lý người dùng", "AppUser" },
                    { 1101, "VIEW_LIST", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xem danh sách quyền", null, "Quản lý phân quyền", "AppRole" },
                    { 1102, "VIEW_DETAIL", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xem chi tiết quyền", null, "Quản lý phân quyền", "AppRole" },
                    { 1103, "CREATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Thêm quyền", null, "Quản lý phân quyền", "AppRole" },
                    { 1104, "UPDATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Sửa quyền", null, "Quản lý phân quyền", "AppRole" },
                    { 1105, "DELETE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xóa quyền", null, "Quản lý phân quyền", "AppRole" },
                    { 1205, "MANAGER", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Quản lý file hệ thống", null, "Quản lý file", "FileManager" },
                    { 1301, "VIEW_LIST", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xem danh sách thương hiệu", null, "Quản lý thương hiệu", "MstProductBrand" },
                    { 1302, "CREATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Thêm thương hiệu", null, "Quản lý thương hiệu", "MstProductBrand" },
                    { 1303, "UPDATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Sửa thương hiệu", null, "Quản lý thương hiệu", "MstProductBrand" },
                    { 1304, "DELETE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xóa thương hiệu", null, "Quản lý thương hiệu", "MstProductBrand" },
                    { 1401, "VIEW_LIST", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xem danh sách chi nhánh", null, "Quản lý chi nhánh", "AppBranch" },
                    { 1402, "CREATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Thêm chi nhánh", null, "Quản lý chi nhánh", "AppBranch" },
                    { 1403, "UPDATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Sửa chi nhánh", null, "Quản lý chi nhánh", "AppBranch" },
                    { 1404, "DELETE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xóa chi nhánh", null, "Quản lý chi nhánh", "AppBranch" },
                    { 1501, "VIEW_LIST", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xem danh sách mã khuyến mãi", null, "Quản lý mã khuyến mãi", "AppDiscountCode" },
                    { 1502, "CREATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Thêm mã khuyến mãi", null, "Quản lý mã khuyến mãi", "AppDiscountCode" },
                    { 1503, "UPDATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Sửa mã khuyến mãi", null, "Quản lý mã khuyến mãi", "AppDiscountCode" },
                    { 1504, "DELETE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xóa mã khuyến mãi", null, "Quản lý mã khuyến mãi", "AppDiscountCode" },
                    { 1701, "VIEW_LIST", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xem danh sách màu sản phẩm", null, "Quản lý màu sắc sản phẩm", "MstProductColor" },
                    { 1702, "CREATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Thêm màu sản phẩm", null, "Quản lý màu sắc sản phẩm", "MstProductColor" },
                    { 1703, "UPDATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Sửa màu sản phẩm", null, "Quản lý màu sắc sản phẩm", "MstProductColor" },
                    { 1704, "DELETE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xóa màu sản phẩm", null, "Quản lý màu sắc sản phẩm", "MstProductColor" },
                    { 1901, "VIEW_LIST", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xem danh sách slider", null, "Quản lý slider", "AppSlider" },
                    { 1902, "CREATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Thêm slider", null, "Quản lý slider", "AppSlider" },
                    { 1903, "UPDATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Sửa slider", null, "Quản lý slider", "AppSlider" },
                    { 1904, "DELETE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xóa slider", null, "Quản lý slider", "AppSlider" },
                    { 2001, "VIEW_LIST", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xem danh sách chính sách", null, "Quản lý chính sách", "AppPolicy" },
                    { 2002, "VIEW_DETAIL", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xem chi tiết chính sách", null, "Quản lý chính sách", "AppPolicy" },
                    { 2003, "CREATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Thêm chính sách", null, "Quản lý chính sách", "AppPolicy" },
                    { 2004, "UPDATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Sửa chính sách", null, "Quản lý chính sách", "AppPolicy" },
                    { 2005, "DELETE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xóa chính sách", null, "Quản lý chính sách", "AppPolicy" },
                    { 2101, "VIEW_LIST", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xem danh sách thể loại tin tức", null, "Quản lý thể loại tin tức", "AppNewsCategory" },
                    { 2102, "CREATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Thêm thể loại tin tức", null, "Quản lý thể loại tin tức", "AppNewsCategory" },
                    { 2103, "UPDATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Sửa thể loại tin tức", null, "Quản lý thể loại tin tức", "AppNewsCategory" },
                    { 2104, "DELETE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xóa thể loại tin tức", null, "Quản lý thể loại tin tức", "AppNewsCategory" },
                    { 2201, "VIEW_LIST", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xem danh sách tin tức", null, "Quản lý tin tức", "AppNews" },
                    { 2202, "CREATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Thêm tin tức", null, "Quản lý tin tức", "AppNews" },
                    { 2203, "UPDATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Sửa tin tức", null, "Quản lý tin tức", "AppNews" },
                    { 2204, "DELETE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xóa tin tức", null, "Quản lý tin tức", "AppNews" },
                    { 2205, "PUBLIC", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Hiển thị tin tức", null, "Quản lý tin tức", "AppNews" },
                    { 2206, "UNPUBLIC", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Ẩn tin tức", null, "Quản lý tin tức", "AppNews" },
                    { 2207, "SENDMAILREGISTER", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Gửi mail cho ngươi đăng ký", null, "Quản lý tin tức", "AppNews" },
                    { 2208, "VIEW_DETAIL", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xem chi tiết bài viết", null, "Quản lý tin tức", "AppNews" },
                    { 2301, "VIEW_LIST", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xem trang giới thiệu", null, "Quản lý giới thiệu công ty", "SystemEnv" },
                    { 2302, "UPDATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Cập nhật trang giới thiệu", null, "Quản lý giới thiệu công ty", "SystemEnv" },
                    { 2401, "VIEW_LIST", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xem danh sách thể loại sản phẩm", null, "Quản lý thể loại sản phẩm", "AppProductCategory" },
                    { 2402, "CREATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Thêm thể loại sản phẩm", null, "Quản lý thể loại sản phẩm", "AppProductCategory" },
                    { 2403, "UPDATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Sửa thể loại sản phẩm", null, "Quản lý thể loại sản phẩm", "AppProductCategory" },
                    { 2404, "DELETE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xóa thể loại sản phẩm", null, "Quản lý thể loại sản phẩm", "AppProductCategory" },
                    { 2501, "VIEW_LIST", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xem danh sách sản phẩm", null, "Quản lý sản phẩm", "AppProduct" },
                    { 2502, "CREATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Thêm sản phẩm", null, "Quản lý sản phẩm", "AppProduct" },
                    { 2503, "UPDATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Sửa sản phẩm", null, "Quản lý sản phẩm", "AppProduct" },
                    { 2504, "DELETE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xóa sản phẩm", null, "Quản lý sản phẩm", "AppProduct" },
                    { 2506, "PUBLIC", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Hiển thị sản phẩm", null, "Quản lý sản phẩm", "AppProduct" },
                    { 2507, "UNPUBLIC", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Ẩn sản phẩm", null, "Quản lý sản phẩm", "AppProduct" },
                    { 2508, "VIEW_DETAIL", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xem chi tiết sản phẩm", null, "Quản lý sản phẩm", "AppProduct" },
                    { 2601, "VIEW_LIST", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xem danh sách đơn hàng", null, "Quản lý đơn hàng", "AppOrder" },
                    { 2602, "CREATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xem chi tiết đơn hàng", null, "Quản lý đơn hàng", "AppOrder" },
                    { 2603, "UPDATE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Sửa đơn hàng", null, "Quản lý đơn hàng", "AppOrder" },
                    { 2604, "DELETE", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(4134), null, "Xóa đơn hàng", null, "Quản lý đơn hàng", "AppOrder" }
                });

            migrationBuilder.InsertData(
                table: "MstProductColor",
                columns: new[] { "Id", "ColorName", "CreatedDate", "CssColor", "DeletedDate", "DisplayOrder" },
                values: new object[,]
                {
                    { 1, "Red", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6509), "#FF0000", null, null },
                    { 2, "Black", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6509), "#000000", null, null },
                    { 3, "Blue", new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(6509), "#0000FF", null, null }
                });

            migrationBuilder.InsertData(
                table: "AppProductCategory",
                columns: new[] { "Id", "CateLevel", "Content", "CoverImgPath", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "Name", "ParentCateId", "Slug", "StampPath", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 6, 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, "Chuột/ Bàn phím", 5, "chuot-ban-phim", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 7, 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, "Óp lưng", 5, "op-lung", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 8, 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, "Balo/ Túi chống sốc", 5, "balo-tui-chong-soc", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 9, 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, "Ốp lưng", 5, "op-lung", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 10, 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, "Kính cường lực", 5, "kinh-cuong-luc", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 11, 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, "Apple Watch Ultra 2", 4, "apple-watch-ultra-2", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 12, 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, "Apple Watch SE", 4, "apple-watch-se", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 13, 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, "MacBook Pro", 3, "macbook-pro", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 14, 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, "MacBook Air", 3, "macbook-air", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 15, 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, "MacBook Pro M1", 3, "macbook-pro-m1", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 16, 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, "MacBook Pro M2", 3, "macbook-pro-m2", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 17, 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, "IMac", 3, "imac", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 18, 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, "IPad Pro M1", 2, "ipad-pro-m1", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 19, 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, "IPad Pro M2", 2, "ipad-pro-m2", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 20, 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, "IPad Air", 2, "ipad-air", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 21, 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, "IPad Mini", 2, "ipad-mini", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 22, 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, "IPhone 15 series", 1, "iphone-15-series", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 23, 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, "IPhone 14 series", 1, "iphone-14-series", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 24, 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, "IPhone 13 series", 1, "iphone-13-series", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 25, 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, "IPhone 12 series", 1, "iphone-12-series", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 26, 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, "IPhone 11 series", 1, "iphone-11-series", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) },
                    { 27, 2, null, null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328), null, null, "IPhone SE", 1, "iphone-se", null, null, new DateTime(2024, 5, 4, 11, 40, 14, 123, DateTimeKind.Local).AddTicks(5328) }
                });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "Address", "AppRoleId", "Avatar", "BlockedBy", "BlockedTo", "CreatedBy", "CreatedDate", "DeletedDate", "DisplayOrder", "Email", "FullName", "PasswordHash", "PasswordSalt", "PhoneNumber", "UpdatedBy", "UpdatedDate", "Username" },
                values: new object[] { 1, "Thành phố Cần Thơ", 2, "~/Images/Avatar/default.png", null, null, -1, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "hello@gmail.com", "Lilocon", new byte[] { 137, 25, 119, 216, 60, 187, 90, 119, 54, 163, 100, 173, 95, 59, 227, 219, 81, 130, 118, 197, 19, 77, 182, 110, 58, 206, 3, 149, 13, 211, 23, 177, 85, 148, 179, 107, 9, 181, 200, 89, 205, 60, 85, 90, 185, 214, 196, 151, 127, 199, 3, 155, 154, 124, 95, 44, 247, 174, 160, 178, 245, 175, 75, 131 }, new byte[] { 114, 236, 14, 76, 94, 31, 112, 225, 183, 188, 207, 105, 86, 206, 201, 104, 164, 12, 188, 145, 179, 52, 126, 0, 119, 51, 250, 22, 121, 125, 250, 165, 133, 206, 76, 207, 238, 112, 113, 214, 42, 221, 213, 126, 49, 233, 106, 205, 197, 121, 248, 60, 149, 175, 100, 171, 133, 248, 72, 67, 170, 69, 102, 188, 92, 96, 203, 73, 116, 39, 63, 99, 98, 200, 243, 195, 204, 175, 69, 165, 8, 167, 107, 57, 173, 155, 78, 16, 140, 152, 207, 126, 81, 126, 3, 66, 161, 220, 66, 48, 50, 9, 206, 55, 30, 28, 90, 242, 2, 97, 160, 179, 187, 188, 1, 97, 30, 22, 11, 153, 87, 34, 29, 119, 117, 179, 103, 228 }, "0928666158", -1, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_AppNews_CategoryId",
                table: "AppNews",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AppNews_UserId",
                table: "AppNews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "uq_slug",
                table: "AppNews",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppOrder_CreatedBy",
                table: "AppOrder",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AppOrder_DiscountCodeId",
                table: "AppOrder",
                column: "DiscountCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppOrder_EmployeeId",
                table: "AppOrder",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppOrder_StatusId",
                table: "AppOrder",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AppOrderDetail_OrderId",
                table: "AppOrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_AppOrderDetail_ProductId",
                table: "AppOrderDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AppPolicy_UserId",
                table: "AppPolicy",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppProduct_CategoryId",
                table: "AppProduct",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AppProductCategory_ParentCateId",
                table: "AppProductCategory",
                column: "ParentCateId");

            migrationBuilder.CreateIndex(
                name: "IX_AppProductDetail_ColorId",
                table: "AppProductDetail",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_AppProductDetail_ProductId",
                table: "AppProductDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AppProductImage_ProductId",
                table: "AppProductImage",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AppRolePermission_AppRoleId",
                table: "AppRolePermission",
                column: "AppRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AppRolePermission_MstPermissionId",
                table: "AppRolePermission",
                column: "MstPermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppSlider_CategoryId",
                table: "AppSlider",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_AppRoleId",
                table: "AppUser",
                column: "AppRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_Username",
                table: "AppUser",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppVerifyCode_UserId",
                table: "AppVerifyCode",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppBranch");

            migrationBuilder.DropTable(
                name: "AppNews");

            migrationBuilder.DropTable(
                name: "AppOrderDetail");

            migrationBuilder.DropTable(
                name: "AppPolicy");

            migrationBuilder.DropTable(
                name: "AppProductImage");

            migrationBuilder.DropTable(
                name: "AppRolePermission");

            migrationBuilder.DropTable(
                name: "AppSlider");

            migrationBuilder.DropTable(
                name: "AppVerifyCode");

            migrationBuilder.DropTable(
                name: "AppNewsCategory");

            migrationBuilder.DropTable(
                name: "AppOrder");

            migrationBuilder.DropTable(
                name: "AppProductDetail");

            migrationBuilder.DropTable(
                name: "MstPermission");

            migrationBuilder.DropTable(
                name: "AppDiscountCode");

            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "MstOrderStatus");

            migrationBuilder.DropTable(
                name: "AppProduct");

            migrationBuilder.DropTable(
                name: "MstProductColor");

            migrationBuilder.DropTable(
                name: "AppRole");

            migrationBuilder.DropTable(
                name: "AppProductCategory");
        }
    }
}
