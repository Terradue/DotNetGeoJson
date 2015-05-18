namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("dictionaryEntry", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class DictionaryEntryType : AbstractMemberType
  {

    private DefinitionType itemField;

    private ItemChoiceType17 itemElementNameField;

    private string nilReasonField;

    private string remoteSchemaField;

    [System.Xml.Serialization.XmlElementAttribute("CoordinateSystemAxis", typeof (CoordinateSystemAxisType))]
    [System.Xml.Serialization.XmlElementAttribute("Definition", typeof (DefinitionType))]
    [System.Xml.Serialization.XmlElementAttribute("DefinitionCollection", typeof (DictionaryType))]
    [System.Xml.Serialization.XmlElementAttribute("DefinitionProxy", typeof (DefinitionProxyType))]
    [System.Xml.Serialization.XmlElementAttribute("Dictionary", typeof (DictionaryType))]
    [System.Xml.Serialization.XmlElementAttribute("Ellipsoid", typeof (EllipsoidType))]
    [System.Xml.Serialization.XmlElementAttribute("OperationMethod", typeof (OperationMethodType))]
    [System.Xml.Serialization.XmlElementAttribute("PrimeMeridian", typeof (PrimeMeridianType))]
    [System.Xml.Serialization.XmlElementAttribute("TimeReferenceSystem", typeof (TimeReferenceSystemType))]
    [System.Xml.Serialization.XmlElementAttribute("UnitDefinition", typeof (UnitDefinitionType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public DefinitionType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType17 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified,
      DataType = "anyURI")]
    public string remoteSchema
    {
      get { return remoteSchemaField; }
      set { remoteSchemaField = value; }
    }
  }
}