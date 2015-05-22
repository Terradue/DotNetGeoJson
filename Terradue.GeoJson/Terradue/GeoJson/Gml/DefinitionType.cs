using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (DefinitionProxyType))]
  [XmlInclude(typeof (TimeOrdinalEraType))]
  [XmlInclude(typeof (TimeCalendarEraType))]
  [XmlInclude(typeof (TimeReferenceSystemType))]
  [XmlInclude(typeof (TimeOrdinalReferenceSystemType))]
  [XmlInclude(typeof (TimeClockType))]
  [XmlInclude(typeof (TimeCalendarType))]
  [XmlInclude(typeof (TimeCoordinateSystemType))]
  [XmlInclude(typeof (IdentifiedObjectType))]
  [XmlInclude(typeof (AbstractGeneralOperationParameterType))]
  [XmlInclude(typeof (OperationParameterGroupType))]
  [XmlInclude(typeof (OperationParameterType))]
  [XmlInclude(typeof (OperationMethodType))]
  [XmlInclude(typeof (AbstractCoordinateOperationType))]
  [XmlInclude(typeof (PassThroughOperationType))]
  [XmlInclude(typeof (ConcatenatedOperationType))]
  [XmlInclude(typeof (AbstractGeneralTransformationType))]
  [XmlInclude(typeof (TransformationType))]
  [XmlInclude(typeof (AbstractGeneralConversionType))]
  [XmlInclude(typeof (ConversionType))]
  [XmlInclude(typeof (EllipsoidType))]
  [XmlInclude(typeof (PrimeMeridianType))]
  [XmlInclude(typeof (AbstractDatumType))]
  [XmlInclude(typeof (TemporalDatumBaseType))]
  [XmlInclude(typeof (TemporalDatumType))]
  [XmlInclude(typeof (VerticalDatumType))]
  [XmlInclude(typeof (ImageDatumType))]
  [XmlInclude(typeof (EngineeringDatumType))]
  [XmlInclude(typeof (GeodeticDatumType))]
  [XmlInclude(typeof (CoordinateSystemAxisType))]
  [XmlInclude(typeof (AbstractCoordinateSystemType))]
  [XmlInclude(typeof (ObliqueCartesianCSType))]
  [XmlInclude(typeof (TemporalCSType))]
  [XmlInclude(typeof (AffineCSType))]
  [XmlInclude(typeof (CylindricalCSType))]
  [XmlInclude(typeof (PolarCSType))]
  [XmlInclude(typeof (SphericalCSType))]
  [XmlInclude(typeof (UserDefinedCSType))]
  [XmlInclude(typeof (LinearCSType))]
  [XmlInclude(typeof (TimeCSType))]
  [XmlInclude(typeof (VerticalCSType))]
  [XmlInclude(typeof (CartesianCSType))]
  [XmlInclude(typeof (EllipsoidalCSType))]
  [XmlInclude(typeof (AbstractCRSType))]
  [XmlInclude(typeof (AbstractGeneralDerivedCRSType))]
  [XmlInclude(typeof (DerivedCRSType))]
  [XmlInclude(typeof (ProjectedCRSType))]
  [XmlInclude(typeof (GeocentricCRSType))]
  [XmlInclude(typeof (GeographicCRSType))]
  [XmlInclude(typeof (TemporalCRSType))]
  [XmlInclude(typeof (ImageCRSType))]
  [XmlInclude(typeof (EngineeringCRSType))]
  [XmlInclude(typeof (VerticalCRSType))]
  [XmlInclude(typeof (GeodeticCRSType))]
  [XmlInclude(typeof (CompoundCRSType))]
  [XmlInclude(typeof (UnitDefinitionType))]
  [XmlInclude(typeof (ConventionalUnitType))]
  [XmlInclude(typeof (DerivedUnitType))]
  [XmlInclude(typeof (BaseUnitType))]
  [XmlInclude(typeof (DictionaryType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("Definition", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class DefinitionType : DefinitionBaseType
  {
    private string remarksField;

    [XmlElement]
    public string remarks
    {
      get { return remarksField; }
      set { remarksField = value; }
    }
  }
}