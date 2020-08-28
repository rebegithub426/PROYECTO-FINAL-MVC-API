using SolutionMvc2.Data;
using SolutionMvc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolutionMvc2.Repositories
{
    public class RepositoryProducto
    {
        ContextoProducto contexto;

        public RepositoryProducto()
        {
            this.contexto = new ContextoProducto();
        }
        //metodo para obtener la lista de los productos
        public List<Producto1> GetProductos()
        {
            var consulta = from Producto1 in contexto.Producto select Producto1;
            return consulta.ToList();
        }
        //metodo para buscar los productos con esos id
        public List<Producto1> BuscarProductos(List<int> id)
        {
            var consulta = from Producto in contexto.Producto where id.Contains(Producto.Id_Producto) select Producto;
            return consulta.ToList();
        }
    }
}