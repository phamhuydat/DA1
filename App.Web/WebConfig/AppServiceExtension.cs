using App.Data;
using App.Web.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace App.Web.WebConfig
{
	public static class AppServiceExtension
	{
        public static IConfiguration Configuration { get; }

        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
		{
            services.AddControllersWithViews();
            services.AddHttpContextAccessor();
            services.AddAppService(Configuration);
            services.AddServicesDependencies();
            services.AddScoped<DbContext, WebAppDbContext>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return services;
		}
	}
}
