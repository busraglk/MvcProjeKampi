using Business.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        CategoryManager categoryManager = new CategoryManager();
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult GetCategoryList()
        {
           //var categoryvalues = categoryManager.GetAllBL();
            return View();
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            //categoryManager.CategoryAddBL(category);
            return RedirectToAction("GetCategoryList");
            //ekleme işlemini gerçekleştirdikten sonra beni 
            // GetCategoryList methoduna yönlendir.
        }

    }
}