namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("TopoComplex", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TopoComplexType : AbstractTopologyType
  {

    private TopoComplexPropertyType maximalComplexField;

    private TopoComplexPropertyType[] superComplexField;

    private TopoComplexPropertyType[] subComplexField;

    private TopoPrimitiveMemberType[] topoPrimitiveMemberField;

    private TopoPrimitiveArrayAssociationType topoPrimitiveMembersField;

    private bool isMaximalField;

    private AggregationType aggregationTypeField;

    private bool aggregationTypeFieldSpecified;

    public TopoComplexType()
    {
      isMaximalField = false;
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public TopoComplexPropertyType maximalComplex
    {
      get { return maximalComplexField; }
      set { maximalComplexField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("superComplex")]
    public TopoComplexPropertyType[] superComplex
    {
      get { return superComplexField; }
      set { superComplexField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("subComplex")]
    public TopoComplexPropertyType[] subComplex
    {
      get { return subComplexField; }
      set { subComplexField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("topoPrimitiveMember")]
    public TopoPrimitiveMemberType[] topoPrimitiveMember
    {
      get { return topoPrimitiveMemberField; }
      set { topoPrimitiveMemberField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public TopoPrimitiveArrayAssociationType topoPrimitiveMembers
    {
      get { return topoPrimitiveMembersField; }
      set { topoPrimitiveMembersField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool isMaximal
    {
      get { return isMaximalField; }
      set { isMaximalField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public AggregationType aggregationType
    {
      get { return aggregationTypeField; }
      set { aggregationTypeField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool aggregationTypeSpecified
    {
      get { return aggregationTypeFieldSpecified; }
      set { aggregationTypeFieldSpecified = value; }
    }
  }
}