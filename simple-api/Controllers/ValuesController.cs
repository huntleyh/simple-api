using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace simple_api.Controllers
{
    public class ValuesController : ApiController
    {
        //private readonly IConfiguration _config;
        private string api_name;

        //public ValuesController(IConfiguration config)
        public ValuesController()
        {
            //this._config = config;
            this.api_name = System.Configuration.ConfigurationManager.AppSettings["api-name"];
        }
        // GET api/values
        public IEnumerable<string> Get()
        {            
            return new string[] { this.api_name + ": no-value" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return this.api_name + ": called Get with " + id;
        }

        // POST api/values
        public string Post([FromBody] string value)
        {
            return this.api_name + ": called Post";
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
