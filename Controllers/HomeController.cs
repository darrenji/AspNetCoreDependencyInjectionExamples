using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreDependencyInjectionExamples.Models;
using AspNetCoreDependencyInjectionExamples.Infrastructure;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreDependencyInjectionExamples.Controllers
{
    public class HomeController : Controller
    {
        //private IRepository repository;
        //private ProductTotalizer totalizer;

        //public HomeController(IRepository repo, ProductTotalizer total)
        //{
        //    repository = repo;
        //    totalizer = total;
        //}

        ////public IRepository Repository { get; set; } = TypeBroker.Repository;
        //// GET: /<controller>/
        //public IActionResult Index()
        //{
        //    //return View(Repository.Products);
        //    ViewBag.Total = totalizer.Total;
        //    return View(repository.Products);
        //}


        //直接在Action中使用依赖倒置
        //public ViewResult Index([FromServices]ProductTotalizer totalizer)
        //{
        //    IRepository repository = HttpContext.RequestServices.GetService<IRepository>();
        //}
    }
}
