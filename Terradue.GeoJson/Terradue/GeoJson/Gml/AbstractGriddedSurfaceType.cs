namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (SphereType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CylinderType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ConeType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AbstractGriddedSurface", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract partial class AbstractGriddedSurfaceType : AbstractParametricCurveSurfaceType
  {

    private AbstractGriddedSurfaceTypeRow[] rowsField;

    private string rows1Field;

    private string columnsField;

    [System.Xml.Serialization.XmlArrayAttribute()]
    [System.Xml.Serialization.XmlArrayItemAttribute("Row", IsNullable = false)]
    public AbstractGriddedSurfaceTypeRow[] rows
    {
      get { return rowsField; }
      set { rowsField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute("rows", DataType = "integer")]
    public string rows1
    {
      get { return rows1Field; }
      set { rows1Field = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    public string columns
    {
      get { return columnsField; }
      set { columnsField = value; }
    }
  }
}