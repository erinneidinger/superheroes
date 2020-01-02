using Superheroes_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superheroes_Project.Controllers
{
    public class SuperheroesController : Controller
    {
        ApplicationDbContext context;

        public SuperheroesController()
        {
            context = new ApplicationDbContext();
        }

        // GET: Superheroes
        public ActionResult Index()
        {
            List<Hero> allSuperheroes = context.Superheroes.ToList();
            return View(allSuperheroes);
        }

        // GET: Superheroes/Details/5
        public ActionResult Details(int id)
        {
            Hero heroDetails = context.Superheroes.Where(a => a.HeroId == id).FirstOrDefault();
            return View(heroDetails);
        }

        // GET: Superheroes/Create
        public ActionResult Create()
        {
            Hero hero = new Hero();
            return View(hero);
        }

        // POST: Superheroes/Create
        [HttpPost]
        public ActionResult Create(Hero hero)
        {
            try
            {
                // TODO: Add insert logic here
                context.Superheroes.Add(hero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Edit/5
        public ActionResult Edit(int id)
        {
            Hero foundHero = context.Superheroes.Where(a => a.HeroId == id).FirstOrDefault();
            return View(foundHero);
        }

        // POST: Superheroes/Edit/5
        [HttpPost]
        public ActionResult Edit(Hero hero)
        {
            try
            {
                // TODO: Add update logic here
                Hero editedHero = context.Superheroes.Where(a => a.HeroId == hero.HeroId).FirstOrDefault();
                editedHero.SuperheroName = hero.SuperheroName;
                editedHero.AlterEgo = hero.AlterEgo;
                editedHero.PrimaryAbility = hero.PrimaryAbility;
                editedHero.SecondaryAbility = hero.SecondaryAbility;
                editedHero.CatchPhrase = hero.CatchPhrase;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Delete/5
        public ActionResult Delete(int id)
        {
            Hero foundHero = context.Superheroes.Find(id);
            return View(foundHero);
        }

        // POST: Superheroes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Hero hero)
        {
            try
            {
                // TODO: Add delete logic here
                Hero foundHero = context.Superheroes.Find(id);
                context.Superheroes.Remove(foundHero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
