using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers.OTConnect
{
    /// <summary>
    /// OT Connect
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class OTController : ControllerBase
    {
        
        /// <summary>
        /// OT Connect Get Methods
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/OT/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value " + id;
        }

       
    }
}
