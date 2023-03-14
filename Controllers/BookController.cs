using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using BTVN_B5_2.Models;
using Microsoft.Ajax.Utilities;
using BTVN_B5_2.Controllers;
using BTVN_B5_2.Areas.Admin.Controllers;

namespace BTVN_B5_2.Controllers
{
    public class BookController : Controller
    {
        /*private BookModelContext db = new BookModelContext();*/
       
        // GET: Book
        /*[Authorize(Roles ="Admin")]*/
        public ActionResult Index()
        {
            
            var context = new BookModelContext();
            return View(context.Books.ToList());
        }

        public ActionResult GetBookByCategory(int id)
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

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
          /*  if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }*/

            var context = new BookModelContext();
            var firstBook = context.Books.FirstOrDefault(p => p.Id == id);
            if(firstBook == null)
                return HttpNotFound("Cann't Find Id Book");

            return View(firstBook);
        }
        [Authorize]
        public ActionResult AddToCard(int id)
        {
           
            return Content("Them Thanh Cong");
        }

        // GET: Book/Create
/*        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }*/
    }
}
