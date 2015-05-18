namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DynamicFeatureCollectionType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("DynamicFeature", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class DynamicFeatureType : AbstractFeatureType
  {

    private TimePrimitivePropertyType validTimeField;

    private HistoryPropertyType item1Field;

    private Item1ChoiceType8 item1ElementNameField;

    private StringOrRefType dataSourceField;

    private ReferenceType dataSourceReferenceField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public TimePrimitivePropertyType validTime
    {
      get { return validTimeField; }
      set { validTimeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("history", typeof (HistoryPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("track", typeof (HistoryPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
    public HistoryPropertyType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public Item1ChoiceType8 Item1ElementName
    {
      get { return item1ElementNameField; }
      set { item1ElementNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public StringOrRefType dataSource
    {
      get { return dataSourceField; }
      set { dataSourceField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public ReferenceType dataSourceReference
    {
      get { return dataSourceReferenceField; }
      set { dataSourceReferenceField = value; }
    }
  }
}