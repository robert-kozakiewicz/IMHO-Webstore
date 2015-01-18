using ImhoWebstore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImhoWebstore.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        private readonly ProductRepository _productRepository = new ProductRepository();

        public ActionResult Details(int productId)
        {
            return View(_productRepository.GetProducts().Where(x => x.Id == productId).First());
        }

        public ActionResult List(string category)
        {
            ViewBag.Category = category;
            return View(_productRepository.GetProducts().Where(x => x.Category == category));
        }
    }
}
