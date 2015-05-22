using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (PassThroughOperationType))]
  [XmlInclude(typeof (ConcatenatedOperationType))]
  [XmlInclude(typeof (AbstractGeneralTransformationType))]
  [XmlInclude(typeof (TransformationType))]
  [XmlInclude(typeof (AbstractGeneralConversionType))]
  [XmlInclude(typeof (ConversionType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractCoordinateOperation", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract class AbstractCoordinateOperationType : IdentifiedObjectType
  {
    private coordinateOperationAccuracy[] coordinateOperationAccuracyField;
    private domainOfValidity domainOfValidityField;
    private string operationVersionField;
    private string[] scopeField;
    private CRSPropertyType sourceCRSField;
    private CRSPropertyType targetCRSField;

    [XmlElement]
    public domainOfValidity domainOfValidity
    {
      get { return domainOfValidityField; }
      set { domainOfValidityField = value; }
    }

    [XmlElement("scope")]
    public string[] scope
    {
      get { return scopeField; }
      set { scopeField = value; }
    }

    [XmlElement]
    public string operationVersion
    {
      get { return operationVersionField; }
      set { operationVersionField = value; }
    }

    [XmlElement("coordinateOperationAccuracy")]
    public coordinateOperationAccuracy[] coordinateOperationAccuracy
    {
      get { return coordinateOperationAccuracyField; }
      set { coordinateOperationAccuracyField = value; }
    }

    [XmlElement]
    public CRSPropertyType sourceCRS
    {
      get { return sourceCRSField; }
      set { sourceCRSField = value; }
    }

    [XmlElement]
    public CRSPropertyType targetCRS
    {
      get { return targetCRSField; }
      set { targetCRSField = value; }
    }
  }
}