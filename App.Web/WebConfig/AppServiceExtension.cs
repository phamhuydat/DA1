﻿using App.Data;
using App.Data.Repositories;
using App.Web.Services;

namespace App.Web.WebConfig
{
    public static class AppServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config, IWebHostEnvironment env)
        {
            services.AddControllersWithViews();
            services.AddHttpContextAccessor();
            services.AddAppService(config, env);
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddServicesDependencies();

            return services;
        }
    }
}
