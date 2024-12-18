﻿using App.Data;
using App.Data.Repositories;
using App.Web.Common;
using App.Web.Common.Mailer;
using App.Web.ViewModels.Cart;
using AspNetCoreHero.ToastNotification;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;

namespace App.Web.WebConfig
{
    public static class AppService
    {
        public static string WebRootPath { get; private set; }

        public static void AddAppService(this IServiceCollection services, IConfiguration Configuration, IWebHostEnvironment env)
        {
            WebRootPath = env.WebRootPath;
            services.AddDbContext<WebAppDbContext>(opt =>
            {
                opt.UseSqlServer(Configuration.GetConnectionString("Database"));
            });
            services.AddScoped<GenericRepository>();
            services.AddTransient<OrderDataVM>();

            // Cấu hình đăng nhập
            services.AddAuthentication(AppConst.COOKIES_AUTH).AddCookie(options =>
            {
                options.LoginPath = AppConst.ADMIN_LOGIN_PATH;
                options.ExpireTimeSpan = TimeSpan.FromHours(AppConst.LOGIN_TIMEOUT);
                options.Cookie.HttpOnly = true;
            });

            // Cấu hình AutoMapper
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.AddProfile(new AutoMapperProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            // Cấu hình thư mục view cho ViewComponent
            services.Configure<RazorViewEngineOptions>(config =>
            {
                // path: /Components/{component-name}/Default.cshtml
                config.ViewLocationFormats.Add("/{0}.cshtml");
                config.AreaViewLocationFormats.Add("Areas/Admin/{0}.cshtml");
            });

            // Khởi tạo thông tin mail
            AppMailConfiguration mailConfig = new();
            mailConfig.LoadFromConfig(Configuration);
            services.AddSingleton(mailConfig);

            services.AddNotyf(config =>
            {
                config.DurationInSeconds = 10;
                config.IsDismissable = true;
                config.Position = NotyfPosition.BottomRight;
            });

            services.AddHttpContextAccessor();

            // Cấu hình session
            services.AddSession(sessionConf =>
            {
                // Dữ liệu session tồn tại trong 2 ngày
                sessionConf.IdleTimeout = TimeSpan.FromDays(2);
                sessionConf.IOTimeout = TimeSpan.FromDays(2);
            });

            services.AddAntiforgery(opt => opt.Cookie.Expiration = TimeSpan.FromMinutes(-1));
        }
    }
}
