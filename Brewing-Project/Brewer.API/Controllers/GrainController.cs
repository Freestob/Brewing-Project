using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Brewer.API.Controllers
{
    public class GrainController : ApiController
    {
        // GET: api/Grain
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Grain/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Grain
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Grain/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Grain/5
        public void Delete(int id)
        {
        }
    }
}
