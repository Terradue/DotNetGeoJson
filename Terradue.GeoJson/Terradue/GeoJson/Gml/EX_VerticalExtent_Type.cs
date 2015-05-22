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
  public class EX_VerticalExtent_Type : AbstractObject_Type
  {
    private Real_PropertyType maximumValueField;
    private Real_PropertyType minimumValueField;
    private SC_CRS_PropertyType verticalCRSField;

    [XmlElement]
    public Real_PropertyType minimumValue
    {
      get { return minimumValueField; }
      set { minimumValueField = value; }
    }

    [XmlElement]
    public Real_PropertyType maximumValue
    {
      get { return maximumValueField; }
      set { maximumValueField = value; }
    }

    [XmlElement]
    public SC_CRS_PropertyType verticalCRS
    {
      get { return verticalCRSField; }
      set { verticalCRSField = value; }
    }
  }
}