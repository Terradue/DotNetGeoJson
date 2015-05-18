namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("BaseUnit", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class BaseUnitType : UnitDefinitionType
  {

    private ReferenceType unitsSystemField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public ReferenceType unitsSystem
    {
      get { return unitsSystemField; }
      set { unitsSystemField = value; }
    }
  }
}