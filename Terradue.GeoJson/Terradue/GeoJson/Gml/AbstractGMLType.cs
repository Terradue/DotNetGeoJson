using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (ArrayType))]
  [XmlInclude(typeof (BagType))]
  [XmlInclude(typeof (AbstractTopologyType))]
  [XmlInclude(typeof (TopoComplexType))]
  [XmlInclude(typeof (TopoVolumeType))]
  [XmlInclude(typeof (TopoSurfaceType))]
  [XmlInclude(typeof (TopoCurveType))]
  [XmlInclude(typeof (TopoPointType))]
  [XmlInclude(typeof (AbstractTopoPrimitiveType))]
  [XmlInclude(typeof (TopoSolidType))]
  [XmlInclude(typeof (EdgeType))]
  [XmlInclude(typeof (FaceType))]
  [XmlInclude(typeof (NodeType))]
  [XmlInclude(typeof (CompositeValueType))]
  [XmlInclude(typeof (ValueArrayType))]
  [XmlInclude(typeof (AbstractTimeSliceType))]
  [XmlInclude(typeof (MovingObjectStatusType))]
  [XmlInclude(typeof (AbstractFeatureType))]
  [XmlInclude(typeof (BoundedFeatureType))]
  [XmlInclude(typeof (AbstractFeatureCollectionType))]
  [XmlInclude(typeof (FeatureCollectionType))]
  [XmlInclude(typeof (ObservationType))]
  [XmlInclude(typeof (DirectedObservationType))]
  [XmlInclude(typeof (DirectedObservationAtDistanceType))]
  [XmlInclude(typeof (AbstractCoverageType))]
  [XmlInclude(typeof (AbstractContinuousCoverageType))]
  [XmlInclude(typeof (DiscreteCoverageType))]
  [XmlInclude(typeof (DynamicFeatureType))]
  [XmlInclude(typeof (DynamicFeatureCollectionType))]
  [XmlInclude(typeof (AbstractGeometryType))]
  [XmlInclude(typeof (GridType))]
  [XmlInclude(typeof (RectifiedGridType))]
  [XmlInclude(typeof (GeometricComplexType))]
  [XmlInclude(typeof (AbstractGeometricAggregateType))]
  [XmlInclude(typeof (MultiSolidType))]
  [XmlInclude(typeof (MultiSurfaceType))]
  [XmlInclude(typeof (MultiCurveType))]
  [XmlInclude(typeof (MultiPointType))]
  [XmlInclude(typeof (MultiGeometryType))]
  [XmlInclude(typeof (AbstractGeometricPrimitiveType))]
  [XmlInclude(typeof (AbstractSolidType))]
  [XmlInclude(typeof (CompositeSolidType))]
  [XmlInclude(typeof (SolidType))]
  [XmlInclude(typeof (AbstractSurfaceType))]
  [XmlInclude(typeof (CompositeSurfaceType))]
  [XmlInclude(typeof (OrientableSurfaceType))]
  [XmlInclude(typeof (SurfaceType))]
  [XmlInclude(typeof (TinType))]
  [XmlInclude(typeof (PolygonType))]
  [XmlInclude(typeof (AbstractCurveType))]
  [XmlInclude(typeof (CompositeCurveType))]
  [XmlInclude(typeof (OrientableCurveType))]
  [XmlInclude(typeof (CurveType))]
  [XmlInclude(typeof (LineStringType))]
  [XmlInclude(typeof (PointType))]
  [XmlInclude(typeof (AbstractTimeObjectType))]
  [XmlInclude(typeof (AbstractTimeComplexType))]
  [XmlInclude(typeof (TimeTopologyComplexType))]
  [XmlInclude(typeof (AbstractTimePrimitiveType))]
  [XmlInclude(typeof (AbstractTimeTopologyPrimitiveType))]
  [XmlInclude(typeof (TimeEdgeType))]
  [XmlInclude(typeof (TimeNodeType))]
  [XmlInclude(typeof (AbstractTimeGeometricPrimitiveType))]
  [XmlInclude(typeof (TimePeriodType))]
  [XmlInclude(typeof (TimeInstantType))]
  [XmlInclude(typeof (DefinitionBaseType))]
  [XmlInclude(typeof (DefinitionType))]
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
  [XmlRoot("AbstractGML", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract class AbstractGMLType
  {
    private StringOrRefType descriptionField;
    private ReferenceType descriptionReferenceField;
    private CodeWithAuthorityType identifierField;
    private string idField;
    private MetaDataPropertyType[] metaDataPropertyField;
    private CodeType[] nameField;

    [XmlElement("metaDataProperty1")]
    public MetaDataPropertyType[] metaDataProperty
    {
      get { return metaDataPropertyField; }
      set { metaDataPropertyField = value; }
    }

    [XmlElement]
    public StringOrRefType description
    {
      get { return descriptionField; }
      set { descriptionField = value; }
    }

    [XmlElement]
    public ReferenceType descriptionReference
    {
      get { return descriptionReferenceField; }
      set { descriptionReferenceField = value; }
    }

    [XmlElement]
    public CodeWithAuthorityType identifier
    {
      get { return identifierField; }
      set { identifierField = value; }
    }

    [XmlElement("name")]
    public CodeType[] name
    {
      get { return nameField; }
      set { nameField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified, DataType = "ID")]
    public string id
    {
      get { return idField; }
      set { idField = value; }
    }
  }
}