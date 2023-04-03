using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading;
using System.Timers;
using System.Web;

namespace WebApplication2.Utils
{
  public sealed class SingletonApr
  {
    private readonly static SingletonApr _instance = new SingletonApr();
    
    private static dynamic _MyDynamicInfoEntry;
    public static dynamic MyDynamicInfoEntry
    {
      get { return _MyDynamicInfoEntry; }

      set
      {
        _MyDynamicInfoEntry = value;

      }
    }

    private static dynamic _MyDynamicInfoExit;
    public static dynamic MyDynamicInfoExit
    {
      get { return _MyDynamicInfoExit; }

      set
      {
        _MyDynamicInfoExit = value;

      }
    }
    public static Infoplate LastInfoEntry { get; set; }
    public static DateTime lastentrydate { get; set; }
    public static Infoplate LastInfoExit { get; set; }
    public static DateTime lastexitdate { get; set; }

    
    private SingletonApr()
    {
      resetcameras();
      
      resetInfoEntry();
      resetInfoExit();
    }

    public static void resetcameras()
    {
      var obj = JsonConvert.DeserializeObject(@"{
""DateHour"": ""01/01/2017 08:00:00"",
""Engine"": ""LPR"",
""Plate"": ""*"",
""PlateDescription"": """",
""CardID"": """",
""Container"": """",
""ExtraInfo"": """",
""Confidence"": """",
""Country"": ""Colombia"",
""CountryID"": 202,
""ProcTime"": 607,
""CharHeight"": 21.67,
""CamID"": 1,
""CamName"": ""Camara1"",
""ImageLeft"": 601,
""ImageTop"": 292,
""ImageWidth"": 88,
""ImageHeight"": 33,
""Path"": """",
""DirectionVector"": 0,
""imgSize"": 0,
""img"": """",
""ComputerID"": 1,
""Feedback"": """",
""EventID"": """",
""IncidenceID"": 22079,
""nFrame"": 0,
""aviFileName"": """",
""Code"": 1,
""Speed"": ""0.0"",
""GPSLat"": """",
""GPSLon"": """",
""List"": [
-1
],
""ListName"": ""not in list"",
""CharConfidence"": """",
""VehicleMake"": ""0"",
""VehicleClass"": ""0"",
""VehicleColor"": ""0"",
""LaneName"": """",
""LaneID"": 0,
""RedLightState"": 0,
""RedLightPosTime"": 0,
""LocationID"": 1,
""Angle"": 2.87,
""VehicleType"": 1,
""Char0TopX"": 605,
""Char0TopY"": 300,
""Char0BottomX"": 605,
""Char0BottomY"": 321,
""CharNTopX"": 686,
""CharNTopY"": 297,
""CharNBottomX"": 686,
""CharNBottomY"": 319,
""Evidences"": []
}");
      _MyDynamicInfoEntry = obj;
      var obj1 = JsonConvert.DeserializeObject(@"{
""DateHour"": ""01/01/2017 08:00:00"",
""Engine"": ""LPR"",
""Plate"": ""*"",
""PlateDescription"": """",
""CardID"": """",
""Container"": """",
""ExtraInfo"": """",
""Confidence"": """",
""Country"": ""Colombia"",
""CountryID"": 202,
""ProcTime"": 607,
""CharHeight"": 21.67,
""CamID"": 1,
""CamName"": ""Camara2"",
""ImageLeft"": 601,
""ImageTop"": 292,
""ImageWidth"": 88,
""ImageHeight"": 33,
""Path"": """",
""DirectionVector"": 0,
""imgSize"": 0,
""img"": """",
""ComputerID"": 1,
""Feedback"": """",
""EventID"": """",
""IncidenceID"": 22079,
""nFrame"": 0,
""aviFileName"": """",
""Code"": 1,
""Speed"": ""0.0"",
""GPSLat"": """",
""GPSLon"": """",
""List"": [
-1
],
""ListName"": ""not in list"",
""CharConfidence"": """",
""VehicleMake"": ""0"",
""VehicleClass"": ""0"",
""VehicleColor"": ""0"",
""LaneName"": """",
""LaneID"": 0,
""RedLightState"": 0,
""RedLightPosTime"": 0,
""LocationID"": 1,
""Angle"": 2.87,
""VehicleType"": 1,
""Char0TopX"": 605,
""Char0TopY"": 300,
""Char0BottomX"": 605,
""Char0BottomY"": 321,
""CharNTopX"": 686,
""CharNTopY"": 297,
""CharNBottomX"": 686,
""CharNBottomY"": 319,
""Evidences"": []
}");
      MyDynamicInfoExit = obj1;
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