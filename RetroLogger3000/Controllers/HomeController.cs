using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RetroLogger3000.DAL;
using RetroLogger3000.Models;
using RetroLogger3000.ViewModels;

namespace RetroLogger3000.Controllers
{
	public class HomeController : Controller
	{
		private RetroContext db = new RetroContext();
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			IQueryable<GamesTotal> data = from game in db.Games
					   group game by game.Title into titleGroup
					   select new GamesTotal()
					   {
							Title = titleGroup.Key,
							GameCount = titleGroup.Count()
					   };
			return View(data.ToList());
		}

		protected override void Dispose(bool disposing)
		{
			db.Dispose();
			base.Dispose(disposing);
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}