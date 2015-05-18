namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MovingObjectStatusType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AbstractTimeSlice", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract partial class AbstractTimeSliceType : AbstractGMLType
  {

    private TimePrimitivePropertyType validTimeField;

    private StringOrRefType dataSourceField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public TimePrimitivePropertyType validTime
    {
      get { return validTimeField; }
      set { validTimeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public StringOrRefType dataSource
    {
      get { return dataSourceField; }
      set { dataSourceField = value; }
    }
  }
}