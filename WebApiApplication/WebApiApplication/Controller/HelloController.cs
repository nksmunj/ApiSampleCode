using AppleDiagnostics.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace WebApiApplication.Controller
{
    public class HelloController : ApiController
    {
        //public HttpResponseMessage Get()
        //{
        //    return Request.CreateResponse(HttpStatusCode.OK, APIResponse.Success("Success Return"));
        //}

        // GET: api/student
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/student/5
        public string Get(int id,string name,string age)
        {
            return "value";
        }

        // POST: api/student
        public void Post(APIResponseEntity entity)
        {
        }

        //// PUT: api/student/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}


        // PUT: api/student/5
        public void Put(int id, APIResponseEntity entity)
        {
        }

        // DELETE: api/student/5
        public void Delete(int id)
        {
        }

        //Given above are the specific http verds other than these you may use other controllers too
        [HttpGet]
        public HttpResponseMessage GetPatientDetails()
        {
            return Request.CreateResponse(HttpStatusCode.OK, APIResponse.Success("Success Return"));
        }

        [HttpGet]
        public string HelloMyNameIsNikhil()
        {
            return "Hello 123";
        }
    }
}