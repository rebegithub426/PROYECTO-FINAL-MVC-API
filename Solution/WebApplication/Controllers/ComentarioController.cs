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
    //public class ComentarioController : ApiController
    //{
    //}

    public class ComentarioController : ApiController
    {

        //GET: api/Comentario
        public IQueryable<ent.Comentario> GetAll()
        {
            return new Solution.BS.Comentario().GetAll().AsQueryable();
        }

        //GET: api/Comentario/5
        public ent.Comentario GetOneById(int id)
        {
            return new Solution.BS.Comentario().GetOneById(id);
        }


        // DELETE: api/Comentario/5
        public IHttpActionResult DeleteCliente(int id)
        {
            var t = new Solution.BS.Comentario().GetOneById(id);
            new Solution.BS.Comentario().Delete(t);
            return Ok();

        }

        // PUT: api/Comentario/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCliente(int id, Solution.DO.Objects.Comentario Comentario)
        {
            new Solution.BS.Comentario().Updated(Comentario);
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Comentario
        [ResponseType(typeof(ent.Comentario))]
        public IHttpActionResult PostCliente(ent.Comentario Comentario)
        {
            new Solution.BS.Comentario().Insert(Comentario);
            return CreatedAtRoute("DefaultApi", new { id = Comentario }, Comentario);
        }

    }
}
