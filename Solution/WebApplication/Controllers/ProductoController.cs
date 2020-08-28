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
    //public class ProductoController : ApiController
    //{
    //}

    public class ProductoController : ApiController
    {

        //GET: api/Producto
        public IQueryable<ent.Producto> GetAll()
        {
            return new Solution.BS.Producto().GetAll().AsQueryable();
        }

        //GET: api/Producto/5
        public ent.Producto GetOneById(int id)
        {
            return new Solution.BS.Producto().GetOneById(id);
        }


        // DELETE: api/Producto/5
        public IHttpActionResult DeleteCliente(int id)
        {
            var t = new Solution.BS.Producto().GetOneById(id);
            new Solution.BS.Producto().Delete(t);
            return Ok();

        }

        // PUT: api/Producto/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCliente(int id, Solution.DO.Objects.Producto Producto)
        {
            new Solution.BS.Producto().Updated(Producto);
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Producto
        [ResponseType(typeof(ent.Producto))]
        public IHttpActionResult PostCliente(ent.Producto Producto)
        {
            new Solution.BS.Producto().Insert(Producto);
            return CreatedAtRoute("DefaultApi", new { id = Producto }, Producto);
        }

    }
}
