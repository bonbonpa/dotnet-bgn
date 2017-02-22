using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspApi.Controllers
{
    public class TestApiController : ApiController
    {
        public string Get()
        {
            return "Welcome To Web Api";
        }
        public List<string>Get(int Id)
        {
            return new List<string>
            {
                "Data1",
                "Data2"
            };
        }
    }
}
