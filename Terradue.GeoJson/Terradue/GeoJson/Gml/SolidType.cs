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
  [XmlRoot("Solid", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public class SolidType : AbstractSolidType
  {
    private ShellPropertyType exteriorField;
    private ShellPropertyType[] interiorField;

    [XmlElement]
    public ShellPropertyType exterior
    {
      get { return exteriorField; }
      set { exteriorField = value; }
    }

    [XmlElement("interior")]
    public ShellPropertyType[] interior
    {
      get { return interiorField; }
      set { interiorField = value; }
    }
  }
}