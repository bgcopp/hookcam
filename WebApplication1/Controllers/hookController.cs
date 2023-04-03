using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebApplication1.Utils;

namespace WebApplication1.Controllers
{
  public class hookController : ApiController
  {
    [HttpPost]
    public void Marcacion()
    {
      try
      {
        Stream s = HttpContext.Current.Request.InputStream;
        s.Position = 0;
        using (StreamReader sr = new StreamReader(s))
        {
          string jsontext = sr.ReadToEnd();
          var obj = JsonConvert.DeserializeObject<Infoplate>(jsontext);
          SingletonApr.LastInfoEntry = obj;
        }
      }
      catch (Exception)
      {

       // throw;
      }
      
      
    }
  }
}
