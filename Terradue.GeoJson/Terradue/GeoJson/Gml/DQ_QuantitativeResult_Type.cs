namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class DQ_QuantitativeResult_Type : AbstractDQ_Result_Type
  {

    private RecordType_PropertyType valueTypeField;

    private UnitOfMeasure_PropertyType valueUnitField;

    private CharacterString_PropertyType errorStatisticField;

    private Record_PropertyType[] valueField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public RecordType_PropertyType valueType
    {
      get { return valueTypeField; }
      set { valueTypeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public UnitOfMeasure_PropertyType valueUnit
    {
      get { return valueUnitField; }
      set { valueUnitField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType errorStatistic
    {
      get { return errorStatisticField; }
      set { errorStatisticField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public Record_PropertyType[] value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}