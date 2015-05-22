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
  public class MD_Georeferenceable_Type : MD_GridSpatialRepresentation_Type
  {
    private Boolean_PropertyType controlPointAvailabilityField;
    private Record_PropertyType georeferencedParametersField;
    private Boolean_PropertyType orientationParameterAvailabilityField;
    private CharacterString_PropertyType orientationParameterDescriptionField;
    private CI_Citation_PropertyType[] parameterCitationField;

    [XmlElement]
    public Boolean_PropertyType controlPointAvailability
    {
      get { return controlPointAvailabilityField; }
      set { controlPointAvailabilityField = value; }
    }

    [XmlElement]
    public Boolean_PropertyType orientationParameterAvailability
    {
      get { return orientationParameterAvailabilityField; }
      set { orientationParameterAvailabilityField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType orientationParameterDescription
    {
      get { return orientationParameterDescriptionField; }
      set { orientationParameterDescriptionField = value; }
    }

    [XmlElement]
    public Record_PropertyType georeferencedParameters
    {
      get { return georeferencedParametersField; }
      set { georeferencedParametersField = value; }
    }

    [XmlElement("parameterCitation")]
    public CI_Citation_PropertyType[] parameterCitation
    {
      get { return parameterCitationField; }
      set { parameterCitationField = value; }
    }
  }
}