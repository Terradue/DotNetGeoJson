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
  public abstract class AbstractRS_ReferenceSystem_Type : AbstractObject_Type
  {
    private EX_Extent_PropertyType[] domainOfValidityField;
    private RS_Identifier_PropertyType nameField;

    [XmlElement]
    public RS_Identifier_PropertyType name
    {
      get { return nameField; }
      set { nameField = value; }
    }

    [XmlElement("domainOfValidity")]
    public EX_Extent_PropertyType[] domainOfValidity
    {
      get { return domainOfValidityField; }
      set { domainOfValidityField = value; }
    }
  }
}