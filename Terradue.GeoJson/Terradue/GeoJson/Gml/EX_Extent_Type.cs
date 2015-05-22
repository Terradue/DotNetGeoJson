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
  public class EX_Extent_Type : AbstractObject_Type
  {
    private CharacterString_PropertyType descriptionField;
    private EX_GeographicExtent_PropertyType[] geographicElementField;
    private EX_TemporalExtent_PropertyType[] temporalElementField;
    private EX_VerticalExtent_PropertyType[] verticalElementField;

    [XmlElement]
    public CharacterString_PropertyType description
    {
      get { return descriptionField; }
      set { descriptionField = value; }
    }

    [XmlElement("geographicElement")]
    public EX_GeographicExtent_PropertyType[] geographicElement
    {
      get { return geographicElementField; }
      set { geographicElementField = value; }
    }

    [XmlElement("temporalElement")]
    public EX_TemporalExtent_PropertyType[] temporalElement
    {
      get { return temporalElementField; }
      set { temporalElementField = value; }
    }

    [XmlElement("verticalElement")]
    public EX_VerticalExtent_PropertyType[] verticalElement
    {
      get { return verticalElementField; }
      set { verticalElementField = value; }
    }
  }
}