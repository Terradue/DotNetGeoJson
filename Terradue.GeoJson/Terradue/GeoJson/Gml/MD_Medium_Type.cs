namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_Medium_Type : AbstractObject_Type
  {

    private MD_MediumNameCode_PropertyType nameField;

    private Real_PropertyType[] densityField;

    private CharacterString_PropertyType densityUnitsField;

    private Integer_PropertyType volumesField;

    private MD_MediumFormatCode_PropertyType[] mediumFormatField;

    private CharacterString_PropertyType mediumNoteField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_MediumNameCode_PropertyType name
    {
      get { return nameField; }
      set { nameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("density")]
    public Real_PropertyType[] density
    {
      get { return densityField; }
      set { densityField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType densityUnits
    {
      get { return densityUnitsField; }
      set { densityUnitsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Integer_PropertyType volumes
    {
      get { return volumesField; }
      set { volumesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("mediumFormat")]
    public MD_MediumFormatCode_PropertyType[] mediumFormat
    {
      get { return mediumFormatField; }
      set { mediumFormatField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType mediumNote
    {
      get { return mediumNoteField; }
      set { mediumNoteField = value; }
    }
  }
}