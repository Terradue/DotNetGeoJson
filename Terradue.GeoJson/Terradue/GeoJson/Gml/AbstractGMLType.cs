namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ArrayType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (BagType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractTopologyType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TopoComplexType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TopoVolumeType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TopoSurfaceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TopoCurveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TopoPointType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractTopoPrimitiveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TopoSolidType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (EdgeType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (FaceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (NodeType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CompositeValueType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ValueArrayType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractTimeSliceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MovingObjectStatusType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractFeatureType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (BoundedFeatureType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractFeatureCollectionType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (FeatureCollectionType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ObservationType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DirectedObservationType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DirectedObservationAtDistanceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractCoverageType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractContinuousCoverageType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DiscreteCoverageType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DynamicFeatureType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DynamicFeatureCollectionType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractGeometryType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (GridType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (RectifiedGridType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (GeometricComplexType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractGeometricAggregateType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MultiSolidType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MultiSurfaceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MultiCurveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MultiPointType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MultiGeometryType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractGeometricPrimitiveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractSolidType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CompositeSolidType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (SolidType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractSurfaceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CompositeSurfaceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (OrientableSurfaceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (SurfaceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TinType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (PolygonType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractCurveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CompositeCurveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (OrientableCurveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CurveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (LineStringType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (PointType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractTimeObjectType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractTimeComplexType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeTopologyComplexType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractTimePrimitiveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractTimeTopologyPrimitiveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeEdgeType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeNodeType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractTimeGeometricPrimitiveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimePeriodType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeInstantType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DefinitionBaseType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DefinitionType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DefinitionProxyType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeOrdinalEraType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeCalendarEraType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeReferenceSystemType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeOrdinalReferenceSystemType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeClockType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeCalendarType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeCoordinateSystemType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (IdentifiedObjectType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractGeneralOperationParameterType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (OperationParameterGroupType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (OperationParameterType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (OperationMethodType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractCoordinateOperationType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (PassThroughOperationType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ConcatenatedOperationType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractGeneralTransformationType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TransformationType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractGeneralConversionType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ConversionType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (EllipsoidType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (PrimeMeridianType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractDatumType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TemporalDatumBaseType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TemporalDatumType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (VerticalDatumType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ImageDatumType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (EngineeringDatumType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (GeodeticDatumType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CoordinateSystemAxisType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractCoordinateSystemType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ObliqueCartesianCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TemporalCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AffineCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CylindricalCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (PolarCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (SphericalCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (UserDefinedCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (LinearCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (VerticalCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CartesianCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (EllipsoidalCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractGeneralDerivedCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DerivedCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ProjectedCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (GeocentricCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (GeographicCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TemporalCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ImageCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (EngineeringCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (VerticalCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (GeodeticCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CompoundCRSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (UnitDefinitionType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ConventionalUnitType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DerivedUnitType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (BaseUnitType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DictionaryType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AbstractGML", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract partial class AbstractGMLType
  {

    private MetaDataPropertyType[] metaDataPropertyField;

    private StringOrRefType descriptionField;

    private ReferenceType descriptionReferenceField;

    private CodeWithAuthorityType identifierField;

    private CodeType[] nameField;

    private string idField;

    [System.Xml.Serialization.XmlElementAttribute("metaDataProperty1")]
    public MetaDataPropertyType[] metaDataProperty
    {
      get { return metaDataPropertyField; }
      set { metaDataPropertyField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public StringOrRefType description
    {
      get { return descriptionField; }
      set { descriptionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public ReferenceType descriptionReference
    {
      get { return descriptionReferenceField; }
      set { descriptionReferenceField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CodeWithAuthorityType identifier
    {
      get { return identifierField; }
      set { identifierField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("name")]
    public CodeType[] name
    {
      get { return nameField; }
      set { nameField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "ID")]
    public string id
    {
      get { return idField; }
      set { idField = value; }
    }
  }
}