using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (SphereType))]
  [XmlInclude(typeof (CylinderType))]
  [XmlInclude(typeof (ConeType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractGriddedSurface", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract class AbstractGriddedSurfaceType : AbstractParametricCurveSurfaceType
  {
    private string columnsField;
    private string rows1Field;
    private AbstractGriddedSurfaceTypeRow[] rowsField;

    [XmlArray]
    [XmlArrayItem("Row", IsNullable = false)]
    public AbstractGriddedSurfaceTypeRow[] rows
    {
      get { return rowsField; }
      set { rowsField = value; }
    }

    [XmlAttribute("rows", DataType = "integer")]
    public string rows1
    {
      get { return rows1Field; }
      set { rows1Field = value; }
    }

    [XmlAttribute(DataType = "integer")]
    public string columns
    {
      get { return columnsField; }
      set { columnsField = value; }
    }
  }
}