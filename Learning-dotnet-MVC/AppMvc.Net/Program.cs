using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;
using AppMvc.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();
        builder.Services.AddRazorPages();
        builder.Services.AddSingleton<ProductService>();
        builder.Services.Configure<RazorViewEngineOptions>(options =>
        {
            /*
            /View/Controller/Action.cshtml
            /MyView/Controller/Action.cshtml

            {0} -> Action Name
            {1} -> Controller Name
            {2} -> Area Name
            */
            // options.ViewLocationFormats.Add("/MyView/{1}/{0}" + RazorViewEngine.ViewExtension);
            // options.FileProviders.Add(new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "MyView")));
        });

        //builder.Services.AddTransient(typeof(ILogger<>),typeof(Logger<>));
        //Dịch vụ này "ILogger" đã được tự đăng ký dưới hình thức như thế này
        //Nên khi cần tạo ra logger cho 1 đối tượng chỉ cần inject vào
        //khi sử dụng logger thì ta viết những thông tin và dấu vết hoạt động của ứng dụng

        var app = builder.Build();


        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthentication();//Xác định danh tính 

        app.UseAuthorization();// Xác thực quyền truy cập


        // URL: /{controller}/{action}/{id?}
        /*
        *Nếu truy cập với địa chỉ là Abc/Xyz 
        *Hệ thống sẽ phân tích, tìm controller Abc và khởi tạo nó 
        *Sau khi khởi tạo và thiết lập các thuộc tính cho controller 
        *thì nó sẽ gọi phương thức Xyz trong controller 
        */
        /*
        "default" khi mà không có địa chỉ Action thì mặc định Action đấy là Index
        và nếu không thiết lập Controller thì mặc định nó sẽ là Home 
        */
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.MapRazorPages(); // Đăng ký route của Razor Pages ở cấp đỉnh

        app.Run();
    }
}