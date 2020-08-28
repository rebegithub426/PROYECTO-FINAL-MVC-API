using Solution.BS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ent = Solution.DO.Objects;
using Solution.DO.Objects;


namespace WebApplication.Controllers
{
    //public class CategoriaProductoController : ApiController
    //{
    //}

    public class CategoriaProductoController : ApiController
    {

        //GET: api/CategoriaProducto
        public IQueryable<ent.CategoriaProducto> GetAll()
        {
            return new Solution.BS.CategoriaProducto().GetAll().AsQueryable();
        }

        //GET: api/CategoriaProducto/5
        public ent.CategoriaProducto GetOneById(int id)
        {
            return new Solution.BS.CategoriaProducto().GetOneById(id);
        }


        // DELETE: api/CategoriaProducto/5
        public IHttpActionResult DeleteCliente(int id)
        {
            var t = new Solution.BS.CategoriaProducto().GetOneById(id);
            new Solution.BS.CategoriaProducto().Delete(t);
            return Ok();

        }

        // PUT: api/CategoriaProducto/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCliente(int id, Solution.DO.Objects.CategoriaProducto CategoriaProducto)
        {
            new Solution.BS.CategoriaProducto().Updated(CategoriaProducto);
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/CategoriaProducto
        [ResponseType(typeof(ent.CategoriaProducto))]
        public IHttpActionResult PostCliente(ent.CategoriaProducto CategoriaProducto)
        {
            new Solution.BS.CategoriaProducto().Insert(CategoriaProducto);
            return CreatedAtRoute("DefaultApi", new { id = CategoriaProducto }, CategoriaProducto);
        }

    }
}
