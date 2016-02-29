using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Oefening1Week2.Models;

namespace Oefening1Week2.Controllers
{
    public class StoreController : Controller
    {

        private List<Genre> genres = new List<Genre>
        {
            new Genre
            {
                ID = 1,
                Name = "Metaal"
            },

            new Genre
            {
                ID = 2,
                Name = "Steen"
            },

            new Genre
            {
                ID = 3,
                Name = "Jazz"
            }
        };

        private List<Album> albums = new List<Album>
        {
            new Album
            {
                ID = 1,
                Artist = "Disturbed",
                Title = "Waking up the demon",
                Genreke = "Metaal"
            },

            new Album
            {
                ID = 2,
                Artist = "Disturbing",
                Title = "Waking up the demons",
                Genreke = "Metaal"
            },

            new Album
            {
                ID = 3,
                Artist = "Disturbed",
                Title = "Waking up the demon",
                Genreke = "Jazz"
            }
        };
        
        public ActionResult Browse(string name) {

            var returns = from r in albums
                          orderby r.Title
                          where r.Genreke.Equals(name)
                          select r;
            return View(returns);
        }

        // GET: Store
        public ActionResult Index()
        {
            var result = from r in genres
                         orderby r.Name
                         select r;
            return View(result);
        }

        // GET: Store/Details/5
        public ActionResult Details(int id)
        {
            var model = albums.Single(x => x.ID == id);
            return View(model);
        }

        // GET: Store/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Store/Create
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

        // GET: Store/Edit/5
        public ActionResult Edit(int id)
        {
            var model = albums.Single(x => x.ID == id);
            return View(model);
        }

        // POST: Store/Edit/5
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

        // GET: Store/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Store/Delete/5
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
        }
    }
}
