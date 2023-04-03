using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebApplication2.Utils;

namespace WebApplication2.Controllers
{
  public class hookController : ApiController
  {
    [HttpPost]
    //[Route("{camera}")]
    public void Marcacion(string camera)
    {
      Stream s = HttpContext.Current.Request.InputStream;
      s.Position= 0;
      StreamReader sr = new StreamReader(s);
      string jsontext = sr.ReadToEnd();
      dynamic obj = JsonConvert.DeserializeObject(jsontext);
      if(camera == ConfigurationManager.AppSettings["cameraentry"])
      {
        SingletonApr.MyDynamicInfoEntry = obj.infoplate;
      }
      else
      {
        SingletonApr.MyDynamicInfoExit = obj.infoplate;
      }
      
    }
  }
}
