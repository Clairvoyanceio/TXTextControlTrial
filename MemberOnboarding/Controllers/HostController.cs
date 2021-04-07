using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemberOnboarding.Controllers
{
    public class HostController : Controller
    {
        // GET: HostController
        private IWebHostEnvironment _env;
        public HostController(IWebHostEnvironment env)
        {
            _env = env;
        }
        public IActionResult Index()
        {
            var webRoot = _env.WebRootPath;
            var file = System.IO.Path.Combine(webRoot, "test.txt");
            System.IO.File.WriteAllText(file, "Hello World!");
            return View();
        }

    }
}
