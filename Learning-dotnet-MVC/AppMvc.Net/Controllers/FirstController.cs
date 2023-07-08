using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppMvc.Net.Models;

namespace AppMvc.Net.Controllers
{
    //[Route("[controller]")]
    public class FirstController : Controller
    {
        private readonly ILogger<FirstController> _logger;

        public FirstController(ILogger<FirstController> logger)
        {
            _logger = logger;
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
        public object Arr() => new int[] { 1, 2, 3,};

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
        public ContentResult Readme(){
            var content = @"
            Hello everybody
            You are learning ASP.Net Core 7.0
            
            
            Good luck!
            ";
            return this.Content(content,"text/plain");
        }

    }
}