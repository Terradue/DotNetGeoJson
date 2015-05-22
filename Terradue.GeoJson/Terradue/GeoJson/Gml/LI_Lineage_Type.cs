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
  public class LI_Lineage_Type : AbstractObject_Type
  {
    private LI_ProcessStep_PropertyType[] processStepField;
    private LI_Source_PropertyType[] sourceField;
    private CharacterString_PropertyType statementField;

    [XmlElement]
    public CharacterString_PropertyType statement
    {
      get { return statementField; }
      set { statementField = value; }
    }

    [XmlElement("processStep")]
    public LI_ProcessStep_PropertyType[] processStep
    {
      get { return processStepField; }
      set { processStepField = value; }
    }

    [XmlElement("source")]
    public LI_Source_PropertyType[] source
    {
      get { return sourceField; }
      set { sourceField = value; }
    }
  }
}