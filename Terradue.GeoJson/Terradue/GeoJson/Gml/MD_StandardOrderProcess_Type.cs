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
  public class MD_StandardOrderProcess_Type : AbstractObject_Type
  {
    private CharacterString_PropertyType feesField;
    private CharacterString_PropertyType orderingInstructionsField;
    private DateTime_PropertyType plannedAvailableDateTimeField;
    private CharacterString_PropertyType turnaroundField;

    [XmlElement]
    public CharacterString_PropertyType fees
    {
      get { return feesField; }
      set { feesField = value; }
    }

    [XmlElement]
    public DateTime_PropertyType plannedAvailableDateTime
    {
      get { return plannedAvailableDateTimeField; }
      set { plannedAvailableDateTimeField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType orderingInstructions
    {
      get { return orderingInstructionsField; }
      set { orderingInstructionsField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType turnaround
    {
      get { return turnaroundField; }
      set { turnaroundField = value; }
    }
  }
}