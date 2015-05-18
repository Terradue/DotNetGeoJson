namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (PassThroughOperationType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ConcatenatedOperationType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractGeneralTransformationType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TransformationType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractGeneralConversionType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ConversionType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AbstractCoordinateOperation", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract partial class AbstractCoordinateOperationType : IdentifiedObjectType
  {

    private domainOfValidity domainOfValidityField;

    private string[] scopeField;

    private string operationVersionField;

    private coordinateOperationAccuracy[] coordinateOperationAccuracyField;

    private CRSPropertyType sourceCRSField;

    private CRSPropertyType targetCRSField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public domainOfValidity domainOfValidity
    {
      get { return domainOfValidityField; }
      set { domainOfValidityField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("scope")]
    public string[] scope
    {
      get { return scopeField; }
      set { scopeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public string operationVersion
    {
      get { return operationVersionField; }
      set { operationVersionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("coordinateOperationAccuracy")]
    public coordinateOperationAccuracy[] coordinateOperationAccuracy
    {
      get { return coordinateOperationAccuracyField; }
      set { coordinateOperationAccuracyField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CRSPropertyType sourceCRS
    {
      get { return sourceCRSField; }
      set { sourceCRSField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CRSPropertyType targetCRS
    {
      get { return targetCRSField; }
      set { targetCRSField = value; }
    }
  }
}