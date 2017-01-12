using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CounterService.Controllers
{
    [Route("api/[controller]")]
    public class CounterController : Controller
    {
        private static int Counter = 0;
        // GET api/values
        [HttpGet]
        public int Get()
        {
            return CounterController.Counter;
        }

       
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            CounterController.Counter++;
        }
    }
}
