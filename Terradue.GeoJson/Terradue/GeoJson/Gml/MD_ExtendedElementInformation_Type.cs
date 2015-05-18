namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_ExtendedElementInformation_Type : AbstractObject_Type
  {

    private CharacterString_PropertyType nameField;

    private CharacterString_PropertyType shortNameField;

    private Integer_PropertyType domainCodeField;

    private CharacterString_PropertyType definitionField;

    private MD_ObligationCode_PropertyType obligationField;

    private CharacterString_PropertyType conditionField;

    private MD_DatatypeCode_PropertyType dataTypeField;

    private CharacterString_PropertyType maximumOccurrenceField;

    private CharacterString_PropertyType domainValueField;

    private CharacterString_PropertyType[] parentEntityField;

    private CharacterString_PropertyType ruleField;

    private CharacterString_PropertyType[] rationaleField;

    private CI_ResponsibleParty_PropertyType[] sourceField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType name
    {
      get { return nameField; }
      set { nameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType shortName
    {
      get { return shortNameField; }
      set { shortNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Integer_PropertyType domainCode
    {
      get { return domainCodeField; }
      set { domainCodeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType definition
    {
      get { return definitionField; }
      set { definitionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_ObligationCode_PropertyType obligation
    {
      get { return obligationField; }
      set { obligationField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType condition
    {
      get { return conditionField; }
      set { conditionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_DatatypeCode_PropertyType dataType
    {
      get { return dataTypeField; }
      set { dataTypeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType maximumOccurrence
    {
      get { return maximumOccurrenceField; }
      set { maximumOccurrenceField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType domainValue
    {
      get { return domainValueField; }
      set { domainValueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("parentEntity")]
    public CharacterString_PropertyType[] parentEntity
    {
      get { return parentEntityField; }
      set { parentEntityField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType rule
    {
      get { return ruleField; }
      set { ruleField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("rationale")]
    public CharacterString_PropertyType[] rationale
    {
      get { return rationaleField; }
      set { rationaleField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("source")]
    public CI_ResponsibleParty_PropertyType[] source
    {
      get { return sourceField; }
      set { sourceField = value; }
    }
  }
}