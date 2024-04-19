using App.Data.Configurations;
using App.Data.Configurations.ProductConfigs;
using App.Data.DataSeeders;
using App.Data.Entities;
using App.Data.Entities.Products;
using Microsoft.EntityFrameworkCore;

namespace App.Data
{
	public class WebAppDbContext : DbContext
	{
		public WebAppDbContext(DbContextOptions<WebAppDbContext> options) : base(options)
		{
		}
		public DbSet<AppRole> AppRoles { get; set; }
		public DbSet<AppRolePermission> AppRolePermissions { get; set; }
		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<MstPermission> MstPermissions { get; set; }
		public DbSet<AppBranch> AppBranchs { get; set; } // dai chi cua hang
		public DbSet<AppPolicy> AppPolicies { get; set; }
		public DbSet<AppSlider> AppSliders { get; set; }
		public DbSet<MstOrderStatus> MstOrderStatus { get; set; }
		public DbSet<AppVerifyCode> AppVerifyCodes { get; set; }
		public DbSet<AppNewsCategory> AppNewsCategories { get; set; }
		public DbSet<AppNews> AppNews { get; set; }
		public DbSet<AppProductCategory> AppProductCategories { get; set; }
		public DbSet<AppDiscountCode> AppDiscountCodes { get; set; }
		public DbSet<AppOrder> AppOrders { get; set; }
		public DbSet<AppOrderDetail> AppOrderDetails { get; set; }
		public DbSet<MstProductColor> MstProductColors { get; set; }
		public DbSet<AppProduct> AppProducts { get; set; }
		public DbSet<AppProductImage> AppProductImages { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AppUserConfig());
			modelBuilder.ApplyConfiguration(new AppRoleConfig());
			modelBuilder.ApplyConfiguration(new AppRolePermissionConfig());
			modelBuilder.ApplyConfiguration(new MstPermissionConfig());
			modelBuilder.ApplyConfiguration(new AppBranchConfig());
			modelBuilder.ApplyConfiguration(new AppPolicyConfig());
			modelBuilder.ApplyConfiguration(new AppSliderConfig());
			modelBuilder.ApplyConfiguration(new MstOrderStatusConfig());
			modelBuilder.ApplyConfiguration(new AppVerifyCodeConfig());
			modelBuilder.ApplyConfiguration(new AppNewsCategoryConfig());
			modelBuilder.ApplyConfiguration(new AppNewsConfig());
			modelBuilder.ApplyConfiguration(new AppProductCategoryConfig());
			modelBuilder.ApplyConfiguration(new AppDiscountCodeConfig());
			modelBuilder.ApplyConfiguration(new AppOrderConfig());
			modelBuilder.ApplyConfiguration(new AppOrderDetailConfig());

			modelBuilder.ApplyConfiguration(new MstProductColorConfig());
			modelBuilder.ApplyConfiguration(new AppProductConfig());
			modelBuilder.ApplyConfiguration(new AppProductImageConfig());

			// Tạo dữ liệu
			modelBuilder.Entity<MstPermission>().SeedData();
			modelBuilder.Entity<AppRole>().SeedData();
			modelBuilder.Entity<AppUser>().SeedData();
			modelBuilder.Entity<AppRolePermission>().SeedData();
			modelBuilder.Entity<AppBranch>().SeedData();
			//modelBuilder.Entity<AppProductCategory>().SeedData();
			modelBuilder.Entity<MstOrderStatus>().SeedData();

			modelBuilder.Entity<MstProductColor>().SeedData();
			modelBuilder.Entity<AppNewsCategory>().SeedData();
		}
	}
}
