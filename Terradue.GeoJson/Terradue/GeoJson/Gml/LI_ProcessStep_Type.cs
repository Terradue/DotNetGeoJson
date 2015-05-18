namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class LI_ProcessStep_Type : AbstractObject_Type
  {

    private CharacterString_PropertyType descriptionField;

    private CharacterString_PropertyType rationaleField;

    private DateTime_PropertyType dateTimeField;

    private CI_ResponsibleParty_PropertyType[] processorField;

    private LI_Source_PropertyType[] sourceField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType description
    {
      get { return descriptionField; }
      set { descriptionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType rationale
    {
      get { return rationaleField; }
      set { rationaleField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public DateTime_PropertyType dateTime
    {
      get { return dateTimeField; }
      set { dateTimeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("processor")]
    public CI_ResponsibleParty_PropertyType[] processor
    {
      get { return processorField; }
      set { processorField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("source")]
    public LI_Source_PropertyType[] source
    {
      get { return sourceField; }
      set { sourceField = value; }
    }
  }
}