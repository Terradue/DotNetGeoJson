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
  public class MD_GeometricObjects_Type : AbstractObject_Type
  {
    private Integer_PropertyType geometricObjectCountField;
    private MD_GeometricObjectTypeCode_PropertyType geometricObjectTypeField;

    [XmlElement]
    public MD_GeometricObjectTypeCode_PropertyType geometricObjectType
    {
      get { return geometricObjectTypeField; }
      set { geometricObjectTypeField = value; }
    }

    [XmlElement]
    public Integer_PropertyType geometricObjectCount
    {
      get { return geometricObjectCountField; }
      set { geometricObjectCountField = value; }
    }
  }
}