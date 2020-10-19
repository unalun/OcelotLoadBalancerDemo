using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AProductAPI.Controllers
{
    [Route("/api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        [HttpGet]
        public List<string> Get()
        {
            return new List<string> { "product1", "product2" };

        }
    }
}
