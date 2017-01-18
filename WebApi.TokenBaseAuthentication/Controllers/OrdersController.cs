using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace WebApi.TokenBaseAuthentication.Controllers
{
    public class OrdersController : ApiController
    {
        [Authorize]
        public IHttpActionResult Get()
        {
            return Ok("OK ...");
        }
    }
}
