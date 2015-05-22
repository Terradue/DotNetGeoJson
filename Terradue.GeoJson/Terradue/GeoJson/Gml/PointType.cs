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
  [XmlRoot("Point", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public class PointType : AbstractGeometricPrimitiveType
  {
    private object itemField;

    [XmlElement("coordinates", typeof (CoordinatesType))]
    [XmlElement("pos", typeof (DirectPositionType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }
  }
}