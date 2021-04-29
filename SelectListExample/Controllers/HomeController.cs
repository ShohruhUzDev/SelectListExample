using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SelectListExample.Data;
using SelectListExample.Models;
using SelectListExample.Models.ViewModels;
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

        public IActionResult Create()
        {
            CustomerCreateModel customerCreateModel = new CustomerCreateModel();
            customerCreateModel.Customer = new Customer();
            List<SelectListItem> countries = _dbcontext.Countries
                .OrderBy(n => n.Name)
                .Select(n =>
                new SelectListItem
                { 
                    Value=n.Code,
                    Text=n.Name

                }).ToList();
            customerCreateModel.Countries = countries;
            customerCreateModel.Cities = new List<SelectListItem>();
            return View(customerCreateModel);

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
