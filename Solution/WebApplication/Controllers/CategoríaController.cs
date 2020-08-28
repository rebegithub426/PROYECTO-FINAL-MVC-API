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
    //public class CategoríaController : ApiController
    //{
    //}

    public class CategoríaController : ApiController
    {

        //GET: api/Categoría
        public IQueryable<ent.Categoría> GetAll()
        {
            return new Solution.BS.Categoría().GetAll().AsQueryable();
        }

        //GET: api/Categoría/5
        public ent.Categoría GetOneById(int id)
        {
            return new Solution.BS.Categoría().GetOneById(id);
        }


        // DELETE: api/Categoría/5
        public IHttpActionResult DeleteCliente(int id)
        {
            var t = new Solution.BS.Categoría().GetOneById(id);
            new Solution.BS.Categoría().Delete(t);
            return Ok();

        }

        // PUT: api/Categoría/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCliente(int id, Solution.DO.Objects.Categoría Categoría)
        {
            new Solution.BS.Categoría().Updated(Categoría);
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Categoría
        [ResponseType(typeof(ent.Categoría))]
        public IHttpActionResult PostCliente(ent.Categoría Categoría)
        {
            new Solution.BS.Categoría().Insert(Categoría);
            return CreatedAtRoute("DefaultApi", new { id = Categoría }, Categoría);
        }

    }
}
