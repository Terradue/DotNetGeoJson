using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (ArcByBulgeType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("ArcStringByBulge", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class ArcStringByBulgeType : AbstractCurveSegmentType
  {
    private double[] bulgeField;
    private CurveInterpolationType interpolationField;
    private bool interpolationFieldSpecified;
    private ItemsChoiceType3[] itemsElementNameField;
    private object[] itemsField;
    private VectorType[] normalField;
    private string numArcField;

    public ArcStringByBulgeType()
    {
      interpolationField = CurveInterpolationType.circularArc2PointWithBulge;
    }

    [XmlElement("coordinates", typeof (CoordinatesType))]
    [XmlElement("pointProperty", typeof (PointPropertyType))]
    [XmlElement("pointRep", typeof (PointPropertyType))]
    [XmlElement("pos", typeof (DirectPositionType))]
    [XmlElement("posList", typeof (DirectPositionListType))]
    [XmlChoiceIdentifier("ItemsElementName")]
    public object[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType3[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }

    [XmlElement("bulge")]
    public double[] bulge
    {
      get { return bulgeField; }
      set { bulgeField = value; }
    }

    [XmlElement("normal")]
    public VectorType[] normal
    {
      get { return normalField; }
      set { normalField = value; }
    }

    [XmlAttribute]
    public CurveInterpolationType interpolation
    {
      get { return interpolationField; }
      set { interpolationField = value; }
    }

    [XmlIgnore]
    public bool interpolationSpecified
    {
      get { return interpolationFieldSpecified; }
      set { interpolationFieldSpecified = value; }
    }

    [XmlAttribute(DataType = "integer")]
    public string numArc
    {
      get { return numArcField; }
      set { numArcField = value; }
    }
  }
}