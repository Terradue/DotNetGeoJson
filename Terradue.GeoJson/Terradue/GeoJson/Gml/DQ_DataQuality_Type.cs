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
  public class DQ_DataQuality_Type : AbstractObject_Type
  {
    private LI_Lineage_PropertyType lineageField;
    private DQ_Element_PropertyType[] reportField;
    private DQ_Scope_PropertyType scopeField;

    [XmlElement]
    public DQ_Scope_PropertyType scope
    {
      get { return scopeField; }
      set { scopeField = value; }
    }

    [XmlElement("report")]
    public DQ_Element_PropertyType[] report
    {
      get { return reportField; }
      set { reportField = value; }
    }

    [XmlElement]
    public LI_Lineage_PropertyType lineage
    {
      get { return lineageField; }
      set { lineageField = value; }
    }
  }
}