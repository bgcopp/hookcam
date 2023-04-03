using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using WebApplication2.Utils;

namespace WebApplication2.Controllers
{
  public class readController : ApiController
  {
    [HttpGet]
    [Route("service/lpr/{camera}")]
    public dynamic ReadPlates(string camera)
    {
      //return Json(SingletonApr.MyDynamic);
      var camara1set = ConfigurationManager.AppSettings["cameraentry"];
      if(camera == camara1set)
      {
        return Json(SingletonApr.MyDynamicInfoEntry);
      }
      else
      {
        return Json(SingletonApr.MyDynamicInfoExit);
      }
      
    }

    [HttpPost]
    [Route("service/lpr/{camera}")]
    public dynamic ResetPlates(string camera)
    {
      SingletonApr.resetcameras();
      return SingletonApr.MyDynamicInfoEntry;

    }
  }
}
