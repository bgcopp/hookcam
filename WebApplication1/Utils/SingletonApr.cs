using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Utils
{
  public sealed class SingletonApr
  {
    private readonly static SingletonApr _instance = new SingletonApr();

    public static Infoplate LastInfoEntry { get; set; }
    public static DateTime lastentrydate { get; set; }
    public static Infoplate LastInfoExit { get; set; }
    public static DateTime lastexitdate { get; set; }

    private SingletonApr()
    {
      resetInfoEntry();
      resetInfoExit();
    }

    public static void resetInfoEntry()
    {
      LastInfoEntry = new Infoplate()
      {
        Plate = "*",
        CamName = "Camara1",
      };
      lastentrydate = DateTime.Now;

    }
    public static void resetInfoExit()
    {

      lastexitdate = DateTime.Now;
      LastInfoExit = new Infoplate()
      {
        Plate = "*",
        CamName = "Camara2",
      };
    }

    public static SingletonApr Instance
    {
      get
      {
        return _instance;
      }
    }
  }
}