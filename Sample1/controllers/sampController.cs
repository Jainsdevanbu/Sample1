using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sample1.controllers
{
 
    public class sampleController : ControllerBase
    {
        [HttpGet]
        [Route("api/sample")]
        public IActionResult Sample()
        {
            return Ok("Welcome to the sample page");
           
        }
    }
}