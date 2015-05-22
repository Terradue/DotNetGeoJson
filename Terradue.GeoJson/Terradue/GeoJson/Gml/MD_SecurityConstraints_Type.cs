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
  public class MD_SecurityConstraints_Type : MD_Constraints_Type
  {
    private MD_ClassificationCode_PropertyType classificationField;
    private CharacterString_PropertyType classificationSystemField;
    private CharacterString_PropertyType handlingDescriptionField;
    private CharacterString_PropertyType userNoteField;

    [XmlElement]
    public MD_ClassificationCode_PropertyType classification
    {
      get { return classificationField; }
      set { classificationField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType userNote
    {
      get { return userNoteField; }
      set { userNoteField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType classificationSystem
    {
      get { return classificationSystemField; }
      set { classificationSystemField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType handlingDescription
    {
      get { return handlingDescriptionField; }
      set { handlingDescriptionField = value; }
    }
  }
}