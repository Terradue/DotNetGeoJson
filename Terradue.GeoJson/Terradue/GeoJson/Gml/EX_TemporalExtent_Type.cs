using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (EX_SpatialTemporalExtent_Type))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public class EX_TemporalExtent_Type : AbstractObject_Type
  {
    private TM_Primitive_PropertyType extentField;

    [XmlElement]
    public TM_Primitive_PropertyType extent
    {
      get { return extentField; }
      set { extentField = value; }
    }
  }
}