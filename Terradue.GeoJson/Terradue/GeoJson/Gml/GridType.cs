namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (RectifiedGridType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("Grid", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public partial class GridType : AbstractGeometryType
  {

    private GridLimitsType limitsField;

    private string[] itemsField;

    private ItemsChoiceType7[] itemsElementNameField;

    private string dimensionField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public GridLimitsType limits
    {
      get { return limitsField; }
      set { limitsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("axisLabels", typeof (string), DataType = "NCName")]
    [System.Xml.Serialization.XmlElementAttribute("axisName", typeof (string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public string[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType7[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
    public string dimension
    {
      get { return dimensionField; }
      set { dimensionField = value; }
    }
  }
}