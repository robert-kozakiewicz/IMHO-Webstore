using ImhoWebstore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImhoWebstore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductRepository _productRepository = new ProductRepository();

        public ActionResult Index()
        {
            return View(_productRepository.GetProducts().Take(5));
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Categories()
        {
            return PartialView("_CategoriesPartial", _productRepository.GetProducts().Select(x => x.Category).Distinct());
        }
    }
}
