namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("curveMembers", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class CurveArrayPropertyType
  {

    private AbstractCurveType[] itemsField;

    private bool ownsField;

    public CurveArrayPropertyType()
    {
      ownsField = false;
    }

    [System.Xml.Serialization.XmlElementAttribute("CompositeCurve", typeof (CompositeCurveType))]
    [System.Xml.Serialization.XmlElementAttribute("Curve", typeof (CurveType))]
    [System.Xml.Serialization.XmlElementAttribute("LineString", typeof (LineStringType))]
    [System.Xml.Serialization.XmlElementAttribute("OrientableCurve", typeof (OrientableCurveType))]
    public AbstractCurveType[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool owns
    {
      get { return ownsField; }
      set { ownsField = value; }
    }
  }
}