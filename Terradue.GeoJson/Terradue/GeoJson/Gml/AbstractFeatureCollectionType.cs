namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (FeatureCollectionType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AbstractFeatureCollection", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract partial class AbstractFeatureCollectionType : AbstractFeatureType
  {

    private FeaturePropertyType[] featureMemberField;

    private FeatureArrayPropertyType featureMembersField;

    [System.Xml.Serialization.XmlElementAttribute("featureMember")]
    public FeaturePropertyType[] featureMember
    {
      get { return featureMemberField; }
      set { featureMemberField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public FeatureArrayPropertyType featureMembers
    {
      get { return featureMembersField; }
      set { featureMembersField = value; }
    }
  }
}