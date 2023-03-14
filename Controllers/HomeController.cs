using BTVN_B5_2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;


namespace BTVN_B5_2.Controllers
{
    public class HomeController : Controller
    {

        /*  public ActionResult Index()
          {
              return View();
          }

          public ActionResult About()
          {
              ViewBag.Message = "Your application description page.";

              return View();
          }

          public ActionResult Contact()
          {
              ViewBag.Message = "Your contact page.";

              return View();
          }
  */
      /*  public static List<Book> ListBook = new List<Book>();
        private readonly BookModelContext db = new BookModelContext();*/
        public ActionResult Index1()
        {
            var context = new BookModelContext();
            return View(context.Books.ToList());
        }

        /*public ActionResult GetBookByCategory(int id)
        {
            var context = new BookModelContext();
            return View("Index", context.Books.Where(p => p.CategoryId == id).ToList());
        }

        public ActionResult GetCategory(int id)
        {
            var context = new BookModelContext();
            var listCategory = context.Categories.ToList();
            return PartialView(listCategory);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var context = new BookModelContext();
            ViewBag.ListCategory = context.Categories.ToList();
            return View();
        }

        [HttpPost]

        public ActionResult Create(Book newBook)
        {
            var context = new BookModelContext();
            if (ModelState.IsValid)
            {
                context.Books.Add(newBook);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return
                       RedirectToAction("Create");
        }


        public ActionResult Detail(int id)
        {
            var context = new BookModelContext();
            var firstBook = context.Books.FirstOrDefault(x => x.Id == id);
            if (firstBook == null)
                return HttpNotFound("Couldn't Find Book");
            return View(firstBook);
        }
*/


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}