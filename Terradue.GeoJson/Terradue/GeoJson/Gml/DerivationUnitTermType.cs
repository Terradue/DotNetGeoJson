namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("derivationUnitTerm", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class DerivationUnitTermType : UnitOfMeasureType
  {

    private string exponentField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    public string exponent
    {
      get { return exponentField; }
      set { exponentField = value; }
    }
  }
}