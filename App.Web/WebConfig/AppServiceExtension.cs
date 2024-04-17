using App.Data;
using App.Data.Repositories;
using App.Web.Services;

namespace App.Web.WebConfig
{
	public static class AppServiceExtension
	{
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
		{
            services.AddControllersWithViews();
            services.AddHttpContextAccessor();
            services.AddAppService(config);
            services.AddServicesDependencies();
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
		}
	}
}
