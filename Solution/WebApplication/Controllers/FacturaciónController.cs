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
    //public class FacturaciónController : ApiController
    //{
    //}

    public class FacturaciónController : ApiController
    {

        //GET: api/Facturación
        public IQueryable<ent.Facturación> GetAll()
        {
            return new Solution.BS.Facturación().GetAll().AsQueryable();
        }

        //GET: api/Facturación/5
        public ent.Facturación GetOneById(int id)
        {
            return new Solution.BS.Facturación().GetOneById(id);
        }


        // DELETE: api/Facturación/5
        public IHttpActionResult DeleteCliente(int id)
        {
            var t = new Solution.BS.Facturación().GetOneById(id);
            new Solution.BS.Facturación().Delete(t);
            return Ok();

        }

        // PUT: api/Facturación/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCliente(int id, Solution.DO.Objects.Facturación Facturación)
        {
            new Solution.BS.Facturación().Updated(Facturación);
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Facturación
        [ResponseType(typeof(ent.Facturación))]
        public IHttpActionResult PostCliente(ent.Facturación Facturación)
        {
            new Solution.BS.Facturación().Insert(Facturación);
            return CreatedAtRoute("DefaultApi", new { id = Facturación }, Facturación);
        }

    }
}
