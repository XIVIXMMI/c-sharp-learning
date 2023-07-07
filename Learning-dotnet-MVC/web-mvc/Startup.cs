using System.Net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using web_mvc;

namespace StartUp
{
    public class Startup
    {
        public static string ContentRootPath { get; private set; }
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration,IWebHostEnvironment env)
        {
            Configuration = configuration;
            ContentRootPath = env.ContentRootPath;

        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Đăng ký dịch vụ và cấu hình các đối tượng phụ thuộc
            services.AddControllersWithViews();
            services.AddRazorPages();
            //services.AddTransient(typeof(ILogger<>),typeof(Logger<>));
            services.Configure<RazorViewEngineOptions>(options =>{
                // /View/Controller/Action.cshtml
                // /Pages/Controller/Action.cshtml
                // {0} -> Action Name
                // {1} -> Controller Name
                // {2} -> Area Name
                options.ViewLocationFormats.Add("/Pages/{1}/{0}.cshtml"+RazorViewEngine.ViewExtension);
            });
            // Cấu hình các dịch vụ khác (VD: Authentication, Authorization, Database, ...)

            // Cấu hình kết nối đến cơ sở dữ liệu

            // ...

            services.AddSingleton<ProductService>();
            // services.AddSingleton<ProductService, ProductService>();
            // services.AddSingleton(typeof(ProductService));
            //services.AddSingleton(typeof(ProductService), typeof(ProductService));
            //services.AddScoped<ProductService>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            // Cấu hình middleware xác thực (Authentication) và phân quyền (Authorization)
            app.UseAuthorization(); // Xác thực quyền truy cập
            app.UseAuthentication(); //Xác thực danh tính

            app.UseRouting();
            
            
            app.UseStatusCodePages(appError => {
                appError.Run(async context => {
                    var response = context.Response;
                    var code = response.StatusCode;
                    
                    var content = @$"<html>
                        <head>
                            <meta charset='UTF-8 />
                            <title>Lỗi {code} </title>
                        </head>
                        <body>
                            <p>
                                Có lỗi xảy ra : {code} - {(HttpStatusCode)code}
                            </p>
                        </body>
                    </html>";
                    await response.WriteAsync(content);
                });
            }); // Trả về lỗi từ code 400 - 599
            

            app.UseEndpoints(endpoints =>
            {
            
            });
        }
    }
}