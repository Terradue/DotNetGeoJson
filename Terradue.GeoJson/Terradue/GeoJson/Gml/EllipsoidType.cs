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
  [XmlRoot("Ellipsoid", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class EllipsoidType : IdentifiedObjectType
  {
    private secondDefiningParameter secondDefiningParameterField;
    private MeasureType semiMajorAxisField;

    [XmlElement]
    public MeasureType semiMajorAxis
    {
      get { return semiMajorAxisField; }
      set { semiMajorAxisField = value; }
    }

    [XmlElement]
    public secondDefiningParameter secondDefiningParameter
    {
      get { return secondDefiningParameterField; }
      set { secondDefiningParameterField = value; }
    }
  }
}