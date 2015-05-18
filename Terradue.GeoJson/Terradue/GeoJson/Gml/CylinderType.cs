namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("Cylinder", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class CylinderType : AbstractGriddedSurfaceType
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

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public CurveInterpolationType horizontalCurveType
    {
      get { return horizontalCurveTypeField; }
      set { horizontalCurveTypeField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool horizontalCurveTypeSpecified
    {
      get { return horizontalCurveTypeFieldSpecified; }
      set { horizontalCurveTypeFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public CurveInterpolationType verticalCurveType
    {
      get { return verticalCurveTypeField; }
      set { verticalCurveTypeField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool verticalCurveTypeSpecified
    {
      get { return verticalCurveTypeFieldSpecified; }
      set { verticalCurveTypeFieldSpecified = value; }
    }
  }
}