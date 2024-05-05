using App.Data.Entities;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.DataSeeders
{
    public static class MstPermissionSeeder
    {
        public static void SeedData(this EntityTypeBuilder<MstPermission> builder)
        {
            var now = DateTime.Now;
            var groupName = "";

            #region Data liên quan đến bảng Role
            // Permission liên quan đến bảng AppRole
            groupName = "Quản lý phân quyền";
            builder.HasData(
                new MstPermission
                {
                    Id = AuthConst.AppRole.CREATE,
                    Code = "CREATE",
                    Table = DB.AppRole.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Thêm quyền",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppRole.DELETE,
                    Code = "DELETE",
                    Table = DB.AppRole.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xóa quyền",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppRole.UPDATE,
                    Code = "UPDATE",
                    Table = DB.AppRole.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Sửa quyền",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppRole.VIEW_DETAIL,
                    Code = "VIEW_DETAIL",
                    Table = DB.AppRole.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xem chi tiết quyền",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppRole.VIEW_LIST,
                    Code = "VIEW_LIST",
                    Table = DB.AppRole.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xem danh sách quyền",
                    CreatedDate = now
                }
            );
            #endregion
            #region Data liên quản bảng User
            // Permission liên quan đến bảng AppUser
            groupName = "Quản lý người dùng";
            builder.HasData(
                new MstPermission
                {
                    Id = AuthConst.AppUser.BLOCK,
                    Code = "BLOCK",
                    Table = DB.AppUser.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Khóa người dùng",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppUser.CREATE,
                    Code = "CREATE",
                    Table = DB.AppUser.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Thêm người dùng",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppUser.DELETE,
                    Code = "DELETE",
                    Table = DB.AppUser.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xóa người dùng",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppUser.UNBLOCK,
                    Code = "UNBLOCK",
                    Table = DB.AppUser.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Mở khóa người dùng",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppUser.UPDATE,
                    Code = "UPDATE",
                    Table = DB.AppUser.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Cập nhật người dùng",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppUser.UPDATE_PWD,
                    Code = "UPDATE_PWD",
                    Table = DB.AppUser.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Đổi mật khẩu",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppUser.VIEW_DETAIL,
                    Code = "VIEW_DETAIL",
                    Table = DB.AppUser.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xem chi tiết người dùng",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppUser.VIEW_LIST,
                    Code = "VIEW_LIST",
                    Table = DB.AppUser.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xem danh sách người dùng",
                    CreatedDate = now
                }
            );
            #endregion
            #region Data liên quan đến quản lý file
            // Permission liên quan đến quản lý file
            groupName = "Quản lý file";
            builder.HasData(
                new MstPermission
                {
                    Id = AuthConst.FileManager.MANAGE_ALL_USER_FILES,
                    Code = "MANAGER",
                    Table = "FileManager",
                    GroupName = groupName,
                    Desc = "Quản lý file hệ thống",
                    CreatedDate = now
                }
            );
            #endregion
            #region Data liên quan đến quản lý thương hiệu
            groupName = "Quản lý thương hiệu";
            builder.HasData(
                new MstPermission
                {
                    Id = AuthConst.MstProductBrand.VIEW_LIST,
                    Code = "VIEW_LIST",
                    Table = DB.MstProductBrand.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xem danh sách thương hiệu",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.MstProductBrand.CREATE,
                    Code = "CREATE",
                    Table = DB.MstProductBrand.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Thêm thương hiệu",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.MstProductBrand.UPDATE,
                    Code = "UPDATE",
                    Table = DB.MstProductBrand.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Sửa thương hiệu",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.MstProductBrand.DELETE,
                    Code = "DELETE",
                    Table = DB.MstProductBrand.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xóa thương hiệu",
                    CreatedDate = now
                });
            #endregion
            #region Data liên quan đến quản lý tên các chi nhánh
            groupName = "Quản lý chi nhánh";
            builder.HasData(
                new MstPermission
                {
                    Id = AuthConst.AppBranch.VIEW_LIST,
                    Code = "VIEW_LIST",
                    Table = DB.AppBranch.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xem danh sách chi nhánh",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppBranch.CREATE,
                    Code = "CREATE",
                    Table = DB.AppBranch.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Thêm chi nhánh",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppBranch.UPDATE,
                    Code = "UPDATE",
                    Table = DB.AppBranch.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Sửa chi nhánh",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppBranch.DELETE,
                    Code = "DELETE",
                    Table = DB.AppBranch.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xóa chi nhánh",
                    CreatedDate = now
                });
            #endregion
            #region Data liên quan đến quản lý mã giảm giá
            groupName = "Quản lý mã khuyến mãi";
            builder.HasData(
                new MstPermission
                {
                    Id = AuthConst.AppDiscountCode.VIEW_LIST,
                    Code = "VIEW_LIST",
                    Table = DB.AppDiscountCode.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xem danh sách mã khuyến mãi",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppDiscountCode.CREATE,
                    Code = "CREATE",
                    Table = DB.AppDiscountCode.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Thêm mã khuyến mãi",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppDiscountCode.UPDATE,
                    Code = "UPDATE",
                    Table = DB.AppDiscountCode.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Sửa mã khuyến mãi",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppDiscountCode.DELETE,
                    Code = "DELETE",
                    Table = DB.AppDiscountCode.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xóa mã khuyến mãi",
                    CreatedDate = now
                });
            #endregion
            #region Data liên quan đến quản lý màu sắc sản phẩm
            groupName = "Quản lý màu sắc sản phẩm";
            builder.HasData(
                new MstPermission
                {
                    Id = AuthConst.MstProductColor.VIEW_LIST,
                    Code = "VIEW_LIST",
                    Table = DB.MstProductColor.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xem danh sách màu sản phẩm",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.MstProductColor.CREATE,
                    Code = "CREATE",
                    Table = DB.MstProductColor.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Thêm màu sản phẩm",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.MstProductColor.UPDATE,
                    Code = "UPDATE",
                    Table = DB.MstProductColor.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Sửa màu sản phẩm",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.MstProductColor.DELETE,
                    Code = "DELETE",
                    Table = DB.MstProductColor.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xóa màu sản phẩm",
                    CreatedDate = now
                });
            #endregion
            //#region Data liên quan đến quản lý kích thước (Size) sản phẩm
            //groupName = "Quản lý size sản phẩm";
            //builder.HasData(
            //	new MstPermission
            //	{
            //		Id = AuthConst.MstProductSize.VIEW_LIST,
            //		Code = "VIEW_LIST",
            //		Table = DB.MstProductSize.TABLE_NAME,
            //		GroupName = groupName,
            //		Desc = "Xem danh sách size",
            //		CreatedDate = now
            //	},
            //	new MstPermission
            //	{
            //		Id = AuthConst.MstProductSize.CREATE,
            //		Code = "CREATE",
            //		Table = DB.MstProductSize.TABLE_NAME,
            //		GroupName = groupName,
            //		Desc = "Thêm size",
            //		CreatedDate = now
            //	},
            //	new MstPermission
            //	{
            //		Id = AuthConst.MstProductSize.UPDATE,
            //		Code = "UPDATE",
            //		Table = DB.MstProductSize.TABLE_NAME,
            //		GroupName = groupName,
            //		Desc = "Sửa size",
            //		CreatedDate = now
            //	},
            //	new MstPermission
            //	{
            //		Id = AuthConst.MstProductSize.DELETE,
            //		Code = "DELETE",
            //		Table = DB.MstProductSize.TABLE_NAME,
            //		GroupName = groupName,
            //		Desc = "Xóa size",
            //		CreatedDate = now
            //	});
            //#endregion
            #region Data liên quan đến quản lý slider
            groupName = "Quản lý slider";
            builder.HasData(
                new MstPermission
                {
                    Id = AuthConst.AppSlider.VIEW_LIST,
                    Code = "VIEW_LIST",
                    Table = DB.AppSlider.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xem danh sách slider",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppSlider.CREATE,
                    Code = "CREATE",
                    Table = DB.AppSlider.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Thêm slider",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppSlider.UPDATE,
                    Code = "UPDATE",
                    Table = DB.AppSlider.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Sửa slider",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppSlider.DELETE,
                    Code = "DELETE",
                    Table = DB.AppSlider.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xóa slider",
                    CreatedDate = now
                });
            #endregion
            #region Data liên quan đến quản lý chính sách
            groupName = "Quản lý chính sách";
            builder.HasData(
                new MstPermission
                {
                    Id = AuthConst.AppPolicy.VIEW_LIST,
                    Code = "VIEW_LIST",
                    Table = DB.AppPolicy.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xem danh sách chính sách",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppPolicy.VIEW_DETAIL,
                    Code = "VIEW_DETAIL",
                    Table = DB.AppPolicy.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xem chi tiết chính sách",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppPolicy.CREATE,
                    Code = "CREATE",
                    Table = DB.AppPolicy.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Thêm chính sách",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppPolicy.UPDATE,
                    Code = "UPDATE",
                    Table = DB.AppPolicy.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Sửa chính sách",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppPolicy.DELETE,
                    Code = "DELETE",
                    Table = DB.AppPolicy.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xóa chính sách",
                    CreatedDate = now
                });
            #endregion
            #region Data liên quan đến quản lý danh mục tin tức
            groupName = "Quản lý thể loại tin tức";
            builder.HasData(
                new MstPermission
                {
                    Id = AuthConst.AppNewsCategory.VIEW_LIST,
                    Code = "VIEW_LIST",
                    Table = DB.AppNewsCategory.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xem danh sách thể loại tin tức",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppNewsCategory.CREATE,
                    Code = "CREATE",
                    Table = DB.AppNewsCategory.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Thêm thể loại tin tức",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppNewsCategory.UPDATE,
                    Code = "UPDATE",
                    Table = DB.AppNewsCategory.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Sửa thể loại tin tức",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppNewsCategory.DELETE,
                    Code = "DELETE",
                    Table = DB.AppNewsCategory.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xóa thể loại tin tức",
                    CreatedDate = now
                });
            #endregion
            #region Data liên quan đến quản lý tin tức
            groupName = "Quản lý tin tức";
            builder.HasData(
                new MstPermission
                {
                    Id = AuthConst.AppNews.VIEW_LIST,
                    Code = "VIEW_LIST",
                    Table = DB.AppNews.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xem danh sách tin tức",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppNews.CREATE,
                    Code = "CREATE",
                    Table = DB.AppNews.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Thêm tin tức",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppNews.UPDATE,
                    Code = "UPDATE",
                    Table = DB.AppNews.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Sửa tin tức",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppNews.DELETE,
                    Code = "DELETE",
                    Table = DB.AppNews.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xóa tin tức",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppNews.PUBLIC,
                    Code = "PUBLIC",
                    Table = DB.AppNews.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Hiển thị tin tức",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppNews.UNPUBLIC,
                    Code = "UNPUBLIC",
                    Table = DB.AppNews.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Ẩn tin tức",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppNews.SENDMAILREGISTER,
                    Code = "SENDMAILREGISTER",
                    Table = DB.AppNews.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Gửi mail cho ngươi đăng ký",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppNews.VIEW_DETAIL,
                    Code = "VIEW_DETAIL",
                    Table = DB.AppNews.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xem chi tiết bài viết",
                    CreatedDate = now
                });
            #endregion
            #region Data liên quan đến giới thiệu công ty
            groupName = "Quản lý giới thiệu công ty";
            builder.HasData(
                new MstPermission
                {
                    Id = AuthConst.AppAboutCompany.VIEW_LIST,
                    Code = "VIEW_LIST",
                    Table = DB.SystemEnv.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xem trang giới thiệu",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppAboutCompany.UPDATE,
                    Code = "UPDATE",
                    Table = DB.SystemEnv.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Cập nhật trang giới thiệu",
                    CreatedDate = now
                });
            #endregion
            #region Data liên quan đến quản lý danh mục sản phẩm
            groupName = "Quản lý thể loại sản phẩm";
            builder.HasData(
                new MstPermission
                {
                    Id = AuthConst.AppProductCategory.VIEW_LIST,
                    Code = "VIEW_LIST",
                    Table = DB.AppProductCategory.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xem danh sách thể loại sản phẩm",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppProductCategory.CREATE,
                    Code = "CREATE",
                    Table = DB.AppProductCategory.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Thêm thể loại sản phẩm",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppProductCategory.UPDATE,
                    Code = "UPDATE",
                    Table = DB.AppProductCategory.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Sửa thể loại sản phẩm",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppProductCategory.DELETE,
                    Code = "DELETE",
                    Table = DB.AppProductCategory.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xóa thể loại sản phẩm",
                    CreatedDate = now
                });
            #endregion
            #region Data liên quan đến quản lý sản phẩm
            groupName = "Quản lý sản phẩm";
            builder.HasData(
                new MstPermission
                {
                    Id = AuthConst.AppProduct.VIEW_LIST,
                    Code = "VIEW_LIST",
                    Table = DB.AppProduct.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xem danh sách sản phẩm",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppProduct.CREATE,
                    Code = "CREATE",
                    Table = DB.AppProduct.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Thêm sản phẩm",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppProduct.UPDATE,
                    Code = "UPDATE",
                    Table = DB.AppProduct.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Sửa sản phẩm",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppProduct.DELETE,
                    Code = "DELETE",
                    Table = DB.AppProduct.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xóa sản phẩm",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppProduct.PUBLIC,
                    Code = "PUBLIC",
                    Table = DB.AppProduct.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Hiển thị sản phẩm",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppProduct.UNPUBLIC,
                    Code = "UNPUBLIC",
                    Table = DB.AppProduct.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Ẩn sản phẩm",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppProduct.VIEW_DETAIL,
                    Code = "VIEW_DETAIL",
                    Table = DB.AppProduct.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xem chi tiết sản phẩm",
                    CreatedDate = now
                });
            #endregion
            #region Data liên quan đến quản lý đơn hàng
            groupName = "Quản lý đơn hàng";
            builder.HasData(
                new MstPermission
                {
                    Id = AuthConst.AppOrder.VIEW_LIST,
                    Code = "VIEW_LIST",
                    Table = DB.AppOrder.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xem danh sách đơn hàng",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppOrder.DETAILS,
                    Code = "CREATE",
                    Table = DB.AppOrder.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xem chi tiết đơn hàng",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppOrder.UPDATE,
                    Code = "UPDATE",
                    Table = DB.AppOrder.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Sửa đơn hàng",
                    CreatedDate = now
                },
                new MstPermission
                {
                    Id = AuthConst.AppOrder.DELETE,
                    Code = "DELETE",
                    Table = DB.AppOrder.TABLE_NAME,
                    GroupName = groupName,
                    Desc = "Xóa đơn hàng",
                    CreatedDate = now
                });
            #endregion
        }
    }
}