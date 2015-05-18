namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class LI_Lineage_Type : AbstractObject_Type
  {

    private CharacterString_PropertyType statementField;

    private LI_ProcessStep_PropertyType[] processStepField;

    private LI_Source_PropertyType[] sourceField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType statement
    {
      get { return statementField; }
      set { statementField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("processStep")]
    public LI_ProcessStep_PropertyType[] processStep
    {
      get { return processStepField; }
      set { processStepField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("source")]
    public LI_Source_PropertyType[] source
    {
      get { return sourceField; }
      set { sourceField = value; }
    }
  }
}