using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("PrimeMeridian", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class PrimeMeridianType : IdentifiedObjectType
  {
    private AngleType greenwichLongitudeField;

    [XmlElement]
    public AngleType greenwichLongitude
    {
      get { return greenwichLongitudeField; }
      set { greenwichLongitudeField = value; }
    }
  }
}