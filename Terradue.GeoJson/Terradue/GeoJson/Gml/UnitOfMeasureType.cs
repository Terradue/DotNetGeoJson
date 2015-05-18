namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ConversionToPreferredUnitType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DerivationUnitTermType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("unitOfMeasure", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class UnitOfMeasureType
  {

    private string uomField;

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string uom
    {
      get { return uomField; }
      set { uomField = value; }
    }
  }
}