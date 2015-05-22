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
  [XmlRoot(Namespace = "http://www.opengis.net/gml/3.2", IsNullable = true)]
  public class GridEnvelopeType
  {
    private string highField;
    private string lowField;

    [XmlElement]
    public string low
    {
      get { return lowField; }
      set { lowField = value; }
    }

    [XmlElement]
    public string high
    {
      get { return highField; }
      set { highField = value; }
    }
  }
}