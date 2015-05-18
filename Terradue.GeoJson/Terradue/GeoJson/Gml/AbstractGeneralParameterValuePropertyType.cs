namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("parameterValue", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class AbstractGeneralParameterValuePropertyType
  {

    private AbstractGeneralParameterValueType itemField;

    [System.Xml.Serialization.XmlElementAttribute("ParameterValue", typeof (ParameterValueType))]
    [System.Xml.Serialization.XmlElementAttribute("ParameterValueGroup", typeof (ParameterValueGroupType))]
    public AbstractGeneralParameterValueType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }
  }
}