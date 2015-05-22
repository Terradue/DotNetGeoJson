using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("GenericMetaData", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class GenericMetaDataType : AbstractMetaDataType
  {
    private XmlElement[] anyField;

    [XmlAnyElement]
    public XmlElement[] Any
    {
      get { return anyField; }
      set { anyField = value; }
    }
  }
}