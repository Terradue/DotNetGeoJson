using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public class EX_BoundingPolygon_Type : AbstractEX_GeographicExtent_Type
  {
    private GM_Object_PropertyType[] polygonField;

    [XmlElement("polygon")]
    public GM_Object_PropertyType[] polygon
    {
      get { return polygonField; }
      set { polygonField = value; }
    }
  }
}