using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ProjectDelta.Logic;
using ProjectDelta.Types;

namespace ProjectDelta.Controllers
{
    [Route("api/commands")]
    [ApiController]
    [EnableCors("mypolicy")]
    public class CommandsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Command>> GetCommandList()
        {
            var jsonReader = new JsonReader();

            return jsonReader.GetCommandList();
        }
    }
}