using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        public async Task<string> Get()
        {
            Service2 service2 = new Service2();
            await service2.Method1().ConfigureAwait(false);
            Service service = new Service();
            await service.Method1().ConfigureAwait(false);
            return await Task.FromResult("value");
        }

        async Task NoOp()
        {
            await Task.Delay(1000);
        }

        async Task AnotherMethod()
        {
            Request.Properties["test1"] = "Name";
            await Task.Delay(1000).ConfigureAwait(false);
            await MethodThrowsException().ConfigureAwait(false);
            Request.Properties["test"] = "Name";
        }

        async Task<string> MethodThrowsException()
        {
            await Task.Delay(1000).ConfigureAwait(false);
            throw new ArgumentNullException("Exception thrown from async method");
        }
    }
}
