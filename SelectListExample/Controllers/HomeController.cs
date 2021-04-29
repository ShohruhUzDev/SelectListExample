using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SelectListExample.Data;
using SelectListExample.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SelectListExample.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly SelectListDbContext _dbcontext;

        public HomeController(SelectListDbContext selectListDbContext)
        {
            _dbcontext = selectListDbContext ;
        }

        public IActionResult List()
        {
            List<Customer> customers = _dbcontext.Customers.ToList();
            return View(customers);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
