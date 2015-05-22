using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (MD_Band_Type))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public class MD_RangeDimension_Type : AbstractObject_Type
  {
    private CharacterString_PropertyType descriptorField;
    private MemberName_PropertyType sequenceIdentifierField;

    [XmlElement]
    public MemberName_PropertyType sequenceIdentifier
    {
      get { return sequenceIdentifierField; }
      set { sequenceIdentifierField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType descriptor
    {
      get { return descriptorField; }
      set { descriptorField = value; }
    }
  }
}