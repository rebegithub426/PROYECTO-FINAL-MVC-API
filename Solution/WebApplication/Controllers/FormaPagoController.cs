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
    //public class FormaPagoController : ApiController
    //{
    //}

    public class FormaPagoController : ApiController
    {

        //GET: api/FormaPago
        public IQueryable<ent.FormaPago> GetAll()
        {
            return new Solution.BS.FormaPago().GetAll().AsQueryable();
        }

        //GET: api/FormaPago/5
        public ent.FormaPago GetOneById(int id)
        {
            return new Solution.BS.FormaPago().GetOneById(id);
        }


        // DELETE: api/FormaPago/5
        public IHttpActionResult DeleteCliente(int id)
        {
            var t = new Solution.BS.FormaPago().GetOneById(id);
            new Solution.BS.FormaPago().Delete(t);
            return Ok();

        }

        // PUT: api/FormaPago/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCliente(int id, Solution.DO.Objects.FormaPago FormaPago)
        {
            new Solution.BS.FormaPago().Updated(FormaPago);
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/FormaPago
        [ResponseType(typeof(ent.FormaPago))]
        public IHttpActionResult PostCliente(ent.FormaPago FormaPago)
        {
            new Solution.BS.FormaPago().Insert(FormaPago);
            return CreatedAtRoute("DefaultApi", new { id = FormaPago }, FormaPago);
        }

    }
}
