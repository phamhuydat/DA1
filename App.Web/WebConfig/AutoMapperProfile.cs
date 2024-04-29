using App.Data.Entities;
using App.Data.Entities.Products;
using App.Web.Areas.Admin.ViewModels.Account;
using App.Web.Areas.Admin.ViewModels.AppBranch;
using App.Web.Areas.Admin.ViewModels.AppDiscountCode;
using App.Web.Areas.Admin.ViewModels.AppPolicy;
using App.Web.Areas.Admin.ViewModels.AppSlider;
using App.Web.Areas.Admin.ViewModels.MstProductColor;
using App.Web.Areas.Admin.ViewModels.News;
using App.Web.Areas.Admin.ViewModels.NewsCategory;
using App.Web.Areas.Admin.ViewModels.Order.OrderDetail;
using App.Web.Areas.Admin.ViewModels.Order;
using App.Web.Areas.Admin.ViewModels.Product;
using App.Web.Areas.Admin.ViewModels.ProductCategory;
using App.Web.Areas.Admin.ViewModels.Role;
using App.Web.Areas.Admin.ViewModels.User;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Web.ViewModels.AppDiscountCode;
using App.Web.ViewModels.Slider;
using App.Web.ViewModels.Policy;
using App.Web.ViewModels.AppBranch;
using App.Web.ViewModels.Account;
using App.Web.ViewModels.News;
using App.Web.ViewModels.ProductCategory;
using App.Web.ViewModels.Product;
using App.Web.ViewModels.Cart;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System.Security.Policy;

namespace App.Web.WebConfig
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Map dữ liệu từ kiểu UserAddOrEditVM sang AppUser
            CreateMap<UserAddOrEditVM, AppUser>();

            // Map dữ liệu từ kiểu AppUser sang UserAddOrEditVM
            CreateMap<AppUser, UserAddOrEditVM>();
            CreateMap<AppUser, UpdateUserViewModel>().ReverseMap();
            CreateMap<AppUser, UserDataForApp>().ReverseMap();
            CreateMap<AppUser, AcceptUpdateViewModel>().ReverseMap();

            CreateMap<AppBranch, AddOrUpdateBranchVM>().ReverseMap();
            CreateMap<AppDiscountCode, AddOrUpdateDiscountCodeVM>().ReverseMap();
            CreateMap<MstProductColor, AddOrUpdateProductColorVM>().ReverseMap();
            CreateMap<AppSlider, AddOrUpdateSliderVM>().ReverseMap();
            CreateMap<AppPolicy, AddOrUpdatePolicyVM>().ReverseMap();
            CreateMap<AppPolicy, DetailPolicyVM>().ReverseMap();
            CreateMap<AppNewsCategory, AddOrUpdateNewsCategoryVM>().ReverseMap();
            CreateMap<AppNews, AddOrUpdateNewsVM>().ReverseMap();
            CreateMap<AppProductCategory, AddOrUpdateProductCategoryVM>().ReverseMap();
            CreateMap<AppProduct, AddOrUpdateProductVM>().ReverseMap();

            CreateMap<AppPolicy, PolicyDetailVM>().ReverseMap();
            CreateMap<AppUser, RegisterClientVM>().ReverseMap();
            CreateMap<AppProduct, CartItemVM>().ReverseMap();
        }

        public static MapperConfiguration RoleIndexConf = new(mapper =>
        {
            // Map dữ liệu từ kiểu AppRole sang RoleListItemVM
            mapper.CreateMap<AppRole, RoleListItemVM>();
        });

        // Cấu hình mapping cho UserController, action Index
        public static MapperConfiguration UserIndexConf = new(mapper =>
        {
            // Map dữ liệu từ AppUser sang UserListItemVM, map thuộc tính RoleName
            mapper.CreateMap<AppUser, UserListItemVM>()
                .ForMember(uItem => uItem.RoleName, opts => opts.MapFrom(uEntity => uEntity.AppRole.Name));
        });

        // Cấu hình mapping cho AccountController, action Login
        public static MapperConfiguration LoginConf = new(mapper =>
        {
            // Map dữ liệu từ AppUser sang UserListItemVM, map thuộc tính RoleName
            mapper.CreateMap<AppUser, UserDataForApp>()
                .ForMember(uItem => uItem.RoleName, opts => opts.MapFrom(uEntity => uEntity.AppRole == null ? "" : uEntity.AppRole.Name))
                .ForMember(uItem => uItem.Permission, opts => opts.MapFrom
                (
                    uEntity => string.Join(',', uEntity.AppRole
                                                        .AppRolePermissions
                                                        .Select(p => p.MstPermissionId))
                )
            );
        });

        public static MapperConfiguration UpdateConf = new(mapper =>
        {
            // Map dữ liệu từ AppUser sang UserListItemVM, map thuộc tính RoleName
            mapper.CreateMap<AppUser, UpdateUserViewModel>()
                .ForMember(uItem => uItem.RoleName, opts => opts.MapFrom(uEntity => uEntity.AppRole == null ? "" : uEntity.AppRole.Name))
                .ForMember(uItem => uItem.Permission, opts => opts.MapFrom
                (
                    uEntity => string.Join(',', uEntity.AppRole
                                                        .AppRolePermissions
                                                        .Select(p => p.MstPermissionId))
                )
            );
        });

        // Cấu hình mapping cho RoleController, action Delete
        public static MapperConfiguration RoleDeleteConf = new(mapper =>
        {
            // Map dữ liệu thuộc tính con
            mapper.CreateMap<AppUser, RoleDeleteVM_User>();
            // Map dữ liệu thuộc tính cha
            mapper.CreateMap<AppRole, RoleDeleteVM>();
        });


        public static MapperConfiguration AppBranchConf = new MapperConfiguration(mapper =>
        {
            mapper.CreateMap<AppBranch, BranchListItemVM>();
            mapper.CreateMap<AppBranch, ListBranchVM>();
        });

        public static MapperConfiguration AppDiscountCodeConf = new(mapper =>
        {
            mapper.CreateMap<AppDiscountCode, DiscountCodeListItemVM>();
            mapper.CreateMap<AppDiscountCode, AppDiscountCodeListItemVM>();
        });

        public static MapperConfiguration MstProductColorConf = new MapperConfiguration(mapper =>
        {
            mapper.CreateMap<MstProductColor, ProductColorListItemVM>()
                .ForMember(item => item.CountProduct, opts => opts.MapFrom(entity => entity.AppProdcutDetails == null ? 0 : entity.AppProdcutDetails.Where(x => x.DeletedDate == null).Count()));
        });

        public static MapperConfiguration AppSliderConf = new MapperConfiguration(mapper =>
        {
            mapper.CreateMap<AppSlider, SliderListItemVM>();
            mapper.CreateMap<AppSlider, ListSliderVM>();
        });

        public static MapperConfiguration AppPolicyConf = new MapperConfiguration(mapper =>
        {
            mapper.CreateMap<AppPolicy, PolicyListItemVM>();
            mapper.CreateMap<AppPolicy, ListPolicyFooterVM>();
        });

        public static MapperConfiguration NewsCategoryConf = new MapperConfiguration(mapper =>
        {
            mapper.CreateMap<AppNewsCategory, NewsCategoryListItemVM>()
                .ForMember(x => x.TotalNews, opts => opts.MapFrom(x => x.NewsNavigation.Count(x => x.DeletedDate == null)));
        });

        public static MapperConfiguration NewsConf = new(mapper =>
        {
            mapper.CreateMap<AppNews, NewsListItemVM>()
                .ForMember(vm => vm.CategoryName, opt =>
                    opt.MapFrom(entity =>
                        entity.NewsCategory == null ? "" : entity.NewsCategory.Title
                    )
                );
            mapper.CreateMap<NewsListItemVM, AppNews>();
            mapper.CreateMap<AppNews, ListNewsVM>().ReverseMap();
        });

        //public static MapperConfiguration ProductCategoryConf = new(mapper =>
        //{
        //    mapper.CreateMap<AppProductCategory, ListItemProductCategoryVM>()
        //    .ForMember(x => x.ChildCategories, opt => opt.MapFrom(e => e.ChildCategories))
        //    .ReverseMap();
        //});
        //public static MapperConfiguration ProductCategorySelectConf = new(mapper =>
        //{
        //    mapper.CreateMap<AppProductCategory, ListProductCateSelectVM>()
        //    .ForMember(x => x.Name, opt => opt.MapFrom(e => e.ParentCategory == null ? e.Name : $"[{e.ParentCategory.Name}] > [{e.Name}]"))
        //    .ForMember(x => x.CateLevel, opt => opt.MapFrom(e => "Danh mục cấp " + e.CateLevel))
        //    .ReverseMap();
        //});

        //public static MapperConfiguration ProductsConf = new(mapper =>
        //{
        //    mapper.CreateMap<AppProduct, ListItemProductVM>()
        //    .ForMember(uItem => uItem.CategoryName, opts =>
        //        opts.MapFrom(uEntity =>
        //            uEntity.ProductCategory == null ? "" :
        //                (uEntity.ProductCategory.ParentCategory == null ?
        //                    uEntity.ProductCategory.Name :
        //                    uEntity.ProductCategory.ParentCategory.Name + " > " + uEntity.ProductCategory.Name
        //            )
        //        )
        //    )
        //    .ForMember(uItem => uItem.ImagePath, opts =>
        //        opts.MapFrom(uEntity => uEntity.AppProductImages.FirstOrDefault() == null ? "" : uEntity.AppProductImages.First().ImagePath)
        //    )
        //    .ForMember(u => u.ColorName, opt => opt.MapFrom(e => e.ProductColor == null ? "" : e.ProductColor.ColorName)).ReverseMap();

        //    //mapper.CreateMap<AppProduct, ListItemProductVM>()
        //    //.ForMember(uItem => uItem.CategoryName, opts => opts.MapFrom(uEntity => uEntity.ProductCategory == null ? "" : uEntity.ProductCategory.Name))
        //    //.ForMember(uItem => uItem.ImagePath, opts =>
        //    //	opts.MapFrom(uEntity => uEntity.ProductImages.FirstOrDefault() == null ? "" : uEntity.ProductImages.First().ImagePath)
        //    //)
        //    //.ForMember(uItem => uItem.BrandName, opts => opts.MapFrom(uEntity => uEntity.ProductBrand == null ? "" : uEntity.ProductBrand.Name))
        //    //.ForMember(uItem => uItem.StampPathCategory, opts => opts.MapFrom(uEntity => uEntity.ProductCategory == null ? "" : uEntity.ProductCategory.StampPath));

        //});

        //public static MapperConfiguration ProductDetailConf = new(mapper =>
        //{
        //    mapper.CreateMap<AppProduct, ProductDetailClientVM>()
        //        .ForMember(x => x.CategoryName,
        //            //opt => opt.MapFrom(e => e.ProductCategory == null ? ""  
        //            //    : (e.ProductCategory.ParentCategory == null ? e.ProductCategory.Name 
        //            //    : $"[{e.ProductCategory.ParentCategory.Name}] > [{e.ProductCategory.Name}]"))
        //            opt => opt.MapFrom(u => u.AppProdcutCategory.Name))
        //        .ForMember(x => x.ColorName, opt => opt.MapFrom(u => u.MstProductColor.ColorName))
        //        .ReverseMap();

        //    mapper.CreateMap<AppProduct, ProductDetailClientVM>()
        //        .ReverseMap();
        //});

        public static MapperConfiguration ProductDetailConf = new(mapper =>
        {
            mapper.CreateMap<AppProduct, ProductDetailClientVM>()
                .ForMember(x => x.CategoryName,
                    opt => opt.MapFrom(u => u.AppProdcutCategory.Name))
               .ForMember(uItem => uItem.Price, opt =>
                opt.MapFrom(uEntity => uEntity.AppProductDetails == null ? 1000 : uEntity.AppProductDetails.First().Price))

               .ForMember(uItem => uItem.DiscountFrom, opt =>
                    opt.MapFrom(uEntity => uEntity.AppProductDetails.FirstOrDefault() == null ? DateTime.Now : uEntity.AppProductDetails.First().DiscountFrom))
                .ForMember(uItem => uItem.DiscountTo,
                    opt => opt.MapFrom(uEntity => uEntity.AppProductDetails.FirstOrDefault() == null ? DateTime.Now : uEntity.AppProductDetails.First().DiscountTo))
                .ForMember(uItem => uItem.DiscountPrice,
                    opt => opt.MapFrom(uEntity => uEntity.AppProductDetails.FirstOrDefault() == null ? 0 : uEntity.AppProductDetails.First().DiscountPrice))
                .ReverseMap();

            mapper.CreateMap<AppProduct, ProductDetailClientVM>()
                .ReverseMap();
        });


        public static MapperConfiguration OrderConf = new(mapper =>
        {
            mapper.CreateMap<AppOrderDetail, ListItemOrderDetailVM>();
            mapper.CreateMap<AppOrder, ListItemOrderVM>()
                .ForMember(x => x.StatusName, opt => opt.MapFrom(m => m.MstOrderStatus.Name))
                .ForMember(x => x.AppOrderDetails, opt => opt.MapFrom(x => x.AppOrderDetails))
                .ForMember(x => x.DiscountCode, opt => opt.MapFrom(x => x.AppDiscountCode == null ? "Đơn hàng không áp dụng mã giảm giá" : x.AppDiscountCode.Code));
        });

        public static MapperConfiguration OrderDetailConf = new(mapper =>
        {
            mapper.CreateMap<AppOrderDetail, ListItemOrderDetailVM>().ReverseMap();
        });

        public static MapperConfiguration NewsClientConf = new(mapper =>
        {
            mapper.CreateMap<AppNews, RelatedNewsVM>().ReverseMap();
            mapper.CreateMap<AppNews, ListNewsNavBarVM>().ReverseMap();
            mapper.CreateMap<AppNews, ListNewsVM>().ReverseMap();

            mapper.CreateMap<AppNews, NewsDetailVM>()
                .ForMember(x => x.CreatedBy, opt => opt.MapFrom(x => x.Users.FullName))
                .ReverseMap();
        });

        //public static MapperConfiguration ProductCategoryClientConf = new(mapper =>
        //{
        //    mapper.CreateMap<AppProductCategory, CateMenuVM>()
        //        .ForMember(x => x.ChildCategories, opt => opt.MapFrom(e => e.ChildCategories.Where(x => x.DeletedDate == null)))
        //        .ReverseMap();
        //});

        public static MapperConfiguration ProductClientConf = new(mapper =>
        {
            mapper.CreateMap<AppProduct, ProductListVM>()
            .ForMember(uItem => uItem.ImagePath, opt =>
                opt.MapFrom(uEntity => uEntity.AppProductImages.FirstOrDefault() == null ? "" : uEntity.AppProductImages.First().ImagePath))
            .ForMember(uItem => uItem.Price, opt =>
                opt.MapFrom(uEntity => uEntity.AppProductDetails.First().Price))
            .ForMember(uItem => uItem.DiscountFrom, opt =>
                opt.MapFrom(uEntity => uEntity.AppProductDetails.First().DiscountFrom))
            .ForMember(uItem => uItem.DiscountTo,
                opt => opt.MapFrom(uEntity => uEntity.AppProductDetails.First().DiscountTo))
            .ForMember(uItem => uItem.DiscountPrice,
                opt => opt.MapFrom(uEntity => uEntity.AppProductDetails.First().DiscountPrice))
            ;

        });

        public static MapperConfiguration CartConf = new(mapper =>
        {
            mapper.CreateMap<AppProduct, CartItemVM>()
            .ForMember(uItem => uItem.ImagePath, opts =>
                opts.MapFrom(uEntity => uEntity.AppProductImages.FirstOrDefault() == null ? "" : uEntity.AppProductImages.First().ImagePath)
            ).ReverseMap();
        });

    }
}
