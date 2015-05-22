using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("featureMembers", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class FeatureArrayPropertyType
  {
    private AbstractFeatureType[] itemsField;

    [XmlElement("DynamicFeature", typeof (DynamicFeatureType))]
    [XmlElement("FeatureCollection", typeof (FeatureCollectionType))]
    [XmlElement("Observation", typeof (ObservationType))]
    public AbstractFeatureType[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }
  }
}