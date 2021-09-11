using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CommandService.Controllers
{
    [Route("api/c/[controller]")]
    public class PlatformsController : ControllerBase
    {

        public PlatformsController()
        {
        }

        [HttpPost]
        public ActionResult TestConnection()
        {
            Console.WriteLine("Inbound Command Service");
            return Ok("This seems to be working");
        }
    }
}