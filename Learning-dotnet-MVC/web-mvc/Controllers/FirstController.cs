using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StartUp;

namespace web_mvc.Controllers
{
    public class FirstController : Controller
    {
        private readonly ILogger<FirstController> _logger;
        private readonly ProductService _productService;
        public FirstController(ILogger<FirstController> logger, ProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }
        public string Index()
        {
            // this.HttpContext;
            // this.Request;
            // this.Response;
            // this.RouteData;

            // this.User
            // this.ModelState
            // this.ViewData;
            // this.ViewBag
            // this.Url;
            // this.TempData


            // _logger.LogInformation("Index Action ");

            // _logger.LogWarning("Thong bao");
            // _logger.LogError("Thong bao");
            // _logger.LogDebug("Thong Bao");
            // _logger.LogCritical("Thong bao");


            return "Hello World";
        }
        public void Nothing()
        {
            _logger.LogInformation("Nothing Infomation");
            Response.Headers.Add("Hello", "Hello Evernyan");
        }

        public object Anything() => DateTime.Now;

        // IActionResult

        /*
        Kiểu trả về                 | Phương thức
        ------------------------------------------------
        ContentResult               | Content()
        EmptyResult                 | new EmptyResult()
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

        public IActionResult Readme()
        {
            var content = @"
        Hello everynyan,
        how are you, fine sankyu";
            return Content(content, "text/plain");
        }

        // public IActionResult Owl(){
        //     string filePath = Path.Combine(Startup.ContentRootPath, "Picture","geronimo-giqueaux-w2WUqRvTmtg-unsplash.jpg");
        //     var bytes = System.IO.File.ReadAllBytes(filePath);

        //     return File(bytes,"image/jpg");
        // }
        public IActionResult AppleProduct()
        {
            return Json(
                new
                {
                    productName = "Iphone",
                    price = "1099$"
                }
            );
        }
        // public IActionResult Privacy()
        // {
        //     var url = Url.Action("Privacy", "Home");
        //     _logger.LogInformation("Chuyen huong den " + url);
        //     return Redirect(url);
        // }
        public IActionResult Google()
        {
            var url = "https://google.com";
            _logger.LogInformation("Chuyen huong den" + url);
            return Redirect(url);
        }
        public IActionResult HelloView(string username)
        {
            if (string.IsNullOrEmpty(username))
                username = "Guest";

            //View() -> Razor Engine, doc .cshtml (template)
            //-----------------------------------------------
            //View(template) - template đường dẫn tuyệt đối đến .cshtml
            //View(template,model)
            
            //return View("/Pages/HelloWorld.cshtml", username);

            //HelloWorld.cshtml -> /View/First/HelloWorld
            // /View/Controller/Action.cshtml
            //return View((object)username);
            return View("HelloWorld2",username);
        }

        public IActionResult ViewProduct(int? id){
            var product = _productService.Where(p => p.Id == id).FirstOrDefault();
            if (product == null)
                return NotFound();

            return View(product);
        }

    }
}