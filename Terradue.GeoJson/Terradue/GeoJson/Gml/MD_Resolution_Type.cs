using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public class MD_Resolution_Type
  {
    private object itemField;

    [XmlElement("distance", typeof (Distance_PropertyType))]
    [XmlElement("equivalentScale", typeof (MD_RepresentativeFraction_PropertyType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }
  }
}