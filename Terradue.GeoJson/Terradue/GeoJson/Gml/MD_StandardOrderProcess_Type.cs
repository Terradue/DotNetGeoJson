namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_StandardOrderProcess_Type : AbstractObject_Type
  {

    private CharacterString_PropertyType feesField;

    private DateTime_PropertyType plannedAvailableDateTimeField;

    private CharacterString_PropertyType orderingInstructionsField;

    private CharacterString_PropertyType turnaroundField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType fees
    {
      get { return feesField; }
      set { feesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public DateTime_PropertyType plannedAvailableDateTime
    {
      get { return plannedAvailableDateTimeField; }
      set { plannedAvailableDateTimeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType orderingInstructions
    {
      get { return orderingInstructionsField; }
      set { orderingInstructionsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType turnaround
    {
      get { return turnaroundField; }
      set { turnaroundField = value; }
    }
  }
}