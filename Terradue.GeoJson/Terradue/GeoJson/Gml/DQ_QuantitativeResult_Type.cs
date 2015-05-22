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
  public class DQ_QuantitativeResult_Type : AbstractDQ_Result_Type
  {
    private CharacterString_PropertyType errorStatisticField;
    private Record_PropertyType[] valueField;
    private RecordType_PropertyType valueTypeField;
    private UnitOfMeasure_PropertyType valueUnitField;

    [XmlElement]
    public RecordType_PropertyType valueType
    {
      get { return valueTypeField; }
      set { valueTypeField = value; }
    }

    [XmlElement]
    public UnitOfMeasure_PropertyType valueUnit
    {
      get { return valueUnitField; }
      set { valueUnitField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType errorStatistic
    {
      get { return errorStatisticField; }
      set { errorStatisticField = value; }
    }

    [XmlElement("value")]
    public Record_PropertyType[] value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}