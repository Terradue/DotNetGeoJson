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
  public class LI_ProcessStep_Type : AbstractObject_Type
  {
    private DateTime_PropertyType dateTimeField;
    private CharacterString_PropertyType descriptionField;
    private CI_ResponsibleParty_PropertyType[] processorField;
    private CharacterString_PropertyType rationaleField;
    private LI_Source_PropertyType[] sourceField;

    [XmlElement]
    public CharacterString_PropertyType description
    {
      get { return descriptionField; }
      set { descriptionField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType rationale
    {
      get { return rationaleField; }
      set { rationaleField = value; }
    }

    [XmlElement]
    public DateTime_PropertyType dateTime
    {
      get { return dateTimeField; }
      set { dateTimeField = value; }
    }

    [XmlElement("processor")]
    public CI_ResponsibleParty_PropertyType[] processor
    {
      get { return processorField; }
      set { processorField = value; }
    }

    [XmlElement("source")]
    public LI_Source_PropertyType[] source
    {
      get { return sourceField; }
      set { sourceField = value; }
    }
  }
}