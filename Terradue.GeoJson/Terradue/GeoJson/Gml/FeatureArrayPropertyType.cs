namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("featureMembers", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class FeatureArrayPropertyType
  {

    private AbstractFeatureType[] itemsField;

    [System.Xml.Serialization.XmlElementAttribute("DynamicFeature", typeof (DynamicFeatureType))]
    [System.Xml.Serialization.XmlElementAttribute("FeatureCollection", typeof (FeatureCollectionType))]
    [System.Xml.Serialization.XmlElementAttribute("Observation", typeof (ObservationType))]
    public AbstractFeatureType[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }
  }
}