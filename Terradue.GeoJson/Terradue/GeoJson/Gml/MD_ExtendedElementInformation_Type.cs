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
  public class MD_ExtendedElementInformation_Type : AbstractObject_Type
  {
    private CharacterString_PropertyType conditionField;
    private MD_DatatypeCode_PropertyType dataTypeField;
    private CharacterString_PropertyType definitionField;
    private Integer_PropertyType domainCodeField;
    private CharacterString_PropertyType domainValueField;
    private CharacterString_PropertyType maximumOccurrenceField;
    private CharacterString_PropertyType nameField;
    private MD_ObligationCode_PropertyType obligationField;
    private CharacterString_PropertyType[] parentEntityField;
    private CharacterString_PropertyType[] rationaleField;
    private CharacterString_PropertyType ruleField;
    private CharacterString_PropertyType shortNameField;
    private CI_ResponsibleParty_PropertyType[] sourceField;

    [XmlElement]
    public CharacterString_PropertyType name
    {
      get { return nameField; }
      set { nameField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType shortName
    {
      get { return shortNameField; }
      set { shortNameField = value; }
    }

    [XmlElement]
    public Integer_PropertyType domainCode
    {
      get { return domainCodeField; }
      set { domainCodeField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType definition
    {
      get { return definitionField; }
      set { definitionField = value; }
    }

    [XmlElement]
    public MD_ObligationCode_PropertyType obligation
    {
      get { return obligationField; }
      set { obligationField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType condition
    {
      get { return conditionField; }
      set { conditionField = value; }
    }

    [XmlElement]
    public MD_DatatypeCode_PropertyType dataType
    {
      get { return dataTypeField; }
      set { dataTypeField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType maximumOccurrence
    {
      get { return maximumOccurrenceField; }
      set { maximumOccurrenceField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType domainValue
    {
      get { return domainValueField; }
      set { domainValueField = value; }
    }

    [XmlElement("parentEntity")]
    public CharacterString_PropertyType[] parentEntity
    {
      get { return parentEntityField; }
      set { parentEntityField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType rule
    {
      get { return ruleField; }
      set { ruleField = value; }
    }

    [XmlElement("rationale")]
    public CharacterString_PropertyType[] rationale
    {
      get { return rationaleField; }
      set { rationaleField = value; }
    }

    [XmlElement("source")]
    public CI_ResponsibleParty_PropertyType[] source
    {
      get { return sourceField; }
      set { sourceField = value; }
    }
  }
}