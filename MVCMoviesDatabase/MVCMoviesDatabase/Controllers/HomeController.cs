using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVCMoviesDatabase.Models;
using System.Net;

namespace MVCMoviesDatabase.Controllers
{
    public class HomeController : Controller
    {
        private MoviesAndyFEntities db = new MoviesAndyFEntities();

        // GET: Home
        public ActionResult Index(string movieGenre, string searchString)
        { 
            //LINQ query to return all movies from the database
            var movies = from m in db.Movies
                         select m;

            //genre search
            var GenreList = new List<string>();
            //LINQ query to retrieve genre names from db to populate the genre dropdown list
            var GenreQuery = from g in db.Movies
                             orderby g.Genre
                             select g.Genre;
            //adding genre to the genre list without duplicates
            GenreList.AddRange(GenreQuery.Distinct());

            ViewBag.movieGenre = new SelectList(GenreList);

            if(!String.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(x => x.Genre == movieGenre);
            }

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(x => x.Title.Contains(searchString.ToLower()));
            }
            return View(movies);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);

            if(movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);

            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Title, ReleaseDate, Genre, Price")] Movie movie) 
        {//using bind to specify fields to be returned protects from overposting attacks
            if (ModelState.IsValid)
            {

                //get the edited data
                db.Entry(movie).State = EntityState.Modified;
                //save changes to db
                db.SaveChanges();

                //go back to index action
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);

            if (movie == null)
            {
                return HttpNotFound();
            }

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

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Title, ReleaseDate, Genre, Price")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Added;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }
    }
}