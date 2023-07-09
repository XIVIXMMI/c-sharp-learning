using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AppMvc.Net.Views.First
{
    public class HelloView2 : PageModel
    {
        private readonly ILogger<HelloView2> _logger;

        public HelloView2(ILogger<HelloView2> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}