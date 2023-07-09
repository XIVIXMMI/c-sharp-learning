using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppMvc.Net.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.Extensions.FileProviders;
using MimeKit;
using AppMvc.Services;

namespace AppMvc.Net.Controllers
{
    //[Route("[controller]")]
    public class FirstController : Controller
    {
        private readonly IWebHostEnvironment _env;

        private readonly ILogger<FirstController> _logger;
        private readonly ProductService _productService;

        public FirstController(ILogger<FirstController> logger, IWebHostEnvironment env, ProductService productService)
        {
            _logger = logger;
            _env = env;
            _productService = productService; 
        }

        public IActionResult Index()
        {
            /*
            this.HttpContext
            this.Request
            this.Respone
            this.RouteData

            this.User
            this.ModelState
            this.ViewData
            this.Url
            this.TempData
            */

            /* LogLevel
            Debug
            Infomation
            Warning
            Error
            Critical
            */
            _logger.LogWarning("ATTENTION");
            _logger.LogDebug("ATTENTION");
            _logger.LogError("ATTENTION");
            _logger.LogCritical("ATTENTION");
            _logger.LogInformation("Index Action");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
        /*
        *Action trong Controller
        là 1 phương thức được khai báo bằng public
        không thể khai báo static 
        có thể trả về bất kì kiểu dữ liệu hay đối tượng gì
        nội dung trả về cua Action sẽ được convert thành chuỗi
        và thiết lập nội dung trả về cho Client
        Thậm chí Action không trả về kiểu dữ liệu gì như void

        */
        public void Nothing()
        {
            _logger.LogInformation("Nothing Action");
            //Response.Headers.Add("Hello everynyan", "How are you");
        }
        public object Time() => "The time is " + DateTime.Now;
        public object Number() => Math.Sqrt(4);
        public object Arr() => new int[] { 1, 2, 3, };

        /*
        Tuy nhiên các Action trong controller thì thường 
        khai báo trả về những đối tượng triển khai từ interface IActionResult 

        Kiểu trả về                 | Phương thức
        ------------------------------------------------
        ContentResult               | Content()
        EmptyResult                 | new EmptyResult() => tương đương trả về void 

        FileResult                  | File()
        ForbidResult                | Forbid()
        JsonResult                  | Json()
        LocalRedirectResult         | LocalRedirect()
        RedirectResult              | Redirect()
        RedirectToActionResult      | RedirectToAction()
        RedirectToPageResult        | RedirectToRoute()
        RedirectToRouteResult       | RedirectToPage()
        PartialViewResult           | PartialView()
        ViewComponentResult         | ViewComponent()
        StatusCodeResult            | StatusCode()
        ViewResult                  | View()
        
        */
        public ContentResult Readme()
        {
            var content = @"
            Hello everybody
            You are learning ASP.Net Core 7.0
            
            
            Good luck!
            ";
            return this.Content(content, "text/plain");
        }
        public IActionResult Picture()
        {
            string filePath = Path.Combine(_env.ContentRootPath, "Pictures", "HelloWorld.png");
            var bytes = System.IO.File.ReadAllBytes(filePath);
            string contentType = MimeKit.MimeTypes.GetMimeType(filePath);

            var cd = new System.Net.Mime.ContentDisposition
            {
                FileName = filePath,
                Inline = true,
            };

            Response.Headers.Add("Content-Disposition", cd.ToString());

            return File(bytes, contentType);
        }
        public IActionResult AppleProduct()
        {
            return Json(new
            {
                productName = "Iphone 11",
                price = "699$"
            });
        }
        public IActionResult Privacy()
        {
            var url = Url.Action("Privacy", "Home");// Hãy đảm bảo giá trị không phải null ở đây
            if (url != null)
            {
                _logger.LogInformation("Redirect to" + url);
                return LocalRedirect(url);
            }
            else
            {
                return NotFound();// Hoặc trả về một phản hồi khác tùy thuộc vào logic của bạn
            }
        }
        public IActionResult Google()
        {
            var url = "https://www.google.com/";// Hãy đảm bảo giá trị không phải null ở đâyß
            _logger.LogInformation("Redirect to" + url);
            return Redirect(url);
        }
        public IActionResult HelloView2(string username){
            if(string.IsNullOrEmpty(username))
                username = "Guest";
            /*
            *Cơ bản View() 
            Yêu cầu sử dụng Razor Engine đọc và thi hành file .cshtml (template)
            Kết quả khi thi hành cshtml được lưu ở ViewResult và đó là nội dung trả về cho client
            TODO: Gọi phương thức View và chỉ ra file cshtml (template: đường dẫn tuyệt đối tới file cshtml).
            --------------------------------------------------------------------------------------
            ?Truyền dữ liệu từ controller sang view
            Thiết lập dữ liệu ở tham số thứ 2 của phương thức view (Model)
            username = null
            do không có dữ liệu binding đến nên kết quả trả về là Guest
            dữ liệu binding có thể thiết lập trên thanh địa chỉ như 
            http://localhost:5090/First/HelloView2?username=Billy
            lúc này kết quả trả về sẽ là => Hello Billy
            --------------------------------------------------------------------------------------
            ?Trường hợp trong tham số template không ghi đường dẫn tuyệt đối 
            trong trường hợp này Razor engine sẽ tìm đến file secondView
            -> trong thư mục /View -> sau đó đến thư mục con (tên của controller) -> mở file secondView.cshtml
            !Trong View phải có thư mục là tên của Controller 
            return View("secondView",username);
            ?Trường hợp nếu không chỉ ra template
            Gọi phương thức View tạo ViewResult
            Trong trường hợp này yêu cầu Razor Engine mở file template cshtml trùng tên với Action là HelloView2.cshtml
            và tìm nó ở trong thư mục -> View/First
            View/First/HelloView2.cshtml
        TODO: Nếu trong phương thức View không chỉ ra template thì nó sẽ tự động thiết lập file template theo đường dẫn View/First/HelloView2.cshtml
            Nếu muốn truyền model cho HelloView2 ở trường hợp này thiết lập ngay ở tham số đầu tiên
            return View(username);
            Nhưng nếu viết thế này username đang là 1 chuỗi ký tự thì nó sẽ hiểu username là template chứ không phải model
            -> cast nó sang object => (object) username

            View/Controller/Action.cshtml
            */
            return View((object) username);
            //return View("thirdView");
            
        }
        public string Notify{get;set;}
        public IActionResult ViewProduct(int? id){
            var product = _productService.Where(p => p.Id == id).FirstOrDefault();
            if(product == null){
                //TempData["Notify"] = "The product is not exist";
                Notify = "The product is not exist";
                return Redirect(Url.Action("Index","Home"));
            }
            //return Content($"Product ID = {id}");

            //Model
            //return View(product);

            //View Data
            // this.ViewData["product"] = product;
            // ViewData["Title"] = product.Name;
            // return View("secondViewProduct");

            //ViewBag
            ViewBag.product = product;
            return View("thirdViewProduct");
        }

    }
}