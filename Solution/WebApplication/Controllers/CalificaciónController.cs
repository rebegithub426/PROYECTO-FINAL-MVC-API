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
    //public class CalificaciónController : ApiController
    //{
    //}

    public class CalificaciónController : ApiController
    {

        //GET: api/Calificación
        public IQueryable<ent.Calificación> GetAll()
        {
            return new Solution.BS.Calificación().GetAll().AsQueryable();
        }

        //GET: api/Calificación/5
        public ent.Calificación GetOneById(int id)
        {
            return new Solution.BS.Calificación().GetOneById(id);
        }


        // DELETE: api/Calificación/5
        public IHttpActionResult DeleteCliente(int id)
        {
            var t = new Solution.BS.Calificación().GetOneById(id);
            new Solution.BS.Calificación().Delete(t);
            return Ok();

        }

        // PUT: api/Calificación/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCliente(int id, Solution.DO.Objects.Calificación Calificación)
        {
            new Solution.BS.Calificación().Updated(Calificación);
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Calificación
        [ResponseType(typeof(ent.Calificación))]
        public IHttpActionResult PostCliente(ent.Calificación Calificación)
        {
            new Solution.BS.Calificación().Insert(Calificación);
            return CreatedAtRoute("DefaultApi", new { id = Calificación }, Calificación);
        }

    }
}
