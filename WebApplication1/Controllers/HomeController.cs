using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("")]
        public HttpResponseMessage Index()
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("<html><body><a href='/api/values'>Values</a></body></html>")
            };
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("text/html");
            return response;
        }
    }
}
