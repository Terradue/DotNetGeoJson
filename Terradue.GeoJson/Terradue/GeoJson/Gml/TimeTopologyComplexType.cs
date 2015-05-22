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
  [XmlRoot("TimeTopologyComplex", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract class TimeTopologyComplexType : AbstractTimeComplexType
  {
    private TimeTopologyPrimitivePropertyType[] primitiveField;

    [XmlElement("primitive")]
    public TimeTopologyPrimitivePropertyType[] primitive
    {
      get { return primitiveField; }
      set { primitiveField = value; }
    }
  }
}