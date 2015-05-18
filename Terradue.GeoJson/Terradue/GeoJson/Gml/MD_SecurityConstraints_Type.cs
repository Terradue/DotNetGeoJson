namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_SecurityConstraints_Type : MD_Constraints_Type
  {

    private MD_ClassificationCode_PropertyType classificationField;

    private CharacterString_PropertyType userNoteField;

    private CharacterString_PropertyType classificationSystemField;

    private CharacterString_PropertyType handlingDescriptionField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_ClassificationCode_PropertyType classification
    {
      get { return classificationField; }
      set { classificationField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType userNote
    {
      get { return userNoteField; }
      set { userNoteField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType classificationSystem
    {
      get { return classificationSystemField; }
      set { classificationSystemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType handlingDescription
    {
      get { return handlingDescriptionField; }
      set { handlingDescriptionField = value; }
    }
  }
}