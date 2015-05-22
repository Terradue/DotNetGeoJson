using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (TimeOrdinalReferenceSystemType))]
  [XmlInclude(typeof (TimeClockType))]
  [XmlInclude(typeof (TimeCalendarType))]
  [XmlInclude(typeof (TimeCoordinateSystemType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("TimeReferenceSystem", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TimeReferenceSystemType : DefinitionType
  {
    private string domainOfValidityField;

    [XmlElement]
    public string domainOfValidity
    {
      get { return domainOfValidityField; }
      set { domainOfValidityField = value; }
    }
  }
}