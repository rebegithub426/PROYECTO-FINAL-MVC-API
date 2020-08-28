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
    public class ClienteController : ApiController
    {

        //GET: api/Cliente
        public IQueryable<ent.Cliente> GetAll()
        {
            return new Solution.BS.Cliente().GetAll().AsQueryable();
        }

        //GET: api/Cliente/5
        public ent.Cliente GetOneById(int id)
        {
            return new Solution.BS.Cliente().GetOneById(id);
        }


        // DELETE: api/Cliente/5
        public IHttpActionResult DeleteCliente(int id)
        {
            var t = new Solution.BS.Cliente().GetOneById(id);
            new Solution.BS.Cliente().Delete(t);
            return Ok();

        }

        // PUT: api/Cliente/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCliente(int id, Solution.DO.Objects.Cliente cliente)
        {
            new Solution.BS.Cliente().Updated(cliente);
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Cliente
        [ResponseType(typeof(ent.Cliente))]
        public IHttpActionResult PostCliente(ent.Cliente cliente)
        {
            new Solution.BS.Cliente().Insert(cliente);
            return CreatedAtRoute("DefaultApi", new { id = cliente }, cliente);
        }

    }
}
