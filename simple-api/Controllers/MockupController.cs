using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace simple_api.Controllers
{
    public class MockupController : ApiController
    {
        private string api_name;
        public MockupController()
        {
            this.api_name = System.Configuration.ConfigurationManager.AppSettings["api-name"];
        }

        public IEnumerable<string> Get()
        {            
            return new string[] { this.api_name + ": no-value" };
        }

        // GET: Mockup/Details/5
        public string[] Details(int id)
        {
            return new string[] { this.api_name + ": " + id };
        }

        // GET api/Mockup/5
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
