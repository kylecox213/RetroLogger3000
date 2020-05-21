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

namespace RetroLogger3000.Controllers
{
    public class GameController : Controller
    {
        private RetroContext db = new RetroContext();

        // GET: Game
        public ActionResult Index(string sortOrder)
        {
            // ternary statements enabling the view to set the column heading hyperlinks
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Year" ? "year_desc" : "Year";
            var games = from g in db.Games
                           select g;
            switch (sortOrder)
            {
                case "title_desc":
                    games = games.OrderByDescending(g => g.Title);
                    break;
                case "Date":
                    games = games.OrderBy(g => g.Year);
                    break;
                case "year_desc":
                    games = games.OrderByDescending(g => g.Year);
                    break;
                default:
                    games = games.OrderBy(g => g.Title);
                    break;
            }
            return View(games.ToList());
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
