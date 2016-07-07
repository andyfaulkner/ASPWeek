using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVCMoviesDatabase.Models;

namespace MVCMoviesDatabase.Controllers
{
    public class HomeController : Controller
    {
        private MoviesAndyFEntities db = new MoviesAndyFEntities();

        // GET: Home
        public ActionResult Index()
        {
            //LINQ query to return all movies from the database
            var movies = from m in db.Movies
                         select m;

            return View(movies);
        }

        public ActionResult Details(int? id)
        {
            Movie movie = db.Movies.Find(id);

            return View(movie);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Movie movie = db.Movies.Find(id);

            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Title, ReleaseDate, Genre, Price")] Movie movie) 
        {//using bind to specify fields to be returned protects from overposting attacks

            //get the edited data
            db.Entry(movie).State = EntityState.Modified;
            //save changes to db
            db.SaveChanges();
            //go back to index action
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            Movie movie = db.Movies.Find(id);

            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}