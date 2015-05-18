namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/gml/3.2", IsNullable = true)]
  public partial class RelatedTimeType : TimePrimitivePropertyType
  {

    private RelatedTimeTypeRelativePosition relativePositionField;

    private bool relativePositionFieldSpecified;

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public RelatedTimeTypeRelativePosition relativePosition
    {
      get { return relativePositionField; }
      set { relativePositionField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool relativePositionSpecified
    {
      get { return relativePositionFieldSpecified; }
      set { relativePositionFieldSpecified = value; }
    }
  }
}