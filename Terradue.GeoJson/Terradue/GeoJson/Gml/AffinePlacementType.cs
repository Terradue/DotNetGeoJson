namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AffinePlacement", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class AffinePlacementType
  {

    private DirectPositionType locationField;

    private VectorType[] refDirectionField;

    private string inDimensionField;

    private string outDimensionField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public DirectPositionType location
    {
      get { return locationField; }
      set { locationField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("refDirection")]
    public VectorType[] refDirection
    {
      get { return refDirectionField; }
      set { refDirectionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
    public string inDimension
    {
      get { return inDimensionField; }
      set { inDimensionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
    public string outDimension
    {
      get { return outDimensionField; }
      set { outDimensionField = value; }
    }
  }
}