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
  [XmlRoot(Namespace = "http://www.opengis.net/gml/3.2", IsNullable = true)]
  public class FormulaType
  {
    private double aField;
    private bool aFieldSpecified;
    private double bField;
    private double cField;
    private double dField;
    private bool dFieldSpecified;

    [XmlElement]
    public double a
    {
      get { return aField; }
      set { aField = value; }
    }

    [XmlIgnore]
    public bool aSpecified
    {
      get { return aFieldSpecified; }
      set { aFieldSpecified = value; }
    }

    [XmlElement]
    public double b
    {
      get { return bField; }
      set { bField = value; }
    }

    [XmlElement]
    public double c
    {
      get { return cField; }
      set { cField = value; }
    }

    [XmlElement]
    public double d
    {
      get { return dField; }
      set { dField = value; }
    }

    [XmlIgnore]
    public bool dSpecified
    {
      get { return dFieldSpecified; }
      set { dFieldSpecified = value; }
    }
  }
}