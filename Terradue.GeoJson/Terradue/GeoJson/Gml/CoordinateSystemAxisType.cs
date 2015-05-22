using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("CoordinateSystemAxis", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class CoordinateSystemAxisType : IdentifiedObjectType
  {
    private CodeType axisAbbrevField;
    private CodeWithAuthorityType axisDirectionField;
    private double maximumValueField;
    private bool maximumValueFieldSpecified;
    private double minimumValueField;
    private bool minimumValueFieldSpecified;
    private CodeWithAuthorityType rangeMeaningField;
    private string uomField;

    [XmlElement]
    public CodeType axisAbbrev
    {
      get { return axisAbbrevField; }
      set { axisAbbrevField = value; }
    }

    [XmlElement]
    public CodeWithAuthorityType axisDirection
    {
      get { return axisDirectionField; }
      set { axisDirectionField = value; }
    }

    [XmlElement]
    public double minimumValue
    {
      get { return minimumValueField; }
      set { minimumValueField = value; }
    }

    [XmlIgnore]
    public bool minimumValueSpecified
    {
      get { return minimumValueFieldSpecified; }
      set { minimumValueFieldSpecified = value; }
    }

    [XmlElement]
    public double maximumValue
    {
      get { return maximumValueField; }
      set { maximumValueField = value; }
    }

    [XmlIgnore]
    public bool maximumValueSpecified
    {
      get { return maximumValueFieldSpecified; }
      set { maximumValueFieldSpecified = value; }
    }

    [XmlElement]
    public CodeWithAuthorityType rangeMeaning
    {
      get { return rangeMeaningField; }
      set { rangeMeaningField = value; }
    }

    [XmlAttribute]
    public string uom
    {
      get { return uomField; }
      set { uomField = value; }
    }
  }
}