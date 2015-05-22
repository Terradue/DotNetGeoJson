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
  public class CI_Series_Type : AbstractObject_Type
  {
    private CharacterString_PropertyType issueIdentificationField;
    private CharacterString_PropertyType nameField;
    private CharacterString_PropertyType pageField;

    [XmlElement]
    public CharacterString_PropertyType name
    {
      get { return nameField; }
      set { nameField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType issueIdentification
    {
      get { return issueIdentificationField; }
      set { issueIdentificationField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType page
    {
      get { return pageField; }
      set { pageField = value; }
    }
  }
}