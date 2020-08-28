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
    public class CalificaciónController : Controller
    {
        private Tienda_DERMOEntities3 db = new Tienda_DERMOEntities3();

        // GET: Calificación
        public ActionResult Index()
        {
            var calificación = db.Calificación.Include(c => c.Cliente).Include(c => c.Producto);
            return View(calificación.ToList());
        }

        // GET: Calificación/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calificación calificación = db.Calificación.Find(id);
            if (calificación == null)
            {
                return HttpNotFound();
            }
            return View(calificación);
        }

        // GET: Calificación/Create
        public ActionResult Create()
        {
            ViewBag.Id_Cliente = new SelectList(db.Cliente, "Id_Cliente", "Cédula");
            ViewBag.Id_Producto = new SelectList(db.Producto, "Id_Producto", "Nombre");
            return View();
        }

        // POST: Calificación/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_Calificación,Id_Cliente,Id_Producto,Valoración")] Calificación calificación)
        {
            if (ModelState.IsValid)
            {
                db.Calificación.Add(calificación);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_Cliente = new SelectList(db.Cliente, "Id_Cliente", "Cédula", calificación.Id_Cliente);
            ViewBag.Id_Producto = new SelectList(db.Producto, "Id_Producto", "Nombre", calificación.Id_Producto);
            return View(calificación);
        }

        // GET: Calificación/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calificación calificación = db.Calificación.Find(id);
            if (calificación == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_Cliente = new SelectList(db.Cliente, "Id_Cliente", "Cédula", calificación.Id_Cliente);
            ViewBag.Id_Producto = new SelectList(db.Producto, "Id_Producto", "Nombre", calificación.Id_Producto);
            return View(calificación);
        }

        // POST: Calificación/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_Calificación,Id_Cliente,Id_Producto,Valoración")] Calificación calificación)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calificación).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_Cliente = new SelectList(db.Cliente, "Id_Cliente", "Cédula", calificación.Id_Cliente);
            ViewBag.Id_Producto = new SelectList(db.Producto, "Id_Producto", "Nombre", calificación.Id_Producto);
            return View(calificación);
        }

        // GET: Calificación/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calificación calificación = db.Calificación.Find(id);
            if (calificación == null)
            {
                return HttpNotFound();
            }
            return View(calificación);
        }

        // POST: Calificación/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Calificación calificación = db.Calificación.Find(id);
            db.Calificación.Remove(calificación);
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
