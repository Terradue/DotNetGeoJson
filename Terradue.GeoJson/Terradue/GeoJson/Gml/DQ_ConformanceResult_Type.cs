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
  public class DQ_ConformanceResult_Type : AbstractDQ_Result_Type
  {
    private CharacterString_PropertyType explanationField;
    private Boolean_PropertyType passField;
    private CI_Citation_PropertyType specificationField;

    [XmlElement]
    public CI_Citation_PropertyType specification
    {
      get { return specificationField; }
      set { specificationField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType explanation
    {
      get { return explanationField; }
      set { explanationField = value; }
    }

    [XmlElement]
    public Boolean_PropertyType pass
    {
      get { return passField; }
      set { passField = value; }
    }
  }
}