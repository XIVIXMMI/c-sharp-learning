using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppMvc.Net.Controllers
{
    [Route("[controller]")]
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

    }
}