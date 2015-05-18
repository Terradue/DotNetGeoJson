namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DerivedCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ProjectedCRSType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AbstractGeneralDerivedCRS", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract partial class AbstractGeneralDerivedCRSType : AbstractCRSType
  {

    private GeneralConversionPropertyType itemField;

    private ItemChoiceType16 itemElementNameField;

    [System.Xml.Serialization.XmlElementAttribute("conversion", typeof (GeneralConversionPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("definedByConversion", typeof (GeneralConversionPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public GeneralConversionPropertyType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType16 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }
  }
}