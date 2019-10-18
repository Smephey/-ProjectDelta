using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProjectDelta.Logic;
using ProjectDelta.Types;

namespace ProjectDelta.Controllers
{
    [Route("api/applications")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        [HttpGet]
        public ActionResult<ApplicationList> GetAppList()
        {
            var jsonReader = new JsonReader();

            var applicationList = new ApplicationList();

            applicationList = jsonReader.GetApplicationList();

            return applicationList;
        }
    }
}
