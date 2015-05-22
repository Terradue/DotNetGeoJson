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
  public class MD_BrowseGraphic_Type : AbstractObject_Type
  {
    private CharacterString_PropertyType fileDescriptionField;
    private CharacterString_PropertyType fileNameField;
    private CharacterString_PropertyType fileTypeField;

    [XmlElement]
    public CharacterString_PropertyType fileName
    {
      get { return fileNameField; }
      set { fileNameField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType fileDescription
    {
      get { return fileDescriptionField; }
      set { fileDescriptionField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType fileType
    {
      get { return fileTypeField; }
      set { fileTypeField = value; }
    }
  }
}