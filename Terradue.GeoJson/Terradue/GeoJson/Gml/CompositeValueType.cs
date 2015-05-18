namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ValueArrayType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("CompositeValue", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class CompositeValueType : AbstractGMLType
  {

    private ValuePropertyType[] valueComponentField;

    private ValueArrayPropertyType valueComponentsField;

    private AggregationType aggregationTypeField;

    private bool aggregationTypeFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("valueComponent")]
    public ValuePropertyType[] valueComponent
    {
      get { return valueComponentField; }
      set { valueComponentField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public ValueArrayPropertyType valueComponents
    {
      get { return valueComponentsField; }
      set { valueComponentsField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public AggregationType aggregationType
    {
      get { return aggregationTypeField; }
      set { aggregationTypeField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool aggregationTypeSpecified
    {
      get { return aggregationTypeFieldSpecified; }
      set { aggregationTypeFieldSpecified = value; }
    }
  }
}