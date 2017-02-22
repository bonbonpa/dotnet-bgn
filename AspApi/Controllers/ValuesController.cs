using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspApi.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        static List<string> language = new List<string>() {
            "C#","ASP.NET","MVC"
        };
        // GET api/values
        public IEnumerable<string> Get()
        {
            return language;
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return language[id];
            //return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            language.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            language[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            language.RemoveAt(id);
        }
    }
}
