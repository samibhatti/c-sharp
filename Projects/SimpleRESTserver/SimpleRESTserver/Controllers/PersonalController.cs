using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleRESTserver.Controllers
{
    public class PersonalController : ApiController
    {
        // GET: api/Personal
        public IEnumerable<string> Get()
        {
            return new string[] { "person4", "person3" };
        }

        // GET: api/Personal/5
        public string Get(int id)
        {
            return "some person";
        }

        // POST: api/Personal
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Personal/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Personal/5
        public void Delete(int id)
        {
        }
    }
}
