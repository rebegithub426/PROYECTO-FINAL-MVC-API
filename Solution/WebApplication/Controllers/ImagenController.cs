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
    //public class ImagenController : ApiController
    //{
    //}

    public class ImagenController : ApiController
    {

        //GET: api/Imagen
        public IQueryable<ent.Imagen> GetAll()
        {
            return new Solution.BS.Imagen().GetAll().AsQueryable();
        }

        //GET: api/Imagen/5
        public ent.Imagen GetOneById(int id)
        {
            return new Solution.BS.Imagen().GetOneById(id);
        }


        // DELETE: api/Imagen/5
        public IHttpActionResult DeleteCliente(int id)
        {
            var t = new Solution.BS.Imagen().GetOneById(id);
            new Solution.BS.Imagen().Delete(t);
            return Ok();

        }

        // PUT: api/Imagen/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCliente(int id, Solution.DO.Objects.Imagen Imagen)
        {
            new Solution.BS.Imagen().Updated(Imagen);
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Imagen
        [ResponseType(typeof(ent.Imagen))]
        public IHttpActionResult PostCliente(ent.Imagen Imagen)
        {
            new Solution.BS.Imagen().Insert(Imagen);
            return CreatedAtRoute("DefaultApi", new { id = Imagen }, Imagen);
        }

    }
}
