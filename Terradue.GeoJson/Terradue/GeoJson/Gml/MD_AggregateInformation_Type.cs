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
  public class MD_AggregateInformation_Type : AbstractObject_Type
  {
    private MD_Identifier_PropertyType aggregateDataSetIdentifierField;
    private CI_Citation_PropertyType aggregateDataSetNameField;
    private DS_AssociationTypeCode_PropertyType associationTypeField;
    private DS_InitiativeTypeCode_PropertyType initiativeTypeField;

    [XmlElement]
    public CI_Citation_PropertyType aggregateDataSetName
    {
      get { return aggregateDataSetNameField; }
      set { aggregateDataSetNameField = value; }
    }

    [XmlElement]
    public MD_Identifier_PropertyType aggregateDataSetIdentifier
    {
      get { return aggregateDataSetIdentifierField; }
      set { aggregateDataSetIdentifierField = value; }
    }

    [XmlElement]
    public DS_AssociationTypeCode_PropertyType associationType
    {
      get { return associationTypeField; }
      set { associationTypeField = value; }
    }

    [XmlElement]
    public DS_InitiativeTypeCode_PropertyType initiativeType
    {
      get { return initiativeTypeField; }
      set { initiativeTypeField = value; }
    }
  }
}