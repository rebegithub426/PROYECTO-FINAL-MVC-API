using SolutionMvc2.Models;
using SolutionMvc2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolutionMvc2.Controllers
{
    public class ProductoController : Controller
    {
        RepositoryProducto repo;
        private Tienda_DERMOEntities3 db = new Tienda_DERMOEntities3();

        public ProductoController()
        {
            repo = new RepositoryProducto();
        }

        // GET: Producto
        public ActionResult ListaProductos(int? id)
        {
            if (id != null)
            {

                List<int> codigosProductos;

                if (Session["PRODUCTOS"] == null)
                {
                    codigosProductos = new List<int>();
                }
                else
                {
                    codigosProductos = Session["PRODUCTOS"] as List<int>;
                }
                codigosProductos.Add(id.Value);
                Session["PRODUCTOS"] = codigosProductos;
                ViewBag.Mensaje = "Productos en el carrito: " + codigosProductos.Count();
            }
            ViewBag.Carrito = Session["PRODUCTOS"];
            var prod = db.Producto.ToList();
            List<Producto1> ListaProductos = new List<Producto1>();
            foreach (var item in prod)
            {
                Producto1 ObjProducto1 = new Producto1();
                ObjProducto1.Id_Producto = item.Id_Producto;
                ObjProducto1.Nombre = item.Nombre;
                ObjProducto1.Referencia = item.Referencia;
                ObjProducto1.Precio = item.Precio;
                ObjProducto1.Stock = item.Stock;
                ListaProductos.Add(ObjProducto1);
            }

            return View(ListaProductos);
        }
        //Obtenemos por GET el id para borrar productos
        public ActionResult ProductosCarrito(int? id)
        {
            if (id != null)
            {
                List<int> lista = (List<int>)Session["PRODUCTOS"];
                lista.Remove(id.GetValueOrDefault());
                if (lista.Count() == 0)
                {
                    Session["PRODUCTOS"] = null;
                }
                else
                {
                    Session["PRODUCTOS"] = lista;
                }
            }
            if (Session["PRODUCTOS"] == null)
            {
                return View();
            }
            else
            {
                List<int> lista = (List<int>)Session["PRODUCTOS"];
                var consulta = from Producto in db.Producto where lista.Contains(Producto.Id_Producto) select Producto;
                List<Producto1> ListaProductos = new List<Producto1>();
                foreach (var item in consulta)
                {
                    Producto1 ObjProducto1 = new Producto1();
                    ObjProducto1.Id_Producto = item.Id_Producto;
                    ObjProducto1.Nombre = item.Nombre;
                    ObjProducto1.Referencia = item.Referencia;
                    ObjProducto1.Precio = item.Precio;
                    ObjProducto1.Stock = item.Stock;
                    ListaProductos.Add(ObjProducto1);
                }
                decimal subtotal = 0;
                foreach (var item in ListaProductos)
                {
                    subtotal = item.Precio + subtotal;
                }
                decimal Iva = subtotal * 0.13m;
                decimal neto = subtotal * 1.13m;
                ViewBag.SubTotal = subtotal.ToString();
                ViewBag.IVA = Iva.ToString();
                ViewBag.Total = neto.ToString();

                return View(ListaProductos);
            }
        }

        public ActionResult FacturaProductos(int? id)
        {
            if (id != null)
            {
                List<int> facturaProductos;

                if (Session["PRODUCTOS"] == null)
                {
                    facturaProductos = new List<int>();
                }
                else
                {
                    facturaProductos = Session["PRODUCTOS"] as List<int>;
                }
                facturaProductos.Add(id.Value);
                Session["PRODUCTOS"] = facturaProductos;
                ViewBag.Mensaje = "Productos en el carrito: " + facturaProductos.Count();
            }
            ViewBag.Carrito = Session["PRODUCTOS"];
            var prod = db.Producto.ToList();
            //var fact = db.Facturación.ToList();
            List<int> lista = (List<int>)Session["PRODUCTOS"];
            var consulta = from Producto in db.Producto where lista.Contains(Producto.Id_Producto) select Producto;
            //var consulta2 = from Facturación in db.Facturación where lista.Contains(Facturación.Id_Factura) select Facturación;
            List<Producto1> ListaProductos = new List<Producto1>();
            //List<Facturación> ListaFacturacion = new List<Facturación>();
            foreach (var item in consulta)
            {
                
                Producto1 ObjProducto1 = new Producto1();
                ObjProducto1.Id_Producto = item.Id_Producto;
                ObjProducto1.Nombre = item.Nombre;
                ObjProducto1.Precio = item.Precio;
                ListaProductos.Add(ObjProducto1);
            }
            decimal subtotal = 0;
            foreach (var item in ListaProductos)
            {
                subtotal = item.Precio + subtotal;
            }
            decimal Iva = subtotal * 0.13m;
            decimal neto = subtotal * 1.13m;
            ViewBag.SubTotal = subtotal.ToString();
            ViewBag.IVA = Iva.ToString();
            ViewBag.Total = neto.ToString();
           //foreach (var item in consulta2)
           // {
           //     Facturación ObjFactura = new Facturación();
           //     ObjFactura.Id_Factura = item.Id_Factura;
           //     ObjFactura.Nombre = item.Nombre;
           //     ObjFactura.Apellidos = item.Apellidos;
           // }

            return View(ListaProductos);
        }
    }

}

    
    
