namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("DataBlock", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class DataBlockType
  {

    private AssociationRoleType rangeParametersField;

    private object itemField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public AssociationRoleType rangeParameters
    {
      get { return rangeParametersField; }
      set { rangeParametersField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("doubleOrNilReasonTupleList", typeof (string))]
    [System.Xml.Serialization.XmlElementAttribute("tupleList", typeof (CoordinatesType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }
  }
}