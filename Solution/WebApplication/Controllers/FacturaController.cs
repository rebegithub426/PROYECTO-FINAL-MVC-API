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
    //public class FacturaController : ApiController
    //{
    //}

    public class FacturaController : ApiController
    {

        //GET: api/Factura
        public IQueryable<ent.Factura> GetAll()
        {
            return new Solution.BS.Factura().GetAll().AsQueryable();
        }

        //GET: api/Factura/5
        public ent.Factura GetOneById(int id)
        {
            return new Solution.BS.Factura().GetOneById(id);
        }


        // DELETE: api/Factura/5
        public IHttpActionResult DeleteCliente(int id)
        {
            var t = new Solution.BS.Factura().GetOneById(id);
            new Solution.BS.Factura().Delete(t);
            return Ok();

        }

        // PUT: api/Factura/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCliente(int id, Solution.DO.Objects.Factura Factura)
        {
            new Solution.BS.Factura().Updated(Factura);
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Factura
        [ResponseType(typeof(ent.Factura))]
        public IHttpActionResult PostCliente(ent.Factura Factura)
        {
            new Solution.BS.Factura().Insert(Factura);
            return CreatedAtRoute("DefaultApi", new { id = Factura }, Factura);
        }

    }
}
