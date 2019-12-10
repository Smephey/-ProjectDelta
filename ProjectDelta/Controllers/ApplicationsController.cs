﻿using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ProjectDelta.Logic;
using ProjectDelta.Types;

namespace ProjectDelta.Controllers
{
    [Route("api/applications")]
    [ApiController]
    [EnableCors("mypolicy")]
    public class ApplicationController : ControllerBase
    {
        [HttpGet]
        public ActionResult<ApplicationList> GetAppList()
        {
            var jsonReader = new JsonReader();

            return jsonReader.GetApplicationList();
        }
    }
}
