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
  public class DS_DataSet_Type : AbstractObject_Type
  {
    private MD_Metadata_PropertyType[] hasField;
    private DS_Aggregate_PropertyType[] partOfField;

    [XmlElement("has")]
    public MD_Metadata_PropertyType[] has
    {
      get { return hasField; }
      set { hasField = value; }
    }

    [XmlElement("partOf")]
    public DS_Aggregate_PropertyType[] partOf
    {
      get { return partOfField; }
      set { partOfField = value; }
    }
  }
}