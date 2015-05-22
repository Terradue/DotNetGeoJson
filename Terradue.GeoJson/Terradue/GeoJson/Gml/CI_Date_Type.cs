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
  public class CI_Date_Type : AbstractObject_Type
  {
    private Date_PropertyType dateField;
    private CI_DateTypeCode_PropertyType dateTypeField;

    [XmlElement]
    public Date_PropertyType date
    {
      get { return dateField; }
      set { dateField = value; }
    }

    [XmlElement]
    public CI_DateTypeCode_PropertyType dateType
    {
      get { return dateTypeField; }
      set { dateTypeField = value; }
    }
  }
}