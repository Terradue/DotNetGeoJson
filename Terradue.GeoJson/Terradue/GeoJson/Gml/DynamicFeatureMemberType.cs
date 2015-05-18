namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("dynamicMembers", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class DynamicFeatureMemberType : AbstractFeatureMemberType
  {

    private DynamicFeatureType[] itemsField;

    private string nilReasonField;

    private string remoteSchemaField;

    [System.Xml.Serialization.XmlElementAttribute("DynamicFeature", typeof (DynamicFeatureType))]
    [System.Xml.Serialization.XmlElementAttribute("DynamicFeatureCollection", typeof (DynamicFeatureCollectionType))]
    public DynamicFeatureType[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
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