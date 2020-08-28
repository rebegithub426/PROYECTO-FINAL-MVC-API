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
    public class FacturaciónController : Controller
    {
        private Tienda_DERMOEntities3 db = new Tienda_DERMOEntities3();

        // GET: Facturación
        public ActionResult Index()
        {
            var facturación = db.Facturación.Include(f => f.Factura);
            return View(facturación.ToList());
        }

        // GET: Facturación/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facturación facturación = db.Facturación.Find(id);
            if (facturación == null)
            {
                return HttpNotFound();
            }
            return View(facturación);
        }

        // GET: Facturación/Create
        public ActionResult Create()
        {
            ViewBag.Id_Factura = new SelectList(db.Factura, "Id_Factura", "Id_Factura");
            return View();
        }

        // POST: Facturación/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_Facturación,Id_Factura,Identificación,Nombre,Apellidos,Teléfono,Dirección")] Facturación facturación)
        {
            if (ModelState.IsValid)
            {
                db.Facturación.Add(facturación);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_Factura = new SelectList(db.Factura, "Id_Factura", "Id_Factura", facturación.Id_Factura);
            return View(facturación);
        }

        // GET: Facturación/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facturación facturación = db.Facturación.Find(id);
            if (facturación == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_Factura = new SelectList(db.Factura, "Id_Factura", "Id_Factura", facturación.Id_Factura);
            return View(facturación);
        }

        // POST: Facturación/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_Facturación,Id_Factura,Identificación,Nombre,Apellidos,Teléfono,Dirección")] Facturación facturación)
        {
            if (ModelState.IsValid)
            {
                db.Entry(facturación).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_Factura = new SelectList(db.Factura, "Id_Factura", "Id_Factura", facturación.Id_Factura);
            return View(facturación);
        }

        // GET: Facturación/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facturación facturación = db.Facturación.Find(id);
            if (facturación == null)
            {
                return HttpNotFound();
            }
            return View(facturación);
        }

        // POST: Facturación/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Facturación facturación = db.Facturación.Find(id);
            db.Facturación.Remove(facturación);
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
