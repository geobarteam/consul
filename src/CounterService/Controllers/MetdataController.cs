using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace CounterService.Controllers
{
    
    public class MetdataController : Controller
    {

        static string SessionId;
       
        
        [HttpGet]
        [Route("api/metadata")]
        public Metadata Get()
        {
            if ( MetdataController.SessionId == null){
                 MetdataController.SessionId = System.Guid.NewGuid().ToString();
            }
            
            return new Metadata
            {
                IP =  this.HttpContext.Connection.RemoteIpAddress.ToString(),
                SessionId = MetdataController.SessionId
            };
        }

    }
}
