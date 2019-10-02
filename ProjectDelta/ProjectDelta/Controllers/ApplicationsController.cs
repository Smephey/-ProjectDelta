using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ProjectDelta.Controllers
{
    [Route("api/applications")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Application>> GetAppList()
        {
            var applicationList = new List<Application>();

            applicationList.Add(new Application
            {
                Name = "ConfigManager"
            });

            return applicationList;
        }
    }
}
