﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        //Endpoint http://localhost:58922/api/values - does not throw SO exception
        public async Task<string> Get()
        {
            return await CallMethod().ConfigureAwait(false);
            
        }

        //Endpoint http://localhost:58922/2 - This one throws stackoverflow exception
        [HttpGet]
        [Route("2")]
        public async Task<string> Get2()
        {
            return await CallMethod2().ConfigureAwait(false);
        }

        [HttpGet]
        [Route("3")]
        public async Task<string> CallMethod()
        {
            Service2 service2 = new Service2();
            bool b = true;
            await service2.Method1().ConfigureAwait(b);
            Service service = new Service();
            await service.Method1().ConfigureAwait(false);
            return await Task.FromResult("value");
        }


        [HttpGet]
        [Route("4")]
        public async Task<string> CallMethod2()
        {
            Service2 service2 = new Service2();
            bool b = false;
            await service2.Method1().ConfigureAwait(b);
            Service service = new Service();
            await service.Method1().ConfigureAwait(false);
            return await Task.FromResult("value");
        }

    }
}
