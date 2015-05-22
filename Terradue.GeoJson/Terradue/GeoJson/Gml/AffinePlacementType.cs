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
  [XmlRoot("AffinePlacement", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class AffinePlacementType
  {
    private string inDimensionField;
    private DirectPositionType locationField;
    private string outDimensionField;
    private VectorType[] refDirectionField;

    [XmlElement]
    public DirectPositionType location
    {
      get { return locationField; }
      set { locationField = value; }
    }

    [XmlElement("refDirection")]
    public VectorType[] refDirection
    {
      get { return refDirectionField; }
      set { refDirectionField = value; }
    }

    [XmlElement(DataType = "positiveInteger")]
    public string inDimension
    {
      get { return inDimensionField; }
      set { inDimensionField = value; }
    }

    [XmlElement(DataType = "positiveInteger")]
    public string outDimension
    {
      get { return outDimensionField; }
      set { outDimensionField = value; }
    }
  }
}