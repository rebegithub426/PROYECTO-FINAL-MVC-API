using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SolutionMvc2.Models;

namespace SolutionMvc2.Controllers
{

    public class CategoríaController : Controller
    {
        private Tienda_DERMOEntities3 db = new Tienda_DERMOEntities3();

        [Authorize(Roles = "Administrador")]
        // GET: Categoría
        public ActionResult Index()
        {
            return View(db.Categoría.ToList());
        }

        // GET: Categoría/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoría categoría = db.Categoría.Find(id);
            if (categoría == null)
            {
                return HttpNotFound();
            }
            return View(categoría);
        }

        // GET: Categoría/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoría/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_Categoría,Nombre")] Categoría categoría)
        {
            if (ModelState.IsValid)
            {
                db.Categoría.Add(categoría);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoría);
        }

        // GET: Categoría/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoría categoría = db.Categoría.Find(id);
            if (categoría == null)
            {
                return HttpNotFound();
            }
            return View(categoría);
        }

        // POST: Categoría/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_Categoría,Nombre")] Categoría categoría)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoría).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoría);
        }

        // GET: Categoría/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoría categoría = db.Categoría.Find(id);
            if (categoría == null)
            {
                return HttpNotFound();
            }
            return View(categoría);
        }

        // POST: Categoría/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Categoría categoría = db.Categoría.Find(id);
            db.Categoría.Remove(categoría);
            db.SaveChanges();
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
