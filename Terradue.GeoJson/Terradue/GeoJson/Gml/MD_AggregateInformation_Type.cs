namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_AggregateInformation_Type : AbstractObject_Type
  {

    private CI_Citation_PropertyType aggregateDataSetNameField;

    private MD_Identifier_PropertyType aggregateDataSetIdentifierField;

    private DS_AssociationTypeCode_PropertyType associationTypeField;

    private DS_InitiativeTypeCode_PropertyType initiativeTypeField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CI_Citation_PropertyType aggregateDataSetName
    {
      get { return aggregateDataSetNameField; }
      set { aggregateDataSetNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_Identifier_PropertyType aggregateDataSetIdentifier
    {
      get { return aggregateDataSetIdentifierField; }
      set { aggregateDataSetIdentifierField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public DS_AssociationTypeCode_PropertyType associationType
    {
      get { return associationTypeField; }
      set { associationTypeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public DS_InitiativeTypeCode_PropertyType initiativeType
    {
      get { return initiativeTypeField; }
      set { initiativeTypeField = value; }
    }
  }
}