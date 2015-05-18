namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_Georeferenceable_Type : MD_GridSpatialRepresentation_Type
  {

    private Boolean_PropertyType controlPointAvailabilityField;

    private Boolean_PropertyType orientationParameterAvailabilityField;

    private CharacterString_PropertyType orientationParameterDescriptionField;

    private Record_PropertyType georeferencedParametersField;

    private CI_Citation_PropertyType[] parameterCitationField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public Boolean_PropertyType controlPointAvailability
    {
      get { return controlPointAvailabilityField; }
      set { controlPointAvailabilityField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Boolean_PropertyType orientationParameterAvailability
    {
      get { return orientationParameterAvailabilityField; }
      set { orientationParameterAvailabilityField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType orientationParameterDescription
    {
      get { return orientationParameterDescriptionField; }
      set { orientationParameterDescriptionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Record_PropertyType georeferencedParameters
    {
      get { return georeferencedParametersField; }
      set { georeferencedParametersField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("parameterCitation")]
    public CI_Citation_PropertyType[] parameterCitation
    {
      get { return parameterCitationField; }
      set { parameterCitationField = value; }
    }
  }
}