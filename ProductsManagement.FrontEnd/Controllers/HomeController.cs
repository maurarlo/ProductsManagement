using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductsManagement.Business;
using ProductsManagement.Business.Data;
using ProductsManagement.Entities;

namespace ProductsManagement.FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.GetAllProducts();
        }

        public ActionResult SetDataStorage(string dataStorage)
        {
            this.Session["selectedValue"] = dataStorage;

            return RedirectToAction("Index", "Home");
        }
        
        [HttpGet]
        public ActionResult GetProducts()
        {
            return this.GetAllProducts();
        }

        public ActionResult AddProduct()
        {
            return PartialView("_AddProduct");
        }

        public ActionResult SaveProduct(Models.ProductViewModel product)
        {
            new ProductLogic(ProductDataFactory.Get(Convert.ToString(this.Session["selectedValue"]))).Create(new Product
            {
                Number = product.Number,
                Price = product.Price,
                Title = product.Title,
            });

            return RedirectToAction("Index", "Home");
        }

        private ActionResult GetAllProducts()
        {
            var products = new ProductLogic(ProductDataFactory.Get(Convert.ToString(this.Session["selectedValue"]))).Get();

            return View(products);
        }
    }
}