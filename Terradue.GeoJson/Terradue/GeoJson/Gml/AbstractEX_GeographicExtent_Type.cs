using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (EX_GeographicDescription_Type))]
  [XmlInclude(typeof (EX_GeographicBoundingBox_Type))]
  [XmlInclude(typeof (EX_BoundingPolygon_Type))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public abstract class AbstractEX_GeographicExtent_Type : AbstractObject_Type
  {
    private Boolean_PropertyType extentTypeCodeField;

    [XmlElement]
    public Boolean_PropertyType extentTypeCode
    {
      get { return extentTypeCodeField; }
      set { extentTypeCodeField = value; }
    }
  }
}