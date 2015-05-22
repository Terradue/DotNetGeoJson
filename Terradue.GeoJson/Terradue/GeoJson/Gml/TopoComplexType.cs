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
  [XmlRoot("TopoComplex", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TopoComplexType : AbstractTopologyType
  {
    private AggregationType aggregationTypeField;
    private bool aggregationTypeFieldSpecified;
    private bool isMaximalField;
    private TopoComplexPropertyType maximalComplexField;
    private TopoComplexPropertyType[] subComplexField;
    private TopoComplexPropertyType[] superComplexField;
    private TopoPrimitiveMemberType[] topoPrimitiveMemberField;
    private TopoPrimitiveArrayAssociationType topoPrimitiveMembersField;

    public TopoComplexType()
    {
      isMaximalField = false;
    }

    [XmlElement]
    public TopoComplexPropertyType maximalComplex
    {
      get { return maximalComplexField; }
      set { maximalComplexField = value; }
    }

    [XmlElement("superComplex")]
    public TopoComplexPropertyType[] superComplex
    {
      get { return superComplexField; }
      set { superComplexField = value; }
    }

    [XmlElement("subComplex")]
    public TopoComplexPropertyType[] subComplex
    {
      get { return subComplexField; }
      set { subComplexField = value; }
    }

    [XmlElement("topoPrimitiveMember")]
    public TopoPrimitiveMemberType[] topoPrimitiveMember
    {
      get { return topoPrimitiveMemberField; }
      set { topoPrimitiveMemberField = value; }
    }

    [XmlElement]
    public TopoPrimitiveArrayAssociationType topoPrimitiveMembers
    {
      get { return topoPrimitiveMembersField; }
      set { topoPrimitiveMembersField = value; }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    public bool isMaximal
    {
      get { return isMaximalField; }
      set { isMaximalField = value; }
    }

    [XmlAttribute]
    public AggregationType aggregationType
    {
      get { return aggregationTypeField; }
      set { aggregationTypeField = value; }
    }

    [XmlIgnore]
    public bool aggregationTypeSpecified
    {
      get { return aggregationTypeFieldSpecified; }
      set { aggregationTypeFieldSpecified = value; }
    }
  }
}