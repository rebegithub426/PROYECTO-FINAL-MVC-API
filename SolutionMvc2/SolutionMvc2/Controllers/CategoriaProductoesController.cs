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
    public class CategoriaProductoesController : Controller
    {
        private Tienda_DERMOEntities3 db = new Tienda_DERMOEntities3();

        // GET: CategoriaProductoes
        public ActionResult Index()
        {
            var categoriaProducto = db.CategoriaProducto.Include(c => c.Categoría).Include(c => c.Producto);
            return View(categoriaProducto.ToList());
        }

        // GET: CategoriaProductoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaProducto categoriaProducto = db.CategoriaProducto.Find(id);
            if (categoriaProducto == null)
            {
                return HttpNotFound();
            }
            return View(categoriaProducto);
        }

        // GET: CategoriaProductoes/Create
        public ActionResult Create()
        {
            ViewBag.Id_Categoria = new SelectList(db.Categoría, "Id_Categoría", "Nombre");
            ViewBag.Id_Producto = new SelectList(db.Producto, "Id_Producto", "Nombre");
            return View();
        }

        // POST: CategoriaProductoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_CategoriaProducto,Id_Producto,Id_Categoria")] CategoriaProducto categoriaProducto)
        {
            if (ModelState.IsValid)
            {
                db.CategoriaProducto.Add(categoriaProducto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_Categoria = new SelectList(db.Categoría, "Id_Categoría", "Nombre", categoriaProducto.Id_Categoria);
            ViewBag.Id_Producto = new SelectList(db.Producto, "Id_Producto", "Nombre", categoriaProducto.Id_Producto);
            return View(categoriaProducto);
        }

        // GET: CategoriaProductoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaProducto categoriaProducto = db.CategoriaProducto.Find(id);
            if (categoriaProducto == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_Categoria = new SelectList(db.Categoría, "Id_Categoría", "Nombre", categoriaProducto.Id_Categoria);
            ViewBag.Id_Producto = new SelectList(db.Producto, "Id_Producto", "Nombre", categoriaProducto.Id_Producto);
            return View(categoriaProducto);
        }

        // POST: CategoriaProductoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_CategoriaProducto,Id_Producto,Id_Categoria")] CategoriaProducto categoriaProducto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoriaProducto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_Categoria = new SelectList(db.Categoría, "Id_Categoría", "Nombre", categoriaProducto.Id_Categoria);
            ViewBag.Id_Producto = new SelectList(db.Producto, "Id_Producto", "Nombre", categoriaProducto.Id_Producto);
            return View(categoriaProducto);
        }

        // GET: CategoriaProductoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaProducto categoriaProducto = db.CategoriaProducto.Find(id);
            if (categoriaProducto == null)
            {
                return HttpNotFound();
            }
            return View(categoriaProducto);
        }

        // POST: CategoriaProductoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CategoriaProducto categoriaProducto = db.CategoriaProducto.Find(id);
            db.CategoriaProducto.Remove(categoriaProducto);
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
