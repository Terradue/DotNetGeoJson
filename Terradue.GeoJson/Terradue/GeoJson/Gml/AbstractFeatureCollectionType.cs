using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (FeatureCollectionType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractFeatureCollection", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract class AbstractFeatureCollectionType : AbstractFeatureType
  {
    private FeaturePropertyType[] featureMemberField;
    private FeatureArrayPropertyType featureMembersField;

    [XmlElement("featureMember")]
    public FeaturePropertyType[] featureMember
    {
      get { return featureMemberField; }
      set { featureMemberField = value; }
    }

    [XmlElement]
    public FeatureArrayPropertyType featureMembers
    {
      get { return featureMembersField; }
      set { featureMembersField = value; }
    }
  }
}