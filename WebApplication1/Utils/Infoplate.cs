using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebApplication1.Utils
{
  [XmlRoot(ElementName = "infoplate")]
  public class Infoplate
  {
    //[XmlElement(ElementName = "img")]
    //public string img { get; set; }
    [XmlElement(ElementName = "DateHour")]
    public string DateHour { get; set; }
    [XmlElement(ElementName = "Engine")]
    public string Engine { get; set; }
    [XmlElement(ElementName = "Plate")]
    public string Plate { get; set; }
    [XmlElement(ElementName = "PlateDescription")]
    public string PlateDescription { get; set; }
    [XmlElement(ElementName = "CardID")]
    public string CardID { get; set; }
    [XmlElement(ElementName = "Container")]
    public string Container { get; set; }
    [XmlElement(ElementName = "ExtraInfo")]
    public string ExtraInfo { get; set; }
    [XmlElement(ElementName = "Confidence")]
    public string Confidence { get; set; }
    [XmlElement(ElementName = "Country")]
    public string Country { get; set; }
    [XmlElement(ElementName = "CountryID")]
    public string CountryID { get; set; }
    [XmlElement(ElementName = "ProcTime")]
    public string ProcTime { get; set; }
    [XmlElement(ElementName = "CharHeight")]
    public string CharHeight { get; set; }
    [XmlElement(ElementName = "CamID")]
    public string CamID { get; set; }
    [XmlElement(ElementName = "CamName")]
    public string CamName { get; set; }
    [XmlElement(ElementName = "ImageLeft")]
    public string ImageLeft { get; set; }
    [XmlElement(ElementName = "ImageTop")]
    public string ImageTop { get; set; }
    [XmlElement(ElementName = "ImageWidth")]
    public string ImageWidth { get; set; }
    [XmlElement(ElementName = "ImageHeight")]
    public string ImageHeight { get; set; }
    [XmlElement(ElementName = "Path")]
    public string Path { get; set; }
    [XmlElement(ElementName = "DirectionVector")]
    public string DirectionVector { get; set; }
    [XmlElement(ElementName = "imgSize")]
    public string ImgSize { get; set; }
    [XmlElement(ElementName = "img")]
    public string Img { get; set; }
    [XmlElement(ElementName = "ComputerID")]
    public string ComputerID { get; set; }
    [XmlElement(ElementName = "Feedback")]
    public string Feedback { get; set; }
    [XmlElement(ElementName = "EventID")]
    public string EventID { get; set; }
    [XmlElement(ElementName = "IncidenceID")]
    public string IncidenceID { get; set; }
    [XmlElement(ElementName = "nFrame")]
    public string NFrame { get; set; }
    [XmlElement(ElementName = "aviFileName")]
    public string AviFileName { get; set; }
    [XmlElement(ElementName = "Code")]
    public string Code { get; set; }
    [XmlElement(ElementName = "Speed")]
    public string Speed { get; set; }
    [XmlElement(ElementName = "GPSLat")]
    public string GPSLat { get; set; }
    [XmlElement(ElementName = "GPSLon")]
    public string GPSLon { get; set; }
    [XmlElement(ElementName = "List")]
    public string List { get; set; }
    [XmlElement(ElementName = "ListName")]
    public string ListName { get; set; }
    [XmlElement(ElementName = "CharConfidence")]
    public string CharConfidence { get; set; }
    [XmlElement(ElementName = "VehicleMake")]
    public string VehicleMake { get; set; }
    [XmlElement(ElementName = "VehicleClass")]
    public string VehicleClass { get; set; }
    [XmlElement(ElementName = "VehicleColor")]
    public string VehicleColor { get; set; }
    [XmlElement(ElementName = "LaneName")]
    public string LaneName { get; set; }
    [XmlElement(ElementName = "LaneID")]
    public string LaneID { get; set; }
    [XmlElement(ElementName = "RedLightState")]
    public string RedLightState { get; set; }
    [XmlElement(ElementName = "RedLightPosTime")]
    public string RedLightPosTime { get; set; }
    [XmlElement(ElementName = "LocationID")]
    public string LocationID { get; set; }
    [XmlElement(ElementName = "Angle")]
    public string Angle { get; set; }
    [XmlElement(ElementName = "VehicleType")]
    public string VehicleType { get; set; }
    [XmlElement(ElementName = "Char0TopX")]
    public string Char0TopX { get; set; }
    [XmlElement(ElementName = "Char0TopY")]
    public string Char0TopY { get; set; }
    [XmlElement(ElementName = "Char0BottomX")]
    public string Char0BottomX { get; set; }
    [XmlElement(ElementName = "Char0BottomY")]
    public string Char0BottomY { get; set; }
    [XmlElement(ElementName = "CharNTopX")]
    public string CharNTopX { get; set; }
    [XmlElement(ElementName = "CharNTopY")]
    public string CharNTopY { get; set; }
    [XmlElement(ElementName = "CharNBottomX")]
    public string CharNBottomX { get; set; }
    [XmlElement(ElementName = "CharNBottomY")]
    public string CharNBottomY { get; set; }
    [XmlElement(ElementName = "Evidences")]
    public string Evidences { get; set; }
  }
}