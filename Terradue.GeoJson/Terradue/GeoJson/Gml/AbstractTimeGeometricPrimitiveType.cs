using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (TimePeriodType))]
  [XmlInclude(typeof (TimeInstantType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractTimeGeometricPrimitive",
    Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public abstract class AbstractTimeGeometricPrimitiveType : AbstractTimePrimitiveType
  {
    private string frameField;

    public AbstractTimeGeometricPrimitiveType()
    {
      frameField = "#ISO-8601";
    }

    [XmlAttribute(DataType = "anyURI")]
    [DefaultValue("#ISO-8601")]
    public string frame
    {
      get { return frameField; }
      set { frameField = value; }
    }
  }
}