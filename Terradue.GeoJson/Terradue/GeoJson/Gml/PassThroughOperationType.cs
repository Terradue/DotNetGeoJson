namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("PassThroughOperation", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class PassThroughOperationType : AbstractCoordinateOperationType
  {

    private string[] modifiedCoordinateField;

    private CoordinateOperationPropertyType itemField;

    private ItemChoiceType15 itemElementNameField;

    private AggregationType aggregationTypeField;

    private bool aggregationTypeFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("modifiedCoordinate", DataType = "positiveInteger")]
    public string[] modifiedCoordinate
    {
      get { return modifiedCoordinateField; }
      set { modifiedCoordinateField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("coordOperation", typeof (CoordinateOperationPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesOperation", typeof (CoordinateOperationPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesSingleOperation", typeof (CoordinateOperationPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public CoordinateOperationPropertyType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType15 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
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