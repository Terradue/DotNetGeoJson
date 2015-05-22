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
  public class DQ_Scope_Type : AbstractObject_Type
  {
    private EX_Extent_PropertyType extentField;
    private MD_ScopeDescription_PropertyType[] levelDescriptionField;
    private MD_ScopeCode_PropertyType levelField;

    [XmlElement]
    public MD_ScopeCode_PropertyType level
    {
      get { return levelField; }
      set { levelField = value; }
    }

    [XmlElement]
    public EX_Extent_PropertyType extent
    {
      get { return extentField; }
      set { extentField = value; }
    }

    [XmlElement("levelDescription")]
    public MD_ScopeDescription_PropertyType[] levelDescription
    {
      get { return levelDescriptionField; }
      set { levelDescriptionField = value; }
    }
  }
}