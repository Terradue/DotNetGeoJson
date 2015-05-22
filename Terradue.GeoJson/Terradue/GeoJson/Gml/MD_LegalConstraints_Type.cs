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
  public class MD_LegalConstraints_Type : MD_Constraints_Type
  {
    private MD_RestrictionCode_PropertyType[] accessConstraintsField;
    private CharacterString_PropertyType[] otherConstraintsField;
    private MD_RestrictionCode_PropertyType[] useConstraintsField;

    [XmlElement("accessConstraints")]
    public MD_RestrictionCode_PropertyType[] accessConstraints
    {
      get { return accessConstraintsField; }
      set { accessConstraintsField = value; }
    }

    [XmlElement("useConstraints")]
    public MD_RestrictionCode_PropertyType[] useConstraints
    {
      get { return useConstraintsField; }
      set { useConstraintsField = value; }
    }

    [XmlElement("otherConstraints")]
    public CharacterString_PropertyType[] otherConstraints
    {
      get { return otherConstraintsField; }
      set { otherConstraintsField = value; }
    }
  }
}