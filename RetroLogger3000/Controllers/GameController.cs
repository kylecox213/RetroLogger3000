using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RetroLogger3000.DAL;
using RetroLogger3000.Models;
using PagedList;

namespace RetroLogger3000.Controllers
{
    public class GameController : Controller
    {
        private RetroContext db = new RetroContext();

        // GET: Game

        // add a page parameter, current sort order parameter, and current filter parameter to the method signature
        public ViewResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //viewbag prop to provide the view with the current sort order; included in page links to keep sort order the same while paging
            ViewBag.CurrentSort = sortOrder;

            // ternary statements enabling the view to set the column heading hyperlinks
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Year" ? "year_desc" : "Year";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var games = from g in db.Games
                           select g;
            if (!String.IsNullOrEmpty(searchString))
            {
                games = games.Where(g => g.Title.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "title_desc":
                    games = games.OrderByDescending(g => g.Title);
                    break;
                case "Year":
                    games = games.OrderBy(g => g.Year);
                    break;
                case "year_desc":
                    games = games.OrderByDescending(g => g.Year);
                    break;
                default: // Title ascending
                    games = games.OrderBy(g => g.Title);
                    break;
            }

            int pageSize = 8;
            // ?? null-coalescing operator defines a default values for a nullable type----(page ?? 1) return the value of page or return 1 if null
            int pageNumber = (page ?? 1);
            return View(games.ToPagedList(pageNumber, pageSize));

            //return View(games.ToList());
        }

        // GET: Game/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // GET: Game/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Game/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Year,Rank,Clean,Complete,Beaten,Duplicate")] Game game)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Games.Add(game);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
                catch (DataException /* dex */)
    {
        //Log the error (uncomment dex variable name and add a line here to write a log.
        ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
    }

            return View(game);
        }

        // GET: Game/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // POST: Game/Edit/5
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditPost(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var gameToUpdate = db.Games.Find(id);
            if (TryUpdateModel(gameToUpdate, "",
               new string[] { "ID", "Title", "Year", "Rank", "Clean", "Complete", "Beaten", "Duplicate" }))
            {
                try
                {
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch (DataException /* dex */)
                {
                    //Log the error (uncomment dex variable name and add a line here to write a log.
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                }
            }
            return View(gameToUpdate);
        }

        // GET: Game/Delete/5
        public ActionResult Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
            }
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // POST: Game/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                Game game = db.Games.Find(id);
                db.Games.Remove(game);
                db.SaveChanges();

                //Game gameToDelete = new Game() { ID = id };
                //db.Entry(gameToDelete).State = EntityState.Deleted;
            }
            catch (DataException/* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
