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
  public class MD_Medium_Type : AbstractObject_Type
  {
    private Real_PropertyType[] densityField;
    private CharacterString_PropertyType densityUnitsField;
    private MD_MediumFormatCode_PropertyType[] mediumFormatField;
    private CharacterString_PropertyType mediumNoteField;
    private MD_MediumNameCode_PropertyType nameField;
    private Integer_PropertyType volumesField;

    [XmlElement]
    public MD_MediumNameCode_PropertyType name
    {
      get { return nameField; }
      set { nameField = value; }
    }

    [XmlElement("density")]
    public Real_PropertyType[] density
    {
      get { return densityField; }
      set { densityField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType densityUnits
    {
      get { return densityUnitsField; }
      set { densityUnitsField = value; }
    }

    [XmlElement]
    public Integer_PropertyType volumes
    {
      get { return volumesField; }
      set { volumesField = value; }
    }

    [XmlElement("mediumFormat")]
    public MD_MediumFormatCode_PropertyType[] mediumFormat
    {
      get { return mediumFormatField; }
      set { mediumFormatField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType mediumNote
    {
      get { return mediumNoteField; }
      set { mediumNoteField = value; }
    }
  }
}