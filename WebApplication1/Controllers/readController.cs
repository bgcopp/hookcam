using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using WebApplication1.Utils;

namespace WebApplication1.Controllers
{
  public class readController : ApiController
  {
    [HttpGet]
    public JsonResult<Infoplate> ReadPlates()
    {
      return Json(SingletonApr.LastInfoEntry);
    }
  }
}
