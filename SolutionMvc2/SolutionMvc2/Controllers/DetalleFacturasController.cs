﻿using System;
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
    public class DetalleFacturasController : Controller
    {
        private Tienda_DERMOEntities3 db = new Tienda_DERMOEntities3();

        // GET: DetalleFacturas
        public ActionResult Index()
        {
            var detalleFactura = db.DetalleFactura.Include(d => d.Factura).Include(d => d.Producto);
            return View(detalleFactura.ToList());
        }

        // GET: DetalleFacturas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalleFactura detalleFactura = db.DetalleFactura.Find(id);
            if (detalleFactura == null)
            {
                return HttpNotFound();
            }
            return View(detalleFactura);
        }

        // GET: DetalleFacturas/Create
        public ActionResult Create()
        {
            ViewBag.Id_Factura = new SelectList(db.Factura, "Id_Factura", "Id_Factura");
            ViewBag.Id_Producto = new SelectList(db.Producto, "Id_Producto", "Nombre");
            return View();
        }

        // POST: DetalleFacturas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_DetalleFactura,Id_Factura,Id_Producto,Cantidad,Valor_Unitario")] DetalleFactura detalleFactura)
        {
            if (ModelState.IsValid)
            {
                db.DetalleFactura.Add(detalleFactura);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_Factura = new SelectList(db.Factura, "Id_Factura", "Id_Factura", detalleFactura.Id_Factura);
            ViewBag.Id_Producto = new SelectList(db.Producto, "Id_Producto", "Nombre", detalleFactura.Id_Producto);
            return View(detalleFactura);
        }

        // GET: DetalleFacturas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalleFactura detalleFactura = db.DetalleFactura.Find(id);
            if (detalleFactura == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_Factura = new SelectList(db.Factura, "Id_Factura", "Id_Factura", detalleFactura.Id_Factura);
            ViewBag.Id_Producto = new SelectList(db.Producto, "Id_Producto", "Nombre", detalleFactura.Id_Producto);
            return View(detalleFactura);
        }

        // POST: DetalleFacturas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_DetalleFactura,Id_Factura,Id_Producto,Cantidad,Valor_Unitario")] DetalleFactura detalleFactura)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detalleFactura).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_Factura = new SelectList(db.Factura, "Id_Factura", "Id_Factura", detalleFactura.Id_Factura);
            ViewBag.Id_Producto = new SelectList(db.Producto, "Id_Producto", "Nombre", detalleFactura.Id_Producto);
            return View(detalleFactura);
        }

        // GET: DetalleFacturas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalleFactura detalleFactura = db.DetalleFactura.Find(id);
            if (detalleFactura == null)
            {
                return HttpNotFound();
            }
            return View(detalleFactura);
        }

        // POST: DetalleFacturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DetalleFactura detalleFactura = db.DetalleFactura.Find(id);
            db.DetalleFactura.Remove(detalleFactura);
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
