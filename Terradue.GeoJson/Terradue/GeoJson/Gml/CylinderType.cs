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
  [XmlRoot("Cylinder", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class CylinderType : AbstractGriddedSurfaceType
  {
    private CurveInterpolationType horizontalCurveTypeField;
    private bool horizontalCurveTypeFieldSpecified;
    private CurveInterpolationType verticalCurveTypeField;
    private bool verticalCurveTypeFieldSpecified;

    public CylinderType()
    {
      horizontalCurveTypeField = CurveInterpolationType.circularArc3Points;
      verticalCurveTypeField = CurveInterpolationType.linear;
    }

    [XmlAttribute]
    public CurveInterpolationType horizontalCurveType
    {
      get { return horizontalCurveTypeField; }
      set { horizontalCurveTypeField = value; }
    }

    [XmlIgnore]
    public bool horizontalCurveTypeSpecified
    {
      get { return horizontalCurveTypeFieldSpecified; }
      set { horizontalCurveTypeFieldSpecified = value; }
    }

    [XmlAttribute]
    public CurveInterpolationType verticalCurveType
    {
      get { return verticalCurveTypeField; }
      set { verticalCurveTypeField = value; }
    }

    [XmlIgnore]
    public bool verticalCurveTypeSpecified
    {
      get { return verticalCurveTypeFieldSpecified; }
      set { verticalCurveTypeFieldSpecified = value; }
    }
  }
}