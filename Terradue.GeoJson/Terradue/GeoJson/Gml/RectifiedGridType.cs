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
  [XmlRoot("RectifiedGrid", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class RectifiedGridType : GridType
  {
    private VectorType[] offsetVectorField;
    private PointPropertyType originField;

    [XmlElement]
    public PointPropertyType origin
    {
      get { return originField; }
      set { originField = value; }
    }

    [XmlElement("offsetVector")]
    public VectorType[] offsetVector
    {
      get { return offsetVectorField; }
      set { offsetVectorField = value; }
    }
  }
}