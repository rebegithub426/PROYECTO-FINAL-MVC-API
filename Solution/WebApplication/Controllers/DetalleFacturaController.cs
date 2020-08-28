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
    //public class DetalleFacturaController : ApiController
    //{
    //}

    public class DetalleFacturaController : ApiController
    {

        //GET: api/DetalleFactura
        public IQueryable<ent.DetalleFactura> GetAll()
        {
            return new Solution.BS.DetalleFactura().GetAll().AsQueryable();
        }

        //GET: api/DetalleFactura/5
        public ent.DetalleFactura GetOneById(int id)
        {
            return new Solution.BS.DetalleFactura().GetOneById(id);
        }


        // DELETE: api/DetalleFactura/5
        public IHttpActionResult DeleteCliente(int id)
        {
            var t = new Solution.BS.DetalleFactura().GetOneById(id);
            new Solution.BS.DetalleFactura().Delete(t);
            return Ok();

        }

        // PUT: api/DetalleFactura/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCliente(int id, Solution.DO.Objects.DetalleFactura DetalleFactura)
        {
            new Solution.BS.DetalleFactura().Updated(DetalleFactura);
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/DetalleFactura
        [ResponseType(typeof(ent.DetalleFactura))]
        public IHttpActionResult PostCliente(ent.DetalleFactura DetalleFactura)
        {
            new Solution.BS.DetalleFactura().Insert(DetalleFactura);
            return CreatedAtRoute("DefaultApi", new { id = DetalleFactura }, DetalleFactura);
        }

    }
}
